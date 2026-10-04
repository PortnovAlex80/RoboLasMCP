# Install-RoboLas.ps1
# Установщик/деинсталлятор плагина RoboLas (LAS_TERRAIN) + MCP-адаптера
# (LAS_TERRAIN.MCP) для Topomatic Robur.
#
# Предполагается: Robur и плагин robur-mcp пользователь ставит сам
# (robur_mcp-0_1.tpm через Диспетчер пакетов Topomatic). Этот скрипт ставит
# ТОЛЬКО файлы RoboLas: LAS_TERRAIN.dll/.plugin, LAS_TERRAIN.MCP.dll/.plugin,
# иконки -> <Robur>\icons\.
#
# Запуск: install.cmd (интерактивно) или напрямую:
#   powershell -NoProfile -ExecutionPolicy Bypass -File Install-RoboLas.ps1
# Параметры:
#   -Path <каталог Robur>  поставить в указанный каталог (без поиска и меню)
#   -All                   поставить во все найденные установки Robur
#   -Uninstall             удалить RoboLas (вместо установки)
#   -Yes                   без вопросов (тихий режим)
#   -ListOnly              только показать найденные установки и выйти
#   -NoElevate             не пытаться поднимать UAC (для тестов)
param(
    [string]$Path,
    [switch]$All,
    [switch]$Uninstall,
    [switch]$Yes,
    [switch]$ListOnly,
    [switch]$NoElevate
)

$ErrorActionPreference = 'Stop'
$Script:SelfDir = $PSScriptRoot
$Script:FilesDir = Join-Path $SelfDir 'files'
$Script:BackupRoot = Join-Path $env:ProgramData 'RoboLas\backups'
$Script:LogFile = Join-Path $env:ProgramData 'RoboLas\install.log'
$Script:ManifestName = 'RoboLas-MCP.files.txt'
$MinRoburMcpVersion = '16.0.62.12'   # требование robur-mcp 0.1

# ─────────────────────────── базовые функции ───────────────────────────

function Write-Log([string]$Message) {
    try {
        $dir = Split-Path -Parent $Script:LogFile
        if (-not (Test-Path $dir)) { New-Item -ItemType Directory -Path $dir -Force | Out-Null }
        Add-Content -Path $Script:LogFile -Value ("[{0}] {1}" -f (Get-Date -Format 'yyyy-MM-dd HH:mm:ss'), $Message)
    } catch { }
}

function Write-Host2([string]$Message, [string]$Color = 'Gray') {
    Write-Host $Message -ForegroundColor $Color
}

function Test-IsAdmin() {
    $identity = [Security.Principal.WindowsIdentity]::GetCurrent()
    (New-Object Security.Principal.WindowsPrincipal($identity)).IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)
}

function Test-PathWritable([string]$Dir) {
    try {
        $probe = Join-Path $Dir ('.robolas_probe_' + [Guid]::NewGuid().ToString('N'))
        New-Item -ItemType File -Path $probe -ErrorAction Stop | Out-Null
        Remove-Item $probe -Force
        return $true
    } catch { return $false }
}

# ─────────────────────────── поиск Robur ───────────────────────────

function Find-RoburInstallations() {
    $found = New-Object System.Collections.Generic.List[string]

    # 1) стандартные каталоги Program Files
    $roots = @()
    if ($env:ProgramFiles) { $roots += $env:ProgramFiles }
    $x86 = ${env:ProgramFiles(x86)}
    if ($x86) { $roots += $x86 }
    foreach ($root in $roots) {
        Get-ChildItem -Path $root -Directory -Filter 'Topomatic*' -ErrorAction SilentlyContinue |
            ForEach-Object { $found.Add($_.FullName) }
    }

    # 2) реестр (деинсталляционные записи)
    $regPaths = @(
        'HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\*',
        'HKLM:\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\*'
    )
    foreach ($rp in $regPaths) {
        Get-ItemProperty $rp -ErrorAction SilentlyContinue |
            Where-Object { $_.DisplayName -match 'Robur|Topomatic' -and $_.InstallLocation } |
            ForEach-Object {
                $loc = $_.InstallLocation.Trim('"')
                if ($loc -and (Test-Path $loc)) { $found.Add($loc.TrimEnd('\')) }
            }
    }

    # валидация: в каталоге должен лежать Topomatic.ApplicationPlatform.dll
    $valid = $found | Sort-Object -Unique | Where-Object {
        Test-Path (Join-Path $_ 'Topomatic.ApplicationPlatform.dll')
    }
    return @($valid)
}

function Get-RoburVersion([string]$Dir) {
    $dll = Join-Path $Dir 'Topomatic.ApplicationPlatform.dll'
    if (-not (Test-Path $dll)) { return $null }
    try { return [System.Diagnostics.FileVersionInfo]::GetVersionInfo($dll).FileVersion } catch { return $null }
}

# ─────────────────────────── подготовка цели ───────────────────────────

function Get-TargetWarnings([string]$Target) {
    $warnings = @()
    $version = Get-RoburVersion $Target
    if (-not $version) {
        $warnings += 'НЕ УДАЛОСЬ определить версию Robur (нет/не читается Topomatic.ApplicationPlatform.dll).'
    } else {
        try {
            if ([version]$version -lt [version]$MinRoburMcpVersion) {
                $warnings += ("Robur {0} СТАРЕЕ требуемой robur-mcp версии {1}: MCP-тулзы las_* работать НЕ БУДУТ (нужен апгрейд Robur). Плагин RoboLas (меню/команды) продолжит работать." -f $version, $MinRoburMcpVersion)
            }
        } catch {
            $warnings += "Версия Robur не распознана: '$version'. Проверьте вручную (нужно >= $MinRoburMcpVersion для MCP)."
        }
    }
    if (-not (Test-Path (Join-Path $Target 'Topomatic.ToolBridge.dll'))) {
        $warnings += 'robur-mcp НЕ УСТАНОВЛЕН (нет Topomatic.ToolBridge.dll): тулзы las_* не появятся. Поставьте robur_mcp-0_1.tpm через Диспетчер пакетов Topomatic (https://topomatic.ru/plugins-robur/free-plugins-robur/).'
    }
    return $warnings
}

# ─────────────────────────── установка ───────────────────────────

function Invoke-Install([string]$Target) {
    Write-Host2 ("==> Установка RoboLas в: {0}" -f $Target) 'Cyan'

    foreach ($warn in (Get-TargetWarnings $Target)) {
        Write-Host2 ("    ВНИМАНИЕ: {0}" -f $warn) 'Yellow'
    }

    # payload
    $payloadRoot = @(
        'LAS_TERRAIN.dll',
        'LAS_TERRAIN.plugin',
        'LAS_TERRAIN.MCP.dll',
        'LAS_TERRAIN.MCP.plugin'
    )
    foreach ($f in $payloadRoot) {
        if (-not (Test-Path (Join-Path $Script:FilesDir $f))) {
            throw "В пакете нет файла $f (ожидался в '$($Script:FilesDir)'). Пакет повреждён."
        }
    }
    $iconsDir = Join-Path $Script:FilesDir 'icons'
    if (-not (Test-Path $iconsDir)) { throw "В пакете нет папки icons ($iconsDir)." }
    $icons = Get-ChildItem $iconsDir -Filter '*.png'
    if ($icons.Count -eq 0) { throw 'В пакете нет ни одной иконки.' }

    # бэкап существующих файлов RoboLas
    $stamp = Get-Date -Format 'yyyyMMdd-HHmmss'
    $roburName = Split-Path -Leaf $Target
    $backupDir = Join-Path $Script:BackupRoot ("{0}-{1}" -f $stamp, $roburName)
    $backedUp = 0
    foreach ($f in $payloadRoot) {
        $dst = Join-Path $Target $f
        if (Test-Path $dst) {
            if (-not (Test-Path $backupDir)) { New-Item -ItemType Directory -Path $backupDir -Force | Out-Null }
            Copy-Item $dst (Join-Path $backupDir $f) -Force
            $backedUp++
        }
    }
    if ($backedUp -gt 0) {
        Write-Host2 ("    Бэкап предыдущей версии ({0} файл.): {1}" -f $backedUp, $backupDir) 'DarkGray'
    }

    # копирование
    $installed = New-Object System.Collections.Generic.List[string]
    try {
        foreach ($f in $payloadRoot) {
            Copy-Item (Join-Path $Script:FilesDir $f) (Join-Path $Target $f) -Force
            $installed.Add($f)
        }
        $targetIcons = Join-Path $Target 'icons'
        if (-not (Test-Path $targetIcons)) { New-Item -ItemType Directory -Path $targetIcons -Force | Out-Null }
        foreach ($icon in $icons) {
            Copy-Item $icon.FullName (Join-Path $targetIcons $icon.Name) -Force
            $installed.Add('icons\' + $icon.Name)
        }
        # манифест установленных файлов (для корректного удаления)
        $manifestPath = Join-Path $Target $Script:ManifestName
        $installed | Set-Content -Path $manifestPath -Encoding UTF8
        $installed.Add($Script:ManifestName) | Out-Null
    } catch {
        # откат: восстанавливаем бэкап и убираем новое
        Write-Host2 '    ОШИБКА копирования, откат…' 'Red'
        foreach ($rel in $installed) { Remove-Item (Join-Path $Target $rel) -Force -ErrorAction SilentlyContinue }
        if ($backedUp -gt 0 -and (Test-Path $backupDir)) {
            Copy-Item (Join-Path $backupDir '*') $Target -Force
        }
        throw
    }

    # Кэш сборок хоста (%LOCALAPPDATA%\Topomatic\<Robur>\16.0\assemblies) хранит
    # регистрацию плагинов и ПЕРЕЖИВАЕТ обновление DLL: без очистки Robur после
    # обновления продолжает отдавать список команд/тулзов СТАРОЙ версии (девелоперский
    # PreBuildEvent этот же кэш чистит всегда — см. docs/PROJECT_STRUCTURE.md).
    # Кэш полностью регенерируется хостом при старте; очистка не критична для установки.
    try {
        $leaf = Split-Path -Leaf $Target
        $verPart = ($leaf -split '\s+')[-1]
        $flavor = if ($leaf -match 'rail') { 'rail' } elseif ($leaf -match 'road') { 'road' } else { $null }
        $topoLocal = Join-Path $env:LOCALAPPDATA 'Topomatic'
        if ($flavor -and (Test-Path $topoLocal)) {
            foreach ($prod in (Get-ChildItem $topoLocal -Directory -ErrorAction SilentlyContinue)) {
                if ($prod.Name -notmatch ('robur.*' + $flavor)) { continue }
                $cacheDir = Join-Path $prod.FullName (Join-Path $verPart 'assemblies')
                if (Test-Path $cacheDir) {
                    Remove-Item (Join-Path $cacheDir '*') -Force -ErrorAction SilentlyContinue
                    Write-Host2 ("    Очистен кэш сборок Robur: {0} (регенерируется при старте)" -f $cacheDir) 'DarkGray'
                }
            }
        }
    } catch {
        Write-Host2 ("    Кэш сборок не очищен ({0}) — при старых тулазах после перезапуска удалите {1}\Topomatic\...\assemblies вручную" -f $_.Exception.Message, $env:LOCALAPPDATA) 'Yellow'
    }

    Write-Log ("INSTALL OK: {0}; файлов: {1} (иконок: {2}); бэкап: {3}" -f $Target, $installed.Count, $icons.Count, $backedUp)
    Write-Host2 ("    Готово: {0} файлов ({1} иконок)." -f $installed.Count, $icons.Count) 'Green'
    Write-Host2 '    Дальше: перезапустите Robur и откройте проект — MCP-сервер запустится автоматически.' 'DarkCyan'
    Write-Host2 '    (Ручной запуск: кнопка «Запуск MCP» на вкладке RoboLas или команда mcp_run.)' 'DarkCyan'
    Write-Host2 '    Проверка: curl http://127.0.0.1:8000/health и наличие тулов las_* в tools/list.' 'DarkCyan'
}

# ─────────────────────────── удаление ───────────────────────────

function Invoke-Uninstall([string]$Target) {
    Write-Host2 ("==> Удаление RoboLas из: {0}" -f $Target) 'Cyan'

    $manifestPath = Join-Path $Target $Script:ManifestName
    $entries = $null
    if (Test-Path $manifestPath) {
        $entries = Get-Content $manifestPath | Where-Object { $_ -and $_.Trim() }
    } elseif (Test-Path (Join-Path $Script:FilesDir 'files.manifest')) {
        Write-Host2 '    Манифест в установке не найден, использую манифест пакета.' 'Yellow'
        $entries = Get-Content (Join-Path $Script:FilesDir 'files.manifest') | Where-Object { $_ -and $_.Trim() }
    } else {
        throw "Не найден список установленных файлов ($Script:ManifestName). Удалите файлы вручную: LAS_TERRAIN.*, LAS_TERRAIN.MCP.*, иконки RoboLas в icons\."
    }

    $removed = 0
    $missing = 0
    foreach ($rel in $entries) {
        $full = Join-Path $Target ($rel -replace '/', '\')
        if (Test-Path $full) {
            Remove-Item $full -Force
            $removed++
        } else { $missing++ }
    }
    # сам манифест в свой список не входит — убираем отдельно
    if (Test-Path $manifestPath) { Remove-Item $manifestPath -Force; $removed++ }
    Write-Log ("UNINSTALL: {0}; удалено: {1}; отсутствовало: {2}" -f $Target, $removed, $missing)
    Write-Host2 ("    Удалено файлов: {0} (не найдено: {1})." -f $removed, $missing) 'Green'
    Write-Host2 '    Перезапустите Robur. robur-mcp и Robur не затронуты (удаляются отдельно).' 'DarkCyan'
}

# ─────────────────────────── выбор целей ───────────────────────────

function Select-Targets() {
    $installations = Find-RoburInstallations
    if ($installations.Count -eq 0) {
        Write-Host2 'Установки Topomatic Robur не найдены автоматически.' 'Red'
        Write-Host2 'Укажите каталог вручную: powershell -File Install-RoboLas.ps1 -Path "C:\Program Files\Topomatic Robur Rail 16.0"' 'Gray'
        exit 1
    }

    Write-Host2 'Найденные установки Robur:' 'White'
    for ($i = 0; $i -lt $installations.Count; $i++) {
        $dir = $installations[$i]
        $ver = Get-RoburVersion $dir
        $bridge = if (Test-Path (Join-Path $dir 'Topomatic.ToolBridge.dll')) { 'robur-mcp: есть' } else { 'robur-mcp: НЕТ' }
        Write-Host2 ("  [{0}] {1}  (Robur {2}; {3})" -f ($i + 1), $dir, $ver, $bridge)
    }

    if ($All) { return $installations }
    if ($Yes) { if ($installations.Count -eq 1) { return $installations }
                Write-Host2 'Найдено несколько установок, но -Yes без -All: используйте -Path или -All.' 'Red'; exit 1 }

    Write-Host2 ("Куда ставить? Введите номер (1-{0}), несколько через запятую, A = все, Q = выход:" -f $installations.Count) 'White'
    $answer = Read-Host
    if ($answer -match '^[Qq]') { exit 0 }
    if ($answer -match '^[Aa]$') { return $installations }
    $picked = New-Object System.Collections.Generic.List[string]
    foreach ($part in ($answer -split ',')) {
        $n = 0
        if ([int]::TryParse($part.Trim(), [ref]$n) -and $n -ge 1 -and $n -le $installations.Count) {
            $picked.Add($installations[$n - 1])
        }
    }
    if ($picked.Count -eq 0) { Write-Host2 'Ничего не выбрано.' 'Red'; exit 1 }
    return $picked
}

function Ensure-Elevation([string[]]$Targets) {
    if ($NoElevate -or (Test-IsAdmin)) { return }
    $needElevation = $false
    foreach ($t in $Targets) {
        if (-not (Test-PathWritable $t)) { $needElevation = $true }
    }
    if (-not $needElevation) { return }

    Write-Host2 'Требуются права администратора — запрашиваю UAC…' 'Yellow'
    $argList = @('-NoProfile', '-ExecutionPolicy', 'Bypass', '-File', ('"{0}"' -f $PSCommandPath))
    foreach ($t in $Targets) { $argList += @('-Path', ('"{0}"' -f $t)) }
    if ($Uninstall) { $argList += '-Uninstall' }
    if ($Yes) { $argList += '-Yes' }
    $argList += '-NoElevate'
    try {
        $proc = Start-Process powershell -Verb RunAs -ArgumentList ($argList -join ' ') -PassThru -Wait
        exit $proc.ExitCode
    } catch {
        Write-Host2 'UAC отклонён — установка отменена.' 'Red'
        exit 1
    }
}

# ─────────────────────────── main ───────────────────────────

Write-Host2 '=== Установщик RoboLas + MCP-адаптера (для Topomatic Robur) ===' 'White'

if (-not (Test-Path $Script:FilesDir) -and -not $ListOnly) {
    # поддержка запуска прямо из installer/ репозитория (для тестов): рядом нет files\
    Write-Host2 ("Не найдена папка с файлами: {0}" -f $Script:FilesDir) 'Red'
    Write-Host2 'Запускайте install.cmd из распакованного дистрибутива (рядом должна быть папка files\).' 'Gray'
    exit 1
}

if ($ListOnly) {
    $installations = Find-RoburInstallations
    if ($installations.Count -eq 0) { Write-Host2 'Установки Robur не найдены.' 'Yellow'; exit 1 }
    foreach ($dir in $installations) {
        $ver = Get-RoburVersion $dir
        $bridge = if (Test-Path (Join-Path $dir 'Topomatic.ToolBridge.dll')) { 'robur-mcp: есть' } else { 'robur-mcp: НЕТ' }
        Write-Host2 ("{0}  (Robur {1}; {2})" -f $dir, $ver, $bridge)
    }
    exit 0
}

if ($Path) {
    if (-not (Test-Path $Path)) { Write-Host2 ("Каталог не существует: {0}" -f $Path) 'Red'; exit 1 }
    if (-not (Test-Path (Join-Path $Path 'Topomatic.ApplicationPlatform.dll'))) {
        Write-Host2 ("В каталоге нет Topomatic.ApplicationPlatform.dll — это точно установка Robur? {0}" -f $Path) 'Yellow'
        if (-not $Yes) {
            if ((Read-Host 'Продолжить всё равно? (y/n)') -notmatch '^[Yy]') { exit 1 }
        }
    }
    $targets = @($Path)
}
else {
    $targets = Select-Targets
}

Ensure-Elevation $targets

$failed = 0
foreach ($t in $targets) {
    try {
        if ($Uninstall) { Invoke-Uninstall $t } else { Invoke-Install $t }
    } catch {
        $failed++
        Write-Host2 ("    ОШИБКА: {0}" -f $_.Exception.Message) 'Red'
        Write-Log ("FAIL {0}: {1}" -f $t, $_.Exception.Message)
    }
}

if ($failed -gt 0) { Write-Host2 ("Завершено с ошибками: {0} из {1}." -f $failed, $targets.Count) 'Red'; exit 1 }
Write-Host2 'Готово.' 'Green'
exit 0
