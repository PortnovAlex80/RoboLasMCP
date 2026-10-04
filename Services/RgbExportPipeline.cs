using System;
using System.Collections.Generic;
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Filters;
using LAS_TERRAIN.Helpers;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.IO;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Service.Collector;
using Topomatic.Alg;
using Topomatic.Cad.Foundation;
using Topomatic.Controls;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Service
{
    internal sealed class RgbExportOutcome
    {
        internal long Raw,Ground,Written,Center,Edge;
        internal bool Published,Cancelled;
    }

    // One attributed implementation for GUI and MCP; the legacy path is used
    // only for colorless native buffers. Every stage carries the record's RGB.
    internal static class RgbExportPipeline
    {
        internal static bool TryReduce(Alignment alg,List<LidarBuffer> buffers,LasExportSourceContext context,
            double percent,string outputPath,bool groundFilter,out RgbExportOutcome outcome)
        {
            var result=new RgbExportOutcome();outcome=result;
            RgbExportSession session=null;PreparedLasFile prepared=null;Exception failure=null;bool completed=false;
            var stations=SectionStationPlanner.Plan(alg.Plan.CompoundLine.Length,1.0);
            var options=LasFilterOptions.FromThickness(1.0,true);
            var groundOptions=GraphGround3DSettingsAdapter.Capture();
            int flushThreshold=groundFilter?MemoryStatus.CalcBatchSizeForGroundReduce():MemoryStatus.CalcBatchSizeForReduceOnly();
            Func<bool> cancel=delegate{return WaitProgress.CancellationPending;};
            try
            {
                WaitProgress.BeginProgress("RGB: источник → обработка → LAS",delegate
                {
                    try
                    {
                        CalculationTelemetry.Report("read_native_rgb",0.05);
                        session=RgbExportSession.Create(buffers,outputPath,cancel);
                        if(session==null){completed=true;return;}
                        using(var writer=new LasBatchStreamWriter(outputPath,true))
                        {
                            writer.IsCancellationRequested=cancel;
                            var batch=new List<LasColoredPoint>();
                            Action flush=delegate
                            {
                                result.Raw+=batch.Count;
                                var selectedSource=batch;
                                if(groundFilter){CalculationTelemetry.Report("filter_ground_rgb",0.4);selectedSource=Ground(batch,groundOptions,cancel);result.Ground+=selectedSource.Count;}
                                CalculationTelemetry.Report("reduce_rgb",0.6);
                                var selected=SamplingHelper.ReduceByPercentWithProgress<LasColoredPoint>(selectedSource,percent,null,cancel);
                                for(int n=0;n<selected.Count;n++)selected[n]=RgbExportSession.ForLas(selected[n]);
                                writer.WriteColoredPoints(selected);result.Written+=selected.Count;batch.Clear();
                            };
                            for(int i=0;i<stations.Count;i++)
                            {
                                ThrowCancelled(cancel);
                                SectionCollectStatus status;
                                CalculationTelemetry.Report("collect_rgb",0.15+0.6*i/Math.Max(1,stations.Count));
                                LasSectionPointsCollectorService.StreamColoredAtStation(alg,buffers,stations[i],options,null,session,
                                    batch.Add,cancel,out status);
                                CheckStatus(status);
                                WaitProgress.ProgressChange((float)(i+1)/Math.Max(1,stations.Count));
                                if((batch.Count>=flushThreshold||i==stations.Count-1) && batch.Count>0)flush();
                            }
                            if(result.Written>0){CalculationTelemetry.Report("stage_rgb",0.9);prepared=writer.Complete();}
                            completed=true;
                        }
                    }
                    catch(OperationCanceledException){result.Cancelled=true;}
                    catch(Exception error){failure=error;}
                },true);
                if(failure!=null)throw new InvalidOperationException("RGB export failed: "+failure.Message,failure);
                if(cancel()||result.Cancelled){result.Cancelled=true;return true;}
                if(!completed)throw new InvalidOperationException("RGB progress did not complete.");
                if(session==null)return false;
                if(!context.IsCurrent())throw new InvalidOperationException("Loaded source changed before RGB publication.");
                session.AssertCurrent(cancel);ThrowCancelled(cancel);
                if(prepared!=null){CalculationTelemetry.Report("publish_rgb",0.98);prepared.Publish();result.Published=true;}
                return true;
            }
            catch(OperationCanceledException){result.Cancelled=true;return true;}
            finally{if(prepared!=null)prepared.Dispose();if(session!=null)session.Dispose();}
        }

        internal static List<LasColoredPoint> Ground(List<LasColoredPoint> points,GraphGround3DOptions options,Func<bool> cancel)
        {
            var geometry=new List<Vector4D>(points.Count);foreach(var point in points)geometry.Add(point.Position);
            var result=new List<LasColoredPoint>();
            GraphGround3DFilter.ApplyWithSelection(geometry,options,null,TopomaticIndexScheduler.ForEach,cancel,
                delegate(int index){result.Add(points[index]);});
            return result;
        }

        internal static bool TrySplit(Alignment alg,List<LidarBuffer> buffers,LasExportSourceContext context,
            double left,double right,double percentCenter,double percentEdge,ExportRequest request,out RgbExportOutcome outcome)
        {
            var result=new RgbExportOutcome();outcome=result;
            RgbExportSession session=null;PreparedLasFile center=null,edge=null;Exception failure=null;bool completed=false;
            var stations=SectionStationPlanner.Plan(alg.Plan.CompoundLine.Length,1.0);
            double length=alg.Plan.CompoundLine.Length;
            if(stations.Count>0 && length-stations[stations.Count-1]>=0.5 && stations[stations.Count-1]<length)stations.Add(length);
            var options=LasFilterOptions.FromThickness(1.0,true);options.IncludePositiveSliceBorder=true;
            Func<bool> cancel=delegate{return WaitProgress.CancellationPending;};
            try
            {
                WaitProgress.BeginProgress("RGB: разделение и сохранение цветов",delegate
                {
                    try
                    {
                        session=RgbExportSession.Create(buffers,request.PrimaryPath,cancel);
                        if(session==null){completed=true;return;}
                        session.AssertOutputPath(request.EdgePath);
                        using(var outer=new ColoredPointSpool(request.PrimaryPath))
                        using(var inner=new ColoredPointSpool(request.PrimaryPath))
                        {
                            Collect(alg,buffers,stations,options,session,delegate(Vector2D p){return p.X < -left || p.X > right;},outer,cancel);
                            Collect(alg,buffers,stations,options,session,delegate(Vector2D p){return p.X >= -left && p.X <= right;},inner,cancel);
                            result.Raw=(long)inner.Count+outer.Count;
                            IList<LasColoredPoint> centerPoints=percentCenter>=100?inner:(IList<LasColoredPoint>)SamplingHelper.ReduceByPercentWithProgress<LasColoredPoint>(inner,percentCenter,null,cancel);
                            IList<LasColoredPoint> edgePoints=percentEdge>=100?outer:(IList<LasColoredPoint>)SamplingHelper.ReduceByPercentWithProgress<LasColoredPoint>(outer,percentEdge,null,cancel);
                            result.Center=centerPoints.Count;result.Edge=edgePoints.Count;result.Written=result.Center+result.Edge;
                            center=Prepare(centerPoints,request.PrimaryPath,cancel);edge=Prepare(edgePoints,request.EdgePath,cancel);
                            completed=true;
                        }
                    }
                    catch(OperationCanceledException){result.Cancelled=true;}
                    catch(Exception error){failure=error;}
                },true);
                if(failure!=null)throw new InvalidOperationException("RGB split failed: "+failure.Message,failure);
                if(cancel()||result.Cancelled){result.Cancelled=true;return true;}
                if(!completed)throw new InvalidOperationException("RGB split did not complete.");
                if(session==null)return false;
                if(!context.IsCurrent())throw new InvalidOperationException("Loaded source changed before RGB publication.");
                session.AssertCurrent(cancel);ThrowCancelled(cancel);
                if(center!=null&&edge!=null)LasPairPublication.Publish(center,edge);
                else if(center!=null)center.Publish();else if(edge!=null)edge.Publish();
                result.Published=center!=null||edge!=null;return true;
            }
            catch(OperationCanceledException){result.Cancelled=true;return true;}
            finally{if(edge!=null)edge.Dispose();if(center!=null)center.Dispose();if(session!=null)session.Dispose();}
        }
        private static void Collect(Alignment alg,List<LidarBuffer> buffers,IList<double> stations,LasFilterOptions options,
            RgbExportSession session,Func<Vector2D,bool> filter,ColoredPointSpool spool,Func<bool> cancel)
        {
            using(var raw=new ColoredPointSpool(System.IO.Path.Combine(spool.DirectoryPath,"rgb-collection.las")))
            {
            for(int i=0;i<stations.Count;i++)
            {
                ThrowCancelled(cancel);SectionCollectStatus status;
                LasSectionPointsCollectorService.StreamColoredAtStation(alg,buffers,stations[i],options,filter,session,
                    raw.Append,cancel,out status);
                CheckStatus(status);WaitProgress.ProgressChange((float)(i+1)/Math.Max(1,stations.Count));
            }
            raw.Seal();raw.CopyDistinctTo(spool,cancel);
            }
        }
        private static PreparedLasFile Prepare(IList<LasColoredPoint> points,string path,Func<bool> cancel)
        {if(points.Count==0)return null;using(var writer=new LasBatchStreamWriter(path,true))
         {
             writer.IsCancellationRequested=cancel;var batch=new List<LasColoredPoint>();
             foreach(var point in points)
             {ThrowCancelled(cancel);batch.Add(RgbExportSession.ForLas(point));if(batch.Count>=65536){writer.WriteColoredPoints(batch);batch.Clear();}}
             if(batch.Count>0)writer.WriteColoredPoints(batch);return writer.Complete();
         }}
        private static void ThrowCancelled(Func<bool> cancel){if(cancel())throw new OperationCanceledException();}
        private static void CheckStatus(SectionCollectStatus status)
        {if(status==SectionCollectStatus.Cancelled)throw new OperationCanceledException();
         if(status!=SectionCollectStatus.Success)throw new InvalidOperationException("Section RGB collection exceeded its point limit.");}
    }
}
