using System;
using System.Collections.Generic;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.IO;
using LAS_TERRAIN.Models;
using Topomatic.Alg;
using Topomatic.Cad.Foundation;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Service.Collector
{
    internal static partial class LasSectionPointsCollectorService
    {
        internal static void StreamColoredAtStation(Alignment alg,IList<LidarBuffer> buffers,
            double station,LasFilterOptions options,Func<Vector2D,bool> filter,RgbExportSession session,
            Action<LasColoredPoint> accept,Func<bool> cancel,out SectionCollectStatus status)
        {
            LasColoredPoint current=new LasColoredPoint();List<Vector4D> unused;
            CollectInternal(alg,buffers,station,options,out unused,null,filter,false,
                delegate(Vector4D point){accept(current);},false,cancel,out status,
                delegate(LidarBuffer buffer,BoundingBox2D box,Action<Vector4D> emit)
                {session.FindPoints(buffer,box,delegate(LasColoredPoint point){current=point;emit(point.Position);},cancel);});
        }
    }
}
