$ErrorActionPreference = 'Stop'
$root = (Resolve-Path (Join-Path $PSScriptRoot '../..')).Path
$out = Join-Path $root 'build/.verification/section-renderer'
New-Item -ItemType Directory -Path $out -Force | Out-Null
$roslyn = 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\Roslyn\csc.exe'
if (-not (Test-Path -LiteralPath $roslyn)) { $roslyn = "$env:WINDIR\Microsoft.NET\Framework\v4.0.30319\csc.exe" }
$sources = @('Mcp/SectionImageRenderer.cs', 'Automation/LasAutomationSectionVisualDtos.cs', 'tests/Mcp/SectionRendererTests.cs')
Push-Location $root
try {
  $sources = @($sources | ForEach-Object { (Join-Path $root $_).Replace('/', '\') })
  & $roslyn /nologo /target:exe "/out:$out/SectionRendererTests.exe" /r:System.Drawing.dll $sources
  if ($LASTEXITCODE -ne 0) { throw 'Section renderer compilation failed' }
  & "$out/SectionRendererTests.exe"
  if ($LASTEXITCODE -ne 0) { throw 'Section renderer tests failed' }
} finally { Pop-Location }
