param(
    [string]$DllPath,
    [string]$OutPath
)

$name = [System.IO.Path]::GetFileNameWithoutExtension($DllPath)

try {
    $asm = [System.Reflection.Assembly]::LoadFrom($DllPath)
} catch {
    "# $name`n`n**Error loading assembly:** $_" | Out-File -Encoding UTF8 $OutPath
    exit 1
}

$sb = New-Object System.Text.StringBuilder
[void]$sb.AppendLine("# $name")
[void]$sb.AppendLine("")
[void]$sb.AppendLine("Assembly: ``$name``")
[void]$sb.AppendLine("")

$types = $asm.GetExportedTypes() | Sort-Object Namespace, Name
$nsGroups = $types | Group-Object Namespace | Sort-Object Name

foreach ($grp in $nsGroups) {
    $ns = $grp.Name
    [void]$sb.AppendLine("## Namespace: ``$ns``")
    [void]$sb.AppendLine("")

    foreach ($t in ($grp.Group | Sort-Object Name)) {
        $typeKind = if ($t.IsInterface) { 'interface' } elseif ($t.IsEnum) { 'enum' } elseif ($t.IsValueType) { 'struct' } elseif ($t.IsAbstract) { 'abstract class' } else { 'class' }
        $baseType = if ($t.BaseType -ne $null) { $t.BaseType.FullName } else { '' }
        $ifaces = ($t.GetInterfaces() | ForEach-Object { $_.FullName }) -join ', '

        [void]$sb.AppendLine("### ``$($t.Name)`` ($typeKind)")
        if ($baseType) { [void]$sb.AppendLine("- **Base:** ``$baseType``") }
        if ($ifaces) { [void]$sb.AppendLine("- **Implements:** ``$ifaces``") }
        [void]$sb.AppendLine("")

        # Properties
        $props = $t.GetProperties([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance -bor [System.Reflection.BindingFlags]::DeclaredOnly)
        if ($props.Count -gt 0) {
            [void]$sb.AppendLine("| Property | Type |")
            [void]$sb.AppendLine("|----------|------|")
            foreach ($p in ($props | Sort-Object Name)) {
                $pt = $p.PropertyType.FullName
                if ($pt -eq $null) { $pt = $p.PropertyType.Name }
                [void]$sb.AppendLine("| ``$($p.Name)`` | ``$pt`` |")
            }
            [void]$sb.AppendLine("")
        }

        # Instance Methods
        $methods = $t.GetMethods([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance -bor [System.Reflection.BindingFlags]::DeclaredOnly) | Where-Object { !$_.IsSpecialName }
        if ($methods.Count -gt 0) {
            [void]$sb.AppendLine("| Method | Return | Parameters |")
            [void]$sb.AppendLine("|--------|--------|------------|")
            foreach ($m in ($methods | Sort-Object Name)) {
                $ret = $m.ReturnType.FullName
                if ($ret -eq $null) { $ret = $m.ReturnType.Name }
                $pars = ($m.GetParameters() | ForEach-Object { "$($_.ParameterType.Name) $($_.Name)" }) -join ', '
                [void]$sb.AppendLine("| ``$($m.Name)`` | ``$ret`` | ``$pars`` |")
            }
            [void]$sb.AppendLine("")
        }

        # Static Methods
        $staticMethods = $t.GetMethods([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Static -bor [System.Reflection.BindingFlags]::DeclaredOnly) | Where-Object { !$_.IsSpecialName }
        if ($staticMethods.Count -gt 0) {
            [void]$sb.AppendLine("#### Static Methods")
            [void]$sb.AppendLine("")
            [void]$sb.AppendLine("| Method | Return | Parameters |")
            [void]$sb.AppendLine("|--------|--------|------------|")
            foreach ($m in ($staticMethods | Sort-Object Name)) {
                $ret = $m.ReturnType.FullName
                if ($ret -eq $null) { $ret = $m.ReturnType.Name }
                $pars = ($m.GetParameters() | ForEach-Object { "$($_.ParameterType.Name) $($_.Name)" }) -join ', '
                [void]$sb.AppendLine("| ``$($m.Name)`` | ``$ret`` | ``$pars`` |")
            }
            [void]$sb.AppendLine("")
        }

        # Events
        $events = $t.GetEvents([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance -bor [System.Reflection.BindingFlags]::DeclaredOnly)
        if ($events.Count -gt 0) {
            [void]$sb.AppendLine("#### Events")
            [void]$sb.AppendLine("")
            foreach ($e in ($events | Sort-Object Name)) {
                $et = $e.EventHandlerType.FullName
                if ($et -eq $null) { $et = $e.EventHandlerType.Name }
                [void]$sb.AppendLine("- ``$($e.Name)``: ``$et``")
            }
            [void]$sb.AppendLine("")
        }

        # Enum values
        if ($t.IsEnum) {
            [void]$sb.AppendLine("| Member | Value |")
            [void]$sb.AppendLine("|--------|-------|")
            foreach ($eName in [System.Enum]::GetNames($t)) {
                try { $val = [System.Convert]::ToInt64([System.Enum]::Parse($t, $eName)) } catch { $val = [System.Convert]::ToUInt64([System.Enum]::Parse($t, $eName)) }
                [void]$sb.AppendLine("| ``$eName`` | ``$val`` |")
            }
            [void]$sb.AppendLine("")
        }
    }
}

$sb.ToString() | Out-File -Encoding UTF8 $OutPath
Write-Host "Done: $name - $($types.Count) types"
