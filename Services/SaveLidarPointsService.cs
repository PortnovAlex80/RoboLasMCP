using LAS_TERRAIN.Application;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.IO;
using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;
using Topomatic.Cad.View;
using Topomatic.Controls;

namespace LAS_TERRAIN.Service
{
    public static class SaveLidarPointsService
    {
        public static bool TryAskSaveModeAndPath(CadView cadView, out ExportRequest request)
        {
            string path = UserDialogs.GetSaveFilePath("Выберите путь для LAS-файла");
            request = String.IsNullOrEmpty(path) ? null : new ExportRequest(path);
            return request != null;
        }

        public static void Save(List<Vector4D> points, ExportRequest request,
            bool useExternalProgress, float startOffset)
        {
            if (request == null) throw new ArgumentNullException("request");
            using (PreparedLasFile prepared = Prepare(points, request.PrimaryPath,
                (cur, total) =>
                {
                    if (useExternalProgress)
                    {
                        float rel = total == 0 ? 1f : cur / (float)total;
                        WaitProgress.ProgressChange(startOffset + (1f - startOffset) * rel);
                    }
                }))
            {
                if (WaitProgress.CancellationPending) throw new OperationCanceledException();
                prepared.Publish();
            }
            if (useExternalProgress)
            {
                // The LAS file is already published. A closed progress window must
                // not turn a committed export into a reported failure and invite
                // the user to retry an operation with other side effects.
                try { WaitProgress.ProgressChange(1f); }
                catch (Exception ex)
                {
                    if (ex is OutOfMemoryException || ex is StackOverflowException ||
                        ex is System.Threading.ThreadAbortException)
                        throw;
                    System.Diagnostics.Trace.WriteLine(
                        "[SaveLidarPointsService] Final progress update failed after LAS publication: " + ex);
                }
            }
        }

        public static void SaveTwoExternalProgress(List<Vector4D> firstPoints,
            List<Vector4D> secondPoints, ExportRequest request, float startOffset)
        {
            SaveTwoExternalProgress(firstPoints, secondPoints, request, startOffset, null);
        }

        public static void SaveTwoExternalProgress(List<Vector4D> firstPoints,
            List<Vector4D> secondPoints, ExportRequest request, float startOffset,
            Action beforePublish)
        {
            if (request == null) throw new ArgumentNullException("request");
            bool hasFirst = firstPoints != null && firstPoints.Count > 0;
            bool hasSecond = secondPoints != null && secondPoints.Count > 0;
            if (!hasFirst && !hasSecond)
            {
                UserDialogs.ShowInfo("Нет данных для сохранения.");
                return;
            }

            PreparedLasFile first = null;
            PreparedLasFile second = null;
            try
            {
                if (hasFirst)
                    first = Prepare(firstPoints, request.PrimaryPath,
                        (cur, total) => ReportPairProgress(cur, total, false, startOffset));
                if (hasSecond)
                    second = Prepare(secondPoints, request.EdgePath,
                        (cur, total) => ReportPairProgress(cur, total, true, startOffset));
                if (WaitProgress.CancellationPending) throw new OperationCanceledException();
                if (beforePublish != null) beforePublish();
                if (WaitProgress.CancellationPending) throw new OperationCanceledException();

                if (first != null && second != null)
                    LasPairPublication.Publish(first, second);
                else if (first != null)
                    first.Publish();
                else
                    second.Publish();
            }
            finally
            {
                if (second != null) second.Dispose();
                if (first != null) first.Dispose();
            }
        }

        private static void ReportPairProgress(int current, int total, bool second, float startOffset)
        {
            float rel = total == 0 ? 1f : current / (float)total;
            float span = 0.30f;
            float p = startOffset + span * (second ? 0.50f + 0.50f * rel : 0.50f * rel);
            WaitProgress.ProgressChange(Math.Min(1f, p));
        }

        private static PreparedLasFile Prepare(List<Vector4D> points, string path, Action<int, int> progress)
        {
            using (LasStreamWriter writer = new LasStreamWriter(path))
            {
                writer.IsCancellationRequested = () => WaitProgress.CancellationPending;
                writer.OnProgress = progress;
                writer.WritePoints(points);
                return writer.Complete();
            }
        }
    }
}
