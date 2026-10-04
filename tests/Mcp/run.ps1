$ErrorActionPreference='Stop'
$root=(Resolve-Path (Join-Path $PSScriptRoot '../..')).Path
$out=Join-Path $root 'build/.verification/mcp-contract'
New-Item -ItemType Directory -Path $out -Force | Out-Null
$json='C:\Program Files\Topomatic Robur Rail 16.0\Newtonsoft.Json.dll'
Copy-Item -LiteralPath $json -Destination $out -Force
$sources=@('tests/Mcp/ContractTests.cs','Mcp/McpToolContract.cs','Mcp/OperationLedger.cs','Mcp/SettingsSchema.cs',
  'Automation/PluginSettings.cs','Infrastructure/CalculationTelemetry.cs','Infrastructure/RuntimeConfig.cs',
  'Infrastructure/GraphGround3DSettingsAdapter.cs','Domain/Models/GraphGround3DOptions.cs',
  'Domain/Models/PlanSurfaceSettings.cs','Domain/Models/FilterOperationSnapshot.cs','LaunchSettings/Settings.cs',
  'Mcp/Tools/LasSectionVisualTools.cs','Mcp/SectionImageRenderer.cs','Automation/LasAutomationSectionVisualDtos.cs')
Push-Location $root
try {
  $sources=@($sources | ForEach-Object { (Join-Path $root $_).Replace('/','\') })
  & "$env:WINDIR\Microsoft.NET\Framework\v4.0.30319\csc.exe" /nologo /target:exe "/out:$out/ContractTests.exe" "/r:$json" /r:System.Drawing.dll $sources
  if($LASTEXITCODE -ne 0) { throw 'Contract compilation failed' }
  & "$out/ContractTests.exe"
  if($LASTEXITCODE -ne 0) { throw 'Contract tests failed' }
} finally { Pop-Location }
