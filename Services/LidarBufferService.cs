// Services/LidarBufferService.cs
using System;
using System.Collections.Generic;
using Topomatic.Alg;
using Topomatic.Cad.Foundation;
using Topomatic.Lidar;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.Sfc;
using Topomatic.Alg.Runtime.Tools;
using Topomatic.Controls.Dialogs;

namespace LAS_TERRAIN.Service
{
    /// <summary>
    /// Сервис для сбора и валидации буферов лазерных точек.
    /// </summary>
    internal static class LidarBufferService
    {
        /// <summary>
        /// Собирает все доступные буферы точек лазерного сканирования для данного выравнивания.
        /// </summary>
        public static List<LidarBuffer> CollectBuffers(Alignment alg)
        {
            var buffers = new List<LidarBuffer>();
            var model = PluginCoreOps.FindModel(alg);
            var surfaces = new List<Surface>(alg.EgSurfaceRelativePaths.Count);
            if (!AlignLibrary.FindSurfaces(model, alg.EgSurfaceRelativePaths, surfaces))
                return buffers;

            foreach (var surface in surfaces)


            {
                if (surface == null)
                    continue;
                foreach (var provider in surface.ProxySourceProviders)
                {
                    ILidarBufferContainer container = provider as ILidarBufferContainer;
                    if (container != null)
                    {
                        LidarBuffer buffer = container.GetBuffer();
                        // The same cloud can be exposed through more than one
                        // selected surface. Count each SDK buffer only once;
                        // otherwise exports and point deletion duplicate it.
                        if (buffer != null && !ContainsReference(buffers, buffer))
                            buffers.Add(buffer);
                    }
                }
            }
            return buffers;
        }

        private static bool ContainsReference(List<LidarBuffer> buffers, LidarBuffer candidate)
        {
            foreach (LidarBuffer buffer in buffers)
                if (Object.ReferenceEquals(buffer, candidate)) return true;
            return false;
        }

        /// <summary>
        /// Проверяет, найдены ли буферы, и выводит сообщение при отсутствии.
        /// </summary>
        public static bool ValidateBuffers(List<LidarBuffer> buffers)
        {
            if (buffers == null || buffers.Count == 0)
            {
                MessageDlg.Show(
                    "Не удалось найти источник точек лазерных отражений. " +
                    "\nУбедитесь, что выбран ЦММ, содержащий точки лазерных отражений и что включено отображение интересующих наборов точек.",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        /// <summary>
        /// Находит все точки в списке буферов, попадающие в заданную область.
        /// </summary>
        public static List<Vector4D> FindPoints(
            IList<LidarBuffer> buffers,
            BoundingBox2D box)
        {
            var points = new List<Vector4D>();
            foreach (var buf in buffers)
            {
                if (buf == null)
                    continue;
                buf.FindPoints(box, pt => points.Add(new Vector4D(pt.X, pt.Y, pt.Z,
                    LAS_TERRAIN.Infrastructure.NativeLidarPointAdapter.Weight(pt))));
            }
            return points;
        }
    }
}
