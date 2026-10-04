param(
    [string]$DllPath,
    [string]$OutputFile
)

$sb = New-Object System.Text.StringBuilder

[void]$sb.AppendLine("# $(Split-Path $DllPath -Leaf)")
[void]$sb.AppendLine("")

try {
    $asm = [System.Reflection.Assembly]::LoadFrom($DllPath)
    [void]$sb.AppendLine("**Runtime**: $($asm.ImageRuntimeVersion)")
    [void]$sb.AppendLine("**Full Name**: $($asm.FullName)")
    [void]$sb.AppendLine("")

    $types = $asm.GetExportedTypes()
    [void]$sb.AppendLine("**Public Types**: $($types.Count)")
    [void]$sb.AppendLine("")

    $nsGroups = $types | Group-Object Namespace | Sort-Object Name
    foreach ($ns in $nsGroups) {
        [void]$sb.AppendLine("---")
        [void]$sb.AppendLine("## Namespace: $($ns.Name)")
        [void]$sb.AppendLine("")

        foreach ($t in $ns.Group | Sort-Object Name) {
            [void]$sb.AppendLine("### $($t.Name)")
            [void]$sb.AppendLine("")
            [void]$sb.AppendLine("- **Full Name**: ``$($t.FullName)``")

            $kind = "Class"
            if ($t.IsInterface) { $kind = "Interface" }
            elseif ($t.IsEnum) { $kind = "Enum" }
            elseif ($t.IsAbstract -and $t.IsSealed) { $kind = "Static Class" }
            elseif ($t.IsAbstract) { $kind = "Abstract Class" }
            elseif ($t.IsValueType) { $kind = "Struct" }
            [void]$sb.AppendLine("- **Kind**: $kind")

            if ($t.BaseType -and $t.BaseType.FullName -ne "System.Object" -and $t.BaseType.FullName -ne "System.ValueType" -and $t.BaseType.FullName -ne "System.Enum") {
                [void]$sb.AppendLine("- **Base Type**: ``$($t.BaseType.FullName)``")
            }

            $ifaces = $t.GetInterfaces()
            if ($ifaces.Count -gt 0) {
                $ifaceNames = ($ifaces | ForEach-Object { "``$($_.Name)``" }) -join ", "
                [void]$sb.AppendLine("- **Interfaces**: $ifaceNames")
            }
            [void]$sb.AppendLine("")

            # Constructors
            $ctors = $t.GetConstructors([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance)
            if ($ctors.Count -gt 0) {
                [void]$sb.AppendLine("#### Constructors")
                [void]$sb.AppendLine("")
                foreach ($c in $ctors) {
                    $parms = ($c.GetParameters() | ForEach-Object { "``$($_.ParameterType.Name)`` $($_.Name)" }) -join ", "
                    [void]$sb.AppendLine("- ``.ctor($parms)``")
                }
                [void]$sb.AppendLine("")
            }

            # Properties
            $props = $t.GetProperties([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance -bor [System.Reflection.BindingFlags]::DeclaredOnly)
            if ($props.Count -gt 0) {
                [void]$sb.AppendLine("#### Properties")
                [void]$sb.AppendLine("")
                foreach ($p in $props | Sort-Object Name) {
                    $canRead = ""
                    $canWrite = ""
                    if ($p.CanRead) { $canRead = "get" }
                    if ($p.CanWrite) { $canWrite = "set" }
                    $access = @()
                    if ($canRead) { $access += $canRead }
                    if ($canWrite) { $access += $canWrite }
                    $accessStr = $access -join ", "
                    [void]$sb.AppendLine("- ``$($p.PropertyType.Name) $($p.Name)`` { $accessStr }")
                }
                [void]$sb.AppendLine("")
            }

            # Methods
            $methods = $t.GetMethods([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance -bor [System.Reflection.BindingFlags]::DeclaredOnly)
            $methods = $methods | Where-Object { $_.IsSpecialName -eq $false }
            if ($methods.Count -gt 0) {
                [void]$sb.AppendLine("#### Methods")
                [void]$sb.AppendLine("")
                foreach ($m in $methods | Sort-Object Name) {
                    $parms = ($m.GetParameters() | ForEach-Object { "``$($_.ParameterType.Name)`` $($_.Name)" }) -join ", "
                    [void]$sb.AppendLine("- ``$($m.ReturnType.Name) $($m.Name)($parms)``")
                }
                [void]$sb.AppendLine("")
            }

            # Static Methods
            $staticMethods = $t.GetMethods([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Static -bor [System.Reflection.BindingFlags]::DeclaredOnly)
            $staticMethods = $staticMethods | Where-Object { $_.IsSpecialName -eq $false }
            if ($staticMethods.Count -gt 0) {
                [void]$sb.AppendLine("#### Static Methods")
                [void]$sb.AppendLine("")
                foreach ($m in $staticMethods | Sort-Object Name) {
                    $parms = ($m.GetParameters() | ForEach-Object { "``$($_.ParameterType.Name)`` $($_.Name)" }) -join ", "
                    [void]$sb.AppendLine("- ``static $($m.ReturnType.Name) $($m.Name)($parms)``")
                }
                [void]$sb.AppendLine("")
            }

            # Events
            $events = $t.GetEvents([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance -bor [System.Reflection.BindingFlags]::DeclaredOnly)
            if ($events.Count -gt 0) {
                [void]$sb.AppendLine("#### Events")
                [void]$sb.AppendLine("")
                foreach ($e in $events | Sort-Object Name) {
                    [void]$sb.AppendLine("- ``$($e.EventHandlerType.Name) $($e.Name)``")
                }
                [void]$sb.AppendLine("")
            }

            # Enum values
            if ($t.IsEnum) {
                [void]$sb.AppendLine("#### Enum Values")
                [void]$sb.AppendLine("")
                $values = [Enum]::GetValues($t)
                foreach ($v in $values) {
                    [void]$sb.AppendLine("- ``$v = $([Convert]::ToInt32($v))``")
                }
                [void]$sb.AppendLine("")
            }

            # Fields (for static classes, constants)
            $fields = $t.GetFields([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Static -bor [System.Reflection.BindingFlags]::DeclaredOnly)
            if ($fields.Count -gt 0) {
                [void]$sb.AppendLine("#### Static Fields")
                [void]$sb.AppendLine("")
                foreach ($f in $fields | Sort-Object Name) {
                    try {
                        $val = $f.GetValue($null)
                        [void]$sb.AppendLine("- ``$($f.FieldType.Name) $($f.Name)`` = $val")
                    } catch {
                        [void]$sb.AppendLine("- ``$($f.FieldType.Name) $($f.Name)``")
                    }
                }
                [void]$sb.AppendLine("")
            }
        }
    }
} catch {
    [void]$sb.AppendLine("")
    [void]$sb.AppendLine("**ERROR loading DLL**: $($_.Exception.Message)")
    [void]$sb.AppendLine("")
}

$sb.ToString() | Out-File -FilePath $OutputFile -Encoding UTF8
Write-Host "Done: $OutputFile ($(($sb.ToString()).Length) chars)"
