using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Topomatic.ToolBridge;

namespace LAS_TERRAIN.Mcp
{
    internal sealed class LasHarnessTools : ToolProvider
    {
        [ToolDef(Name="las_get_capabilities", Description="RoboLas free edition: harness contract, schemas and native bridge limitations.", InputSchema = @"{""type"":""object"",""properties"":{""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""additionalProperties"":false}", ReadOnlyHint=true, IdempotentHint=true)]
        public object Capabilities(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_get_capabilities", args, CapabilitiesCore);
        }

        private object CapabilitiesCore(Dictionary<string, object> args)
        {
            return ToolResult.Ok(new { product="RoboLas MCP Free", contract_version="1.0", edition="free",
                execution_mode="native_synchronous", live_polling=false, agent_cancellation=false,
                preserves_source_rgb=true, rgb_export_status="native_record_rgb; host_ui_e2e_pending",
                rgb_channel_bits=16, rgb_operations=new[]{"reduce","ground_reduce","split","polygon_delete_plan","polygon_delete_crs"},
                rgb_source_binding="loaded Robur LidarBuffer: texture or legacy clrs; exact indexer and point index",
                rgb_native_channel_bits=8, rgb_las_normalization="8-bit channel << 8 (ASPRS)",
                rgb_ambiguity_policy="no coordinate joins; malformed or mixed color availability rejected",
                user_cancellation="Robur progress dialog; see operation result", history_limit=64,
                replay_scope="request_id, completed writes retained in this process only; never blindly retry after timeout",
                native_error_boundary="Bridge startup, dispatch and transport errors are outside this extension",
                tools=McpToolContract.Catalog() }, "Discover tools, preflight, execute, then inspect the operation.",
                ToolResult.Step("las_get_context","Read active project and alignment.",ToolResult.NoArgs()));
        }
        [ToolDef(Name="las_preflight", Description="Validate a RoboLas request and capture project/settings fingerprint without executing it. Does not guarantee SDK execution or file writability.", InputSchema = @"{""type"":""object"",""properties"":{""tool"":{""type"":""string"",""minLength"":1},""arguments"":{""type"":""object""},""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""tool"",""arguments""],""additionalProperties"":false}", ReadOnlyHint=true, IdempotentHint=true)]
        public object Preflight(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_preflight", args, PreflightCore);
        }

        private object PreflightCore(Dictionary<string, object> args)
        {
            string tool=(string)args["tool"];
            JObject input=(JObject)args["arguments"];
            McpToolContract.Validate(input,JObject.Parse(McpToolContract.Definition(tool).InputSchema),"arguments");
            string fingerprint=McpToolContract.ContextFingerprint();
            JObject next=(JObject)input.DeepClone(); next["expected_context"]=fingerprint;
            return ToolResult.Ok(new { validated=true, expected_context=fingerprint,
                checks=new string[] {"argument_schema","project_settings_snapshot"},
                @unchecked=new string[] {"SDK_execution","output_file_writability","source_RGB_availability"} },
                "Bind a unique request_id when invoking a write.",ToolResult.Step(tool,"Execute after reviewing context and output paths.",next));
        }
        [ToolDef(Name="las_get_operation", Description="Read a completed calculation by operation_id or request_id; native bridge cannot poll during a blocking calculation.", InputSchema = @"{""type"":""object"",""properties"":{""id"":{""type"":""string"",""minLength"":1},""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""id""],""additionalProperties"":false}", ReadOnlyHint=true, IdempotentHint=true)]
        public object Operation(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_get_operation", args, OperationCore);
        }

        private object OperationCore(Dictionary<string, object> args)
        { return ToolResult.Ok(OperationLedger.Get((string)args["id"]),"Process-local operation history."); }
        [ToolDef(Name="las_list_operations", Description="List up to 64 retained RoboLas writes/calculations in this Robur process.", InputSchema = @"{""type"":""object"",""properties"":{""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""additionalProperties"":false}", ReadOnlyHint=true, IdempotentHint=true)]
        public object Operations(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_list_operations", args, OperationsCore);
        }

        private object OperationsCore(Dictionary<string, object> args)
        { return ToolResult.Ok(OperationLedger.History(),"Process-local bounded history."); }
    }
}
