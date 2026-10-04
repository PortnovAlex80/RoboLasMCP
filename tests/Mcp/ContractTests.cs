using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Newtonsoft.Json.Linq;
using LAS_TERRAIN.Automation;
using LAS_TERRAIN.Configuration;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Mcp;

namespace Topomatic.ToolBridge
{
    [AttributeUsage(AttributeTargets.Method)] public class ToolDefAttribute:Attribute
    { public string Name,Description,InputSchema; public bool ReadOnlyHint,DestructiveHint,IdempotentHint; }
    public class ToolProvider { }
    public static class JsonUtils
    {
        public static object UnwrapJsonValue(object value) { JValue token=value as JValue; return token==null?value:token.Value; }
        public static string GetString(Dictionary<string,object> source,string key,string def) { return GetString(source,key,false,def); }
        public static string RequireString(Dictionary<string,object> source,string key) { return GetString(source,key,true,null); }
        static string GetString(Dictionary<string,object> source,string key,bool require,string def)
        {
            object raw;
            if(source==null||!source.TryGetValue(key,out raw)||raw==null) { if(require) throw new ArgumentException(key+" is required"); return def; }
            object value=UnwrapJsonValue(raw);
            if(value is string) return (string)value;
            throw new ArgumentException(key+" must be a string");
        }
        public static int? GetInt(Dictionary<string,object> source,string key,int? def)
        {
            object raw;
            if(source==null||!source.TryGetValue(key,out raw)||raw==null) return def;
            return Convert.ToInt32(UnwrapJsonValue(raw),CultureInfo.InvariantCulture);
        }
        public static double? GetDouble(Dictionary<string,object> source,string key,double? def)
        {
            object raw;
            if(source==null||!source.TryGetValue(key,out raw)||raw==null) return def;
            return Convert.ToDouble(UnwrapJsonValue(raw),CultureInfo.InvariantCulture);
        }
        public static double RequireDouble(Dictionary<string,object> source,string key)
        {
            double? value=GetDouble(source,key,null);
            if(!value.HasValue) throw new ArgumentException(key+" is required");
            return value.Value;
        }
        public static bool? GetBool(Dictionary<string,object> source,string key,bool? def)
        {
            object raw;
            if(source==null||!source.TryGetValue(key,out raw)||raw==null) return def;
            object value=UnwrapJsonValue(raw);
            if(value is bool) return (bool)value;
            if(value is string) return Boolean.Parse((string)value);
            throw new ArgumentException(key+" must be a boolean");
        }
    }
}
namespace Topomatic.ApplicationPlatform
{
    public class ApplicationHost { public static ApplicationHost Current=new ApplicationHost(); public Dictionary<string,object> Settings=new Dictionary<string,object>(); }
}
namespace Topomatic.Stg
{
    public interface IStgSerializable { void LoadFromStg(StgNode node); void SaveToStg(StgNode node); }
    public class StgNode
    {
        private Dictionary<string,object> values=new Dictionary<string,object>();
        public double GetDouble(string key) { return (double)values[key]; }
        public bool GetBoolean(string key,bool fallback) { return values.ContainsKey(key)?(bool)values[key]:fallback; }
        public void AddDouble(string key,double value) { values[key]=value; }
        public void AddBoolean(string key,bool value) { values[key]=value; }
    }
}
namespace LAS_TERRAIN.Automation
{
    public static class LasAutomation
    {
        public static object GetContext() { return new {project="fixture",alignment="A"}; }
        // Fixture facade of docs/MCP_SECTION_VISUAL.md: real signatures, synthetic data.
        public static LasSectionFrame GetSectionFrame(double station,double thickness,int maxStoredPoints)
        {
            LasSectionFrame f=new LasSectionFrame();
            f.Alignment="A"; f.Station=station; f.Thickness=thickness; f.LeftOffset=20; f.RightOffset=20;
            int n=64;
            f.Offsets=new double[n]; f.Elevations=new double[n]; f.Weights=new double[n]; f.SliceDistances=new double[n];
            for(int i=0;i<n;i++)
            { f.Offsets[i]=-18+36.0*i/(n-1); f.Elevations[i]=100+f.Offsets[i]*0.1; f.Weights[i]=1000.0*i; f.SliceDistances[i]=0.4*Math.Sin(i*0.3); }
            f.TotalPoints=n; f.StoredPoints=n; f.OffsetMin=-18; f.OffsetMax=18; f.ZMin=98.2; f.ZMax=101.8; f.WeightMin=0; f.WeightMax=63000;
            return f;
        }
        public static LasSectionPreviewResult PreviewSectionPolygons(double station,double thickness,double[][][] polygons)
        {
            LasSectionPreviewResult r=new LasSectionPreviewResult();
            r.Alignment="A"; r.Station=station; r.Thickness=thickness; r.PolygonCount=polygons==null?0:polygons.Length;
            r.SlicePoints=64; r.MatchedPoints=7; r.Polygons.Add(new LasSectionPolygonCount{Index=0,Count=7});
            return r;
        }
        public static LasSectionDeleteResult DeleteSectionPoints(LasSectionPolygonSpec[] sections,string outputPath)
        {
            LasSectionDeleteResult r=new LasSectionDeleteResult();
            r.OutputPath=outputPath; r.Sections=sections==null?0:sections.Length; r.Deleted=7; r.Kept=93;
            r.Published=true; r.RgbPreserved=true; r.ElapsedSeconds=0.01; r.Note="fixture export";
            r.PerSection.Add(new LasSectionPolygonCount{Index=0,Count=7});
            return r;
        }
    }
}
namespace LAS_TERRAIN.Mcp
{
    // The real native tool schema constant is compiled below; SDK access is deliberately absent.
    internal class LasSettingsTools
    { [Topomatic.ToolBridge.ToolDef(Name="las_set_settings",InputSchema=SettingsSchema.Patch)] public object Set(Dictionary<string,object> args) { return null; } }
    internal class LasContextTools
    { [Topomatic.ToolBridge.ToolDef(Name="las_get_context",InputSchema="{\"type\":\"object\",\"properties\":{},\"additionalProperties\":false}",ReadOnlyHint=true)] public object Get(Dictionary<string,object> args) { return null; } }
    internal class LasTerrainTools {} internal class LasExportTools {} internal class LasPolygonTools {} internal class LasHarnessTools {}
    internal static class ToolResult
    {
        internal static Dictionary<string,object> Ok(object result,string description,params object[] steps)
        { return new Dictionary<string,object>{{"status","ok"},{"result",result},{"description",description},{"next_steps",steps}}; }
        internal static object Step(string tool,string when,object args) { return new {tool=tool,when=when,args=args}; }
        internal static object NoArgs() { return new Dictionary<string,object>(); }
    }
}
class ContractTests
{
    static int checks;
    static void Check(bool value,string name) { checks++; if(!value) throw new Exception(name); }
    static void Reject(Action action,string name) { bool rejected=false; try { action(); } catch(ArgumentException) { rejected=true; } Check(rejected,name); }
    static JObject Call(Dictionary<string,object> args,Func<Dictionary<string,object>,object> action)
    { return JObject.FromObject(McpToolContract.Execute("las_set_settings",args,action)); }
    static Dictionary<string,object> Patch(string key,object value) { return new Dictionary<string,object>{{key,value}}; }
    static void Main()
    {
        Dictionary<string,object> original=PluginSettings.Read();
        Check(original.Count==33,"all preference keys");
        List<string> catalog=new List<string>(PluginSettings.RuntimeProperties());
        foreach(PropertyInfo p in typeof(RuntimeConfig).GetProperties(BindingFlags.Static|BindingFlags.Public))
            if(p.CanWrite) Check(catalog.Contains(p.Name),"runtime preference covered: "+p.Name);
        JObject domain=JObject.FromObject(PluginSettings.Describe()), native=JObject.Parse(SettingsSchema.Patch);
        ((JObject)native["properties"]).Remove("request_id"); ((JObject)native["properties"]).Remove("expected_context");
        Check(JToken.DeepEquals(domain,native),"native schema exactly matches authoritative catalog");
        foreach(string key in original.Keys)
        { PluginSettings.Apply(Patch(key,original[key])); Check(PluginSettings.Read()[key].Equals(original[key]),"roundtrip "+key); }
        Reject(()=>PluginSettings.Apply(Patch("spline_sigma",Double.NaN)),"NaN");
        Reject(()=>PluginSettings.Apply(Patch("spline_sigma",Double.PositiveInfinity)),"infinity");
        Reject(()=>PluginSettings.Apply(Patch("polynomial_degree",1.5)),"fractional integer");
        Reject(()=>PluginSettings.Apply(Patch("use_spline_filter","true")),"string boolean");
        Reject(()=>PluginSettings.Apply(Patch("max_filter_border",9)),"readonly");
        Reject(()=>PluginSettings.Apply(new Dictionary<string,object>()),"empty patch");
        Reject(()=>PluginSettings.Apply(new Dictionary<string,object>{{"grid_step",2.0},{"spline_sigma",0.0}}),"atomic invalid patch");
        Check(PluginSettings.Read()["grid_step"].Equals(original["grid_step"]),"invalid patch changed no preference");
        LAS_TERRAIN.Settings settings=new LAS_TERRAIN.Settings();
        PluginSettings.Apply(new Dictionary<string,object>{{"ground3d_bin_x",2.5},{"polynomial_degree",2},{"spline_enable_rail_filter",true},{"c_spline_smooth",0.0}});
        Dictionary<string,object> expected=PluginSettings.Read();
        Topomatic.Stg.StgNode storage=new Topomatic.Stg.StgNode();
        ((Topomatic.Stg.IStgSerializable)settings).SaveToStg(storage);
        PluginSettings.Apply(original);
        ((Topomatic.Stg.IStgSerializable)settings).LoadFromStg(storage);
        Check(JToken.DeepEquals(JObject.FromObject(expected),JObject.FromObject(PluginSettings.Read())),"all 33 preferences survive host persistence roundtrip");
        int calls=0;
        Func<Dictionary<string,object>,object> action=args=> { calls++; CalculationTelemetry.Report("collect",0.2); CalculationTelemetry.Report("publish",0.9); return ToolResult.Ok(new {Published=true},"done"); };
        JObject bad=Call(Patch("polynomial_degree",1.5),action);
        Check((string)bad["status"]=="error" && calls==0,"malformed input rejected before action");
        Check(bad["input_schema"]!=null && bad["correct_request"]!=null && bad["next_steps"]!=null,"error recovery contract");
        McpToolContract.Validate(bad["correct_request"]["params"]["arguments"],bad["input_schema"],"example"); Check(true,"corrective example validates");
        JObject empty=Call(Patch("request_id","empty"),action);
        Check((string)empty["status"]=="error" && calls==0,"metadata-only patch rejected");
        Dictionary<string,object> request=new Dictionary<string,object>{{"request_id","test-1"},{"grid_step",2.0}};
        JObject first=Call(request,action), second=Call(request,action);
        Check(calls==1 && (bool)second["replayed"],"same write ID replays without executing");
        Check((string)first["operation_id"]==(string)second["operation_id"],"stable operation identity");
        Check((string)first["operation"]["state"]=="completed" && ((JArray)first["operation"]["stage_events"]).Count==5,"actual stage events");
        request["grid_step"]=3.0;
        Check((string)Call(request,action)["status"]=="error" && calls==1,"reused ID with different arguments rejected");
        request=new Dictionary<string,object>{{"grid_step",2.0},{"expected_context",new String('0',64)}};
        Check((string)Call(request,action)["status"]=="error" && calls==1,"stale context rejected before action");
        JObject failed=Call(Patch("grid_step",2.0),args=> { throw new System.IO.IOException("fixture failure"); });
        Check((string)failed["operation"]["state"]=="failed" && (string)failed["error"]["mutation_state"]=="inspect_context_before_retry","uncertain apply failure preserved");
        JObject cancelled=Call(Patch("grid_step",2.0),args=>ToolResult.Ok(new {Cancelled=true},"cancelled"));
        Check((string)cancelled["status"]=="cancelled","user cancellation is terminal cancellation");
        JObject noOutput=Call(Patch("grid_step",2.0),args=>ToolResult.Ok(new {Published=false},"empty"));
        Check((string)noOutput["status"]=="no_output","empty export does not claim output");
        Check(McpToolContract.Fingerprint(JObject.Parse("{\"b\":2,\"a\":1}"))==McpToolContract.Fingerprint(JObject.Parse("{\"a\":1,\"b\":2}")),"canonical fingerprint");
        int observed=0; IDisposable old=CalculationTelemetry.Observe((s,p)=>observed++); old.Dispose();
        using(CalculationTelemetry.Observe((s,p)=>observed++)) { old.Dispose(); CalculationTelemetry.Report("x",1); }
        Check(observed==1,"disposed subscriber cannot clear newer observer");
        using(CalculationTelemetry.Observe((s,p)=> { throw new Exception("telemetry failure"); })) CalculationTelemetry.Report("publish",1);
        Check(true,"telemetry cannot fail committed calculation");
        for(int i=0;i<70;i++) Call(Patch("grid_step",2.0),action);
        Check(JArray.FromObject(OperationLedger.History()).Count==64,"bounded operation history");
        // ── section visual tools (docs/MCP_SECTION_VISUAL.md) ──
        List<string> advertised=new List<string>();
        foreach(object entry in (System.Collections.IEnumerable)McpToolContract.Catalog())
            advertised.Add((string)((Dictionary<string,object>)entry)["name"]);
        Check(advertised.Contains("las_render_section")&&advertised.Contains("las_preview_section_polygon")
            &&advertised.Contains("las_delete_section_points"),"section visual tools advertised");
        Check(advertised.Count==5,"harness catalog: two fixture tools plus three section visual tools");
        Check(McpToolContract.Definition("las_render_section").ReadOnlyHint
            &&McpToolContract.Definition("las_preview_section_polygon").ReadOnlyHint,"section render/preview are read-only");
        Check(McpToolContract.Definition("las_delete_section_points").DestructiveHint,"section delete is destructive");
        string[] sectionToolNames={"las_render_section","las_preview_section_polygon","las_delete_section_points"};
        JObject[] sectionSchemas=new JObject[3];
        for(int i=0;i<sectionToolNames.Length;i++)
        {
            sectionSchemas[i]=JObject.Parse(McpToolContract.Definition(sectionToolNames[i]).InputSchema);
            Check((bool)sectionSchemas[i]["additionalProperties"]==false,sectionToolNames[i]+" closed schema");
            Check(sectionSchemas[i]["properties"]["request_id"]!=null
                &&sectionSchemas[i]["properties"]["expected_context"]!=null,sectionToolNames[i]+" request metadata");
        }
        McpToolContract.Validate(JObject.Parse("{\"station\":1234.5,\"thickness\":0.4,\"max_points\":10}"),sectionSchemas[0],"render");
        Check(true,"render accepts station+thickness");
        Reject(()=>McpToolContract.Validate(JObject.Parse("{\"station\":-1,\"thickness\":0.4}"),sectionSchemas[0],"render"),"render rejects negative station");
        Reject(()=>McpToolContract.Validate(JObject.Parse("{\"station\":1,\"thickness\":0}"),sectionSchemas[0],"render"),"render rejects zero thickness");
        Reject(()=>McpToolContract.Validate(JObject.Parse("{\"station\":1}"),sectionSchemas[0],"render"),"render requires thickness");
        Reject(()=>McpToolContract.Validate(JObject.Parse("{\"station\":1,\"thickness\":0.4,\"colour\":\"red\"}"),sectionSchemas[0],"render"),"render rejects unknown field");
        McpToolContract.Validate(JObject.Parse("{\"station\":10,\"thickness\":0.4,\"polygons\":[[[1,2],[3,4],[5,6]]]}"),sectionSchemas[1],"preview");
        Check(true,"preview accepts triangle polygon");
        Reject(()=>McpToolContract.Validate(JObject.Parse("{\"station\":10,\"thickness\":0.4,\"polygons\":[[[1,2],[3,4]]]}"),sectionSchemas[1],"preview"),"preview rejects two-vertex polygon");
        Reject(()=>McpToolContract.Validate(JObject.Parse("{\"station\":10,\"thickness\":0,\"polygons\":[[[1,2],[3,4],[5,6]]]}"),sectionSchemas[1],"preview"),"preview rejects zero thickness");
        Reject(()=>McpToolContract.Validate(JObject.Parse("{\"station\":10,\"thickness\":0.4,\"depth\":1.2,\"polygons\":[[[1,2],[3,4],[5,6]]]}"),sectionSchemas[1],"preview"),"preview rejects depth: single thickness parameter only");
        Reject(()=>McpToolContract.Validate(JObject.Parse("{\"station\":10,\"thickness\":0.4}"),sectionSchemas[1],"preview"),"preview requires polygons");
        McpToolContract.Validate(JObject.Parse("{\"output_path\":\"D:\\\\exports\\\\cleaned.las\",\"sections\":[{\"station\":10,\"thickness\":1.2,\"polygons\":[[[1,2],[3,4],[5,6]]]}]}"),sectionSchemas[2],"delete");
        Check(true,"delete accepts one section");
        Reject(()=>McpToolContract.Validate(JObject.Parse("{\"output_path\":\"D:\\\\e.las\",\"sections\":[]}"),sectionSchemas[2],"delete"),"delete rejects empty sections");
        Reject(()=>McpToolContract.Validate(JObject.Parse("{\"output_path\":\"D:\\\\e.las\",\"sections\":[{\"station\":10,\"polygons\":[[[1,2],[3,4],[5,6]]]}]}"),sectionSchemas[2],"delete"),"delete requires thickness per section");
        Reject(()=>McpToolContract.Validate(JObject.Parse("{\"output_path\":\"D:\\\\e.las\",\"sections\":[{\"station\":-5,\"thickness\":1,\"polygons\":[[[1,2],[3,4],[5,6]]]}]}"),sectionSchemas[2],"delete"),"delete rejects negative section station");
        Reject(()=>McpToolContract.Validate(JObject.Parse("{\"output_path\":\"D:\\\\e.las\",\"sections\":[{\"station\":10,\"thickness\":1,\"polygons\":[[[1,2],[3,4],[5,6]]],\"extra\":1}]}"),sectionSchemas[2],"delete"),"delete rejects unknown section field");
        string sectionDir=System.IO.Path.Combine(System.IO.Path.GetTempPath(),"RoboLasSectionContractTests");
        LasSectionVisualTools sectionTools=new LasSectionVisualTools();
        JObject renderRun=JObject.FromObject(sectionTools.RenderSection(new Dictionary<string,object>{
            {"station",10.0},{"thickness",0.4},{"width_px",320},{"height_px",240},{"max_points",5},
            {"include_points_file",true},{"output_dir",sectionDir}}));
        Check((string)renderRun["status"]=="ok","render tool executes end to end");
        Check(System.IO.File.Exists((string)renderRun["result"]["points_file"]),"render writes points.json");
        Check(System.IO.File.Exists((string)renderRun["result"]["image"]["path"]),"render writes png");
        JObject previewRun=JObject.FromObject(sectionTools.PreviewSectionPolygon(new Dictionary<string,object>{
            {"station",10.0},{"thickness",0.4},{"width_px",320},{"height_px",240},
            {"output_dir",sectionDir},{"polygons",JArray.Parse("[[[1,2],[3,4],[5,6]]]")}}));
        Check((string)previewRun["status"]=="ok"&&(long)previewRun["result"]["matched_points"]==7,"preview executes with dry-run counts");
        Check(System.IO.File.Exists((string)previewRun["result"]["image"]["path"]),"preview writes png with polygon overlay");
        Check(((JArray)previewRun["result"]["polygons_counts"]).Count==1,"preview reports per-polygon counts");
        JObject deleteRun=JObject.FromObject(sectionTools.DeleteSectionPoints(new Dictionary<string,object>{
            {"output_path",System.IO.Path.Combine(sectionDir,"cleaned.las")},
            {"sections",JArray.Parse("[{\"station\":10,\"thickness\":1.2,\"polygons\":[[[1,2],[3,4],[5,6]]]}]")}}));
        Check((string)deleteRun["status"]=="ok"&&(long)deleteRun["result"]["deleted"]==7,"delete executes against fixture facade");
        Check((int)deleteRun["result"]["per_section"][0]["index"]==0,"delete reports per-section counts");
        Console.WriteLine("PASS "+checks+" settings, persistence, harness and section visual contracts");
    }
}
