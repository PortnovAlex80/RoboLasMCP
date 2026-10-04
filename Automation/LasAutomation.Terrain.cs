// Automation/LasAutomation.Terrain.cs
// Headless-версии главного сценария RoboLas: авторазбивка сечений и
// построение ЦММ по LAS-точкам. Пайплайн повторяет SectionBaseUseCase,
// но интерактивные вводы (выбор трассы мышью, толщина, шаг) заменены
// параметрами вызова. Прогресс отображается стандартным окном Robur.
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Configuration;
using LAS_TERRAIN.Domain.Service;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Topomatic.Alg;
using Topomatic.Alg.Crs;
using Topomatic.Alg.Runtime.ServiceClasses;
using Topomatic.Alg.Runtime.Tools;
using Topomatic.ApplicationPlatform;
using Topomatic.ApplicationPlatform.Core;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.Cad.Foundation;
using Topomatic.Cad.View;
using Topomatic.Sfc;
using Topomatic.Sfc.Layer;

namespace LAS_TERRAIN.Automation
{
    public static partial class LasAutomation
    {
        /// <summary>
        /// Авторазбивка сечений активной трассы с заданным шагом.
        /// Заменяет существующие сечения (транзакция с откатом при сбое).
        /// </summary>
        public static LasTerrainResult GenerateSections(double step)
        {
            if (step <= 0 || double.IsNaN(step) || double.IsInfinity(step))
                throw new LasAutomationException("Шаг сечений должен быть положительным числом (метры).");
            using (EnterGate())
            {
                RequireCadView();
                using (ActiveAlignmentReciver<Alignment> receiver =
                    ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    Alignment alg = RequireAlignment(receiver);
                    CalculationTelemetry.Report("plan_sections", 0.15);
                    List<double> stations = PlanStations(alg, step);
                    Stopwatch clock = Stopwatch.StartNew();
                    CalculationTelemetry.Report("commit_sections", 0.85);
                    ReplaceSections(alg, stations);
                    clock.Stop();
                    return new LasTerrainResult
                    {
                        Mode = "generated",
                        Step = step,
                        StationsPlanned = stations.Count,
                        SectionsCreated = alg.Corridor.Sections.Count,
                        FilterUsed = RuntimeConfig.UseSplineFilter ? "spline" : "minweight",
                        ElapsedSeconds = clock.Elapsed.TotalSeconds
                    };
                }
            }
        }

        /// <summary>
        /// Построение ЦММ: сбор LAS-точек по сечениям активной трассы,
        /// фильтрация земли и вставка в поверхность ЦММ.
        /// step задан — сечения пересоздаются с этим шагом (mode=generated);
        /// step не задан — используются существующие сечения (mode=existing).
        /// </summary>
        public static LasTerrainResult BuildTerrain(double thickness, double? step)
        {
            if (thickness <= 0 || double.IsNaN(thickness) || double.IsInfinity(thickness))
                throw new LasAutomationException(
                    "Толщина слайса должна быть положительным числом (метры, обычно 0.1–1.0).");
            if (step.HasValue && (step.Value <= 0 || double.IsNaN(step.Value) || double.IsInfinity(step.Value)))
                throw new LasAutomationException("Шаг сечений должен быть положительным числом (метры).");

            using (EnterGate())
            {
                CadView view = RequireCadView();
                Stopwatch clock = Stopwatch.StartNew();
                using (ActiveAlignmentReciver<Alignment> receiver =
                    ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    Alignment alg = RequireAlignment(receiver);

                    SurfaceLayer surfaceLayer = SurfaceLayer.GetSurfaceLayer(view);
                    if (surfaceLayer == null || surfaceLayer.Surface == null)
                        throw new LasAutomationException(
                            "Не найден слой ЦММ на видовом экране. Откройте вид с поверхностью ЦММ трассы.");
                    Surface surface = surfaceLayer.Surface;

                    CalculationTelemetry.Report("capture_source", 0.1);
                    var buffers = LidarBufferService.CollectBuffers(alg);
                    if (buffers == null || buffers.Count == 0)
                        throw new LasAutomationException(
                            "Не найден источник точек лазерного сканирования. Убедитесь, что ЦММ трассы " +
                            "содержит облако LAS и отображение точек включено.");
                    var source = BorrowedLidarSourceSnapshot.Capture(buffers);
                    Func<bool> sourceCurrent = delegate
                    {
                        try { return source.Matches(LidarBufferService.CollectBuffers(alg)); }
                        catch (Exception) { return false; }
                    };

                    // Пилотная фиксация цели (как в SectionBaseUseCase.ExecuteSections).
                    var sections = alg.Corridor.Sections.ToList();
                    var host = ApplicationHost.Current;
                    object pilotProject = host == null ? null : host.ActiveProject;
                    object pilotDocument = host == null ? null : host.ActiveDocument;
                    object pilotModel = PluginCoreOps.FindModel(alg);
                    Guid pilotAlignmentId = AlignmentValueConverter.GetId(alg);
                    if (pilotProject == null || pilotDocument == null ||
                        pilotModel == null || pilotAlignmentId == Guid.Empty)
                        throw new LasAutomationException(
                            "Не удалось зафиксировать модель и трассу для расчёта.");

                    uint[] pilotSectionIds = new uint[sections.Count];
                    double[] pilotStations = new double[sections.Count];
                    uint[] originalConstructionIds = new uint[sections.Count];
                    object[] originalSectionLines = new object[sections.Count];
                    for (int i = 0; i < sections.Count; i++)
                    {
                        pilotSectionIds[i] = sections[i].Id;
                        pilotStations[i] = sections[i].Station;
                        originalConstructionIds[i] = sections[i].ConstructionId;
                        originalSectionLines[i] = sections[i].SectionLine;
                    }

                    List<double> plannedStations = step.HasValue
                        ? PlanStations(alg, step.Value)
                        : null;
                    if (plannedStations == null && sections.Count == 0)
                        throw new LasAutomationException(
                            "У трассы нет сечений. Задайте step для авторазбивки " +
                            "(например, 1.0) или вызовите las_generate_sections.");

                    var options = LasFilterOptions.FromThickness(thickness: thickness, async: true);
                    bool onePass = RuntimeConfig.OnePassActive;
                    FilterOperationSnapshot filterSettings = FilterSettingsSnapshotAdapter.Capture();

                    CalculationTelemetry.Report("collect_and_filter", 0.25);
                    OperationResult<List<Vector3D>> outcome = plannedStations != null
                        ? GroundPointsCollector.CollectAtStations(
                            alg, buffers, plannedStations, options, filterSettings, onePass)
                        : GroundPointsCollector.CollectPilot(
                            alg, buffers, sections, options, null, filterSettings, onePass);

                    LasTerrainResult result = new LasTerrainResult();
                    result.Mode = plannedStations != null ? "generated" : "existing";
                    result.Thickness = thickness;
                    result.Step = step.HasValue ? step.Value : 0.0;
                    result.StationsPlanned = plannedStations != null ? plannedStations.Count : sections.Count;
                    result.FilterUsed = RuntimeConfig.UseSplineFilter ? "spline" : "minweight";

                    if (outcome.Status == OperationStatus.Cancelled)
                    {
                        result.Cancelled = true;
                        clock.Stop();
                        result.ElapsedSeconds = clock.Elapsed.TotalSeconds;
                        return result;
                    }
                    if (outcome.Status == OperationStatus.Overflow)
                        throw new LasAutomationException(
                            "Слишком много точек. Примените прореживание облака (las_reduce_cloud).");
                    if (outcome.Status == OperationStatus.Failed)
                        throw new LasAutomationException(
                            "Ошибка расчёта сечений (" + outcome.Stage + "): " + outcome.Error.Message,
                            outcome.Error);
                    List<Vector3D> points = outcome.Status == OperationStatus.Empty
                        ? new List<Vector3D>() : outcome.Value;
                    result.PointsCollected = points.Count;
                    if (outcome.Status == OperationStatus.Empty && plannedStations == null)
                    {
                        clock.Stop();
                        result.ElapsedSeconds = clock.Elapsed.TotalSeconds;
                        result.Note = "Точек не найдено по существующим сечениям; ЦММ не изменена. " +
                            "Проверьте подключение LAS к ЦММ трассы (las_get_context).";
                        return result;
                    }

                    CalculationTelemetry.Report("validate_target_and_commit_surface", 0.85);
                    if (plannedStations != null)
                    {
                        ApplyGeneratedResult(view, surfaceLayer, surface, alg,
                            pilotModel, pilotProject, pilotDocument, pilotAlignmentId,
                            sections, pilotSectionIds, pilotStations,
                            originalConstructionIds, originalSectionLines,
                            plannedStations, points, sourceCurrent);
                        result.SectionsCreated = alg.Corridor.Sections.Count;
                    }
                    else
                    {
                        var writer = new TopomaticSurfaceWriter(surface, () =>
                            IsOriginalSectionsCurrent(view, surfaceLayer, surface, alg,
                                pilotModel, pilotProject, pilotDocument, pilotAlignmentId,
                                sections, pilotSectionIds, pilotStations,
                                originalConstructionIds, originalSectionLines) &&
                            sourceCurrent());
                        try
                        {
                            if (view.IsDisposed || !view.IsHandleCreated)
                                throw new InvalidOperationException(
                                    "Окно проекта закрыто до применения результата.");
                            // Вызов уже на CAD UI-потоке.
                            writer.Apply(points);
                        }
                        catch (Exception error)
                        {
                            Exception cause = error is System.Reflection.TargetInvocationException &&
                                error.InnerException != null ? error.InnerException : error;
                            throw new LasAutomationException("Результат не применён: " + cause.Message, cause);
                        }
                    }

                    result.PointsInserted = points.Count;
                    clock.Stop();
                    result.ElapsedSeconds = clock.Elapsed.TotalSeconds;
                    var layerAfter = SurfaceLayer.GetSurfaceLayer(view);
                    if (layerAfter != null && layerAfter.Surface != null)
                        result.SurfacePointsAfter = layerAfter.Surface.Points.Count.ToString();
                    return result;
                }
            }
        }

        private static List<double> PlanStations(Alignment alg, double step)
        {
            double length = alg.Plan.CompoundLine.Length;
            try
            {
                return SectionStationPlanner.Plan(length, step);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new LasAutomationException(ex.Message, ex);
            }
        }

        // Замена сечений с транзакцией — копия CrossSectionGenerator.ReplaceSections.
        private static void ReplaceSections(Alignment alg, List<double> stations)
        {
            var sections = alg.Corridor.Sections;
            if (sections.TransactionManager == null)
                throw new LasAutomationException(
                    "У списка сечений нет менеджера транзакций Topomatic.");
            bool started = false;
            try
            {
                global::UpdateLoop.BeginTransaction(sections);
                started = true;
                sections.Clear();
                foreach (double station in stations)
                    sections.Add(station);
                if (sections.Count != stations.Count)
                    throw new InvalidOperationException(
                        "Topomatic изменил число созданных сечений.");
                for (int i = 0; i < stations.Count; i++)
                    if (BitConverter.DoubleToInt64Bits(sections[i].Station) !=
                        BitConverter.DoubleToInt64Bits(stations[i]))
                        throw new InvalidOperationException(
                            "Topomatic изменил пикетаж созданного сечения.");
                global::UpdateLoop.Commit(sections);
                started = false;
            }
            catch (Exception error)
            {
                if (started)
                {
                    try { global::UpdateLoop.Rollback(sections); }
                    catch (Exception rollbackError)
                    {
                        throw new LasAutomationException(
                            "Откат сечений не удался; состояние проекта неизвестно. " +
                            rollbackError.Message, error);
                    }
                }
                throw new LasAutomationException("Не удалось заменить сечения: " + error.Message, error);
            }
        }

        // Применение результата в режиме авторазбивки — копия ApplyGeneratedResult.
        private static void ApplyGeneratedResult(Topomatic.Cad.View.CadView view,
            SurfaceLayer layer, Surface surface, Alignment alignment,
            object model, object project, object document, Guid alignmentId,
            IList<Section> originalSections,
            uint[] originalIds, double[] originalStations,
            uint[] originalConstructionIds, object[] originalLines,
            List<double> plannedStations, List<Vector3D> points,
            Func<bool> sourceCurrent)
        {
            bool sectionsCommitted = false;
            try
            {
                if (view.IsDisposed || !view.IsHandleCreated)
                    throw new InvalidOperationException(
                        "Окно проекта закрыто до применения результата.");
                if (!IsOriginalSectionsCurrent(view, layer, surface, alignment,
                        model, project, document, alignmentId,
                        originalSections, originalIds, originalStations,
                        originalConstructionIds, originalLines) ||
                    !sourceCurrent())
                    throw new InvalidOperationException(
                        "Проект, поверхность или исходные сечения изменились во время расчёта.");

                ReplaceSections(alignment, plannedStations);
                sectionsCommitted = true;
                if (points.Count == 0) return;

                var committedSections = alignment.Corridor.Sections.ToList();
                var committedIds = new uint[committedSections.Count];
                var committedStations = new double[committedSections.Count];
                for (int i = 0; i < committedSections.Count; i++)
                {
                    committedIds[i] = committedSections[i].Id;
                    committedStations[i] = committedSections[i].Station;
                }
                var writer = new TopomaticSurfaceWriter(surface, () =>
                    IsPilotTargetValid(view, layer, surface, alignment, model,
                        project, document, alignmentId,
                        committedIds, committedStations) && sourceCurrent());
                writer.Apply(points);
            }
            catch (Exception error)
            {
                Exception cause = error is System.Reflection.TargetInvocationException &&
                    error.InnerException != null ? error.InnerException : error;
                string prefix = sectionsCommitted
                    ? "Сечения созданы, но точки поверхности не применены полностью. " +
                      "Не запускайте операцию повторно до проверки проекта. "
                    : "Не удалось заменить сечения. ";
                SurfaceApplyException surfaceError = cause as SurfaceApplyException;
                if (surfaceError != null)
                {
                    if (surfaceError.UpdateStateUnknown)
                        prefix += "Состояние обновления поверхности в SDK требует проверки. ";
                    if (!surfaceError.PointsRestored)
                        prefix += "Часть точек могла остаться на поверхности. ";
                }
                throw new LasAutomationException(prefix + cause.Message, cause);
            }
        }

        private static bool IsOriginalSectionsCurrent(Topomatic.Cad.View.CadView view,
            SurfaceLayer layer, Surface surface, Alignment alignment,
            object model, object project, object document, Guid alignmentId,
            IList<Section> sections,
            uint[] ids, double[] stations, uint[] constructionIds, object[] lines)
        {
            if (!IsPilotTargetValid(view, layer, surface, alignment, model,
                project, document, alignmentId, ids, stations))
                return false;
            for (int i = 0; i < sections.Count; i++)
            {
                Section current = alignment.Corridor.Sections[i];
                if (!Object.ReferenceEquals(current, sections[i]) ||
                    current.ConstructionId != constructionIds[i] ||
                    BitConverter.DoubleToInt64Bits(current.Station) !=
                        BitConverter.DoubleToInt64Bits(stations[i]) ||
                    !Object.ReferenceEquals(current.SectionLine, lines[i]))
                    return false;
            }
            return true;
        }

        private static bool IsPilotTargetValid(Topomatic.Cad.View.CadView view,
            SurfaceLayer layer, Surface surface, Alignment alignment,
            object model, object project, object document, Guid alignmentId,
            uint[] sectionIds, double[] stations)
        {
            try
            {
                var host = ApplicationHost.Current;
                if (view == null || view.IsDisposed || !view.IsHandleCreated ||
                    host == null ||
                    !Object.ReferenceEquals(host.ActiveProject, project) ||
                    !Object.ReferenceEquals(host.ActiveDocument, document) ||
                    !Object.ReferenceEquals(SurfaceLayer.GetSurfaceLayer(view), layer) ||
                    !Object.ReferenceEquals(layer.Surface, surface) ||
                    !Object.ReferenceEquals(PluginCoreOps.FindModel(alignment), model) ||
                    AlignmentValueConverter.GetId(alignment) != alignmentId ||
                    alignment.Corridor.Sections.Count != sectionIds.Length)
                    return false;
                for (int i = 0; i < sectionIds.Length; i++)
                {
                    Section current = alignment.Corridor.Sections[i];
                    if (current.Id != sectionIds[i] || current.Station != stations[i])
                        return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ─────────────── Активация вида со слоем ЦММ ───────────────

        /// <summary>
        /// Делает активным видовым экраном вид со слоем ЦММ активной трассы
        /// (требование las_build_terrain / las_build_surface_by_polygons: вставка
        /// идёт в поверхность ЦММ активного вида). Порядок: активный вид → все
        /// открытые виды → узел ЦММ в дереве модели трассы (OpenModel + activate,
        /// как при активации трассы). Данные проекта не меняются.
        /// </summary>
        public static LasSurfaceViewState ActivateSurfaceView()
        {
            using (EnterGate())
            {
                IApplicationHost host = ApplicationHost.Current;
                if (host == null)
                    throw new LasAutomationException("Нет запущенного хоста Robur.");
                LasSurfaceViewState state = new LasSurfaceViewState();

                // 1) Активный вид уже несёт слой ЦММ?
                CadView active = GetActiveCadView();
                SurfaceLayer layer = active == null ? null : SurfaceLayer.GetSurfaceLayer(active);
                if (layer != null && layer.Surface != null)
                {
                    state.ActivatedView = "active";
                    return ReportSurfaceState(state, layer);
                }

                // 2) Среди открытых видов ищем несущий слой ЦММ (MDI-дети хоста,
                //    иначе все открытые формы процесса).
                System.Windows.Forms.Form main = host.MainForm as System.Windows.Forms.Form;
                List<System.Windows.Forms.Form> candidateForms = new List<System.Windows.Forms.Form>();
                if (main != null && main.MdiChildren != null)
                    candidateForms.AddRange(main.MdiChildren);
                if (candidateForms.Count == 0)
                    foreach (System.Windows.Forms.Form openForm in System.Windows.Forms.Application.OpenForms)
                        candidateForms.Add(openForm);
                foreach (System.Windows.Forms.Form form in candidateForms)
                {
                    ICadViewForm viewForm = form as ICadViewForm;
                    if (viewForm == null || viewForm.CadView == null || viewForm.CadView.IsDisposed) continue;
                    SurfaceLayer viewLayer = SurfaceLayer.GetSurfaceLayer(viewForm.CadView);
                    state.Diagnostics.Add("open view: '" + SafeFormText(form) + "' surface_layer=" +
                        (viewLayer == null ? "no" : (viewLayer.Surface == null ? "empty" : "yes")));
                    if (viewLayer != null && viewLayer.Surface != null)
                    {
                        ActivateForm(form);
                        state.ActivatedView = SafeFormText(form);
                        return ReportSurfaceState(state, viewLayer);
                    }
                }

                // 3) Окно поперечников (штатная утилита вида, как в командах RoboLas).
                CadView crossCv = Topomatic.Cad.View.Design.CadViewDesignUtils
                    .OnCadViewSelect(Topomatic.Cad.View.Design.CadViewDesignUtils.CrossSectionCadViewAlias);
                if (crossCv != null && !crossCv.IsDisposed)
                {
                    SurfaceLayer crossLayer = SurfaceLayer.GetSurfaceLayer(crossCv);
                    state.Diagnostics.Add("cross-section view: surface_layer=" +
                        (crossLayer == null ? "no" : (crossLayer.Surface == null ? "empty" : "yes")));
                    if (crossLayer != null && crossLayer.Surface != null)
                    {
                        ActivateForm(crossCv.FindForm());
                        state.ActivatedView = "cross-section";
                        return ReportSurfaceState(state, crossLayer);
                    }
                }

                // 4) Узел ЦММ в дереве ПРОЕКТА (обычно «Модели/ЦММ»): открыть и активировать.
                ModelProject project = host.ActiveProject as ModelProject;
                IProjectModel root = project == null
                    ? host.ActiveProject as IProjectModel
                    : project.Model;
                if (root != null)
                {
                    IProjectModel surfaceNode = FindSurfaceNode(root, state.Diagnostics, 0);
                    if (surfaceNode != null && project != null)
                    {
                        project.OpenModel(surfaceNode);
                        host.Plugins.Execute("activate", new object[] { surfaceNode });
                        // Открытие асинхронно по природе хоста: ждём, пока ЦММ станет
                        // активным документом и появится слой поверхности.
                        for (int attempt = 0; attempt < 30; attempt++)
                        {
                            System.Threading.Thread.Sleep(100);
                            ICadViewForm activeForm = host.ActiveDocument as ICadViewForm;
                            if (activeForm != null && activeForm.CadView != null && !activeForm.CadView.IsDisposed)
                            {
                                SurfaceLayer activeLayer = SurfaceLayer.GetSurfaceLayer(activeForm.CadView);
                                if (activeLayer != null && activeLayer.Surface != null)
                                {
                                    state.ActivatedView = SafeFormText(
                                        activeForm as System.Windows.Forms.Form);
                                    return ReportSurfaceState(state, activeLayer);
                                }
                            }
                        }
                    }
                }

                state.Note = "Вид со слоем ЦММ не найден среди открытых и не открылся из дерева проекта. " +
                    "Откройте ЦММ трассы в Robur вручную и повторите вызов. Диагностика — в Diagnostics.";
                return state;
            }
        }

        private static LasSurfaceViewState ReportSurfaceState(LasSurfaceViewState state, SurfaceLayer layer)
        {
            state.HasSurfaceLayer = layer != null;
            state.HasSurface = layer != null && layer.Surface != null;
            if (state.HasSurface)
            {
                state.SurfacePoints = layer.Surface.Points.Count;
                state.SurfaceTriangles = layer.Surface.Triangles.Count;
            }
            state.Note = state.HasSurface
                ? "Вид со слоем ЦММ активен — las_build_terrain готов к запуску."
                : "Слой ЦММ найден, но поверхность на нём ещё не создана.";
            return state;
        }

        private static void ActivateForm(System.Windows.Forms.Form form)
        {
            if (form == null || form.IsDisposed) return;
            if (!form.Visible) form.Show();
            form.Activate();
        }

        private static string SafeFormText(System.Windows.Forms.Form form)
        {
            try { return form == null ? "<null>" : (form.Text ?? "<no title>"); }
            catch (Exception) { return "<error>"; }
        }

        // Поиск узла ЦММ в дереве проекта: тип узла вида "surface"/"terrain"/"dtm"
        // или имя/URI с «ЦММ»/surface. Папки не открываются как вид — в них только
        // рекурсируем. Диагностика пишет структуру верхних уровней.
        private static IProjectModel FindSurfaceNode(IProjectModel model, List<string> diagnostics, int depth)
        {
            if (model == null || depth > 6) return null;
            IProjectModel[] children = model.GetChilds();
            if (children == null) return null;
            foreach (IProjectModel child in children)
            {
                string modelType = child.ModelType ?? string.Empty;
                string uri = string.Empty;
                try { if (child.Uri != null) uri = child.Uri.ToString(); } catch (Exception) { }
                string haystack = (modelType + " " + uri).ToLowerInvariant();
                if (depth < 4)
                    diagnostics.Add("tree: type='" + modelType + "' uri=" + uri);
                bool isFolder = modelType == "folder";
                if (!isFolder &&
                    (haystack.Contains("surface") || haystack.Contains("terrain") ||
                     haystack.Contains("dtm") || haystack.Contains("цмм")))
                    return child;
                IProjectModel deep = FindSurfaceNode(child, diagnostics, depth + 1);
                if (deep != null) return deep;
            }
            return null;
        }
    }
}
