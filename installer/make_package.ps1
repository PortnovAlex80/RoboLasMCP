# make_package.ps1
# Сборка дистрибутива RoboLas + MCP-адаптера в один zip:
#   dist\RoboLas-MCP-<версия>.zip
# Внутри: install.cmd/uninstall.cmd, Install-RoboLas.ps1, README, files\*.
# Перед запуском соберите оба проекта (LAS_TERRAIN.csproj и Mcp\LasTerrain.Mcp.csproj).
param(
    [string]$Configuration = 'Release',
    [string]$TopomaticPath = '',
    [switch]$AllIcons
)

$ErrorActionPreference = 'Stop'
$root = Split-Path -Parent $PSScriptRoot   # LAS_TERRAIN\
$mainOut = Join-Path $root "bin\$Configuration"
$mcpOut = Join-Path $root "Mcp\bin\$Configuration"

# ── проверка сборок ──
$mainDll = Join-Path $mainOut 'LAS_TERRAIN.dll'
$mcpDll = Join-Path $mcpOut 'LAS_TERRAIN.MCP.dll'
foreach ($f in @(
        $mainDll,
        (Join-Path $root 'LAS_TERRAIN.plugin'),
        $mcpDll,
        (Join-Path $root 'Mcp\LAS_TERRAIN.MCP.plugin')
    )) {
    if (-not (Test-Path $f)) { throw "Не найден $f — сначала соберите оба проекта (см. docs/MCP_INTEGRATION.md)." }
}

$version = [System.Diagnostics.FileVersionInfo]::GetVersionInfo($mainDll).FileVersion
if (-not $version) { $version = '0.0.0.0' }

# ── рабочая папка пакета ──
$pkgName = "RoboLas-MCP-$version"
$work = Join-Path $env:TEMP ("pkg_" + [Guid]::NewGuid().ToString('N'))
$filesDir = Join-Path $work 'files'
$iconsDir = Join-Path $filesDir 'icons'
New-Item -ItemType Directory -Path $iconsDir -Force | Out-Null

Copy-Item $mainDll $filesDir
Copy-Item (Join-Path $root 'LAS_TERRAIN.plugin') $filesDir
Copy-Item $mcpDll $filesDir
Copy-Item (Join-Path $root 'Mcp\LAS_TERRAIN.MCP.plugin') $filesDir

# pdb — опционально (стектрейсы у пользователя)
if (Test-Path (Join-Path $mainOut 'LAS_TERRAIN.pdb')) { Copy-Item (Join-Path $mainOut 'LAS_TERRAIN.pdb') $filesDir }
if (Test-Path (Join-Path $mcpOut 'LAS_TERRAIN.MCP.pdb')) { Copy-Item (Join-Path $mcpOut 'LAS_TERRAIN.MCP.pdb') $filesDir }

# иконки: только те, на которые ссылается LAS_TERRAIN.plugin (хост ищет по имени
# в <Robur>\icons\). -AllIcons — положить весь RobolasIcons (плоско).
$iconSources = Join-Path $root 'RobolasIcons'
if (-not (Test-Path $iconSources)) { throw "Не найден каталог иконок: $iconSources" }
$allIconFiles = Get-ChildItem $iconSources -Recurse -Filter '*.png'
$byName = @{}
foreach ($icf in $allIconFiles) { if (-not $byName.ContainsKey($icf.Name)) { $byName[$icf.Name] = $icf.FullName } }
$count = 0
if ($AllIcons) {
    foreach ($pair in $byName.GetEnumerator()) {
        Copy-Item $pair.Value (Join-Path $iconsDir $pair.Key) -Force
        $count++
    }
} else {
    # собираем имена иконок из манифеста (все свойства "icon": "имя")
    $manifestJson = Get-Content (Join-Path $root 'LAS_TERRAIN.plugin') -Raw -Encoding UTF8 | ConvertFrom-Json
    $wanted = New-Object System.Collections.Generic.HashSet[string]
    function Walk-Icons($node) {
        if ($null -eq $node) { return }
        if ($node -is [System.Management.Automation.PSCustomObject]) {
            foreach ($p in $node.PSObject.Properties) {
                if ($p.Name -eq 'icon' -and $p.Value) { $null = $wanted.Add([string]$p.Value) }
                else { Walk-Icons $p.Value }
            }
        } elseif ($node -is [System.Collections.IEnumerable] -and $node -isnot [string]) {
            foreach ($item in $node) { Walk-Icons $item }
        }
    }
    Walk-Icons $manifestJson
    $missing = @()
    foreach ($name in ($wanted | Sort-Object)) {
        # манифест ссылается на базовое имя; физические файлы — варианты
        # <base>_16dp_1x.png … <base>_32dp_3x.png (+ возможен точный <base>.png)
        $variantPattern = '^' + [regex]::Escape($name) + '(_|$)'
        $variants = @($allIconFiles | Where-Object { $_.BaseName -match $variantPattern })
        if ($variants.Count -gt 0) {
            foreach ($v in $variants) {
                Copy-Item $v.FullName (Join-Path $iconsDir $v.Name) -Force
                $count++
            }
        } else {
            $missing += $name
        }
    }
    if ($missing.Count -gt 0) {
        throw ("В RobolasIcons нет иконок, на которые ссылается манифест: " + ($missing -join ', '))
    }
}

# манифест файлов пакета (деинсталлятор использует его, если нет манифеста в установке)
$manifest = New-Object System.Collections.Generic.List[string]
$manifest.Add('LAS_TERRAIN.dll')
$manifest.Add('LAS_TERRAIN.plugin')
$manifest.Add('LAS_TERRAIN.MCP.dll')
$manifest.Add('LAS_TERRAIN.MCP.plugin')
if (Test-Path (Join-Path $filesDir 'LAS_TERRAIN.pdb')) { $manifest.Add('LAS_TERRAIN.pdb') }
if (Test-Path (Join-Path $filesDir 'LAS_TERRAIN.MCP.pdb')) { $manifest.Add('LAS_TERRAIN.MCP.pdb') }
Get-ChildItem $iconsDir -Filter '*.png' | ForEach-Object { $manifest.Add('icons\' + $_.Name) }
$manifest | Set-Content (Join-Path $filesDir 'files.manifest') -Encoding UTF8

# скрипты установки + readme (имя файла — ASCII: PS5.1 Compress-Archive
# портит кириллицу в именах записей zip; содержимое README — на русском)
Copy-Item (Join-Path $PSScriptRoot 'Install-RoboLas.ps1') $work
Copy-Item (Join-Path $PSScriptRoot 'install.cmd') $work
Copy-Item (Join-Path $PSScriptRoot 'uninstall.cmd') $work
Copy-Item (Join-Path $PSScriptRoot 'README-УСТАНОВКА.txt') (Join-Path $work 'README-INSTALL.txt')

# демо-промпты для показа возможностей MCP (вставляются в MCP-клиент)
$demoSource = Join-Path $root 'demo\ROBOLAS-MCP-DEMO.md'
if (Test-Path $demoSource) { Copy-Item $demoSource (Join-Path $work 'DEMO.md') }

# версия в имя файла манифеста удаления берётся из пакета; записываем и версию пакета
("RoboLas-MCP $version; собран {0}" -f (Get-Date -Format 'yyyy-MM-dd HH:mm')) |
    Set-Content (Join-Path $work 'VERSION.txt') -Encoding UTF8

# ── zip ──
$dist = Join-Path (Split-Path -Parent $root) 'dist'
if (-not (Test-Path $dist)) { New-Item -ItemType Directory -Path $dist -Force | Out-Null }
$zip = Join-Path $dist ($pkgName + '.zip')
if (Test-Path $zip) { Remove-Item $zip -Force }
Compress-Archive -Path (Join-Path $work '*') -DestinationPath $zip
Remove-Item $work -Recurse -Force

Write-Host ("Пакет собран: {0}" -f $zip)
Write-Host ("  версия LAS_TERRAIN: {0}; иконок: {1}; файлов: {2}" -f $version, $count, $manifest.Count)
exit 0
