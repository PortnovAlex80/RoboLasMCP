// Automation/LasAutomation.Export.cs
// Headless-экспорт LAS: прореживание (обычное и с 3D ground-фильтром) и
// разделение облака на полосу/обочины. Пайплайны повторяют
// ReduceLasAsyncToPercentUseCase / ReduceWithGroundRedSectorUseCase /
// SplitLasByOffsetUseCase с заменой диалогов на параметры вызова.
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Collector;
using LAS_TERRAIN.Filters;
using LAS_TERRAIN.Helpers;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.IO;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Service;
using LAS_TERRAIN.Service.Collector;
using System;
using System.Collections.Generic;
using Topomatic.Alg;
using Topomatic.Alg.Runtime.ServiceClasses;
using Topomatic.Cad.Foundation;
using Topomatic.Controls;

namespace LAS_TERRAIN.Automation
{
    public static partial class LasAutomation
    {
        /// <summary>
        /// Прореживание облака вдоль активной трассы: сбор слайсов толщиной 1 м,
        /// опционально 3D ground-фильтр, затем редукция до percent% и запись
        /// нового LAS 1.2. Исходное облако в проекте не меняется.
        /// </summary>
        public static LasReduceResult ReduceCloud(double percent, string outputPath, bool groundFilter)
        {
            ValidatePercent(percent);
            string validatedPath = ValidateLasPath(outputPath);
            using (EnterGate())
            {
                RequireCadView();
                using (ActiveAlignmentReciver<Alignment> receiver =
                    ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    Alignment alg = RequireAlignment(receiver);
                    CalculationTelemetry.Report("capture_source", 0.1);
                    var buffers = LidarBufferService.CollectBuffers(alg);
                    if (buffers == null || buffers.Count == 0)
                        throw new LasAutomationException(NoLidarSourceMessage);
                    LasExportSourceContext sourceContext =
                        LasExportSourceContext.Capture(LasAutomation.GetActiveCadView(), alg, buffers);
                    if (sourceContext == null || !sourceContext.IsCurrent())
                        throw new LasAutomationException(SourceChangedMessage);

                    RgbExportOutcome rgb;
                    if(RgbExportPipeline.TryReduce(alg,buffers,sourceContext,percent,validatedPath,groundFilter,out rgb))
                        return new LasReduceResult{OutputPath=validatedPath,Percent=percent,GroundFilterUsed=groundFilter,
                            TotalRaw=rgb.Raw,TotalGround=rgb.Ground,TotalReduced=rgb.Written,Published=rgb.Published,Cancelled=rgb.Cancelled,
                            RgbPreserved=rgb.Published,Note=rgb.Cancelled?"Операция отменена; LAS не опубликован.":"Исходные RGB uint16 сохранены с выбранными записями."};
                    List<double> stations = PlanStations(alg, 1.0);
                    var options = LasFilterOptions.FromThickness(thickness: 1.0, async: true);
                    GraphGround3DOptions groundOptions = GraphGround3DSettingsAdapter.Capture();

                    int flushThreshold = groundFilter
                        ? MemoryStatus.CalcBatchSizeForGroundReduce()
                        : MemoryStatus.CalcBatchSizeForReduceOnly();
                    int totalSections = stations.Count;
                    long totalRaw = 0;
                    long totalGround = 0;
                    long totalReduced = 0;
                    var buffer = new List<Vector4D>(flushThreshold + 10000);
                    bool processingCompleted = false;
                    bool outputPublished = false;
                    bool cancellationObserved = false;
                    PreparedLasFile prepared = null;
                    SectionCollectStatus collectionStatus = SectionCollectStatus.Success;
                    Func<bool> isCancelled = delegate
                    {
                        if (WaitProgress.CancellationPending) cancellationObserved = true;
                        return cancellationObserved;
                    };

                    LasReduceResult result = new LasReduceResult();
                    result.OutputPath = validatedPath;
                    result.Percent = percent;
                    result.GroundFilterUsed = groundFilter;
                    try
                    {
                        using (var writer = new LasBatchStreamWriter(validatedPath))
                        {
                            writer.IsCancellationRequested = isCancelled;
                            WaitProgress.BeginProgress(
                                string.Format("{0} ({1} секций)...",
                                    groundFilter ? "Ground + Reduce" : "Редукция облака", totalSections),
                                () =>
                                {
                                    for (int i = 0; i < totalSections; i++)
                                    {
                                        if (isCancelled()) return;
                                        SectionCollectStatus sectionStatus;
                                        CalculationTelemetry.Report("collect", 0.15 + 0.6 * i / Math.Max(1, totalSections));
                                        LasSectionPointsCollectorService.StreamRawAtStation(
                                            alg, buffers, stations[i], options, buffer.Add,
                                            isCancelled, out sectionStatus);
                                        if (sectionStatus != SectionCollectStatus.Success)
                                        {
                                            collectionStatus = sectionStatus;
                                            if (sectionStatus == SectionCollectStatus.Cancelled)
                                                cancellationObserved = true;
                                            return;
                                        }
                                        WaitProgress.ProgressChange((float)(i + 1) / totalSections);

                                        if (buffer.Count >= flushThreshold || i == totalSections - 1)
                                        {
                                            int batchRaw = buffer.Count;
                                            var batchPoints = buffer;
                                            buffer = new List<Vector4D>(flushThreshold + 10000);

                                            if (groundFilter)
                                            {
                                                List<Vector4D> ground;
                                                try
                                                {
                                                    CalculationTelemetry.Report("filter_ground", 0.2 + 0.6 * i / Math.Max(1, totalSections));
                                                    ground = GraphGround3DFilter.Apply(batchPoints,
                                                        groundOptions, null, TopomaticIndexScheduler.ForEach,
                                                        isCancelled);
                                                }
                                                catch (OperationCanceledException)
                                                {
                                                    cancellationObserved = true;
                                                    return;
                                                }
                                                totalGround += ground.Count;
                                                batchPoints = ground;
                                            }

                                            if (batchPoints.Count == 0)
                                            {
                                                totalRaw += batchRaw;
                                                continue;
                                            }
                                            List<Vector4D> reduced;
                                            try
                                            {
                                                CalculationTelemetry.Report("reduce", 0.25 + 0.6 * i / Math.Max(1, totalSections));
                                                reduced = SamplingHelper.ReduceByPercentWithProgress(
                                                    batchPoints, percent, null, isCancelled);
                                            }
                                            catch (OperationCanceledException)
                                            {
                                                cancellationObserved = true;
                                                return;
                                            }
                                            totalRaw += batchRaw;
                                            totalReduced += reduced.Count;
                                            LidarIntensity.ExpandInPlace(reduced);
                                            CalculationTelemetry.Report("write_stage", 0.3 + 0.6 * i / Math.Max(1, totalSections));
                                            writer.WritePoints(reduced);
                                        }
                                    }
                                    if (collectionStatus != SectionCollectStatus.Success || isCancelled())
                                        return;
                                    if (totalReduced > 0)
                                    {
                                        CalculationTelemetry.Report("validate_stage", 0.93);
                                        prepared = writer.Complete();
                                        if (isCancelled()) return;
                                    }
                                    processingCompleted = true;
                                }, true);
                        }
                        if (collectionStatus == SectionCollectStatus.Overflow)
                            throw new LasAutomationException(
                                "Слишком много точек. Уменьшите процент или задайте ground_filter=true.");
                        if (cancellationObserved || WaitProgress.CancellationPending)
                        {
                            result.Cancelled = true;
                            return result;
                        }
                        if (!processingCompleted)
                            throw new LasAutomationException(
                                "Прореживание не завершилось. Повторите вызов.");
                        if (!sourceContext.IsCurrent())
                            throw new LasAutomationException(SourceChangedMessage);
                        result.TotalRaw = totalRaw;
                        result.TotalGround = totalGround;
                        result.TotalReduced = totalReduced;
                        if (totalReduced == 0)
                        {
                            result.Note = groundFilter
                                ? "Точек не найдено или все отфильтрованы ground-фильтром; файл не создан."
                                : "Точек не найдено; файл не создан.";
                            return result;
                        }
                        CalculationTelemetry.Report("publish", 0.97);
                        prepared.Publish();
                        outputPublished = true;
                        result.Published = true;
                        result.Note = "Исходное облако в проекте не менялось. Чтобы работать с результатом, импортируйте LAS в Topomatic.";
                    }
                    catch (OperationCanceledException)
                    {
                        if (!outputPublished && (prepared == null || !prepared.IsPublished))
                        {
                            result.Cancelled = true;
                            return result;
                        }
                    }
                    catch (OutOfMemoryException)
                    {
                        if (!outputPublished && (prepared == null || !prepared.IsPublished))
                            throw new LasAutomationException(
                                "Слишком много точек. Уменьшите процент или задайте ground_filter=true.");
                        throw;
                    }
                    finally
                    {
                        if (prepared != null) prepared.Dispose();
                    }
                    return result;
                }
            }
        }

        /// <summary>
        /// Разделение облака на два LAS: полоса трассы (±offsets от оси) и обочины.
        /// Каждый файл редуцируется до своего процента. Исходное облако не меняется.
        /// edge-файл создаётся автоматически рядом с primaryPath.
        /// </summary>
        public static LasSplitResult SplitByOffset(double leftOffset, double rightOffset,
            double percentCenter, double percentEdge, string primaryPath)
        {
            ValidatePercent(percentCenter, "percent_center");
            ValidatePercent(percentEdge, "percent_edge");
            if (double.IsNaN(leftOffset) || double.IsInfinity(leftOffset) || leftOffset <= 0)
                throw new LasAutomationException("Левый офсет должен быть положительным числом (метры).");
            if (double.IsNaN(rightOffset) || double.IsInfinity(rightOffset) || rightOffset <= 0)
                throw new LasAutomationException("Правый офсет должен быть положительным числом (метры).");
            string validatedPath = ValidateLasPath(primaryPath);

            using (EnterGate())
            {
                RequireCadView();
                using (ActiveAlignmentReciver<Alignment> receiver =
                    ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    Alignment alg = RequireAlignment(receiver);
                    CalculationTelemetry.Report("capture_source", 0.1);
                    var buffers = LidarBufferService.CollectBuffers(alg);
                    if (buffers == null || buffers.Count == 0)
                        throw new LasAutomationException(NoLidarSourceMessage);
                    LasExportSourceContext sourceContext =
                        LasExportSourceContext.Capture(LasAutomation.GetActiveCadView(), alg, buffers);
                    if (sourceContext == null || !IsCurrentSource(sourceContext))
                        throw new LasAutomationException(SourceChangedMessage);

                    ExportRequest exportRequest = new ExportRequest(validatedPath);
                    LasSplitResult result = new LasSplitResult();
                    result.PrimaryPath = exportRequest.PrimaryPath;
                    result.EdgePath = exportRequest.EdgePath;
                    result.LeftOffset = leftOffset;
                    result.RightOffset = rightOffset;
                    result.PercentCenter = percentCenter;
                    result.PercentEdge = percentEdge;

                    // Завершение предыдущей незавершённой пары без повторного расчёта.
                    string recoveryJournal = LasPairPublication.JournalPath(exportRequest.PrimaryPath);
                    if (System.IO.File.Exists(recoveryJournal))
                    {
                        LasPairPublication.Recover(exportRequest.PrimaryPath);
                        result.Recovered = true;
                        result.Published = true;
                        result.Note = "Публикация предыдущей пары LAS восстановлена без повторного расчёта.";
                        return result;
                    }

                    const double step = 1.0;
                    List<double> stations = PlanStations(alg, step);
                    double alignmentLength = alg.Plan.CompoundLine.Length;
                    if (stations.Count > 0 && alignmentLength - stations[stations.Count - 1] >=
                            step / 2.0 && stations[stations.Count - 1] < alignmentLength)
                    {
                        if (stations.Count >= SectionStationPlanner.MaxSections)
                            throw new LasAutomationException("Слишком много сечений для разделения облака.");
                        stations.Add(alignmentLength);
                    }
                    if (!IsCurrentSource(sourceContext))
                        throw new LasAutomationException(SourceChangedMessage);

                    Func<Vector2D, bool> outerFilter = section_pt =>
                        (section_pt.X < -leftOffset || section_pt.X > rightOffset);
                    Func<Vector2D, bool> innerFilter = section_pt =>
                        (section_pt.X >= -leftOffset && section_pt.X <= rightOffset);

                    var optionsOuter = LasFilterOptions.FromThickness(thickness: step, async: true);
                    var optionsInner = LasFilterOptions.FromThickness(thickness: step, async: true);
                    optionsOuter.IncludePositiveSliceBorder = true;
                    optionsInner.IncludePositiveSliceBorder = true;

                    try
                    {
                        RgbExportOutcome rgb;
                        if(RgbExportPipeline.TrySplit(alg,buffers,sourceContext,leftOffset,rightOffset,percentCenter,percentEdge,exportRequest,out rgb))
                        {result.CenterPoints=rgb.Center;result.EdgePoints=rgb.Edge;result.Published=rgb.Published;
                         result.Cancelled=rgb.Cancelled;result.RgbPreserved=rgb.Published;
                         result.Note=rgb.Cancelled?"Операция отменена; LAS не опубликованы.":"Исходные RGB uint16 сохранены с выбранными записями.";return result;}
                        CalculationTelemetry.Report("collect_edge", 0.2);
                        using (SpilledPointList outerSpool = CollectSpool("Сбор (обочины)...", alg,
                            buffers, stations, optionsOuter, outerFilter, sourceContext,
                            exportRequest.PrimaryPath))
                        {
                            if (!IsCurrentSource(sourceContext))
                                throw new LasAutomationException(SourceChangedMessage);
                            CalculationTelemetry.Report("collect_center", 0.45);
                            using (SpilledPointList innerSpool = CollectSpool("Сбор (полоса)...", alg,
                                buffers, stations, optionsInner, innerFilter, sourceContext,
                                exportRequest.PrimaryPath))
                            {
                                if (!IsCurrentSource(sourceContext))
                                    throw new LasAutomationException(SourceChangedMessage);
                                if (innerSpool.Count == 0 && outerSpool.Count == 0)
                                {
                                    result.Note = "Точек не найдено; LAS-файлы не созданы.";
                                    return result;
                                }

                                CalculationTelemetry.Report("reduce_center", 0.6);
                                List<Vector4D> reducedCenter = ReduceBatch("Редукция (полоса)...",
                                    innerSpool, percentCenter, sourceContext);
                                if (!IsCurrentSource(sourceContext))
                                    throw new LasAutomationException(SourceChangedMessage);
                                CalculationTelemetry.Report("reduce_edge", 0.75);
                                List<Vector4D> reducedEdge = ReduceBatch("Редукция (обочины)...",
                                    outerSpool, percentEdge, sourceContext);
                                if (!IsCurrentSource(sourceContext))
                                    throw new LasAutomationException(SourceChangedMessage);
                                if (reducedCenter.Count == 0 && reducedEdge.Count == 0)
                                {
                                    result.Note = "После редукции не осталось точек; LAS-файлы не созданы.";
                                    return result;
                                }

                                bool sourceChangedDuringSave = false;
                                try
                                {
                                    LidarIntensity.ExpandInPlace(reducedCenter);
                                    LidarIntensity.ExpandInPlace(reducedEdge);
                                    CalculationTelemetry.Report("prepare_validate_publish_pair", 0.9);
                                    SaveLidarPointsService.SaveTwoExternalProgress(
                                        reducedCenter, reducedEdge, exportRequest,
                                        startOffset: 0.0f,
                                        beforePublish: delegate
                                        {
                                            if (!sourceContext.IsCurrent())
                                            {
                                                sourceChangedDuringSave = true;
                                                throw new OperationCanceledException();
                                            }
                                        });
                                }
                                catch (OperationCanceledException)
                                {
                                    if (sourceChangedDuringSave)
                                        throw new LasAutomationException(SourceChangedMessage);
                                    throw;
                                }
                                catch (Exception ex)
                                {
                                    string journal = LasPairPublication.JournalPath(exportRequest.PrimaryPath);
                                    string detail = System.IO.File.Exists(journal)
                                        ? " Один файл может быть уже опубликован. Повторно вызовите с тем же путём для восстановления без расчёта."
                                        : "";
                                    throw new LasAutomationException(
                                        "Не удалось сохранить LAS: " + ex.Message + detail, ex);
                                }
                                result.CenterPoints = reducedCenter.Count;
                                result.EdgePoints = reducedEdge.Count;
                                result.Published = true;
                                result.Note = "Исходное облако в проекте не менялось. Чтобы работать с результатом, импортируйте LAS в Topomatic.";
                            }
                        }
                    }
                    catch (LasAutomationCancelledException)
                    {
                        result.Cancelled = true;
                        result.Note = "Операция отменена пользователем; LAS-файлы не опубликованы.";
                        return result;
                    }
                    return result;
                }
            }
        }

        private static SpilledPointList CollectSpool(string title, Alignment alg,
            List<Topomatic.Lidar.LidarBuffer> buffers, IList<double> stations,
            LasFilterOptions options, Func<Vector2D, bool> filter,
            LasExportSourceContext sourceContext, string outputPath)
        {
            using (SpilledPointWriter writer = new SpilledPointWriter(outputPath))
            {
                OperationResult<int> outcome = null;
                bool cancelled = false;
                WaitProgress.BeginProgress(title, delegate
                {
                    outcome = RawPointsCollector.StreamAtStations(
                        alg, buffers, stations, options, filter, writer.Append,
                        delegate(float p) { WaitProgress.ProgressChange(p); });
                    cancelled = WaitProgress.CancellationPending;
                }, true);

                if (!IsCurrentSource(sourceContext))
                    throw new LasAutomationException(SourceChangedMessage);
                if (cancelled || WaitProgress.CancellationPending)
                    throw new LasAutomationCancelledException();
                if (outcome == null)
                    throw new LasAutomationException("Сбор точек завершился без результата.");
                if (outcome.Status == OperationStatus.Cancelled)
                    throw new LasAutomationCancelledException();
                if (outcome.Status == OperationStatus.Overflow)
                    throw new LasAutomationException(
                        "Слишком много точек. Уменьшите проценты редукции.");
                if (outcome.Status == OperationStatus.Failed)
                    throw new LasAutomationException(
                        "Не удалось собрать точки: " + outcome.Error.Message, outcome.Error);
                return writer.Complete();
            }
        }

        private static List<Vector4D> ReduceBatch(string title, IList<Vector4D> points,
            double percent, LasExportSourceContext sourceContext)
        {
            List<Vector4D> candidate = null;
            bool cancelled = false;
            Exception failure = null;
            WaitProgress.BeginProgress(title, delegate
            {
                try
                {
                    candidate = SamplingHelper.ReduceByPercentWithProgress(points, percent,
                        delegate(float p) { WaitProgress.ProgressChange(p); },
                        delegate { return WaitProgress.CancellationPending; });
                }
                catch (OperationCanceledException) { cancelled = true; }
                catch (Exception error) { failure = error; }
                finally
                {
                    if (WaitProgress.CancellationPending) cancelled = true;
                }
            }, true);
            if (cancelled)
                throw new LasAutomationCancelledException();
            if (failure != null)
                throw new LasAutomationException("Не удалось выполнить редукцию: " + failure.Message, failure);
            if (candidate == null)
                throw new LasAutomationException("Редукция завершилась без результата.");
            return candidate;
        }

        private static bool IsCurrentSource(LasExportSourceContext sourceContext)
        {
            return sourceContext != null && sourceContext.IsCurrent();
        }

        private static void ValidatePercent(double percent)
        {
            ValidatePercent(percent, "percent");
        }

        private static void ValidatePercent(double percent, string name)
        {
            if (double.IsNaN(percent) || percent < 1.0 || percent > 100.0)
                throw new LasAutomationException(
                    name + " должен быть от 1 до 100 (процент точек для сохранения).");
        }

        private static string ValidateLasPath(string outputPath)
        {
            if (string.IsNullOrEmpty(outputPath))
                throw new LasAutomationException(
                    "Путь к выходному LAS-файлу обязателен (output_path, абсолютный путь с расширением .las).");
            if (!string.Equals(System.IO.Path.GetExtension(outputPath), ".las",
                    StringComparison.OrdinalIgnoreCase))
                throw new LasAutomationException("Путь выходного файла должен заканчиваться на .las: " + outputPath);
            return outputPath;
        }

        private const string NoLidarSourceMessage =
            "Не найден источник точек лазерного сканирования. Убедитесь, что ЦММ трассы содержит " +
            "облако LAS и отображение точек включено.";

        private const string SourceChangedMessage =
            "Исходная трасса, проект или облако изменились во время операции; результат не сохранён. Повторите вызов.";
    }
}
