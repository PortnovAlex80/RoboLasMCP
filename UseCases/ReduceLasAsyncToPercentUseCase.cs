using LAS_TERRAIN.Collector;
using LAS_TERRAIN.Service.Collector;
using LAS_TERRAIN.Helpers;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.IO;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Service;
using System;
using System.Collections.Generic;
using Topomatic.Alg;
using Topomatic.Alg.Crs;
using Topomatic.Cad.Foundation;
using Topomatic.Controls;
using Topomatic.Sfc;

namespace LAS_TERRAIN.UseCases
{
    [SectionCmd("reduce_las_async_to_percent")]
    public class ReduceLasAsyncToPercentUseCase : ISectionUseCase
    {
        private const string SourceChangedWarning =
            "Исходная трасса, проект или облако изменились; LAS не сохранён.";
        public string Name => "reduce_las_async_to_percent";

        public void Run(SectionEnv env)
        {
            if (!UserDialogs.IsCadViewValid(env.CadView)) return;

            var surface_layer = UserDialogs.GetSurfaceLayerOrShow(env.CadView);
            if (surface_layer == null) return;

            var alg = UserDialogs.SelectAlignment(env.CadView);
            if (alg == null) return;

            var buffers = Service.LidarBufferService.CollectBuffers(alg);
            if (!Service.LidarBufferService.ValidateBuffers(buffers)) return;
            var sourceContext = LasExportSourceContext.Capture(env.CadView, alg, buffers);
            if (sourceContext == null)
            {
                UserDialogs.ShowWarning(SourceChangedWarning);
                return;
            }

            double? requestedPercent = UserDialogs.GetOptionalDouble(env.CadView,
                "Укажите процент точек для сохранения (например, 50 для 50%)", 50.0);
            if (!requestedPercent.HasValue) return;
            double percent = requestedPercent.Value;
            if (percent < 1.0 || percent > 100.0)
            {
                UserDialogs.ShowWarning("Процент должен быть от 1 до 100.");
                return;
            }

            if (!sourceContext.IsCurrent())
            {
                UserDialogs.ShowWarning(SourceChangedWarning);
                return;
            }
            var outputPath = UserDialogs.GetSaveFilePath("Сохранить LAS-файл с уменьшенным облаком");
            if (string.IsNullOrEmpty(outputPath)) return;
            if (!sourceContext.IsCurrent())
            {
                UserDialogs.ShowWarning(SourceChangedWarning);
                return;
            }

            try
            {
                RgbExportOutcome rgb;
                if(RgbExportPipeline.TryReduce(alg,buffers,sourceContext,percent,outputPath,false,out rgb))
                {if(!rgb.Cancelled)UserDialogs.ShowInfo(rgb.Published?"LAS сохранён с исходными RGB: "+rgb.Written+" точек.":"После обработки не осталось точек; LAS не создан.");return;}
            }
            catch(Exception error){UserDialogs.ShowWarning(error.Message);return;}
            double step = 1.0;
            List<double> stations;
            try { stations = SectionStationPlanner.Plan(alg.Plan.CompoundLine.Length, step); }
            catch (ArgumentOutOfRangeException error)
            {
                UserDialogs.ShowWarning(error.Message);
                return;
            }
            var options = LasFilterOptions.FromThickness(thickness: 1.0, async: true);
            int totalSections = stations.Count;
            int flushThreshold = MemoryStatus.CalcBatchSizeForReduceOnly();
            int totalRaw = 0;
            int totalReduced = 0;
            var buffer = new List<Vector4D>(flushThreshold);
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

            // Один прогресс-бар на весь процесс — прогресс по секциям
            try
            {
            using (var writer = new LasBatchStreamWriter(outputPath))
            {
                writer.IsCancellationRequested = isCancelled;
                WaitProgress.BeginProgress(
                    string.Format("Редукция облака ({0} секций)...", totalSections),
                    () =>
                {
                    for (int i = 0; i < totalSections; i++)
                    {
                        if (isCancelled()) return;

                        SectionCollectStatus sectionStatus;
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

                        // Flush when buffer reaches threshold or last section
                        if (buffer.Count >= flushThreshold || i == totalSections - 1)
                        {
                            int batchRaw = buffer.Count;
                            var batchPoints = buffer;
                            buffer = new List<Vector4D>(flushThreshold);

                            List<Vector4D> reduced;
                            try
                            {
                                reduced = SamplingHelper.ReduceByPercentWithProgress(
                                    batchPoints, percent, null, isCancelled);
                            }
                            catch (OperationCanceledException)
                            {
                                cancellationObserved = true;
                                return;
                            }
                            batchPoints = null;

                            totalRaw += batchRaw;
                            totalReduced += reduced.Count;

                            LidarIntensity.ExpandInPlace(reduced);
                            writer.WritePoints(reduced);
                            reduced = null;
                        }
                    }
                    if (collectionStatus != SectionCollectStatus.Success ||
                        isCancelled()) return;
                    if (totalReduced > 0)
                    {
                        prepared = writer.Complete();
                        if (isCancelled()) return;
                    }
                    processingCompleted = true;
                }, true);
            }
            if (collectionStatus == SectionCollectStatus.Overflow)
            {
                UserDialogs.ShowWarning("Слишком много точек. Примените прореживание облака.");
                return;
            }
            if (!processingCompleted || cancellationObserved || WaitProgress.CancellationPending)
                return;
            if (!sourceContext.IsCurrent())
            {
                UserDialogs.ShowWarning(SourceChangedWarning);
                return;
            }
            if (totalReduced == 0)
            {
                UserDialogs.ShowWarning("Точек не найдено.");
                return;
            }
            if (prepared == null)
                throw new InvalidOperationException("LAS preparation did not produce a file.");
            prepared.Publish();
            outputPublished = true;
            }
            catch (OperationCanceledException)
            {
                if (!outputPublished && (prepared == null || !prepared.IsPublished)) return;
            }
            catch (OutOfMemoryException)
            {
                if (!outputPublished && (prepared == null || !prepared.IsPublished))
                {
                    UserDialogs.ShowWarning("Слишком много точек. Примените прореживание облака.");
                    return;
                }
            }
            catch (Exception error)
            {
                if (!outputPublished && (prepared == null || !prepared.IsPublished))
                {
                    UserDialogs.ShowWarning("Не удалось сохранить LAS: " + error.Message);
                    return;
                }
            }
            finally
            {
                if (prepared != null) prepared.Dispose();
            }
            UserDialogs.ShowInfo(
                string.Format("Файл сохранён: {0}\nТочек в облаке: {1}\nПосле редукции ({2:F1}%): {3}",
                    outputPath, totalRaw, percent, totalReduced) +
                "\nИсходное облако в проекте не менялось. Чтобы работать с результатом, импортируйте LAS в Topomatic.");
        }
    }
}
