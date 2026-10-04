// tests/Mcp/SectionRendererTests.cs
// Standalone check of the net48 section image renderer (docs/MCP_SECTION_VISUAL.md)
// without Robur SDK: synthetic LasSectionFrame (sloped ground + object column),
// polygon around the column; verifies PNG output, exact bitmap size, pixel<->meter
// calibration and degenerate cases. Compiled by tests/Mcp/run_section_renderer.ps1.
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using LAS_TERRAIN.Automation;
using LAS_TERRAIN.Mcp;

internal static class SectionRendererTests
{
    private static int failures;

    private static void Check(bool ok, string name, string detail = null)
    {
        if (ok)
        {
            Console.WriteLine("[PASS] " + name);
        }
        else
        {
            failures++;
            Console.WriteLine("[FAIL] " + name + (string.IsNullOrEmpty(detail) ? "" : ": " + detail));
        }
    }

    private static string Text(double value)
    {
        return value.ToString("F3", CultureInfo.InvariantCulture);
    }

    private static LasSectionFrame SyntheticFrame()
    {
        LasSectionFrame frame = new LasSectionFrame();
        frame.Alignment = "Axis-1";
        frame.Station = 1234.5;
        frame.Thickness = 0.4;
        frame.LeftOffset = 20;
        frame.RightOffset = 20;
        const int groundCount = 400;
        const int columnCount = 100;
        int count = groundCount + columnCount;
        frame.Offsets = new double[count];
        frame.Elevations = new double[count];
        frame.Weights = new double[count];
        frame.SliceDistances = new double[count];
        double minO = double.PositiveInfinity, maxO = double.NegativeInfinity;
        double minZ = double.PositiveInfinity, maxZ = double.NegativeInfinity;
        double minW = double.PositiveInfinity, maxW = double.NegativeInfinity;
        for (int i = 0; i < groundCount; i++)
        {
            // sloped "ground": offset -20..+20, z = 100 + 0.05*offset + ripple
            double o = -20.0 + 40.0 * i / (groundCount - 1);
            double z = 100.0 + 0.05 * o + 0.02 * (i % 7);
            double w = 200.0 + 60000.0 * ((i * 37) % 100) / 100.0;
            double d = 0.15 * Math.Sin(i * 0.11);
            Fill(frame, i, o, z, w, d, ref minO, ref maxO, ref minZ, ref maxZ, ref minW, ref maxW);
        }
        for (int j = 0; j < columnCount; j++)
        {
            // vertical "object" column near offset 5..7, z 102..107 (candidate for deletion)
            double o = 5.0 + 2.0 * ((j * 13) % 10) / 10.0;
            double z = 102.0 + 5.0 * ((j * 29) % 10) / 10.0;
            double w = 40000.0 + 20000.0 * ((j * 17) % 10) / 10.0;
            double d = 0.08 * Math.Cos(j * 0.21);
            Fill(frame, groundCount + j, o, z, w, d, ref minO, ref maxO, ref minZ, ref maxZ, ref minW, ref maxW);
        }
        frame.TotalPoints = count;
        frame.StoredPoints = count;
        frame.Truncated = false;
        frame.OffsetMin = minO;
        frame.OffsetMax = maxO;
        frame.ZMin = minZ;
        frame.ZMax = maxZ;
        frame.WeightMin = minW;
        frame.WeightMax = maxW;
        return frame;
    }

    private static void Fill(LasSectionFrame frame, int i, double o, double z, double w, double d,
        ref double minO, ref double maxO, ref double minZ, ref double maxZ,
        ref double minW, ref double maxW)
    {
        frame.Offsets[i] = o;
        frame.Elevations[i] = z;
        frame.Weights[i] = w;
        frame.SliceDistances[i] = d;
        if (o < minO) minO = o;
        if (o > maxO) maxO = o;
        if (z < minZ) minZ = z;
        if (z > maxZ) maxZ = z;
        if (w < minW) minW = w;
        if (w > maxW) maxW = w;
    }

    private static LasSectionFrame EmptyFrame()
    {
        LasSectionFrame frame = new LasSectionFrame();
        frame.Alignment = "Axis-1";
        frame.Station = 42.0;
        frame.Thickness = 0.4;
        frame.LeftOffset = 15;
        frame.RightOffset = 15;
        frame.Offsets = new double[0];
        frame.Elevations = new double[0];
        frame.Weights = new double[0];
        frame.SliceDistances = new double[0];
        return frame;
    }

    private static void Main()
    {
        string dir = Path.Combine(Path.GetTempPath(), "RoboLasSectionRendererTests");
        Directory.CreateDirectory(dir);
        LasSectionFrame frame = SyntheticFrame();
        List<double[][]> polygons = new List<double[][]>();
        polygons.Add(new double[][] { new double[] { 4, 101 }, new double[] { 8, 101 },
            new double[] { 8, 108 }, new double[] { 4, 108 } });

        // 1. Basic render (fit scale, polygon overlay).
        SectionImageOptions options = new SectionImageOptions();
        options.WidthPx = 800;
        options.HeightPx = 500;
        string png = Path.Combine(dir, "section_basic.png");
        SectionImageInfo info = SectionImageRenderer.Render(frame, polygons, options, png);
        Check(File.Exists(png), "render creates PNG", png);
        long size = File.Exists(png) ? new FileInfo(png).Length : 0;
        Check(size > 5000, "PNG is larger than 5 KB", size.ToString(CultureInfo.InvariantCulture));
        Check(info.WidthPx == 800 && info.HeightPx == 500, "info reports requested dimensions",
            info.WidthPx + "x" + info.HeightPx);
        Check(info.PlotLeftPx > 0 && info.PlotTopPx > 0 && info.PlotWidthPx > 0 && info.PlotHeightPx > 0,
            "plot rectangle is positive",
            info.PlotLeftPx + "," + info.PlotTopPx + " " + info.PlotWidthPx + "x" + info.PlotHeightPx);
        Check(info.PlotLeftPx + info.PlotWidthPx <= 800 && info.PlotTopPx + info.PlotHeightPx <= 500,
            "plot rectangle fits canvas");
        Check(info.PixelsPerMeterX > 0 && info.PixelsPerMeterY > 0, "pixels per meter are positive",
            Text(info.PixelsPerMeterX) + " " + Text(info.PixelsPerMeterY));
        Check(info.GridStepOffset > 0 && info.GridStepZ > 0, "grid steps are positive",
            Text(info.GridStepOffset) + " " + Text(info.GridStepZ));
        Check(info.OffsetFrom <= 4 && info.OffsetTo >= 8 && info.ZFrom <= 101 && info.ZTo >= 107,
            "bounds cover data and polygon",
            Text(info.OffsetFrom) + ".." + Text(info.OffsetTo) + " " + Text(info.ZFrom) + ".." + Text(info.ZTo));

        // 2. Pixel<->meter calibration: known points must map inside the plot rectangle.
        bool mappingOk = true;
        string mappingDetail = "";
        for (int i = 0; i < frame.StoredPoints; i += 97)
        {
            double x = info.PlotLeftPx + (frame.Offsets[i] - info.OffsetFrom) * info.PixelsPerMeterX;
            double y = info.PlotTopPx + (info.ZTo - frame.Elevations[i]) * info.PixelsPerMeterY;
            if (x < info.PlotLeftPx - 0.05 || x > info.PlotLeftPx + info.PlotWidthPx + 0.05 ||
                y < info.PlotTopPx - 0.05 || y > info.PlotTopPx + info.PlotHeightPx + 0.05)
            {
                mappingOk = false;
                mappingDetail = "point " + i + " -> (" + Text(x) + ", " + Text(y) + ")";
                break;
            }
        }
        Check(mappingOk, "offset/z -> px mapping stays inside plot rect", mappingDetail);

        // 3. The saved file loads through GDI+ with exact dimensions.
        bool bitmapOk = false;
        string bitmapDetail = "";
        try
        {
            using (Bitmap bitmap = new Bitmap(png))
            {
                bitmapOk = bitmap.Width == 800 && bitmap.Height == 500;
                bitmapDetail = bitmap.Width + "x" + bitmap.Height;
            }
        }
        catch (Exception error)
        {
            bitmapDetail = error.Message;
        }
        Check(bitmapOk, "PNG loads as bitmap with exact dimensions", bitmapDetail);

        // 4. Empty frame with polygon must not crash and must produce a file.
        string emptyPng = Path.Combine(dir, "section_empty.png");
        SectionImageRenderer.Render(EmptyFrame(), polygons, options, emptyPng);
        Check(File.Exists(emptyPng) && new FileInfo(emptyPng).Length > 0, "empty frame renders grid + polygon");

        // 5. Equal scale mode uses a single pixels-per-meter value on both axes.
        SectionImageOptions equal = new SectionImageOptions();
        equal.WidthPx = 800;
        equal.HeightPx = 500;
        equal.ScaleMode = "equal";
        SectionImageInfo equalInfo = SectionImageRenderer.Render(frame, polygons, equal,
            Path.Combine(dir, "section_equal.png"));
        Check(Math.Abs(equalInfo.PixelsPerMeterX - equalInfo.PixelsPerMeterY) <= 1e-6,
            "equal scale keeps PixelsPerMeterX == PixelsPerMeterY",
            Text(equalInfo.PixelsPerMeterX) + " " + Text(equalInfo.PixelsPerMeterY));

        // 6. Alternative color modes do not crash.
        string[] colorModes = new string[] { "z", "slice_distance" };
        foreach (string colorMode in colorModes)
        {
            SectionImageOptions colored = new SectionImageOptions();
            colored.WidthPx = 800;
            colored.HeightPx = 500;
            colored.ColorBy = colorMode;
            string colorPng = Path.Combine(dir, "section_color_" + colorMode + ".png");
            SectionImageInfo coloredInfo = SectionImageRenderer.Render(frame, polygons, colored, colorPng);
            Check(File.Exists(colorPng) && new FileInfo(colorPng).Length > 0,
                "color_by=" + colorMode + " renders", coloredInfo.Path);
        }

        // 7. z_min/z_max clamp the frame; grid_step overrides auto steps.
        SectionImageOptions clamped = new SectionImageOptions();
        clamped.WidthPx = 800;
        clamped.HeightPx = 500;
        clamped.ZMin = 100.0;
        clamped.ZMax = 105.0;
        clamped.GridStep = 1.0;
        SectionImageInfo clampedInfo = SectionImageRenderer.Render(frame, null, clamped,
            Path.Combine(dir, "section_clamped.png"));
        Check(Math.Abs(clampedInfo.ZFrom - 100.0) < 1e-9 && Math.Abs(clampedInfo.ZTo - 105.0) < 1e-9,
            "z_min/z_max override frame bounds",
            Text(clampedInfo.ZFrom) + ".." + Text(clampedInfo.ZTo));
        Check(Math.Abs(clampedInfo.GridStepOffset - 1.0) < 1e-9 && Math.Abs(clampedInfo.GridStepZ - 1.0) < 1e-9,
            "grid_step overrides auto steps",
            Text(clampedInfo.GridStepOffset) + " " + Text(clampedInfo.GridStepZ));

        if (failures > 0)
        {
            Console.WriteLine(failures + " section renderer test(s) failed");
            Environment.Exit(1);
        }
        Console.WriteLine("ALL SECTION RENDERER TESTS PASSED");
    }
}
