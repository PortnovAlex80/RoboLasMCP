// Automation/LasAutomation.cs
// Headless-фасад RoboLas: контекст проекта, трассы, сечения, настройки.
// Все методы должны вызываться на CAD UI-потоке (MCP ToolManager его
// гарантирует). Долгие операции показывают стандартный прогресс-бар
// Robur и могут быть отменены пользователем; отмена не является ошибкой.
using System;
using System.Collections.Generic;
using LAS_TERRAIN.Configuration;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Service;
using Topomatic.Alg;
using Topomatic.Alg.Model;
using Topomatic.Alg.Runtime.ServiceClasses;
using Topomatic.ApplicationPlatform;
using Topomatic.ApplicationPlatform.Core;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.Cad.View;

namespace LAS_TERRAIN.Automation
{
    public static partial class LasAutomation
    {
        /// <summary>Активный видовой экран Robur или null.</summary>
        public static CadView GetActiveCadView()
        {
            IApplicationHost host = ApplicationHost.Current;
            if (host == null) return null;
            ICadViewForm form = host.ActiveDocument as ICadViewForm;
            if (form == null) return null;
            return form.CadView;
        }

        private static CadView RequireCadView()
        {
            CadView view = GetActiveCadView();
            if (view == null || view.IsDisposed || !view.IsHandleCreated)
                throw new LasAutomationException(
                    "Нет активного видового экрана Robur. Откройте проект, активируйте модель " +
                    "и перейдите на видовой экран (план или поперечник), затем повторите вызов.");
            return view;
        }

        private static PluginOperationGate.Lease EnterGate()
        {
            PluginOperationGate.Lease lease = PluginOperationGate.TryEnter();
            if (lease == null)
                throw new LasAutomationException(
                    "Операция RoboLas уже выполняется (команда пользователя или другой вызов). " +
                    "Повторите вызов, когда текущая операция завершится.");
            return lease;
        }

        // ─────────────────────────── Контекст ───────────────────────────

        /// <summary>Сводный снимок состояния проекта для агента (read-only).</summary>
        public static LasAutomationContext GetContext()
        {
            using (EnterGate())
            {
                CadView view = RequireCadView();
                LasAutomationContext ctx = new LasAutomationContext();
                ctx.PluginVersion = typeof(LasAutomation).Assembly.GetName().Version.ToString();
                ctx.CollectMode = RuntimeConfig.OnePassActive ? "onepass" : "legacy";
                ctx.FilterMode = RuntimeConfig.UseSplineFilter ? "spline" : "minweight";

                IApplicationHost host = ApplicationHost.Current;
                object project = host == null ? null : host.ActiveProject;
                if (project != null)
                {
                    ctx.ProjectAlias = GetPropertyValueString(project, "Alias");
                    object uri = GetPropertyValue(project, "TargetProjectUri");
                    if (uri != null) ctx.ProjectUri = uri.ToString();
                }

                using (ActiveAlignmentReciver<Alignment> receiver =
                    ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    Alignment alg = receiver.Alignment;
                    ctx.HasActiveAlignment = alg != null;
                    if (alg != null)
                    {
                        ctx.ActiveAlignment = alg.Alias;
                        if (alg.Corridor != null && alg.Corridor.Sections != null)
                        {
                            var sections = alg.Corridor.Sections;
                            ctx.SectionsCount = sections.Count;
                            if (sections.Count > 0)
                            {
                                ctx.FirstStation = sections[0].Station;
                                ctx.LastStation = sections[sections.Count - 1].Station;
                            }
                        }
                        CollectLidarSummary(alg, ctx);
                    }
                }

                var layer = Topomatic.Sfc.Layer.SurfaceLayer.GetSurfaceLayer(view);
                if (layer != null && layer.Surface != null)
                {
                    ctx.HasSurface = true;
                    ctx.SurfacePoints = layer.Surface.Points.Count;
                    ctx.SurfaceTriangles = layer.Surface.Triangles.Count;
                }
                return ctx;
            }
        }

        private static void CollectLidarSummary(Alignment alg, LasAutomationContext ctx)
        {
            CollectLidarSourceMetadata(alg, ctx);
            List<Topomatic.Lidar.LidarBuffer> buffers = LidarBufferService.CollectBuffers(alg);
            ctx.HasLidarSource = buffers != null && buffers.Count > 0;
            if (buffers == null) return;
            long total = 0;
            foreach (Topomatic.Lidar.LidarBuffer buffer in buffers)
            {
                if (buffer == null) continue;
                if (!string.IsNullOrEmpty(buffer.fullpath))
                    ctx.LidarFiles.Add(buffer.fullpath);
                if (buffer.indexers == null) continue;
                foreach (Topomatic.Lidar.QuadTreeIndexer indexer in buffer.indexers)
                    if (indexer != null && indexer.points != null)
                        total += indexer.points.Count;
            }
            ctx.LidarPointCount = total;
        }

        // Capture source information from the active providers, never from a
        // drive scan or a manually configured RGB file. FileName may be a cache;
        // report what the host actually returns and verify its file signature.
        private static void CollectLidarSourceMetadata(Alignment alg, LasAutomationContext ctx)
        {
            var model = PluginCoreOps.FindModel(alg);
            var surfaces = new List<Topomatic.Sfc.Surface>(alg.EgSurfaceRelativePaths.Count);
            if (!Topomatic.Alg.Runtime.Tools.AlignLibrary.FindSurfaces(model, alg.EgSurfaceRelativePaths, surfaces)) return;
            foreach (var surface in surfaces)
            {
                if (surface == null) continue;
                foreach (var provider in surface.ProxySourceProviders)
                {
                    var container = provider as Topomatic.Lidar.ILidarBufferContainer;
                    if (container == null) continue;
                    var buffer = container.GetBuffer();
                    if (buffer == null) continue;
                    var info = new LasLidarSourceInfo { ProviderType=provider.GetType().FullName,
                        CachePath=buffer.fullpath, AttributeStatus="native_colorless" };
                    var cacheHeader = LAS_TERRAIN.Infrastructure.LidarCacheHeader.Inspect(buffer.fullpath);
                    info.CacheFormatStatus = cacheHeader.Status;
                    info.CacheFormatVersion = cacheHeader.Version;
                    info.CacheReadError = cacheHeader.ReadError;
                    var fileProvider = provider as Topomatic.Sfc.Proxy.FileProxySourceProvider;
                    try { if(fileProvider!=null) info.ProviderPath=fileProvider.FileName; }
                    catch(Exception error) { info.ProviderPathReadError=error.Message; }
                    try
                    {
                        if(!String.IsNullOrEmpty(info.ProviderPath) && System.IO.File.Exists(info.ProviderPath))
                            using(var stream=System.IO.File.OpenRead(info.ProviderPath))
                                info.ProviderPathIsLas=stream.ReadByte()=='L' && stream.ReadByte()=='A' && stream.ReadByte()=='S' && stream.ReadByte()=='F';
                    }
                    catch(Exception error) { info.ProviderPathReadError=error.Message; }
                    if(buffer.indexers!=null) foreach(var indexer in buffer.indexers)
                    {
                        if(indexer==null) continue;
                        info.SdkIndexerCount++;
                        info.PointCount+=indexer.points.Count;
                        info.SdkColorByteCount+=LAS_TERRAIN.Infrastructure.RgbExportSession.ColorByteCount(indexer);
                    }
                    if(info.SdkColorByteCount>0) info.AttributeStatus="native_rgb8_storage_present";
                    ctx.LidarSources.Add(info);
                }
            }
        }

        private static object GetPropertyValue(object obj, string name)
        {
            if (obj == null) return null;
            try
            {
                var prop = obj.GetType().GetProperty(name);
                return prop == null ? null : prop.GetValue(obj, null);
            }
            catch (Exception) { return null; }
        }

        private static string GetPropertyValueString(object obj, string name)
        {
            object value = GetPropertyValue(obj, name);
            return value == null ? null : value.ToString();
        }

        // ─────────────────────────── Трассы ───────────────────────────

        /// <summary>Все трассы дерева проекта + признак активной.</summary>
        public static List<LasAlignmentInfo> ListAlignments()
        {
            using (EnterGate())
            {
                RequireCadView();
                IProjectModel root = RequireProjectRoot();
                string activeName = null;
                using (ActiveAlignmentReciver<Alignment> receiver =
                    ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    if (receiver.Alignment != null)
                        activeName = receiver.Alignment.Alias;
                }
                List<LasAlignmentInfo> result = new List<LasAlignmentInfo>();
                CollectAlignmentInfos(root, result, activeName);
                return result;
            }
        }

        /// <summary>Имя активной трассы или null.</summary>
        public static string GetActiveAlignmentName()
        {
            using (EnterGate())
            {
                using (ActiveAlignmentReciver<Alignment> receiver =
                    ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    return receiver.Alignment == null ? null : receiver.Alignment.Alias;
                }
            }
        }

        /// <summary>Активирует трассу по имени (Alias или имя файла модели).</summary>
        public static LasAlignmentActivationResult SetActiveAlignment(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new LasAutomationException("Имя трассы обязательно. Получите список через las_list_alignments.");
            using (EnterGate())
            {
                RequireCadView();
                IProjectModel root = RequireProjectRoot();
                IProjectModel found = FindAlignmentByName(root, name);
                if (found == null)
                    throw new LasAutomationException(
                        "Трасса не найдена: " + name + ". Вызовите las_list_alignments и используйте точное имя.");
                ModelProject project = GetModelProject();
                project.OpenModel(found);
                IApplicationHost host = ApplicationHost.Current;
                if (host != null && host.Plugins != null)
                    host.Plugins.Execute("activate", new object[] { found });
                return new LasAlignmentActivationResult { Name = name, Activated = true };
            }
        }

        private static IProjectModel RequireProjectRoot()
        {
            IApplicationHost host = ApplicationHost.Current;
            if (host == null || host.ActiveProject == null)
                throw new LasAutomationException(
                    "Нет открытого проекта Robur. Откройте проект и повторите вызов.");
            ModelProject project = host.ActiveProject as ModelProject;
            IProjectModel root = project != null ? project.Model
                : host.ActiveProject as IProjectModel;
            if (root == null)
                throw new LasAutomationException(
                    "Не удалось получить дерево моделей проекта. Откройте модель в структуре проекта.");
            return root;
        }

        private static ModelProject GetModelProject()
        {
            IApplicationHost host = ApplicationHost.Current;
            ModelProject project = host == null ? null : host.ActiveProject as ModelProject;
            if (project == null)
                throw new LasAutomationException("Не удалось получить ModelProject активного проекта.");
            return project;
        }

        private static void CollectAlignmentInfos(IProjectModel model,
            List<LasAlignmentInfo> names, string activeName)
        {
            IProjectModel[] children = model.GetChilds();
            if (children == null) return;
            foreach (IProjectModel child in children)
            {
                if (child.ModelType == "rail" || child.ModelType == "alignment")
                {
                    string uriName = GetNameFromUri(child.Uri);
                    string displayName = uriName;
                    if (string.IsNullOrEmpty(displayName) && child.Model != null)
                    {
                        AlignmentModel am = child.Model as AlignmentModel;
                        if (am != null && am.Alignment != null)
                            displayName = am.Alignment.Alias ?? "(unnamed)";
                    }
                    if (!string.IsNullOrEmpty(displayName))
                    {
                        string alias = null;
                        AlignmentModel aliasedModel = child.Model as AlignmentModel;
                        if (aliasedModel != null && aliasedModel.Alignment != null)
                            alias = aliasedModel.Alignment.Alias;
                        names.Add(new LasAlignmentInfo
                        {
                            Name = displayName,
                            IsActive = (alias != null && alias == activeName) ||
                                (displayName == activeName)
                        });
                    }
                }
                CollectAlignmentInfos(child, names, activeName);
            }
        }

        private static IProjectModel FindAlignmentByName(IProjectModel model, string name)
        {
            IProjectModel[] children = model.GetChilds();
            if (children == null) return null;
            foreach (IProjectModel child in children)
            {
                if (child.ModelType == "rail" || child.ModelType == "alignment")
                {
                    AlignmentModel am = child.Model as AlignmentModel;
                    if (am != null && am.Alignment != null && am.Alignment.Alias == name)
                        return child;
                    if (GetNameFromUri(child.Uri) == name)
                        return child;
                }
                IProjectModel found = FindAlignmentByName(child, name);
                if (found != null) return found;
            }
            return null;
        }

        private static string GetNameFromUri(object uri)
        {
            if (uri == null) return "";
            string uriStr = uri.ToString();
            int lastSlash = uriStr.LastIndexOf('/');
            string fileName = lastSlash >= 0 ? uriStr.Substring(lastSlash + 1) : uriStr;
            int dot = fileName.LastIndexOf('.');
            if (dot > 0) fileName = fileName.Substring(0, dot);
            return fileName;
        }

        // ─────────────────────────── Сечения ───────────────────────────

        /// <summary>Сечения активной трассы (до maxSections записей).</summary>
        public static LasSectionListResult ListSections(int maxSections)
        {
            if (maxSections <= 0) maxSections = 50;
            using (EnterGate())
            {
                RequireCadView();
                using (ActiveAlignmentReciver<Alignment> receiver =
                    ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    Alignment alg = RequireAlignment(receiver);
                    var sections = alg.Corridor.Sections;
                    LasSectionListResult result = new LasSectionListResult();
                    result.TotalCount = sections.Count;
                    if (sections.Count > 0)
                    {
                        result.FirstStation = sections[0].Station;
                        result.LastStation = sections[sections.Count - 1].Station;
                    }
                    result.Truncated = sections.Count > maxSections;
                    int limit = Math.Min(sections.Count, maxSections);
                    for (int i = 0; i < limit; i++)
                        result.Sections.Add(new LasSectionInfo
                        {
                            Id = sections[i].Id,
                            Station = sections[i].Station
                        });
                    result.Count = result.Sections.Count;
                    return result;
                }
            }
        }

        private static Alignment RequireAlignment(ActiveAlignmentReciver<Alignment> receiver)
        {
            if (receiver.Alignment == null)
                throw new LasAutomationException(
                    "Нет активной трассы. Вызовите las_list_alignments и las_set_active_alignment, " +
                    "либо активируйте трассу в Robur («Сделать текущей»).");
            return receiver.Alignment;
        }

        // ─────────────────────────── Настройки ───────────────────────────

        public static Dictionary<string, object> GetSettings()
        {
            using (EnterGate())
            {
                Dictionary<string, object> values = PluginSettings.Read();
                values["max_filter_border"] = RuntimeConfig.MAX_FILTER_BORDER;
                return values;
            }
        }

        public static Dictionary<string, object> ApplySettings(IDictionary<string, object> changes)
        {
            using (EnterGate())
            {
                Dictionary<string, object> result = PluginSettings.Apply(changes);
                Settings.Instance.CaptureRuntimePreferences();
                result["max_filter_border"] = RuntimeConfig.MAX_FILTER_BORDER;
                return result;
            }
        }
    }
}
