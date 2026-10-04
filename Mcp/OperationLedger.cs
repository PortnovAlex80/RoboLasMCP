using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LAS_TERRAIN.Mcp
{
    internal static class OperationLedger
    {
        internal sealed class Run
        {
            internal string Id, RequestId, Tool, Signature, State="validating", Response, Context;
            internal DateTime Started=DateTime.UtcNow, Finished;
            internal List<Dictionary<string,object>> Stages=new List<Dictionary<string,object>>();
            internal double Progress;
            internal bool Mutation;
            internal object Arguments, Settings;
        }
        private static readonly object Sync=new object();
        private static readonly List<Run> Runs=new List<Run>();
        internal static Run FindRequest(string requestId)
        { lock(Sync) return Runs.Find(r=>r.RequestId==requestId); }
        internal static Run Start(string tool,string requestId,string signature,bool mutation)
        {
            lock(Sync)
            {
                while(Runs.Count>=64)
                {
                    int index=Runs.FindIndex(r=>r.Finished!=default(DateTime));
                    if(index<0) throw new InvalidOperationException("Operation history is full of active requests.");
                    Runs.RemoveAt(index);
                }
                Run run=new Run { Id=Guid.NewGuid().ToString("N"), RequestId=requestId, Tool=tool, Signature=signature, Mutation=mutation };
                Runs.Add(run); Stage(run,"validate",0); return run;
            }
        }
        internal static void Stage(Run run,string stage,double progress)
        {
            lock(Sync)
            {
                progress=Math.Max(run.Progress,Math.Max(0,Math.Min(1,progress)));
                run.Progress=progress;
                if(run.Stages.Count>0 && (string)run.Stages[run.Stages.Count-1]["stage"]==stage)
                { run.Stages[run.Stages.Count-1]["progress"]=progress; return; }
                if(run.Stages.Count>=256) run.Stages.RemoveAt(1);
                run.Stages.Add(new Dictionary<string,object>{{"stage",stage},{"progress",progress},{"at",DateTime.UtcNow.ToString("o")}});
            }
        }
        internal static void Finish(Run run,Dictionary<string,object> response,string state)
        {
            lock(Sync)
            {
                run.State=state; run.Finished=DateTime.UtcNow;
                Stage(run,state,state=="completed"?1:run.Progress);
                response["operation_id"]=run.Id; response["request_id"]=run.RequestId;
                response["operation"]=Describe(run);
                run.Response=JsonConvert.SerializeObject(response);
            }
        }
        internal static Dictionary<string,object> Describe(Run run)
        {
            lock(Sync) return new Dictionary<string,object> {
                {"operation_id",run.Id},{"request_id",run.RequestId},{"tool",run.Tool},{"state",run.State},
                {"started_at",run.Started.ToString("o")},{"finished_at",run.Finished==default(DateTime)?null:run.Finished.ToString("o")},
                {"elapsed_seconds",((run.Finished==default(DateTime)?DateTime.UtcNow:run.Finished)-run.Started).TotalSeconds},
                {"stage_events",run.Stages.ConvertAll(s=>new Dictionary<string,object>(s))},{"context_fingerprint",run.Context},
                {"progress",run.Progress},{"arguments",run.Arguments},{"settings_snapshot",run.Settings},
                {"execution_mode","native_synchronous"},{"mutating",run.Mutation}
            };
        }
        internal static object Get(string id)
        {
            lock(Sync)
            {
                Run run=Runs.Find(r=>r.Id==id || r.RequestId==id);
                if(run==null) throw new ArgumentException("Operation is not in this process's bounded history: "+id);
                return new Dictionary<string,object>{{"operation",Describe(run)},{"response",run.Response==null?null:JObject.Parse(run.Response)}};
            }
        }
        internal static object History()
        {
            lock(Sync) { List<object> result=new List<object>(); foreach(Run r in Runs) result.Add(Describe(r)); return result; }
        }
    }
}
