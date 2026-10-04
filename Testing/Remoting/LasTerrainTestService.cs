// Testing/Remoting/LasTerrainTestService.cs
// POC: .NET Remoting IPC service for external test automation + remote control
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Remoting;
using System.Text;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Domain.Service;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Service;
using Topomatic.Alg;
using Topomatic.Alg.Model;
using Topomatic.Alg.Runtime.ServiceClasses;
using Topomatic.ApplicationPlatform;
using Topomatic.ApplicationPlatform.Core;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.Cad.Foundation;
using Topomatic.Cad.View;
using Topomatic.Dwg;
using Topomatic.Dwg.Entities;
using Topomatic.Dwg.Layer;
using Topomatic.Sfc.Layer;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Testing.Remoting
{
    /// <summary>
    /// Remoting test service exposed via IPC channel.
    /// External test client connects and calls Ping/RunTests/DrawLine.
    /// </summary>
    public class LasTerrainTestService : MarshalByRefObject
    {
        public const string ChannelName = "LasTerrainTestIPC";
        public const string ServiceUri = "LasTerrainTestService";

        /// <summary>
        /// Connectivity check.
        /// </summary>
        public string Ping()
        {
            return "PONG";
        }

        private static Dictionary<string, string> IpcStatus(string status)
        {
            var result = new Dictionary<string, string>();
            result["status"] = status;
            return result;
        }

        /// <summary>
        /// Returns plugin and environment info.
        /// </summary>
        public Dictionary<string, string> GetPluginInfo()
        {
            return DiagnosticUiDispatcher.Invoke(GetPluginInfoOnUi,
                IpcStatus("busy"), IpcStatus("ui_unavailable"));
        }

        private Dictionary<string, string> GetPluginInfoOnUi()
        {
            var info = new Dictionary<string, string>();
            info["status"] = "running";
            info["plugin"] = "LAS_TERRAIN";
            info["dotnet"] = Environment.Version.ToString();
            info["machine"] = Environment.MachineName;
            info["pid"] = System.Diagnostics.Process.GetCurrentProcess().Id.ToString();

            CadView cv = IpcTestServer.CadView;
            info["cadview"] = (cv != null) ? "available" : "null";
            return info;
        }

        /// <summary>
        /// Read-only snapshot for comparing project and section identity across host operations.
        /// Model access starts on the main UI thread; a foreign-thread view is rejected.
        /// </summary>
        public Dictionary<string, string> GetContextSnapshot()
        {
            return DiagnosticUiDispatcher.Invoke(GetContextSnapshotOnUi,
                IpcStatus("busy"), IpcStatus("ui_unavailable"));
        }

        private Dictionary<string, string> GetContextSnapshotOnUi()
        {
            var info = new Dictionary<string, string>();
            CadView cv = IpcTestServer.CadView;
            if (cv == null)
            {
                info["status"] = "no_cad_view";
                return info;
            }

            if (cv.InvokeRequired)
            {
                info["status"] = "view_thread_mismatch";
                return info;
            }

            try
            {
                if (cv.IsDisposed || !cv.IsHandleCreated)
                {
                    info["status"] = "view_unavailable";
                    return info;
                }

                cv.Invoke(new Action(delegate
                {
                    try
                    {
                        info["view.isDisposed"] = cv.IsDisposed.ToString();
                        info["view.isHandleCreated"] = cv.IsHandleCreated.ToString();
                        info["view.isLocked"] = cv.IsLocked.ToString();
                        info["view.isActive"] = Object.ReferenceEquals(IpcTestServer.CadView, cv).ToString();
                        if (cv.IsDisposed || !Object.ReferenceEquals(IpcTestServer.CadView, cv))
                        {
                            info["status"] = "view_changed";
                            return;
                        }

                        IApplicationHost host = ApplicationHost.Current;
                        Project project = host == null ? null : host.ActiveProject;
                        if (project == null)
                        {
                            info["status"] = "no_active_project";
                            return;
                        }

                        info["project.alias"] = project.Alias ?? String.Empty;
                        info["project.targetUri"] = project.TargetProjectUri == null
                            ? String.Empty : project.TargetProjectUri.ToString();

                        // Compare the project and host document accessors while
                        // surface and alignment documents are both open.
                        var projectViewForm = project.ActiveDocument as ICadViewForm;
                        CadView projectView = projectViewForm == null
                            ? null : projectViewForm.CadView;
                        info["view.projectDocument.sameAsHost"] =
                            Object.ReferenceEquals(project.ActiveDocument,
                                host.ActiveDocument).ToString();
                        info["view.project.sameAsHost"] =
                            Object.ReferenceEquals(projectView, cv).ToString();
                        info["view.project.surfacePresent"] =
                            (projectView != null &&
                             SurfaceLayer.GetSurfaceLayer(projectView) != null).ToString();

                        SurfaceLayer layer = SurfaceLayer.GetSurfaceLayer(cv);
                        info["surface.layerPresent"] = (layer != null).ToString();
                        info["surface.present"] = (layer != null && layer.Surface != null).ToString();
                        if (layer != null && layer.Surface != null)
                            info["surface.pointCount"] = layer.Surface.Points.Count.ToString(CultureInfo.InvariantCulture);

                        using (ActiveAlignmentReciver<Alignment> receiver =
                            ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                        {
                            Alignment alignment = receiver.Alignment;
                            if (alignment == null)
                            {
                                info["status"] = "no_active_alignment";
                                return;
                            }

                            IProjectModel model = PluginCoreOps.FindModel(alignment);
                            info["model.uri"] = model == null || model.Uri == null
                                ? String.Empty : model.Uri.ToString();
                            info["model.belongsToActiveProject"] =
                                (model != null && Object.ReferenceEquals(model.Project, project)).ToString();
                            info["alignment.id"] = AlignmentValueConverter.GetId(alignment).ToString("D");
                            info["alignment.alias"] = alignment.Alias ?? String.Empty;

                            int count = alignment.Corridor.Sections.Count;
                            info["section.count"] = count.ToString(CultureInfo.InvariantCulture);
                            for (int i = 0; i < count; i++)
                            {
                                var section = alignment.Corridor.Sections[i];
                                info["section." + i.ToString("D6", CultureInfo.InvariantCulture)] =
                                    section.Id.ToString(CultureInfo.InvariantCulture) + "," +
                                    section.Station.ToString("R", CultureInfo.InvariantCulture);
                            }
                            info["status"] = "ok";
                        }
                    }
                    catch (Exception ex)
                    {
                        info["status"] = "error";
                        info["error"] = ex.Message;
                    }
                }));
            }
            catch (Exception ex)
            {
                info["status"] = "error";
                info["error"] = ex.Message;
            }
            return info;
        }

        /// <summary>
        /// Read-only host probe for the borrowed LiDAR references used by Plan.
        /// It does not read or copy point values and uses sequential receivers.
        /// </summary>
        public Dictionary<string, string> GetLidarSourceProbe()
        {
            return DiagnosticUiDispatcher.Invoke(GetLidarSourceProbeOnUi,
                IpcStatus("busy"), IpcStatus("ui_unavailable"));
        }

        private Dictionary<string, string> GetLidarSourceProbeOnUi()
        {
            var result = new Dictionary<string, string>();
            CadView view = IpcTestServer.CadView;
            if (view == null || view.IsDisposed || !view.IsHandleCreated ||
                view.InvokeRequired)
            {
                result["status"] = "view_unavailable";
                return result;
            }

            try
            {
                Alignment capturedAlignment;
                List<LidarBuffer> capturedBuffers;
                BorrowedLidarSourceSnapshot snapshot;
                using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    capturedAlignment = receiver.Alignment;
                    if (capturedAlignment == null)
                    {
                        result["status"] = "no_active_alignment";
                        return result;
                    }
                    capturedBuffers = LidarBufferService.CollectBuffers(capturedAlignment);
                    if (capturedBuffers == null || capturedBuffers.Count == 0)
                    {
                        result["status"] = "no_lidar_buffers";
                        return result;
                    }
                    snapshot = BorrowedLidarSourceSnapshot.Capture(capturedBuffers);
                    result["captured.bufferCount"] = capturedBuffers.Count.ToString(
                        CultureInfo.InvariantCulture);
                }

                result["captured.matchesAfterReceiverDispose"] =
                    snapshot.Matches(capturedBuffers).ToString();
                using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    result["alignment.sameReference"] =
                        Object.ReferenceEquals(receiver.Alignment, capturedAlignment).ToString();
                    if (receiver.Alignment == null)
                    {
                        result["status"] = "active_alignment_changed";
                        return result;
                    }
                    List<LidarBuffer> fresh = LidarBufferService.CollectBuffers(receiver.Alignment);
                    result["provider.matchesSecondEnumeration"] =
                        snapshot.Matches(fresh).ToString();
                    result["fresh.bufferCount"] = fresh == null ? "null" :
                        fresh.Count.ToString(CultureInfo.InvariantCulture);
                }
                result["status"] = "ok";
            }
            catch (Exception ex)
            {
                result["status"] = "error";
                result["error"] = ex.GetType().FullName + ": " + ex.Message;
            }
            return result;
        }

        /// <summary>
        /// On a disposable project only: exercise the SDK's section-list
        /// transaction and check whether rollback restores the original
        /// Section objects and their identifiers. Never saves the project.
        /// </summary>
        public Dictionary<string, string> GetSectionRollbackProbe()
        {
            return DiagnosticUiDispatcher.Invoke(GetSectionRollbackProbeOnUi,
                IpcStatus("busy"), IpcStatus("ui_unavailable"));
        }

        /// <summary>Read-only surface and section transaction ownership on the CAD UI thread.</summary>
        public Dictionary<string, string> GetSurfaceStatusProbe()
        {
            return DiagnosticUiDispatcher.Invoke(GetSurfaceStatusProbeOnUi,
                IpcStatus("busy"), IpcStatus("ui_unavailable"));
        }

        /// <summary>Disposable-project probe of raw append and TIN notification.</summary>
        public Dictionary<string, string> GetSurfaceAppendProbe()
        {
            return DiagnosticUiDispatcher.Invoke(GetSurfaceAppendProbeOnUi,
                IpcStatus("busy"), IpcStatus("ui_unavailable"));
        }

        /// <summary>Compare the legacy and station inputs through the same filter path.</summary>
        public Dictionary<string, string> GetStationParityProbe()
        {
            return DiagnosticUiDispatcher.Invoke(GetStationParityProbeOnUi,
                IpcStatus("busy"), IpcStatus("ui_unavailable"));
        }

        private Dictionary<string, string> GetStationParityProbeOnUi()
        {
            var result = new Dictionary<string, string>();
            try
            {
                CadView view = IpcTestServer.CadView;
                if (view == null || view.IsDisposed || !view.IsHandleCreated || view.InvokeRequired)
                    return IpcStatus("view_unavailable");
                using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    var alignment = receiver.Alignment;
                    if (alignment == null || alignment.Corridor == null ||
                        alignment.Corridor.Sections == null ||
                        alignment.Corridor.Sections.Count < 3)
                        return IpcStatus("sections_unavailable");
                    var sections = new List<Topomatic.Alg.Crs.Section>();
                    var stations = new List<double>();
                    int totalSections = alignment.Corridor.Sections.Count;
                    int sampleCount = Math.Min(30, totalSections);
                    for (int i = 0; i < sampleCount; i++)
                    {
                        int index = i * (totalSections - 1) / (sampleCount - 1);
                        var section = alignment.Corridor.Sections[index];
                        sections.Add(section);
                        stations.Add(section.Station);
                    }
                    result["sections.sampled"] = sampleCount.ToString(CultureInfo.InvariantCulture);
                    var buffers = LidarBufferService.CollectBuffers(alignment);
                    if (buffers.Count == 0) return IpcStatus("buffers_unavailable");
                    var settings = FilterSettingsSnapshotAdapter.Capture();
                    var options = LasFilterOptions.FromThickness(0.25, false);
                    foreach (bool onePass in new bool[] { false, true })
                    {
                        string prefix = onePass ? "onepass" : "legacy";
                        var registered = GroundPointsCollector.Collect(alignment, buffers,
                            sections, options, null, settings, onePass);
                        var stationed = GroundPointsCollector.CollectAtStations(alignment,
                            buffers, stations, options, settings, onePass);
                        result[prefix + ".registered.status"] = registered.Status.ToString();
                        result[prefix + ".stationed.status"] = stationed.Status.ToString();
                        if (registered.Status != stationed.Status)
                        {
                            result["status"] = "status_mismatch";
                            return result;
                        }
                        if (registered.Status == LAS_TERRAIN.Application.OperationStatus.Success)
                        {
                            result[prefix + ".registered.count"] =
                                registered.Value.Count.ToString(CultureInfo.InvariantCulture);
                            result[prefix + ".stationed.count"] =
                                stationed.Value.Count.ToString(CultureInfo.InvariantCulture);
                            bool same = registered.Value.Count == stationed.Value.Count;
                            if (same)
                                for (int i = 0; i < registered.Value.Count; i++)
                                {
                                    Vector3D a = registered.Value[i];
                                    Vector3D b = stationed.Value[i];
                                    if (BitConverter.DoubleToInt64Bits(a.X) != BitConverter.DoubleToInt64Bits(b.X) ||
                                        BitConverter.DoubleToInt64Bits(a.Y) != BitConverter.DoubleToInt64Bits(b.Y) ||
                                        BitConverter.DoubleToInt64Bits(a.Z) != BitConverter.DoubleToInt64Bits(b.Z))
                                    {
                                        same = false;
                                        result[prefix + ".firstMismatch"] = i.ToString(CultureInfo.InvariantCulture);
                                        break;
                                    }
                                }
                            result[prefix + ".sameOrderedBits"] = same.ToString();
                            if (!same)
                            {
                                result["status"] = "point_mismatch";
                                return result;
                            }
                        }
                        else if (registered.Status != LAS_TERRAIN.Application.OperationStatus.Empty)
                        {
                            result["status"] = "calculation_failed";
                            result[prefix + ".registered.error"] = registered.Error == null
                                ? "" : registered.Error.Message;
                            result[prefix + ".stationed.error"] = stationed.Error == null
                                ? "" : stationed.Error.Message;
                            return result;
                        }
                    }
                }
                result["status"] = "ok";
            }
            catch (Exception ex)
            {
                result["status"] = "error";
                result["error"] = ex.GetType().FullName + ": " + ex.Message;
            }
            return result;
        }

        private Dictionary<string, string> GetSurfaceAppendProbeOnUi()
        {
            var result = new Dictionary<string, string>();
            CadView view = IpcTestServer.CadView;
            if (view == null || view.IsDisposed || !view.IsHandleCreated || view.InvokeRequired)
                return IpcStatus("view_unavailable");
            var layer = SurfaceLayer.GetSurfaceLayer(view);
            if (layer == null || layer.Surface == null)
                return IpcStatus("surface_unavailable");
            var surface = layer.Surface;
            if (surface.Points.Count != 0 || surface.Triangles.Count != 0)
                return IpcStatus("requires_empty_surface");
            bool wasDynamic = surface.Style.Dynamic;
            try
            {
                var points = new List<Vector3D>();
                points.Add(new Vector3D(10, 10, 1));
                points.Add(new Vector3D(20, 10, 2));
                points.Add(new Vector3D(10, 20, 3));
                FastSurfaceBuilder.InsertPoints(points, surface);
                result["during.points"] = surface.Points.Count.ToString(CultureInfo.InvariantCulture);
                result["during.triangles"] = surface.Triangles.Count.ToString(CultureInfo.InvariantCulture);
                result["during.elevationAvailable"] =
                    surface.GetElevation(new Vector2D(12, 12)).HasValue.ToString();
                result["status"] = "ok";
            }
            catch (Exception ex)
            {
                result["status"] = "error";
                result["error"] = ex.GetType().FullName + ": " + ex.Message;
            }
            finally
            {
                try
                {
                    while (surface.Points.Count > 0)
                        surface.Points.RemoveAt(surface.Points.Count - 1);
                    surface.PointIndexer.Invalidate();
                    surface.Invalidate(false);
                    surface.Style.Dynamic = wasDynamic;
                    result["after.points"] = surface.Points.Count.ToString(CultureInfo.InvariantCulture);
                    result["after.triangles"] = surface.Triangles.Count.ToString(CultureInfo.InvariantCulture);
                    result["after.dynamicRestored"] = (surface.Style.Dynamic == wasDynamic).ToString();
                }
                catch (Exception ex)
                {
                    result["status"] = "restore_error";
                    result["restore.error"] = ex.GetType().FullName + ": " + ex.Message;
                }
            }
            return result;
        }

        private Dictionary<string, string> GetSurfaceStatusProbeOnUi()
        {
            var result = new Dictionary<string, string>();
            try
            {
                CadView view = IpcTestServer.CadView;
                if (view == null || view.IsDisposed || !view.IsHandleCreated || view.InvokeRequired)
                    return IpcStatus("view_unavailable");
                var layer = SurfaceLayer.GetSurfaceLayer(view);
                if (layer == null || layer.Surface == null)
                    return IpcStatus("surface_unavailable");
                var surface = layer.Surface;
                result["surface.points"] = surface.Points.Count.ToString(CultureInfo.InvariantCulture);
                result["surface.triangles"] = surface.Triangles.Count.ToString(CultureInfo.InvariantCulture);
                result["surface.dynamic"] = surface.Style.Dynamic.ToString();
                result["surface.transactionManager.available"] =
                    (surface.TransactionManager != null).ToString();
                using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    var alignment = receiver.Alignment;
                    var sections = alignment == null || alignment.Corridor == null
                        ? null : alignment.Corridor.Sections;
                    result["sections.available"] = (sections != null).ToString();
                    result["surface.sections.sameTransactionManager"] =
                        (sections != null && surface.TransactionManager != null &&
                         Object.ReferenceEquals(surface.TransactionManager,
                             sections.TransactionManager)).ToString();
                }
                result["status"] = "ok";
            }
            catch (Exception ex)
            {
                result["status"] = "error";
                result["error"] = ex.GetType().FullName + ": " + ex.Message;
            }
            return result;
        }

        private Dictionary<string, string> GetSectionRollbackProbeOnUi()
        {
            var result = new Dictionary<string, string>();
            CadView view = IpcTestServer.CadView;
            if (view == null || view.IsDisposed || !view.IsHandleCreated ||
                view.InvokeRequired)
            {
                result["status"] = "view_unavailable";
                return result;
            }

            try
            {
                using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    Alignment alignment = receiver.Alignment;
                    if (alignment == null || alignment.Corridor == null ||
                        alignment.Corridor.Sections == null ||
                        alignment.Corridor.Sections.Count == 0)
                    {
                        result["status"] = "no_sections";
                        return result;
                    }

                    var sections = alignment.Corridor.Sections;
                    result["transactionManager.available"] =
                        (sections.TransactionManager != null).ToString();
                    if (sections.TransactionManager == null)
                    {
                        result["status"] = "no_transaction_manager";
                        return result;
                    }

                    int count = sections.Count;
                    var original = new Topomatic.Alg.Crs.Section[count];
                    var ids = new uint[count];
                    var constructions = new uint[count];
                    var stations = new long[count];
                    var lines = new object[count];
                    for (int i = 0; i < count; i++)
                    {
                        original[i] = sections[i];
                        ids[i] = original[i].Id;
                        constructions[i] = original[i].ConstructionId;
                        stations[i] = BitConverter.DoubleToInt64Bits(original[i].Station);
                        lines[i] = original[i].SectionLine;
                    }
                    result["before.count"] = count.ToString(CultureInfo.InvariantCulture);

                    bool started = false;
                    try
                    {
                        global::UpdateLoop.BeginTransaction(sections);
                        started = true;
                        sections.Clear();
                        sections.Add(original[0].Station);
                        result["during.count"] = sections.Count.ToString(
                            CultureInfo.InvariantCulture);
                        global::UpdateLoop.Rollback(sections);
                        started = false;
                    }
                    catch (Exception ex)
                    {
                        result["status"] = "rollback_error";
                        result["error"] = ex.GetType().FullName + ": " + ex.Message;
                        result["transaction.open"] = started.ToString();
                        return result;
                    }

                    bool sameReferences = sections.Count == count;
                    bool sameMetadata = sections.Count == count;
                    if (sections.Count == count)
                        for (int i = 0; i < count; i++)
                        {
                            var current = sections[i];
                            sameReferences &= Object.ReferenceEquals(current, original[i]);
                            sameMetadata &= current.Id == ids[i] &&
                                current.ConstructionId == constructions[i] &&
                                BitConverter.DoubleToInt64Bits(current.Station) == stations[i] &&
                                Object.ReferenceEquals(current.SectionLine, lines[i]);
                        }
                    result["after.count"] = sections.Count.ToString(CultureInfo.InvariantCulture);
                    result["after.sameReferences"] = sameReferences.ToString();
                    result["after.sameMetadata"] = sameMetadata.ToString();
                    if (!sameReferences || !sameMetadata)
                    {
                        result["status"] = "rollback_mismatch";
                        return result;
                    }

                    try
                    {
                        global::UpdateLoop.BeginTransaction(sections);
                        sections.Clear();
                        sections.Add(original[0].Station);
                        global::UpdateLoop.Commit(sections);
                        result["commit.count"] = sections.Count.ToString(CultureInfo.InvariantCulture);
                        result["commit.canUndo"] = sections.TransactionManager.CanUndo.ToString();
                        if (!sections.TransactionManager.CanUndo)
                        {
                            result["status"] = "commit_not_undoable";
                            return result;
                        }
                        sections.TransactionManager.Undo();
                        bool undoRestored = sections.Count == count;
                        if (undoRestored)
                            for (int i = 0; i < count; i++)
                                undoRestored &= Object.ReferenceEquals(sections[i], original[i]) &&
                                    sections[i].Id == ids[i] &&
                                    sections[i].ConstructionId == constructions[i] &&
                                    BitConverter.DoubleToInt64Bits(sections[i].Station) == stations[i] &&
                                    Object.ReferenceEquals(sections[i].SectionLine, lines[i]);
                        result["undo.restored"] = undoRestored.ToString();
                        result["undo.canRedo"] = sections.TransactionManager.CanRedo.ToString();
                        if (!undoRestored)
                        {
                            result["status"] = "undo_mismatch";
                            return result;
                        }

                        if (!sections.TransactionManager.CanRedo)
                        {
                            result["status"] = "redo_unavailable";
                            return result;
                        }

                        sections.TransactionManager.Redo();
                        bool redoApplied = sections.Count == 1 &&
                            BitConverter.DoubleToInt64Bits(sections[0].Station) == stations[0];
                        result["redo.applied"] = redoApplied.ToString();
                        if (!redoApplied)
                        {
                            result["status"] = "redo_mismatch";
                            return result;
                        }

                        sections.TransactionManager.Undo();
                        bool finalRestored = sections.Count == count;
                        if (finalRestored)
                            for (int i = 0; i < count; i++)
                                finalRestored &= Object.ReferenceEquals(sections[i], original[i]) &&
                                    sections[i].Id == ids[i] &&
                                    sections[i].ConstructionId == constructions[i] &&
                                    BitConverter.DoubleToInt64Bits(sections[i].Station) == stations[i] &&
                                    Object.ReferenceEquals(sections[i].SectionLine, lines[i]);
                        result["final.restored"] = finalRestored.ToString();
                        result["status"] = finalRestored ? "ok" : "final_mismatch";
                    }
                    catch (Exception ex)
                    {
                        result["status"] = "undo_error";
                        result["error"] = ex.GetType().FullName + ": " + ex.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                result["status"] = "error";
                result["error"] = ex.GetType().FullName + ": " + ex.Message;
            }
            return result;
        }

        /// <summary>
        /// Draw a persistent line in the active Topomatic project.
        /// Coordinates are world coordinates (X, Y, Z).
        /// </summary>
        public string DrawLine(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            return DiagnosticUiDispatcher.Invoke(
                () => DrawLineOnUi(x1, y1, z1, x2, y2, z2),
                "ERROR: Plugin operation already running", "ERROR: CAD UI unavailable");
        }

        private string DrawLineOnUi(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            CadView cv = IpcTestServer.CadView;
            if (cv == null)
                return "ERROR: CadView not available";
            if (cv.IsDisposed || !cv.IsHandleCreated)
                return "ERROR: CadView unavailable";
            if (cv.InvokeRequired)
                return "ERROR: CadView belongs to another UI thread";

            string result = "OK";
            cv.Invoke(new Action(delegate
            {
                try
                {
                    if (cv.IsDisposed || !Object.ReferenceEquals(IpcTestServer.CadView, cv))
                    {
                        result = "ERROR: Active document changed";
                        return;
                    }
                    DrawingLayer dl = DrawingLayer.GetDrawingLayer(cv);
                    if (dl == null || dl.Drawing == null)
                    {
                        result = "ERROR: No DrawingLayer found";
                        return;
                    }

                    Drawing drawing = dl.Drawing;
                    drawing.BeginUpdate();
                    try
                    {
                        DwgLine line = new DwgLine();
                        line.Prepare(drawing);
                        line.StartPoint = new Vector3D(x1, y1, z1);
                        line.EndPoint = new Vector3D(x2, y2, z2);

                        drawing.ActiveSpace.Add(line);
                    }
                    finally
                    {
                        drawing.EndUpdate();
                    }

                    cv.Unlock();
                    cv.Invalidate();
                }
                catch (Exception ex)
                {
                    result = "ERROR: " + ex.Message;
                }
            }));

            return result;
        }

        /// <summary>
        /// Draw multiple connected lines (polyline) in the active project.
        /// Points passed as flat array: [x0,y0,z0, x1,y1,z1, x2,y2,z2, ...]
        /// </summary>
        public string DrawPolyline(double[] coords)
        {
            return DiagnosticUiDispatcher.Invoke(() => DrawPolylineOnUi(coords),
                "ERROR: Plugin operation already running", "ERROR: CAD UI unavailable");
        }

        private string DrawPolylineOnUi(double[] coords)
        {
            CadView cv = IpcTestServer.CadView;
            if (cv == null)
                return "ERROR: CadView not available";
            if (cv.IsDisposed || !cv.IsHandleCreated)
                return "ERROR: CadView unavailable";
            if (cv.InvokeRequired)
                return "ERROR: CadView belongs to another UI thread";
            if (coords == null || coords.Length < 6)
                return "ERROR: Need at least 2 points (6 coordinates)";

            string result = "OK";
            cv.Invoke(new Action(delegate
            {
                try
                {
                    if (cv.IsDisposed || !Object.ReferenceEquals(IpcTestServer.CadView, cv))
                    {
                        result = "ERROR: Active document changed";
                        return;
                    }
                    DrawingLayer dl = DrawingLayer.GetDrawingLayer(cv);
                    if (dl == null || dl.Drawing == null)
                    {
                        result = "ERROR: No DrawingLayer found";
                        return;
                    }

                    Drawing drawing = dl.Drawing;
                    drawing.BeginUpdate();
                    try
                    {
                        int pointCount = coords.Length / 3;
                        var points = new List<Vector2D>(pointCount);
                        for (int i = 0; i < pointCount; i++)
                        {
                            points.Add(new Vector2D(coords[i * 3], coords[i * 3 + 1]));
                        }

                        drawing.ActiveSpace.AddPolyline(points);
                    }
                    finally
                    {
                        drawing.EndUpdate();
                    }

                    cv.Unlock();
                    cv.Invalidate();
                }
                catch (Exception ex)
                {
                    result = "ERROR: " + ex.Message;
                }
            }));

            return result;
        }

        /// <summary>
        /// Draw a point (small cross/marker) in the active project.
        /// </summary>
        public string DrawPoint(double x, double y, double z)
        {
            return DiagnosticUiDispatcher.Invoke(() => DrawPointOnUi(x, y, z),
                "ERROR: Plugin operation already running", "ERROR: CAD UI unavailable");
        }

        private string DrawPointOnUi(double x, double y, double z)
        {
            CadView cv = IpcTestServer.CadView;
            if (cv == null)
                return "ERROR: CadView not available";
            if (cv.IsDisposed || !cv.IsHandleCreated)
                return "ERROR: CadView unavailable";
            if (cv.InvokeRequired)
                return "ERROR: CadView belongs to another UI thread";

            string result = "OK";
            cv.Invoke(new Action(delegate
            {
                try
                {
                    if (cv.IsDisposed || !Object.ReferenceEquals(IpcTestServer.CadView, cv))
                    {
                        result = "ERROR: Active document changed";
                        return;
                    }
                    DrawingLayer dl = DrawingLayer.GetDrawingLayer(cv);
                    if (dl == null || dl.Drawing == null)
                    {
                        result = "ERROR: No DrawingLayer found";
                        return;
                    }

                    Drawing drawing = dl.Drawing;
                    drawing.BeginUpdate();
                    try
                    {
                        DwgPoint pt = new DwgPoint();
                        pt.Prepare(drawing);
                        pt.Position = new Vector3D(x, y, z);

                        drawing.ActiveSpace.Add(pt);
                    }
                    finally
                    {
                        drawing.EndUpdate();
                    }

                    cv.Unlock();
                    cv.Invalidate();
                }
                catch (Exception ex)
                {
                    result = "ERROR: " + ex.Message;
                }
            }));

            return result;
        }

        /// <summary>
        /// Runs all built-in tests, returns result string.
        /// </summary>
        public string RunAllTests()
        {
            var results = new List<string>();
            int passed = 0;
            int failed = 0;

            // Test 1: OrderByX filter
            RunSingleTest("OrderByX", results, ref passed, ref failed,
                delegate
                {
                    var pts = new List<Vector2D>();
                    pts.Add(new Vector2D(3.0, 1.0));
                    pts.Add(new Vector2D(1.0, 2.0));
                    pts.Add(new Vector2D(2.0, 3.0));

                    LAS_TERRAIN.Filters.OrderByX.Apply(pts);

                    if (pts.Count != 3)
                        throw new Exception("Count mismatch: " + pts.Count);
                    if (Math.Abs(pts[0].X - 1.0) > 1e-9)
                        throw new Exception("First point X mismatch: " + pts[0].X);
                    if (Math.Abs(pts[1].X - 2.0) > 1e-9)
                        throw new Exception("Second point X mismatch: " + pts[1].X);
                    if (Math.Abs(pts[2].X - 3.0) > 1e-9)
                        throw new Exception("Third point X mismatch: " + pts[2].X);
                });

            // Test 2: OrderByX with empty list
            RunSingleTest("OrderByX_Empty", results, ref passed, ref failed,
                delegate
                {
                    var pts = new List<Vector2D>();
                    LAS_TERRAIN.Filters.OrderByX.Apply(pts);
                    if (pts.Count != 0)
                        throw new Exception("Empty list should stay empty");
                });

            // Test 3: OrderByX single element
            RunSingleTest("OrderByX_Single", results, ref passed, ref failed,
                delegate
                {
                    var pts = new List<Vector2D>();
                    pts.Add(new Vector2D(5.0, 5.0));
                    LAS_TERRAIN.Filters.OrderByX.Apply(pts);
                    if (pts.Count != 1)
                        throw new Exception("Single element count changed");
                    if (Math.Abs(pts[0].X - 5.0) > 1e-9)
                        throw new Exception("Single element X changed");
                });

            // Test 4: OrderByX already sorted
            RunSingleTest("OrderByX_Sorted", results, ref passed, ref failed,
                delegate
                {
                    var pts = new List<Vector2D>();
                    for (int i = 0; i < 100; i++)
                        pts.Add(new Vector2D(i * 0.1, i));

                    LAS_TERRAIN.Filters.OrderByX.Apply(pts);

                    for (int i = 1; i < pts.Count; i++)
                    {
                        if (pts[i].X < pts[i - 1].X)
                            throw new Exception("Not sorted at index " + i);
                    }
                });

            // Test 5: OrderByX reverse sorted
            RunSingleTest("OrderByX_Reverse", results, ref passed, ref failed,
                delegate
                {
                    var pts = new List<Vector2D>();
                    for (int i = 99; i >= 0; i--)
                        pts.Add(new Vector2D(i * 0.1, i));

                    LAS_TERRAIN.Filters.OrderByX.Apply(pts);

                    for (int i = 1; i < pts.Count; i++)
                    {
                        if (pts[i].X < pts[i - 1].X)
                            throw new Exception("Not sorted at index " + i);
                    }
                });

            // Test 6: OrderByX with duplicates
            RunSingleTest("OrderByX_Duplicates", results, ref passed, ref failed,
                delegate
                {
                    var pts = new List<Vector2D>();
                    pts.Add(new Vector2D(2.0, 1.0));
                    pts.Add(new Vector2D(1.0, 2.0));
                    pts.Add(new Vector2D(2.0, 3.0));
                    pts.Add(new Vector2D(1.0, 4.0));

                    LAS_TERRAIN.Filters.OrderByX.Apply(pts);

                    if (pts.Count != 4)
                        throw new Exception("Duplicates removed: count=" + pts.Count);
                    for (int i = 1; i < pts.Count; i++)
                    {
                        if (pts[i].X < pts[i - 1].X)
                            throw new Exception("Not sorted at index " + i);
                    }
                });

            // Summary
            string summary = string.Format(
                "RESULTS: total={0} passed={1} failed={2}\n{3}",
                passed + failed, passed, failed,
                string.Join("\n", results.ToArray()));

            return summary;
        }

        /// <summary>
        /// Runs a single named test, catches exceptions.
        /// </summary>
        private void RunSingleTest(
            string testName,
            List<string> results,
            ref int passed,
            ref int failed,
            Action testAction)
        {
            try
            {
                testAction();
                results.Add(string.Format("[PASS] {0}", testName));
                passed++;
            }
            catch (Exception ex)
            {
                results.Add(string.Format("[FAIL] {0}: {1}", testName, ex.Message));
                failed++;
            }
        }

        /// <summary>
        /// Get info about the active alignment (track route).
        /// </summary>
        public Dictionary<string, string> GetAlignmentInfo()
        {
            return DiagnosticUiDispatcher.Invoke(GetAlignmentInfoOnUi,
                IpcStatus("busy"), IpcStatus("ui_unavailable"));
        }

        private Dictionary<string, string> GetAlignmentInfoOnUi()
        {
            var info = new Dictionary<string, string>();

            try
            {
                using (ActiveAlignmentReciver<Alignment> receiver =
                    ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    Alignment alg = receiver.Alignment;
                    if (alg == null)
                    {
                        info["status"] = "no_active_alignment";
                        info["hint"] = "Open a project with an alignment first";
                        return info;
                    }

                    info["status"] = "ok";
                    info["planLength"] = alg.Plan.CompoundLine.Length.ToString("F3");
                    info["sectionCount"] = alg.Corridor.Sections.Count.ToString();
                    info["vertexCount"] = alg.Plan.Count.ToString();
                    // Stationing info not available via simple property

                    // List plan vertices
                    var vertices = new List<string>();
                    for (int i = 0; i < alg.Plan.Count; i++)
                    {
                        var v = alg.Plan[i];
                        vertices.Add(string.Format("({0:F1},{1:F1})", v.Position.X, v.Position.Y));
                    }
                    info["vertices"] = string.Join(" -> ", vertices.ToArray());

                    // List section stations
                    var sections = new List<string>();
                    int count = alg.Corridor.Sections.Count;
                    int maxShow = Math.Min(count, 10);
                    for (int i = 0; i < maxShow; i++)
                    {
                        sections.Add(alg.Corridor.Sections[i].Station.ToString("F1"));
                    }
                    if (count > maxShow)
                        sections.Add(string.Format("...({0} more)", count - maxShow));

                    info["sections"] = string.Join(", ", sections.ToArray());
                }
            }
            catch (Exception ex)
            {
                info["error"] = ex.Message;
            }

            return info;
        }

        /// <summary>
        /// Generate cross-sections on the active alignment at given step.
        /// </summary>
        public string GenerateSections(double step)
        {
            return DiagnosticUiDispatcher.Invoke(() => GenerateSectionsOnUi(step),
                "ERROR: Plugin operation already running", "ERROR: CAD UI unavailable");
        }

        private string GenerateSectionsOnUi(double step)
        {
            if (double.IsNaN(step) || double.IsInfinity(step) || step <= 0.0)
                return "ERROR: Step must be finite and positive";

            CadView cv = IpcTestServer.CadView;
            if (cv == null || cv.IsDisposed || !cv.IsHandleCreated)
                return "ERROR: CadView not available";
            if (cv.InvokeRequired)
                return "ERROR: CadView belongs to another UI thread";

            string result = "ERROR: Section generation did not run";
            try
            {
                cv.Invoke(new Action(delegate
                {
                    if (!Object.ReferenceEquals(IpcTestServer.CadView, cv) || cv.IsDisposed)
                    {
                        result = "ERROR: Active document changed";
                        return;
                    }
                    using (ActiveAlignmentReciver<Alignment> receiver =
                        ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                    {
                        Alignment alg = receiver.Alignment;
                        if (alg == null)
                        {
                            result = "ERROR: No active alignment";
                            return;
                        }

                        double length = alg.Plan.CompoundLine.Length;
                        if (double.IsNaN(length) || double.IsInfinity(length) || length < 0.0)
                        {
                            result = "ERROR: Invalid alignment length";
                            return;
                        }
                        // Reject excessive work before touching existing sections.
                        const int maxSections = 100000;
                        if (length / step >= maxSections)
                        {
                            result = "ERROR: Too many sections requested";
                            return;
                        }

                        alg.Corridor.Sections.Clear();

                        double station = 0.0;
                        while (station <= length)
                        {
                            alg.Corridor.Sections.Add(station);
                            double nextStation = station + step;
                            if (nextStation <= station)
                                break;
                            station = nextStation;
                        }

                        result = string.Format("OK: {0} sections generated (step={1}m, length={2:F1}m)",
                            alg.Corridor.Sections.Count, step, length);
                    }
                }));
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
            return result;
        }

        /// <summary>
        /// Explore the project model tree and active alignment information.
        /// </summary>
        public string ExploreProject()
        {
            return DiagnosticUiDispatcher.Invoke(ExploreProjectOnUi,
                "ERROR: Plugin operation already running", "ERROR: CAD UI unavailable");
        }

        private string ExploreProjectOnUi()
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                // Try through ApplicationHost
                IApplicationHost appHost = ApplicationHost.Current;
                if (appHost == null) return "ERROR: ApplicationHost.Current is null";

                sb.AppendFormat("AppHost: {0}\n", appHost.GetType().FullName);

                object project = appHost.ActiveProject;
                if (project == null) return sb.ToString() + "No active project";

                sb.AppendFormat("Project: {0}\n", project.GetType().FullName);

                // Try to get project model interface
                IProjectModel projectModel = project as IProjectModel;
                if (projectModel != null)
                {
                    sb.AppendFormat("Is IProjectModel: true, ModelType={0}\n", projectModel.ModelType ?? "null");
                    ExploreModelTree(projectModel, sb, 0);
                }

                // Also try through ActiveAlignmentReciver
                try
                {
                    using (ActiveAlignmentReciver<Alignment> receiver =
                        ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                    {
                        if (receiver.Alignment != null)
                        {
                            sb.AppendFormat("\n=== Active Alignment ===\n");
                            sb.AppendFormat("Name: {0}\n", receiver.Alignment.Alias ?? "(unnamed)");
                            sb.AppendFormat("ProjectModel: {0}\n", receiver.ProjectModel.GetType().FullName);
                            sb.AppendFormat("ProjectModel.ModelType: {0}\n", receiver.ProjectModel.ModelType ?? "null");

                            IProjectModel pm = receiver.ProjectModel;
                            sb.AppendFormat("\nProject from PM: {0}\n", pm.Project != null ? pm.Project.GetType().FullName : "null");

                            if (pm.Project != null)
                            {
                                IProjectModel root = pm.Project.Model;
                                if (root != null)
                                {
                                    sb.AppendFormat("\n=== Project Tree ===\n");
                                    ExploreModelTree(root, sb, 0);
                                }
                            }
                        }
                        else
                        {
                            sb.Append("\nNo active alignment\n");
                        }
                    }
                }
                catch (Exception ex2)
                {
                    sb.AppendFormat("\nActiveAlignmentReciver error: {0}\n", ex2.Message);
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message + "\n" + ex.StackTrace;
            }
        }

        /// <summary>
        /// Get the name of the currently active alignment.
        /// </summary>
        public string GetActiveAlignmentName()
        {
            return DiagnosticUiDispatcher.Invoke(GetActiveAlignmentNameOnUi,
                "ERROR: Plugin operation already running", "ERROR: CAD UI unavailable");
        }

        private string GetActiveAlignmentNameOnUi()
        {
            try
            {
                using (ActiveAlignmentReciver<Alignment> receiver =
                    ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    if (receiver.Alignment == null)
                        return "(none)";
                    return receiver.Alignment.Alias ?? "(unnamed)";
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        /// <summary>
        /// Create a new alignment with the given name and plan vertices.
        /// xyCoords is a flat array: [x0,y0, x1,y1, x2,y2, ...]
        /// </summary>
        public string CreateTestAlignment(string name, double[] xyCoords)
        {
            return DiagnosticUiDispatcher.Invoke(() => CreateTestAlignmentOnUi(name, xyCoords),
                "ERROR: Plugin operation already running", "ERROR: CAD UI unavailable");
        }

        private string CreateTestAlignmentOnUi(string name, double[] xyCoords)
        {
            try
            {
                if (xyCoords == null || xyCoords.Length < 4)
                    return "ERROR: Need at least 2 points (4 coordinates: x1,y1,x2,y2)";

                using (ActiveAlignmentReciver<Alignment> receiver =
                    ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    if (receiver.Alignment == null)
                        return "ERROR: No active alignment. Open a project with an alignment first.";

                    IProjectModel currentPm = receiver.ProjectModel;
                    ModelProject project = currentPm.Project;
                    if (project == null)
                        return "ERROR: No project available";

                    // Research: inspect project API for alignment creation
                    StringBuilder debug = new StringBuilder();
                    debug.AppendFormat("Project: {0}\n", project.GetType().FullName);

                    System.Reflection.MethodInfo[] methods = project.GetType().GetMethods();
                    foreach (System.Reflection.MethodInfo mi in methods)
                    {
                        if (mi.Name == "Add")
                            debug.AppendFormat("  Project.{0}\n", mi.ToString());
                    }

                    IProjectModel root = project.Model;
                    if (root != null)
                    {
                        debug.AppendFormat("Root: {0}\n", root.GetType().FullName);
                        methods = root.GetType().GetMethods();
                        foreach (System.Reflection.MethodInfo mi in methods)
                        {
                            if (mi.Name == "Add")
                                debug.AppendFormat("  Root.{0}\n", mi.ToString());
                        }
                    }

                    // Find alignment parent in tree
                    IProjectModel alignParent = FindAlignmentParent(root);
                    if (alignParent != null)
                    {
                        debug.AppendFormat("AlignParent: {0}\n", alignParent.GetType().FullName);
                        methods = alignParent.GetType().GetMethods();
                        foreach (System.Reflection.MethodInfo mi in methods)
                        {
                            if (mi.Name == "Add")
                                debug.AppendFormat("  Parent.{0}\n", mi.ToString());
                        }

                        // Inspect URI type and try to create alignment
                        try
                        {
                            // Get existing URI for reference
                            object existingUri = currentPm.Uri;
                            debug.AppendFormat("Existing URI type: {0}\n", existingUri != null ? existingUri.GetType().FullName : "null");
                            debug.AppendFormat("Existing URI value: {0}\n", existingUri != null ? existingUri.ToString() : "null");

                            // Get URI constructors via reflection
                            System.Type uriType = existingUri.GetType();
                            System.Reflection.ConstructorInfo[] ctors = uriType.GetConstructors();
                            foreach (System.Reflection.ConstructorInfo ci in ctors)
                                debug.AppendFormat("  URI ctor: {0}\n", ci.ToString());

                            // Try to create new URI and add alignment
                            // Use existing URI's directory as base, add .railx extension
                            string existingStr = existingUri.ToString();
                            string dir = existingStr.Substring(0, existingStr.LastIndexOf('/') + 1);
                            string newUriStr = dir + name + ".railx";
                            debug.AppendFormat("New URI: {0}\n", newUriStr);

                            object newUri = Activator.CreateInstance(uriType, new object[] { newUriStr });
                            IProjectModel newModel = alignParent.Add((Topomatic.FoundationClasses.URI)newUri, "rail");
                            debug.AppendFormat("Add result: {0}\n", newModel != null ? newModel.GetType().FullName : "null");

                            if (newModel != null)
                            {
                                // Open model to initialize its data
                                project.OpenModel(newModel);
                                debug.AppendFormat("After Open: Model={0}\n",
                                    newModel.Model != null ? newModel.Model.GetType().FullName : "null");

                                // Try to get alignment and add vertices
                                AlignmentModel am = newModel.Model as AlignmentModel;
                                if (am != null && am.Alignment != null)
                                {
                                    Alignment alg = am.Alignment;
                                    debug.AppendFormat("Alignment: {0}\n", alg.Alias ?? "(unnamed)");

                                    // Add vertices to plan
                                    alg.BeginUpdate();
                                    try
                                    {
                                        int pointCount = xyCoords.Length / 2;
                                        System.Reflection.MethodInfo addMethod = alg.Plan.GetType().GetMethod("Add");
                                        if (addMethod != null)
                                        {
                                            System.Type vertexType = addMethod.GetParameters()[0].ParameterType;
                                            for (int i = 0; i < pointCount; i++)
                                            {
                                                object vertex = Activator.CreateInstance(vertexType);
                                                System.Reflection.PropertyInfo posProp = vertexType.GetProperty("Position");
                                                if (posProp != null)
                                                    posProp.SetValue(vertex, new Vector2D(xyCoords[i * 2], xyCoords[i * 2 + 1]), null);
                                                addMethod.Invoke(alg.Plan, new object[] { vertex });
                                            }
                                            debug.AppendFormat("Vertices added: {0}\n", pointCount);
                                        }
                                    }
                                    finally
                                    {
                                        alg.EndUpdate();
                                    }

                                    return string.Format("OK: Created alignment '{0}' with {1} vertices",
                                        name, xyCoords.Length / 2);
                                }
                                else
                                {
                                    debug.AppendFormat("Model is not AlignmentModel: {0}\n",
                                        newModel.Model != null ? newModel.Model.GetType().FullName : "still null");
                                }
                            }
                        }
                        catch (Exception exUri)
                        {
                            debug.AppendFormat("URI/creation error: {0}\n", exUri.Message);
                        }
                    }

                    return "RESEARCH: Alignment creation API:\n" + debug.ToString();
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message + "\n" + ex.StackTrace;
            }
        }

        /// <summary>
        /// List all alignment names found in the project tree.
        /// </summary>
        public string ListAlignments()
        {
            return DiagnosticUiDispatcher.Invoke(ListAlignmentsOnUi,
                "ERROR: Plugin operation already running", "ERROR: CAD UI unavailable");
        }

        private string ListAlignmentsOnUi()
        {
            try
            {
                using (ActiveAlignmentReciver<Alignment> receiver =
                    ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    if (receiver.Alignment == null)
                        return "(no active alignment - cannot access project)";

                    ModelProject project = receiver.ProjectModel.Project;
                    if (project == null)
                        return "ERROR: No project";

                    IProjectModel root = project.Model;
                    if (root == null)
                        return "ERROR: No root model";

                    var names = new List<string>();
                    CollectAlignmentNames(root, names);

                    if (names.Count == 0)
                        return "(no alignments found)";

                    return string.Join(",", names.ToArray());
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        private void CollectAlignmentNames(IProjectModel model, List<string> names)
        {
            IProjectModel[] children = model.GetChilds();
            if (children == null) return;

            foreach (IProjectModel child in children)
            {
                if (child.ModelType == "rail" || child.ModelType == "alignment")
                {
                    // Use URI-based name (unique), fall back to Alias
                    string uriName = GetNameFromUri(child.Uri);
                    if (!string.IsNullOrEmpty(uriName))
                        names.Add(uriName);
                    else if (child.Model != null)
                    {
                        AlignmentModel am = child.Model as AlignmentModel;
                        if (am != null && am.Alignment != null)
                            names.Add(am.Alignment.Alias ?? "(unnamed)");
                    }
                }
                CollectAlignmentNames(child, names);
            }
        }

        private IProjectModel FindAlignmentParent(IProjectModel model)
        {
            if (model == null) return null;
            IProjectModel[] children = model.GetChilds();
            if (children == null) return null;

            foreach (IProjectModel child in children)
            {
                object m = child.Model;
                if (m is AlignmentModel)
                    return model;

                IProjectModel found = FindAlignmentParent(child);
                if (found != null) return found;
            }

            return null;
        }

        /// <summary>
        /// Activate alignment by index (0-based) among all rail models.
        /// </summary>
        public string SetActiveAlignmentByIndex(int index)
        {
            return DiagnosticUiDispatcher.Invoke(() => SetActiveAlignmentByIndexOnUi(index),
                "ERROR: Plugin operation already running", "ERROR: CAD UI unavailable");
        }

        private string SetActiveAlignmentByIndexOnUi(int index)
        {
            try
            {
                using (ActiveAlignmentReciver<Alignment> receiver =
                    ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    if (receiver.Alignment == null)
                        return "ERROR: No active alignment";

                    ModelProject project = receiver.ProjectModel.Project;
                    if (project == null)
                        return "ERROR: No project";

                    IProjectModel root = project.Model;
                    if (root == null)
                        return "ERROR: No root model";

                    // Collect all rail alignment models
                    List<IProjectModel> alignModels = new List<IProjectModel>();
                    CollectRailModels(root, alignModels);

                    if (index < 0 || index >= alignModels.Count)
                        return string.Format("ERROR: Index {0} out of range (0..{1})", index, alignModels.Count - 1);

                    IProjectModel target = alignModels[index];
                    project.OpenModel(target);

                    string label = GetAlignmentLabel(target);
                    return string.Format("OK: Activated [{0}] {1}", index, label);
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        private void CollectRailModels(IProjectModel model, List<IProjectModel> list)
        {
            IProjectModel[] children = model.GetChilds();
            if (children == null) return;

            foreach (IProjectModel child in children)
            {
                if (child.ModelType == "rail")
                    list.Add(child);
                CollectRailModels(child, list);
            }
        }

        private string GetAlignmentLabel(IProjectModel model)
        {
            object m = model.Model;
            AlignmentModel am = m as AlignmentModel;
            if (am != null && am.Alignment != null)
                return am.Alignment.Alias ?? "(unnamed)";

            string uriStr = model.Uri.ToString();
            int lastSlash = uriStr.LastIndexOf('/');
            string fileName = lastSlash >= 0 ? uriStr.Substring(lastSlash + 1) : uriStr;
            return fileName;
        }

        /// <summary>
        /// Set the active alignment by name, searching the project model tree.
        /// </summary>
        public string SetActiveAlignment(string name)
        {
            return DiagnosticUiDispatcher.Invoke(() => SetActiveAlignmentOnUi(name),
                "ERROR: Plugin operation already running", "ERROR: CAD UI unavailable");
        }

        private string SetActiveAlignmentOnUi(string name)
        {
            try
            {
                using (ActiveAlignmentReciver<Alignment> receiver =
                    ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    if (receiver.Alignment == null)
                        return "ERROR: No active alignment";

                    ModelProject project = receiver.ProjectModel.Project;
                    if (project == null)
                        return "ERROR: No project";

                    IProjectModel root = project.Model;
                    if (root == null)
                        return "ERROR: No root model";

                    IProjectModel found = FindAlignmentByName(root, name);
                    if (found == null)
                        return "ERROR: Alignment not found: " + name;

                    // Open model first
                    project.OpenModel(found);

                    // Activate using PluginManager — same as UI "Сделать текущим"
                    IApplicationHost host = ApplicationHost.Current;
                    if (host != null && host.Plugins != null)
                    {
                        object result = host.Plugins.Execute("activate", new object[] { found });
                        return string.Format("OK: Activated: {0}", name);
                    }

                    return "OK: Opened (no PluginManager): " + name;
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        private void ExploreModelTree(IProjectModel model, StringBuilder sb, int depth)
        {
            string indent = new string(' ', depth * 2);
            IProjectModel[] children = model.GetChilds();
            if (children == null) return;

            foreach (IProjectModel child in children)
            {
                object m = child.Model;
                string modelName = "(null)";
                string modelTypeStr = child.ModelType ?? "?";

                if (m != null)
                {
                    modelName = m.GetType().Name;
                    // Check if it's an AlignmentModel
                    AlignmentModel am = m as AlignmentModel;
                    if (am != null && am.Alignment != null)
                    {
                        modelName = string.Format("AlignmentModel[{0}]", am.Alignment.Alias ?? "(unnamed)");
                    }
                }

                sb.AppendFormat("{0}[{1}] type={2}\n", indent, modelName, modelTypeStr);
                ExploreModelTree(child, sb, depth + 1);
            }
        }

        private IProjectModel FindAlignmentByName(IProjectModel model, string name)
        {
            IProjectModel[] children = model.GetChilds();
            if (children == null) return null;

            foreach (IProjectModel child in children)
            {
                // Only check rail/alignment models
                if (child.ModelType == "rail" || child.ModelType == "alignment")
                {
                    // Match by Alias
                    object m = child.Model;
                    AlignmentModel am = m as AlignmentModel;
                    if (am != null && am.Alignment != null && am.Alignment.Alias == name)
                        return child;

                    // Match by URI filename (without extension)
                    string uriName = GetNameFromUri(child.Uri);
                    if (uriName == name)
                        return child;
                }

                // Recurse into children
                IProjectModel found = FindAlignmentByName(child, name);
                if (found != null)
                    return found;
            }

            return null;
        }

        private string GetNameFromUri(object uri)
        {
            if (uri == null) return "";
            string uriStr = uri.ToString();
            int lastSlash = uriStr.LastIndexOf('/');
            string fileName = lastSlash >= 0 ? uriStr.Substring(lastSlash + 1) : uriStr;
            int dot = fileName.LastIndexOf('.');
            if (dot > 0) fileName = fileName.Substring(0, dot);
            return fileName;
        }

        /// <summary>
        /// Keep the remoting object alive indefinitely.
        /// </summary>
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
