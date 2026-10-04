using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using LAS_TERRAIN.Automation;
using LAS_TERRAIN.Infrastructure;
using Topomatic.ToolBridge;

namespace LAS_TERRAIN.Mcp
{
    // Contract applies only after the native bridge dispatches a RoboLas tool.
    internal static class McpToolContract
    {
        private static readonly Type[] Providers = { typeof(LasContextTools), typeof(LasSettingsTools),
            typeof(LasTerrainTools), typeof(LasExportTools), typeof(LasPolygonTools), typeof(LasHarnessTools),
            typeof(LasSectionVisualTools) };
        private static readonly object Dispatch = new object();
        internal static ToolDefAttribute Definition(string name)
        {
            foreach (Type type in Providers)
                foreach (MethodInfo method in type.GetMethods())
                {
                    ToolDefAttribute def = Attribute.GetCustomAttribute(method, typeof(ToolDefAttribute)) as ToolDefAttribute;
                    if (def != null && def.Name == name) return def;
                }
            throw new ArgumentException("Unknown RoboLas tool: " + name);
        }
        internal static object Catalog()
        {
            List<object> list = new List<object>();
            foreach (Type type in Providers)
                foreach (MethodInfo method in type.GetMethods())
                {
                    ToolDefAttribute def = Attribute.GetCustomAttribute(method, typeof(ToolDefAttribute)) as ToolDefAttribute;
                    if (def != null) list.Add(new Dictionary<string,object> {
                        {"name",def.Name},{"description",def.Description},{"input_schema",JObject.Parse(def.InputSchema)},
                        {"read_only",def.ReadOnlyHint},{"destructive",def.DestructiveHint} });
                }
            return list;
        }
        internal static void Validate(JToken value, JToken schema, string path)
        {
            string type = (string)schema["type"];
            bool valid = type == "object" ? value is JObject : type == "array" ? value is JArray :
                type == "string" ? value.Type == JTokenType.String : type == "boolean" ? value.Type == JTokenType.Boolean :
                type == "integer" ? value.Type == JTokenType.Integer : type == "number" ?
                value.Type == JTokenType.Integer || value.Type == JTokenType.Float : type == null;
            if (!valid) throw new ArgumentException(path + ": expected " + type + ".");
            if (schema["enum"] != null)
            {
                bool found = false;
                foreach (JToken item in schema["enum"]) if (JToken.DeepEquals(item,value)) found = true;
                if (!found) throw new ArgumentException(path + ": use one of " + schema["enum"].ToString(Formatting.None));
            }
            if (type == "number" || type == "integer")
            {
                double n = (double)value;
                if (Double.IsNaN(n) || Double.IsInfinity(n)) throw new ArgumentException(path + ": finite number required.");
                if (schema["minimum"] != null && n < (double)schema["minimum"] ||
                    schema["maximum"] != null && n > (double)schema["maximum"] ||
                    schema["exclusiveMinimum"] != null && n <= (double)schema["exclusiveMinimum"])
                    throw new ArgumentException(path + ": outside supported range.");
            }
            if (type == "string" && schema["minLength"] != null && ((string)value).Length < (int)schema["minLength"])
                throw new ArgumentException(path + ": string is too short.");
            if (type == "array")
            {
                JArray array = (JArray)value;
                if (schema["minItems"] != null && array.Count < (int)schema["minItems"] ||
                    schema["maxItems"] != null && array.Count > (int)schema["maxItems"])
                    throw new ArgumentException(path + ": invalid array length.");
                if (schema["items"] != null)
                    for (int i=0;i<array.Count;i++) Validate(array[i],schema["items"],path+"["+i+"]");
            }
            if (type == "object")
            {
                JObject obj = (JObject)value;
                if (schema["minProperties"] != null && obj.Count < (int)schema["minProperties"])
                    throw new ArgumentException(path + ": empty patch is not allowed.");
                if (schema["required"] != null)
                    foreach (JToken required in schema["required"])
                        if (obj[(string)required] == null) throw new ArgumentException(path + ": missing " + (string)required);
                JObject properties = schema["properties"] as JObject;
                foreach (JProperty property in obj.Properties())
                {
                    JToken field = properties == null ? null : properties[property.Name];
                    if (field != null) Validate(property.Value,field,path+"."+property.Name);
                    else if (schema["additionalProperties"] != null && schema["additionalProperties"].Type == JTokenType.Boolean && !(bool)schema["additionalProperties"])
                        throw new ArgumentException(path + ": unknown field " + property.Name);
                }
            }
        }
        private static JToken Ordered(JToken value)
        {
            JObject obj=value as JObject;
            if(obj!=null) { List<string> keys=new List<string>(); foreach(JProperty p in obj.Properties()) keys.Add(p.Name);
                keys.Sort(StringComparer.Ordinal); JObject ordered=new JObject(); foreach(string key in keys) ordered[key]=Ordered(obj[key]); return ordered; }
            JArray array=value as JArray;
            if(array!=null) { JArray ordered=new JArray(); foreach(JToken item in array) ordered.Add(Ordered(item)); return ordered; }
            return value.DeepClone();
        }
        internal static string Fingerprint(object value)
        {
            string json=Ordered(JToken.FromObject(value)).ToString(Formatting.None);
            using(SHA256 sha=SHA256.Create()) return BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(json))).Replace("-","").ToLowerInvariant();
        }
        internal static string ContextFingerprint()
        { return Fingerprint(new { context=LasAutomation.GetContext(), settings=PluginSettings.Read() }); }
        private static JToken Example(JToken schema)
        {
            if(schema["enum"]!=null) return schema["enum"][0].DeepClone();
            string type=(string)schema["type"];
            if(type=="object") { JObject result=new JObject(); JToken props=schema["properties"];
                if(schema["required"]!=null) foreach(JToken key in schema["required"]) result[(string)key]=Example(props[(string)key]);
                if(result.Count==0 && schema["minProperties"]!=null && props!=null) foreach(JProperty p in ((JObject)props).Properties()) { result[p.Name]=Example(p.Value); break; }
                return result; }
            if(type=="array") { JArray result=new JArray(); int count=schema["minItems"]==null?0:(int)schema["minItems"]; for(int i=0;i<count;i++) result.Add(Example(schema["items"])); return result; }
            if(type=="boolean") return new JValue(false);
            if(type=="number" || type=="integer") { double n=schema["minimum"]==null?1:(double)schema["minimum"]; if(schema["exclusiveMinimum"]!=null) n=(double)schema["exclusiveMinimum"]+1; return type=="integer"?new JValue((long)n):new JValue(n); }
            return new JValue("REPLACE_WITH_PROJECT_VALUE");
        }
        internal static Dictionary<string,object> Error(string tool, Exception error, bool started)
        {
            JObject schema=JObject.Parse(Definition(tool).InputSchema);
            JObject example=(JObject)Example(schema);
            if(example["vertices"]!=null) example["vertices"]=JArray.Parse("[[0,0],[10,0],[10,10]]");
            if(example["output_path"]!=null) example["output_path"]=@"D:\exports\result.las";
            if(example["thickness"]!=null) example["thickness"]=0.25;
            return new Dictionary<string,object> {
                {"schema_version","1.0"},{"status","error"},
                {"error",new { code=error is ArgumentException?"invalid_request":"operation_failed", message=error.Message,
                    retryable=false, mutation_state=started?"inspect_context_before_retry":"not_started" }},
                {"input_schema",schema},{"correct_request",new { method="tools/call", @params=new { name=tool, arguments=example } }},
                {"requires_binding",true},{"next_steps",new object[] {ToolResult.Step("las_get_context","Inspect project state and bind the request example to actual project data.",ToolResult.NoArgs())}}
            };
        }
        internal static object Execute(string tool, Dictionary<string,object> args, Func<Dictionary<string,object>,object> action)
        {
            lock(Dispatch)
            {
                OperationLedger.Run run=null; bool started=false;
                try
                {
                    ToolDefAttribute def=Definition(tool);
                    JObject input=JObject.FromObject(args ?? new Dictionary<string,object>());
                    Validate(input,JObject.Parse(def.InputSchema),"arguments");
                    string requestId=(string)input["request_id"], expected=(string)input["expected_context"];
                    input.Remove("request_id"); input.Remove("expected_context");
                    if(tool=="las_set_settings" && input.Count==0) throw new ArgumentException("Provide at least one setting.");
                    string signature=Fingerprint(new { tool=tool, arguments=input, expected_context=expected });
                    if(requestId!=null)
                    {
                        OperationLedger.Run old=OperationLedger.FindRequest(requestId);
                        if(old!=null) { if(old.Signature!=signature) throw new ArgumentException("request_id already belongs to a different request.");
                            if(old.Response==null) throw new InvalidOperationException("Request is still active.");
                            JObject cached=JObject.Parse(old.Response); cached["replayed"]=true; return cached; }
                    }
                    // Observe calculations and writes; history/discovery calls do not evict calculation history.
                    if(!def.ReadOnlyHint) { run=OperationLedger.Start(tool,requestId,signature,true);
                        run.Arguments=input.DeepClone(); run.Settings=PluginSettings.Read(); }
                    if(expected!=null) { string actual=ContextFingerprint(); if(run!=null) run.Context=actual;
                        if(expected!=actual) throw new ArgumentException("Project or settings changed since preflight; obtain a new expected_context."); }
                    Dictionary<string,object> clean=new Dictionary<string,object>();
                    foreach(JProperty p in input.Properties()) { JValue value=p.Value as JValue; clean[p.Name]=value==null?(object)p.Value:value.Value; }
                    if(run!=null) { run.State="running"; OperationLedger.Stage(run,"execute",0.05); }
                    object result;
                    using(CalculationTelemetry.Observe((stage,progress)=> { if(run!=null) OperationLedger.Stage(run,stage,progress); }))
                    { started=!def.ReadOnlyHint; result=action(clean); }
                    Dictionary<string,object> response=result as Dictionary<string,object>;
                    if(response==null) response=ToolResult.Ok(result,"Completed.");
                    response["schema_version"]="1.0";
                    string state="completed"; object payload;
                    if(response.TryGetValue("result",out payload) && payload!=null)
                    { JToken dto=JToken.FromObject(payload); if(dto is JObject) {
                        if((bool?)dto["Cancelled"]==true) state="cancelled";
                        else if((bool?)dto["Published"]==false) state="no_output"; } }
                    response["status"]=state=="completed"?"ok":state;
                    if(run!=null) OperationLedger.Finish(run,response,state);
                    return response;
                }
                catch(Exception error)
                {
                    Dictionary<string,object> response=Error(tool,error,started);
                    if(run!=null) OperationLedger.Finish(run,response,"failed");
                    return response;
                }
            }
        }
    }
}
