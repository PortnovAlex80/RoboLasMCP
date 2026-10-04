// Services/SectionExecutorService.cs
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Domain.Service;
using LAS_TERRAIN.Service.Collector;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Topomatic.Alg;
using Topomatic.Alg.Crs;
using Topomatic.ApplicationPlatform;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.Cad.Foundation;
using Topomatic.Sfc;

namespace LAS_TERRAIN.Service
{
    /// <summary>
    /// Оркестратор базового пайплайна обработки секций DMR по LAS-точкам.
    ///
    /// Общий сценарий для стандартных use-case:
    /// - выбор трассы (Alignment) из CADView
    /// - (опционально) генерация секций
    /// - сбор и валидация буферов
    /// - вызов фильтрации (LasFilter)
    /// - вставка результата в CAD-поверхность
    /// - логирование времени выполнения
    ///
    /// Используется как общий workflow для стандартных команд (use-case).
    /// Для других сценариев (например, reduce) должен быть выделен отдельный use-case.
    /// </summary>
    internal static class SectionBaseUseCase
    {
        private static double lastCrossSectionStep = 1.0;
        private static double lastBorderThickness = 0.25;

        /// <summary>
        /// Универсальный расчёт сечений, совместимый с авторазбивкой и классическим режимом.
        /// </summary>
        /// <param name="context">Контекст запуска расчета.</param>
        public static void ExecuteSections(SectionExecutionContext context)
        {
            if (!UserDialogs.IsCadViewValid(context.CadView)) return;

            var surface_layer = UserDialogs.GetSurfaceLayerOrShow(context.CadView);
            if (surface_layer == null) return;

            var alg = UserDialogs.SelectAlignment(context.CadView);
            if (alg == null) return;

            var buffers = LidarBufferService.CollectBuffers(alg);
            if (!LidarBufferService.ValidateBuffers(buffers)) return;
            var source = BorrowedLidarSourceSnapshot.Capture(buffers);
            Func<bool> sourceCurrent = delegate
            {
                try { return source.Matches(LidarBufferService.CollectBuffers(alg)); }
                catch (Exception) { return false; }
            };

            var surface = surface_layer.Surface;

            double? sectionStep = null;
            if (context.IsNeedGenerateCrossSection)
            {
                sectionStep = context.Step.HasValue
                    ? context.Step
                    : UserDialogs.GetSectionStep(context.CadView, lastCrossSectionStep);
                if (sectionStep == null)
                    return;
            }

            var borderThickness = UserDialogs.GetBorderThickness(context.CadView, lastBorderThickness);
            if (borderThickness == null)
                return; // Отмена пользователем

            List<double> plannedStations = null;
            if (sectionStep.HasValue)
            {
                try
                {
                    plannedStations = SectionStationPlanner.Plan(
                        alg.Plan.CompoundLine.Length, sectionStep.Value);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    UserDialogs.ShowWarning(ex.Message);
                    return;
                }
                if (!context.Step.HasValue)
                    lastCrossSectionStep = sectionStep.Value;
            }

            var sections = alg.Corridor.Sections.ToList();
            var host = ApplicationHost.Current;
            object pilotProject = host == null ? null : host.ActiveProject;
            object pilotDocument = host == null ? null : host.ActiveDocument;
            object pilotModel = PluginCoreOps.FindModel(alg);
            Guid pilotAlignmentId = AlignmentValueConverter.GetId(alg);
            if (pilotProject == null || pilotDocument == null ||
                pilotModel == null || pilotAlignmentId == Guid.Empty)
            {
                UserDialogs.ShowWarning("Не удалось зафиксировать модель и трассу для расчёта.");
                return;
            }
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
            lastBorderThickness = borderThickness.Value;

            // Полная толщина слайса зафиксирована для этого запуска.
            // FromThickness автоматически преобразует в полу-толщину для внутреннего использования
            var options = LasFilterOptions.FromThickness(
                thickness: borderThickness.Value,
                async: context.Async);
            bool onePass = LAS_TERRAIN.Configuration.RuntimeConfig.OnePassActive;

            FilterOperationSnapshot filterSettings = FilterSettingsSnapshotAdapter.Capture();
            OperationResult<List<Vector3D>> outcome = plannedStations != null
                ? GroundPointsCollector.CollectAtStations(
                    alg, buffers, plannedStations, options, filterSettings, onePass)
                : GroundPointsCollector.CollectPilot(
                    alg, buffers, sections, options, null, filterSettings, onePass);
            if (outcome.Status == OperationStatus.Cancelled) return;
            if (outcome.Status == OperationStatus.Overflow)
            {
                UserDialogs.ShowWarning("Слишком много точек. Примените прореживание облака.");
                return;
            }
            if (outcome.Status == OperationStatus.Failed)
            {
                UserDialogs.ShowWarning("Ошибка расчёта сечений (" + outcome.Stage + "): "
                    + outcome.Error.Message);
                return;
            }
            if (outcome.Status == OperationStatus.Empty && plannedStations == null) return;
            List<Vector3D> points = outcome.Status == OperationStatus.Empty
                ? new List<Vector3D>() : outcome.Value;

            if (plannedStations != null)
            {
                if (!ApplyGeneratedResult(context.CadView, surface_layer, surface,
                    alg, pilotModel, pilotProject, pilotDocument,
                    pilotAlignmentId, sections, pilotSectionIds,
                    pilotStations, originalConstructionIds,
                    originalSectionLines, plannedStations, points, sourceCurrent))
                    return;
            }
            else
            {
                var writer = new TopomaticSurfaceWriter(surface, () =>
                    IsOriginalSectionsCurrent(context.CadView, surface_layer, surface, alg,
                        pilotModel, pilotProject, pilotDocument,
                        pilotAlignmentId, sections, pilotSectionIds,
                        pilotStations, originalConstructionIds, originalSectionLines) &&
                    sourceCurrent());
                try
                {
                    if (context.CadView.IsDisposed || !context.CadView.IsHandleCreated)
                        throw new InvalidOperationException("Окно проекта закрыто до применения результата.");
                    MethodInvoker apply = delegate { writer.Apply(points); };
                    if (context.CadView.InvokeRequired)
                        context.CadView.Invoke(apply);
                    else
                        apply();
                }
                catch (Exception error)
                {
                    Exception cause = error is System.Reflection.TargetInvocationException &&
                        error.InnerException != null ? error.InnerException : error;
                    SurfaceApplyException applyError = cause as SurfaceApplyException;
                    string detail = applyError != null && applyError.UpdateStateUnknown
                        ? " Состояние обновления поверхности в SDK требует проверки."
                        : "";
                    UserDialogs.ShowWarning("Результат не применён: " + cause.Message + detail);
                    return;
                }
            }
        }

        private static bool ApplyGeneratedResult(Topomatic.Cad.View.CadView view,
            Topomatic.Sfc.Layer.SurfaceLayer layer, Surface surface, Alignment alignment,
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
                    throw new InvalidOperationException("Окно проекта закрыто до применения результата.");
                MethodInvoker apply = delegate
                {
                    if (!IsOriginalSectionsCurrent(view, layer, surface, alignment,
                        model, project, document, alignmentId,
                        originalSections, originalIds,
                        originalStations, originalConstructionIds, originalLines) ||
                        !sourceCurrent())
                        throw new InvalidOperationException(
                            "Проект, поверхность или исходные сечения изменились во время расчёта.");

                    CrossSectionGenerator.ReplaceSections(alignment, plannedStations);
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
                };
                if (view.InvokeRequired)
                    view.Invoke(apply);
                else
                    apply();
                return true;
            }
            catch (Exception error)
            {
                Exception cause = error is System.Reflection.TargetInvocationException &&
                    error.InnerException != null ? error.InnerException : error;
                SurfaceApplyException surfaceError = cause as SurfaceApplyException;
                string prefix = sectionsCommitted
                    ? "Сечения созданы, но точки поверхности не применены полностью. " +
                      "Не запускайте всю команду повторно до проверки проекта. "
                    : "Не удалось заменить сечения. ";
                string detail = surfaceError != null && surfaceError.UpdateStateUnknown
                    ? "Состояние обновления поверхности в SDK требует проверки. " : "";
                if (surfaceError != null && !surfaceError.PointsRestored)
                    detail += "Часть точек могла остаться на поверхности. ";
                UserDialogs.ShowWarning(prefix + detail + cause.Message);
                return false;
            }
        }

        /// <summary>
        /// Генерирует секции через равные интервалы вдоль трассы.
        /// </summary>
        private static class CrossSectionGenerator
        {
            public static void ReplaceSections(Alignment alg, List<double> stations)
            {
                var sections = alg.Corridor.Sections;
                if (sections.TransactionManager == null)
                    throw new InvalidOperationException(
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
                            throw new InvalidOperationException(
                                "Откат сечений не удался; состояние проекта неизвестно. " +
                                rollbackError.Message, error);
                        }
                    }
                    throw;
                }
            }
        }

        private static bool IsOriginalSectionsCurrent(Topomatic.Cad.View.CadView view,
            Topomatic.Sfc.Layer.SurfaceLayer layer, Surface surface, Alignment alignment,
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
            Topomatic.Sfc.Layer.SurfaceLayer layer, Surface surface, Alignment alignment,
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
                    !Object.ReferenceEquals(Topomatic.Sfc.Layer.SurfaceLayer.GetSurfaceLayer(view), layer) ||
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

    }
}
