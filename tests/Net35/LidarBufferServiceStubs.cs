using System;
using System.Collections.Generic;

namespace Topomatic.Cad.Foundation
{
    public struct Vector4D
    {
        public readonly double X, Y, Z, W;
        public Vector4D(double x, double y, double z, double w)
        { X = x; Y = y; Z = z; W = w; }
    }

    public sealed class BoundingBox2D { }
}

namespace Topomatic.Alg
{
    public sealed class Alignment
    {
        public readonly List<string> EgSurfaceRelativePaths = new List<string>();
        public object Model;
    }
}

namespace Topomatic.ApplicationPlatform.Plugins
{
    public static class PluginCoreOps
    {
        public static object FindModel(Topomatic.Alg.Alignment alignment)
        { return alignment.Model; }
    }
}

namespace Topomatic.Sfc
{
    public sealed class Surface
    {
        public readonly List<object> ProxySourceProviders = new List<object>();
    }
}

namespace Topomatic.Alg.Runtime.Tools
{
    public static class AlignLibrary
    {
        public static bool Found = true;
        public static readonly List<Topomatic.Sfc.Surface> Results =
            new List<Topomatic.Sfc.Surface>();
        public static object LastModel;
        public static IList<string> LastPaths;

        public static bool FindSurfaces(object model, IList<string> paths,
            List<Topomatic.Sfc.Surface> output)
        {
            LastModel = model;
            LastPaths = paths;
            if (!Found) return false;
            output.AddRange(Results);
            return true;
        }
    }
}

namespace Topomatic.Lidar
{
    public sealed class LidarPoint
    {
        public readonly double X, Y, Z, W;
        public LidarPoint(double x, double y, double z, double w)
        { X = x; Y = y; Z = z; W = w; }
    }

    public interface ILidarBufferContainer
    {
        LidarBuffer GetBuffer();
    }

    public sealed class LidarBuffer
    {
        public readonly List<LidarPoint> Points = new List<LidarPoint>();
        public void FindPoints(Topomatic.Cad.Foundation.BoundingBox2D box,
            Action<LidarPoint> add)
        {
            foreach (LidarPoint point in Points) add(point);
        }
    }
}

namespace Topomatic.Controls.Dialogs
{
    public static class MessageDlg
    {
        public static int Calls;
        public static void Show(string message,
            System.Windows.Forms.MessageBoxButtons buttons,
            System.Windows.Forms.MessageBoxIcon icon)
        { Calls++; }
    }
}
