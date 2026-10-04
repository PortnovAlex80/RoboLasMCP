"""Check the schemas actually advertised by native provider attributes."""
from pathlib import Path
import json,re,xml.etree.ElementTree as ET
root=Path(__file__).resolve().parents[2]
tools={}
for path in (root/'Mcp/Tools').glob('*.cs'):
    text=path.read_text(encoding='utf-8')
    for match in re.finditer(r'\[ToolDef\(([\s\S]*?)\)\]\s*public object (\w+)\(Dictionary<string,\s*object> args\)\s*\{([\s\S]*?)\n        \}',text):
        attr,method,body=match.groups()
        name=re.search(r'Name\s*=\s*"([^"]+)"',attr)[1]
        assert name not in tools,name
        assert f'McpToolContract.Execute("{name}", args, {method}Core)' in body,name
        schema=re.search(r'InputSchema\s*=\s*@"((?:[^"]|"")*)"',attr)
        if not schema:
            schema=re.search(r'Patch = @"((?:[^"]|"")*)"',(root/'Mcp/SettingsSchema.cs').read_text(encoding='utf-8'))
        value=json.loads(schema[1].replace('""','"'))
        assert value['additionalProperties'] is False,name
        assert {'request_id','expected_context'}<=value['properties'].keys(),name
        tools[name]=value
assert len(tools)==27,len(tools)
assert 'new LasHarnessTools()' in (root/'Mcp/LasMcpModule.cs').read_text(encoding='utf-8')
# Live bridge registration must mirror the contract catalog: every provider in
# McpToolContract.Providers must also be instantiated in Module.GenerateTools
# (the broadcast handler that feeds robur-mcp). A drift once shipped 26
# advertised tools with only 23 actually registered.
contract=(root/'Mcp/McpToolContract.cs').read_text(encoding='utf-8')
module=(root/'Mcp/LasMcpModule.cs').read_text(encoding='utf-8')
def providers(text):
    array=re.search(r'Type\[\]\s+Providers\s*=\s*\{([^}]*)\}',text)
    assert array,'McpToolContract.Providers array not found'
    return set(re.findall(r'typeof\((\w+)\)',array[1]))
def registered(text):
    return set(re.findall(r'new (\w+)\(\)',text))
missing=providers(contract)-registered(module)
assert not missing,('providers not registered in Module.GenerateTools: ',missing)
print('PASS 27 native schemas/wrappers; Module.GenerateTools registers every contract provider')
