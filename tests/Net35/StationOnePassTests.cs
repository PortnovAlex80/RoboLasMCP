using System;
using System.Collections.Generic;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Service;
using Topomatic.Alg;
using Topomatic.Alg.Crs;
using Topomatic.Cad.Foundation;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Tests
{
    internal static class StationOnePassTests
    {
        private static int checks;

        private static void Check(bool condition, string name)
        {
            checks++;
            if (!condition) throw new Exception(name);
        }

        private static LidarBuffer Buffer(float scaleX, float posX)
        {
            Vector3F[] points = {
                new Vector3F(0, 2.5f, 10), new Vector3F(5, 2.5f, 11),
                new Vector3F(5, 2.5f, 12), new Vector3F(10, 2.5f, 13),
                new Vector3F(5, 3.5f, 14), // open positive border
                new Vector3F(5, 1.5f, 15), // open negative border
                new Vector3F(5, 7.5f, 20), new Vector3F(10, 7.5f, 21)
            };
            QuadTreeIndexer indexer = new QuadTreeIndexer();
            indexer.points = new TestPointArray(points);
            indexer.minx = 0; indexer.maxx = 10;
            indexer.miny = 1; indexer.maxy = 8;
            indexer.start = 0; indexer.count = points.Length;
            indexer.scale.X = scaleX;
            indexer.position.X = posX;
            return new LidarBuffer { indexers = new QuadTreeIndexer[] { indexer } };
        }

        private static void CheckParity(bool parallel, float scaleX, float posX)
        {
            Alignment alignment = new Alignment();
            alignment.Plan.CompoundLine.UseStationAsY = true;
            alignment.Corridor.Sections.ThrowOnRead = true;
            List<Section> sections = new List<Section> {
                new Section { Station = 2.5 }, new Section { Station = 7.5 }
            };
            List<double> stations = new List<double> { 2.5, 7.5 };
            List<LidarBuffer> buffers = new List<LidarBuffer> { Buffer(scaleX, posX) };
            LasFilterOptions options = LasFilterOptions.FromThickness(2.0, parallel);
            LasSectionPoints[] oldResult = OnePassSectionCollector.CollectAllSections(
                alignment, buffers, sections, options, null, null,
                delegate { return false; });
            LasSectionPoints[] stationResult = OnePassSectionCollector.CollectAllAtStations(
                alignment, buffers, stations, options, null,
                delegate { return false; });
            Check(oldResult != null && stationResult != null &&
                oldResult.Length == 2 && stationResult.Length == 2,
                "both collection paths return the two requested sections");
            Check(alignment.Plan.CompoundLine.LastStation == 7.5,
                "station order preserved");
            Check(oldResult[0].SectionPoints.Count == 4 &&
                oldResult[1].SectionPoints.Count == 2,
                "hand-counted section membership and open borders");
            Check(oldResult[0].SectionPoints[0].Y == 10 &&
                oldResult[0].SectionPoints[1].Y == 11 &&
                oldResult[0].SectionPoints[2].Y == 12 &&
                oldResult[0].SectionPoints[3].Y == 13,
                "duplicate positions retain source order and distinct heights");
            for (int i = 0; i < oldResult.Length; i++)
            {
                Check(oldResult[i].OriginOffset == stationResult[i].OriginOffset &&
                    oldResult[i].LeftMostPoint.X == stationResult[i].LeftMostPoint.X &&
                    oldResult[i].LeftMostPoint.Y == stationResult[i].LeftMostPoint.Y &&
                    oldResult[i].RightMostPoint.X == stationResult[i].RightMostPoint.X &&
                    oldResult[i].RightMostPoint.Y == stationResult[i].RightMostPoint.Y &&
                    oldResult[i].Direction.X == stationResult[i].Direction.X &&
                    oldResult[i].Direction.Y == stationResult[i].Direction.Y,
                    "station geometry parity");
                Check(oldResult[i].SectionPoints.Count ==
                    stationResult[i].SectionPoints.Count, "station count parity");
                for (int j = 0; j < oldResult[i].SectionPoints.Count; j++)
                    Check(oldResult[i].SectionPoints[j].X == stationResult[i].SectionPoints[j].X &&
                        oldResult[i].SectionPoints[j].Y == stationResult[i].SectionPoints[j].Y,
                        "station tuple and source-order parity");
            }
        }

        private static void CheckPerAxisLidarTransform(bool parallel)
        {
            // These local coordinates deliberately reverse Y and Z. The expected
            // section points are specified in world coordinates independently
            // of the indexer's coordinate conversion.
            QuadTreeIndexer indexer = new QuadTreeIndexer();
            indexer.points = new TestPointArray(new Vector3F[] {
                new Vector3F(10, 15, 10),  // world (0, 2.5, 10)
                new Vector3F(20, 15, 9.5f), // world (5, 2.5, 11)
                new Vector3F(20, 5, 5)     // world (5, 7.5, 20)
            });
            indexer.minx = 10; indexer.maxx = 20;
            indexer.miny = 5; indexer.maxy = 15;
            indexer.start = 0; indexer.count = 3;
            indexer.scale = new Vector3F(0.5f, -0.5f, -2);
            indexer.position = new Vector3F(-5, 10, 30);

            LidarBuffer buffer = new LidarBuffer {
                indexers = new QuadTreeIndexer[] { indexer }
            };
            Alignment alignment = new Alignment();
            alignment.Plan.CompoundLine.UseStationAsY = true;
            LasFilterOptions options = LasFilterOptions.FromThickness(2.0, parallel);
            LasSectionPoints[] actual = OnePassSectionCollector.CollectAllAtStations(
                alignment, new List<LidarBuffer> { buffer },
                new List<double> { 2.5, 7.5 }, options, null,
                delegate { return false; });

            Check(actual != null && actual.Length == 2,
                "per-axis transformed sections returned");
            Check(actual[0].SectionPoints.Count == 2 &&
                actual[0].SectionPoints[0].X == 0 &&
                actual[0].SectionPoints[0].Y == 10 &&
                actual[0].SectionPoints[1].X == 5 &&
                actual[0].SectionPoints[1].Y == 11,
                "per-axis transform preserves first section world coordinates and order");
            Check(actual[1].SectionPoints.Count == 1 &&
                actual[1].SectionPoints[0].X == 5 &&
                actual[1].SectionPoints[0].Y == 20,
                "negative Y/Z scales preserve second section world coordinates");
        }

        public static int Main()
        {
            CheckParity(false, 1, 0);
            CheckParity(true, 1, 0);
            CheckParity(false, -1, 10);
            CheckPerAxisLidarTransform(false);
            CheckPerAxisLidarTransform(true);
            foreach (float scaleX in new float[] { 1, -1 })
            {
                Alignment splitAlignment = new Alignment();
                splitAlignment.Plan.CompoundLine.UseStationAsY = true;
                LasFilterOptions splitOptions = LasFilterOptions.FromThickness(2.0, false);
                splitOptions.IncludePositiveSliceBorder = true;
                LasSectionPoints[] splitSlices = OnePassSectionCollector.CollectAllAtStations(
                    splitAlignment, new List<LidarBuffer> { Buffer(scaleX,
                        scaleX < 0 ? 10 : 0) }, new List<double> { 2.5, 7.5 },
                    splitOptions, null, delegate { return false; });
                Check(splitSlices[0].SectionPoints.Count == 5 &&
                    splitSlices[0].SectionPoints[4].Y == 15 &&
                    splitSlices[1].SectionPoints.Count == 2,
                    "OnePass split mode includes positive border with either indexer scale");
            }
            foreach (bool parallel in new bool[] { false, true })
            {
                Alignment capturedAlignment = new Alignment();
                capturedAlignment.Plan.CompoundLine.UseStationAsY = true;
                LasFilterOptions mutable = LasFilterOptions.FromThickness(2.0, parallel);
                mutable.IncludePositiveSliceBorder = true;
                bool changed = false;
                LasSectionPoints[] captured = OnePassSectionCollector.CollectAllAtStations(
                    capturedAlignment, new List<LidarBuffer> { Buffer(1, 0) },
                    new List<double> { 2.5 }, mutable,
                    delegate(float progress)
                    {
                        if (progress == 0.0f)
                        {
                            mutable.HalfBorder = 0.01;
                            mutable.IncludePositiveSliceBorder = false;
                            changed = true;
                        }
                    }, delegate { return false; });
                Check(changed && captured != null &&
                    captured[0].SectionPoints.Count == 5 &&
                    captured[0].SectionPoints[4].Y == 15,
                    "OnePass keeps the original slice options after progress changes the caller's copy");
            }
            Alignment alignment = new Alignment();
            List<LidarBuffer> buffers = new List<LidarBuffer> { Buffer(1, 0) };
            LasFilterOptions options = LasFilterOptions.FromThickness(2.0, false);
            bool invalidRejected = false;
            try
            {
                OnePassSectionCollector.CollectAllAtStations(alignment, buffers,
                    new List<double> { Double.NaN }, options, null, null);
            }
            catch (ArgumentOutOfRangeException) { invalidRejected = true; }
            Check(invalidRejected, "nonfinite station rejected before SDK preparation");
            Check(OnePassSectionCollector.CollectAllAtStations(alignment, buffers,
                new List<double> { 2.5 }, options, null, delegate { return true; }) == null,
                "cancellation before collection returns no partial sections");
            List<double> mutableStations = new List<double> { 2.5, 7.5 };
            alignment.Plan.CompoundLine.OnFirstPosition =
                delegate { mutableStations[1] = 99.0; };
            alignment.Plan.CompoundLine.UseStationAsY = true;
            OnePassSectionCollector.CollectAllAtStations(alignment, buffers,
                mutableStations, options, null, delegate { return false; });
            Check(mutableStations[1] == 99.0 &&
                alignment.Plan.CompoundLine.LastStation == 7.5,
                "station input is captured before SDK preparation");
            Console.WriteLine("OnePass station parity: " + checks + " checks passed.");
            return 0;
        }
    }
}
