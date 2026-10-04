using LAS_TERRAIN.Collector;
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Service.Collector;
using LAS_TERRAIN.Helpers;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Service;
using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;
using Topomatic.Controls;

namespace LAS_TERRAIN.UseCases
{
    [SectionCmd("split_las_by_offset")]
    public class SplitLasByOffsetUseCase : ISectionUseCase
    {
        public string Name => "split_las_by_offset";

        public void Run(SectionEnv env)
        {
            if (!UserDialogs.IsCadViewValid(env.CadView)) return;
            var surface_layer = UserDialogs.GetSurfaceLayerOrShow(env.CadView);
            if (surface_layer == null) return;
            var alg = UserDialogs.SelectAlignment(env.CadView);
            if (alg == null) return;

            var buffers = LidarBufferService.CollectBuffers(alg);
            if (!LidarBufferService.ValidateBuffers(buffers)) return;
            LasExportSourceContext sourceContext = LasExportSourceContext.Capture(
                env.CadView, alg, buffers);
            if (!IsCurrentSource(sourceContext)) return;

            double step = 1.0;
            double? leftOffset = UserDialogs.GetOptionalDouble(env.CadView, "Левый оффсет от оси (м)", 5);
            if (!IsCurrentSource(sourceContext)) return;
            if (leftOffset == null) return;
            if (Double.IsNaN(leftOffset.Value) || Double.IsInfinity(leftOffset.Value))
            {
                UserDialogs.ShowWarning("Левый оффсет должен быть конечным числом.");
                return;
            }

            double? rightOffset = UserDialogs.GetOptionalDouble(env.CadView, "Правый оффсет от оси (м)", 5);
            if (!IsCurrentSource(sourceContext)) return;
            if (rightOffset == null) return;
            if (Double.IsNaN(rightOffset.Value) || Double.IsInfinity(rightOffset.Value))
            {
                UserDialogs.ShowWarning("Правый оффсет должен быть конечным числом.");
                return;
            }

            double? percentCenter = UserDialogs.GetOptionalDouble(env.CadView,
                "Процент точек для полосы трассы (например, 50 = 50%)", 50.0);
            if (!IsCurrentSource(sourceContext)) return;
            if (percentCenter == null) return;
            if (percentCenter < 1.0 || percentCenter > 100.0)
            {
                UserDialogs.ShowWarning("Процент должен быть от 1 до 100.");
                return;
            }

            double? percentEdge = UserDialogs.GetOptionalDouble(env.CadView,
                "Процент точек для обочин (например, 10 = 10%)", 10.0);
            if (!IsCurrentSource(sourceContext)) return;
            if (percentEdge == null) return;
            if (percentEdge < 1.0 || percentEdge > 100.0)
            {
                UserDialogs.ShowWarning("Процент должен быть от 1 до 100.");
                return;
            }

            double thickness = step;  // полная толщина слайса = 1.0 м
            ExportRequest exportRequest;
            if (!SaveLidarPointsService.TryAskSaveModeAndPath(env.CadView, out exportRequest)) return;
            if (!IsCurrentSource(sourceContext)) return;

            // Finish a previously prepared pair before collecting points.
            string recoveryJournal = LAS_TERRAIN.IO.LasPairPublication.JournalPath(
                exportRequest.PrimaryPath);
            if (System.IO.File.Exists(recoveryJournal))
            {
                try
                {
                    LAS_TERRAIN.IO.LasPairPublication.Recover(exportRequest.PrimaryPath);
                    UserDialogs.ShowInfo("Публикация LAS-файлов восстановлена без повторного расчёта.");
                }
                catch (Exception ex)
                {
                    UserDialogs.ShowWarning("Не удалось восстановить LAS-файлы: " + ex.Message);
                }
                return;
            }

            try
            {
                RgbExportOutcome rgb;
                if(RgbExportPipeline.TrySplit(alg,buffers,sourceContext,leftOffset.Value,rightOffset.Value,
                    percentCenter.Value,percentEdge.Value,exportRequest,out rgb))
                {if(!rgb.Cancelled)UserDialogs.ShowInfo(rgb.Published?"LAS сохранены с исходными RGB: полоса "+rgb.Center+", обочины "+rgb.Edge+" точек.":"После обработки не осталось точек; LAS не созданы.");return;}
            }
            catch(Exception error){UserDialogs.ShowWarning(error.Message);return;}
            List<double> stations;
            double alignmentLength = alg.Plan.CompoundLine.Length;
            try { stations = SectionStationPlanner.Plan(alignmentLength, step); }
            catch (ArgumentOutOfRangeException error)
            {
                UserDialogs.ShowWarning(error.Message);
                return;
            }
            // A fractional tail beyond the final slice border needs one
            // station at the actual alignment end. It is still inside the
            // alignment, unlike a synthetic station past the endpoint.
            if (stations.Count > 0 && alignmentLength - stations[stations.Count - 1] >=
                    thickness / 2.0 && stations[stations.Count - 1] < alignmentLength)
            {
                if (stations.Count >= SectionStationPlanner.MaxSections)
                {
                    UserDialogs.ShowWarning("Слишком много сечений для разделения облака.");
                    return;
                }
                stations.Add(alignmentLength);
            }
            if (!IsCurrentSource(sourceContext)) return;

            // фильтры
            Func<Vector2D, bool> outerFilter = section_pt =>
                (section_pt.X < -leftOffset.Value || section_pt.X > rightOffset.Value);

            Func<Vector2D, bool> innerFilter = section_pt =>
                (section_pt.X >= -leftOffset.Value && section_pt.X <= rightOffset.Value);

            var optionsOuter = LasFilterOptions.FromThickness(thickness: thickness, async: true);
            var optionsInner = LasFilterOptions.FromThickness(thickness: thickness, async: true);
            optionsOuter.IncludePositiveSliceBorder = true;
            optionsInner.IncludePositiveSliceBorder = true;

            // ЭТАП 1: сбор outer прямо во временный файл
            using (SpilledPointList outerSpool = CollectSpoolOrWarn(
                "Сбор (обочины)...", "обочин", alg, buffers, stations,
                optionsOuter, outerFilter, sourceContext, exportRequest.PrimaryPath))
            {
                if (outerSpool == null) return;
                if (!IsCurrentSource(sourceContext)) return;

                // ЭТАП 2: сбор inner
                using (SpilledPointList innerSpool = CollectSpoolOrWarn(
                    "Сбор (полоса)...", "полосы", alg, buffers, stations,
                    optionsInner, innerFilter, sourceContext, exportRequest.PrimaryPath))
                {
                    if (innerSpool == null) return;
                    if (!IsCurrentSource(sourceContext)) return;

                    if (innerSpool.Count == 0 && outerSpool.Count == 0)
                    {
                        UserDialogs.ShowWarning("Точек не найдено.");
                        return;
                    }

                    // ЭТАП 3a: редукция (полоса)
                    List<Vector4D> reducedCenter;
                    if (!TryReduceWithProgress("Редукция (полоса)...", innerSpool,
                        percentCenter.Value, out reducedCenter)) return;
                    if (!IsCurrentSource(sourceContext)) return;

                    // ЭТАП 3b: редукция (обочины)
                    List<Vector4D> reducedEdge;
                    if (!TryReduceWithProgress("Редукция (обочины)...", outerSpool,
                        percentEdge.Value, out reducedEdge)) return;
                    if (!IsCurrentSource(sourceContext)) return;
                    if (reducedCenter.Count == 0 && reducedEdge.Count == 0)
                    {
                        UserDialogs.ShowWarning("После редукции не осталось точек; LAS-файлы не созданы.");
                        return;
                    }

                    // ЭТАП 4: сохранение — как сейчас (без доп. BeginProgress)
                    bool sourceChangedDuringSave = false;
                    try
                    {
                        LidarIntensity.ExpandInPlace(reducedCenter);
                        LidarIntensity.ExpandInPlace(reducedEdge);
                        SaveLidarPointsService.SaveTwoExternalProgress(
                            reducedCenter, reducedEdge, exportRequest,
                            startOffset: 0.0f, // пусть сам сервис рисует свой короткий прогресс
                            beforePublish: delegate
                            {
                                if (!sourceContext.IsCurrent())
                                {
                                    sourceChangedDuringSave = true;
                                    throw new OperationCanceledException();
                                }
                            }
                        );
                    }
                    catch (OperationCanceledException)
                    {
                        if (sourceChangedDuringSave) ShowSourceChangedWarning();
                        return;
                    }
                    catch (Exception ex)
                    {
                        string journal = LAS_TERRAIN.IO.LasPairPublication.JournalPath(
                            exportRequest.PrimaryPath);
                        string detail = System.IO.File.Exists(journal)
                            ? " Один файл может быть уже опубликован. Повторно выберите тот же путь для восстановления без расчёта."
                            : "";
                        UserDialogs.ShowWarning("Не удалось сохранить LAS: " + ex.Message + detail);
                        return;
                    }
                    string savedPaths = reducedCenter.Count > 0 ? exportRequest.PrimaryPath : "";
                    if (reducedEdge.Count > 0)
                        savedPaths += (savedPaths.Length == 0 ? "" : "\n") + exportRequest.EdgePath;
                    UserDialogs.ShowInfo("LAS сохранён:\n" + savedPaths +
                        "\nИсходное облако в проекте не менялось. Чтобы работать с результатом, импортируйте LAS в Topomatic.");
                }
            }
        }

        private static SpilledPointList CollectSpoolOrWarn(string title, string label,
            Topomatic.Alg.Alignment alg, List<Topomatic.Lidar.LidarBuffer> buffers,
            IList<double> stations, LasFilterOptions options, Func<Vector2D, bool> filter,
            LasExportSourceContext sourceContext, string outputPath)
        {
            try
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

                    if (!IsCurrentSource(sourceContext)) return null;
                    if (cancelled || WaitProgress.CancellationPending) return null;
                    if (outcome == null)
                    {
                        UserDialogs.ShowWarning("Сбор точек " + label + " завершился без результата.");
                        return null;
                    }
                    if (outcome.Status == OperationStatus.Cancelled) return null;
                    if (outcome.Status == OperationStatus.Overflow)
                    {
                        UserDialogs.ShowWarning("Слишком много точек. Примените прореживание облака.");
                        return null;
                    }
                    if (outcome.Status == OperationStatus.Failed)
                    {
                        UserDialogs.ShowWarning("Не удалось собрать точки " + label + ": " +
                            outcome.Error.Message);
                        return null;
                    }
                    return writer.Complete();
                }
            }
            catch (OperationCanceledException) { return null; }
            catch (Exception error)
            {
                UserDialogs.ShowWarning("Не удалось подготовить точки для разделения LAS: " +
                    error.Message);
                return null;
            }
        }

        private static bool IsCurrentSource(LasExportSourceContext sourceContext)
        {
            if (sourceContext != null && sourceContext.IsCurrent()) return true;
            ShowSourceChangedWarning();
            return false;
        }

        private static void ShowSourceChangedWarning()
        {
            UserDialogs.ShowWarning("Источник LAS изменился. LAS-файлы не сохранены. Повторите экспорт.");
        }

        private static bool TryReduceWithProgress(string title, IList<Vector4D> points,
            double percent, out List<Vector4D> reduced)
        {
            List<Vector4D> candidate = null;
            bool cancelled = false;
            Exception failure = null;
            try
            {
                WaitProgress.BeginProgress(title, delegate
                {
                    try
                    {
                        candidate = SamplingHelper.ReduceByPercentWithProgress(points,
                            percent, delegate(float p) { WaitProgress.ProgressChange(p); },
                            delegate { return WaitProgress.CancellationPending; });
                    }
                    catch (OperationCanceledException)
                    {
                        cancelled = true;
                    }
                    catch (Exception error)
                    {
                        failure = error;
                    }
                    finally
                    {
                        // Some progress wrappers reset their flag as the modal closes.
                        if (WaitProgress.CancellationPending) cancelled = true;
                    }
                }, true);
            }
            catch (OperationCanceledException)
            {
                cancelled = true;
            }
            catch (Exception error)
            {
                reduced = null;
                UserDialogs.ShowWarning("Не удалось выполнить редукцию: " + error.Message);
                return false;
            }

            reduced = null;
            if (cancelled || WaitProgress.CancellationPending) return false;
            if (failure != null)
            {
                UserDialogs.ShowWarning("Не удалось выполнить редукцию: " + failure.Message);
                return false;
            }
            if (candidate == null)
            {
                UserDialogs.ShowWarning("Редукция завершилась без результата.");
                return false;
            }
            reduced = candidate;
            return true;
        }
    }

}
