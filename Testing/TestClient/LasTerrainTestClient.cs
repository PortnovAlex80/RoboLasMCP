// Testing/TestClient/LasTerrainTestClient.cs
// Standalone console app that connects to LAS_TERRAIN IPC test service
// running inside Topomatic.
//
// Compile:
//   csc LasTerrainTestClient.cs /r:System.Runtime.Remoting.dll
//
// Usage:
//   LasTerrainTestClient.exe ping            -- connectivity check
//   LasTerrainTestClient.exe info            -- plugin info
//   LasTerrainTestClient.exe tests           -- run all tests
//   LasTerrainTestClient.exe snapshot        -- read project, alignment, section, and surface state
//   LasTerrainTestClient.exe sourceprobe     -- read borrowed LiDAR identity stability
//   LasTerrainTestClient.exe sectionrollback -- mutate and roll back sections on a disposable project
//   LasTerrainTestClient.exe surfaceprobe    -- read surface TIN and transaction ownership
//   LasTerrainTestClient.exe surfaceappend   -- test raw append on an empty disposable surface
//   LasTerrainTestClient.exe stationparity   -- compare ordered XYZ from both section inputs
//   LasTerrainTestClient.exe drawline        -- draw a test line in project
//   LasTerrainTestClient.exe drawgrid        -- draw a 5x5 grid of lines
//   LasTerrainTestClient.exe drawpoints      -- draw test points
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;

namespace LAS_TERRAIN.Testing.Remoting
{
    internal class LasTerrainTestClient
    {
        static int Main(string[] args)
        {
            Console.WriteLine("=== LAS_TERRAIN IPC Test Client ===");
            Console.WriteLine();

            try
            {
                var channel = new IpcChannel("LasTerrainTestClient");
                ChannelServices.RegisterChannel(channel, false);

                var service = (LasTerrainTestService)Activator.GetObject(
                    typeof(LasTerrainTestService), "ipc://LasTerrainTestIPC/LasTerrainTestService");

                if (service == null)
                {
                    Console.WriteLine("ERROR: Could not connect to service.");
                    return 2;
                }

                string command = args.Length > 0 ? args[0].ToLower() : "tests";

                switch (command)
                {
                    case "ping":
                        {
                            string result = service.Ping();
                            Console.WriteLine("Ping -> {0}", result);
                            bool ok = (result == "PONG");
                            Console.WriteLine(ok ? "OK" : "FAIL");
                            return ok ? 0 : 1;
                        }

                    case "info":
                        {
                            var info = service.GetPluginInfo();
                            Console.WriteLine("Plugin Info:");
                            foreach (var kv in info)
                                Console.WriteLine("  {0} = {1}", kv.Key, kv.Value);
                            return 0;
                        }

                    case "snapshot":
                        {
                            var snapshot = service.GetContextSnapshot();
                            var keys = new List<string>(snapshot.Keys);
                            keys.Sort(StringComparer.Ordinal);
                            Console.WriteLine("Context Snapshot:");
                            foreach (string key in keys)
                                Console.WriteLine("  {0} = {1}", key, snapshot[key]);
                            return snapshot.ContainsKey("status") && snapshot["status"] == "ok" ? 0 : 1;
                        }

                    case "sourceprobe":
                        {
                            var probe = service.GetLidarSourceProbe();
                            var keys = new List<string>(probe.Keys);
                            keys.Sort(StringComparer.Ordinal);
                            Console.WriteLine("LiDAR Source Probe:");
                            foreach (string key in keys)
                                Console.WriteLine("  {0} = {1}", key, probe[key]);
                            return probe.ContainsKey("status") && probe["status"] == "ok" ? 0 : 1;
                        }

                    case "sectionrollback":
                        {
                            var probe = service.GetSectionRollbackProbe();
                            var keys = new List<string>(probe.Keys);
                            keys.Sort(StringComparer.Ordinal);
                            Console.WriteLine("Section Rollback Probe:");
                            foreach (string key in keys)
                                Console.WriteLine("  {0} = {1}", key, probe[key]);
                            return probe.ContainsKey("status") && probe["status"] == "ok" ? 0 : 1;
                        }

                    case "surfaceprobe":
                        {
                            var probe = service.GetSurfaceStatusProbe();
                            var keys = new List<string>(probe.Keys);
                            keys.Sort(StringComparer.Ordinal);
                            Console.WriteLine("Surface Status Probe:");
                            foreach (string key in keys)
                                Console.WriteLine("  {0} = {1}", key, probe[key]);
                            return probe.ContainsKey("status") && probe["status"] == "ok" ? 0 : 1;
                        }

                    case "surfaceappend":
                        {
                            var probe = service.GetSurfaceAppendProbe();
                            var keys = new List<string>(probe.Keys);
                            keys.Sort(StringComparer.Ordinal);
                            Console.WriteLine("Surface Append Probe:");
                            foreach (string key in keys)
                                Console.WriteLine("  {0} = {1}", key, probe[key]);
                            return probe.ContainsKey("status") && probe["status"] == "ok" ? 0 : 1;
                        }

                    case "stationparity":
                        {
                            var probe = service.GetStationParityProbe();
                            var keys = new List<string>(probe.Keys);
                            keys.Sort(StringComparer.Ordinal);
                            Console.WriteLine("Station Parity Probe:");
                            foreach (string key in keys)
                                Console.WriteLine("  {0} = {1}", key, probe[key]);
                            return probe.ContainsKey("status") && probe["status"] == "ok" ? 0 : 1;
                        }

                    case "drawline":
                        {
                            double x1 = 0, y1 = 0, x2 = 100, y2 = 100;
                            if (args.Length >= 5)
                            {
                                double.TryParse(args[1], out x1);
                                double.TryParse(args[2], out y1);
                                double.TryParse(args[3], out x2);
                                double.TryParse(args[4], out y2);
                            }
                            Console.WriteLine("Drawing line ({0},{1}) -> ({2},{3})...", x1, y1, x2, y2);
                            string result = service.DrawLine(x1, y1, 0, x2, y2, 0);
                            Console.WriteLine("Result: {0}", result);
                            return result.StartsWith("OK") ? 0 : 1;
                        }

                    case "drawgrid":
                        {
                            Console.WriteLine("Drawing 5x5 grid...");
                            int count = 0;
                            for (int i = 0; i <= 5; i++)
                            {
                                string r1 = service.DrawLine(i * 20, 0, 0, i * 20, 100, 0);
                                string r2 = service.DrawLine(0, i * 20, 0, 100, i * 20, 0);
                                if (r1.StartsWith("OK")) count++;
                                if (r2.StartsWith("OK")) count++;
                            }
                            Console.WriteLine("Drew {0} lines", count);
                            return count > 0 ? 0 : 1;
                        }

                    case "drawpoints":
                        {
                            Console.WriteLine("Drawing 10 points...");
                            int count = 0;
                            for (int i = 0; i < 10; i++)
                            {
                                string r = service.DrawPoint(i * 10, i * 10, 0);
                                if (r.StartsWith("OK")) count++;
                            }
                            Console.WriteLine("Drew {0} points", count);
                            return count > 0 ? 0 : 1;
                        }

                    case "drawpolyline":
                        {
                            Console.WriteLine("Drawing a polyline (triangle)...");
                            double[] coords = new double[] {
                                0, 0, 0,
                                100, 0, 0,
                                50, 86.6, 0,
                                0, 0, 0
                            };
                            string result = service.DrawPolyline(coords);
                            Console.WriteLine("Result: {0}", result);
                            return result.StartsWith("OK") ? 0 : 1;
                        }

                    case "aligninfo":
                        {
                            Console.WriteLine("Getting alignment info...");
                            var info = service.GetAlignmentInfo();
                            foreach (var kv in info)
                                Console.WriteLine("  {0} = {1}", kv.Key, kv.Value);
                            return info.ContainsKey("error") ? 1 : 0;
                        }

                    case "gensections":
                        {
                            double step = 20.0;
                            if (args.Length >= 2)
                                double.TryParse(args[1], out step);
                            Console.WriteLine("Generating sections (step={0}m)...", step);
                            string result = service.GenerateSections(step);
                            Console.WriteLine("Result: {0}", result);
                            return result.StartsWith("OK") ? 0 : 1;
                        }

                    case "explore":
                        {
                            Console.WriteLine("Exploring project structure...");
                            string result = service.ExploreProject();
                            Console.WriteLine(result);
                            return 0;
                        }

                    case "activatename":
                        {
                            Console.WriteLine("Getting active alignment name...");
                            string result = service.GetActiveAlignmentName();
                            Console.WriteLine("Active alignment: {0}", result);
                            return 0;
                        }

                    case "listalignments":
                        {
                            Console.WriteLine("Listing alignments...");
                            string result = service.ListAlignments();
                            Console.WriteLine("Alignments: {0}", result);
                            return 0;
                        }

                    case "createalign":
                        {
                            if (args.Length < 4)
                            {
                                Console.WriteLine("Usage: createalign <name> <x1> <y1> <x2> <y2> [<x3> <y3> ...]");
                                return 1;
                            }
                            string alignName = args[1];
                            int coordCount = args.Length - 2;
                            double[] coords = new double[coordCount];
                            for (int i = 0; i < coordCount; i++)
                            {
                                double.TryParse(args[i + 2], out coords[i]);
                            }
                            Console.WriteLine("Creating alignment '{0}' with {1} coords...", alignName, coordCount);
                            string result = service.CreateTestAlignment(alignName, coords);
                            Console.WriteLine("Result: {0}", result);
                            return result.StartsWith("OK") ? 0 : 1;
                        }

                    case "activate":
                        {
                            if (args.Length < 2)
                            {
                                Console.WriteLine("Usage: activate <name>");
                                return 1;
                            }
                            string alignName = args[1];
                            Console.WriteLine("Activating alignment '{0}'...", alignName);
                            string result = service.SetActiveAlignment(alignName);
                            Console.WriteLine("Result: {0}", result);
                            return result.StartsWith("OK") ? 0 : 1;
                        }

                    case "switchtest":
                        {
                            Console.WriteLine("=== Alignment Switch Test ===");
                            Console.WriteLine();

                            string alignList = service.ListAlignments();
                            Console.WriteLine("Current alignments: {0}", alignList);

                            if (!alignList.Contains("TestA"))
                            {
                                double[] coordsA = new double[] { 20468021, 5581523, 20468100, 5581560, 20468200, 5581540 };
                                Console.Write("Creating TestA...");
                                string r1 = service.CreateTestAlignment("TestA", coordsA);
                                Console.WriteLine(" {0}", r1.Split('\n')[0]);
                            }

                            if (!alignList.Contains("TestB"))
                            {
                                double[] coordsB = new double[] { 20468100, 5581700, 20468200, 5581750, 20468300, 5581720 };
                                Console.Write("Creating TestB...");
                                string r2 = service.CreateTestAlignment("TestB", coordsB);
                                Console.WriteLine(" {0}", r2.Split('\n')[0]);
                            }

                            Console.WriteLine();
                            Console.WriteLine("Switching TestA <-> TestB (10 times, 2s)...");
                            Console.WriteLine();

                            for (int i = 0; i < 10; i++)
                            {
                                string target = (i % 2 == 0) ? "TestA" : "TestB";
                                Console.Write("[{0}/10] {1}...", i + 1, target);
                                string result = service.SetActiveAlignment(target);
                                Console.WriteLine(" {0}", result);

                                if (i < 9)
                                    System.Threading.Thread.Sleep(1000);
                            }

                            Console.WriteLine();
                            Console.WriteLine("=== Switch test complete ===");
                            string current = service.GetActiveAlignmentName();
                            Console.WriteLine("Current active: {0}", current);

                            return 0;
                        }

                    case "tests":
                    default:
                        {
                            Console.WriteLine("Running all tests via IPC...");
                            Console.WriteLine();
                            string results = service.RunAllTests();
                            Console.WriteLine(results);

                            bool hasFailures = results.Contains("[FAIL]");
                            Console.WriteLine();
                            Console.WriteLine(hasFailures ? "SOME TESTS FAILED" : "ALL TESTS PASSED");
                            return hasFailures ? 1 : 0;
                        }
                }
            }
            catch (System.Runtime.Remoting.RemotingException ex)
            {
                Console.WriteLine("REMOTING ERROR: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Make sure Topomatic is running with LAS_TERRAIN plugin loaded.");
                return 2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                return 2;
            }
        }
    }

    /// <summary>
    /// Client-side stub - same namespace and type name as server-side service.
    /// .NET Remoting requires matching type identity for deserialization.
    /// </summary>
    public class LasTerrainTestService : MarshalByRefObject
    {
        public string Ping() { throw new NotSupportedException(); }
        public Dictionary<string, string> GetPluginInfo() { throw new NotSupportedException(); }
        public Dictionary<string, string> GetContextSnapshot() { throw new NotSupportedException(); }
        public Dictionary<string, string> GetLidarSourceProbe() { throw new NotSupportedException(); }
        public Dictionary<string, string> GetSectionRollbackProbe() { throw new NotSupportedException(); }
        public Dictionary<string, string> GetSurfaceStatusProbe() { throw new NotSupportedException(); }
        public Dictionary<string, string> GetSurfaceAppendProbe() { throw new NotSupportedException(); }
        public Dictionary<string, string> GetStationParityProbe() { throw new NotSupportedException(); }
        public string RunAllTests() { throw new NotSupportedException(); }
        public string DrawLine(double x1, double y1, double z1, double x2, double y2, double z2) { throw new NotSupportedException(); }
        public string DrawPolyline(double[] coords) { throw new NotSupportedException(); }
        public string DrawPoint(double x, double y, double z) { throw new NotSupportedException(); }
        public Dictionary<string, string> GetAlignmentInfo() { throw new NotSupportedException(); }
        public string GenerateSections(double step) { throw new NotSupportedException(); }
        public string ExploreProject() { throw new NotSupportedException(); }
        public string GetActiveAlignmentName() { throw new NotSupportedException(); }
        public string CreateTestAlignment(string name, double[] xyCoords) { throw new NotSupportedException(); }
        public string SetActiveAlignment(string name) { throw new NotSupportedException(); }
        public string ListAlignments() { throw new NotSupportedException(); }
        public string SetActiveAlignmentByIndex(int index) { throw new NotSupportedException(); }
    }
}
