<#
.SYNOPSIS
    Enhanced DLL Catalog Generator for Topomatic API Analysis
.DESCRIPTION
    Creates comprehensive markdown documentation from .NET assemblies with:
    - Method parameter names (from ParameterInfo.Name)
    - Constructor information with full parameter details
    - Custom attributes on types and methods
    - Inheritance chain (full hierarchy, not just immediate base)
    - Nested types
    - Interface implementation mapping
    - Extension methods detection
    - Property accessors (get/set availability)
    - Generic parameter constraints
    - Field information (instance and static)
    - Summary statistics per DLL
.PARAMETER DllPath
    Full path to the DLL file to analyze
.PARAMETER OutPath
    Full path to the output markdown file
.EXAMPLE
    .\catalog_dll_enhanced.ps1 -DllPath "C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Core.dll" -OutPath "dlls\Topomatic.Core.md"
#>

param(
    [Parameter(Mandatory=$true)]
    [string]$DllPath,

    [Parameter(Mandatory=$true)]
    [string]$OutPath
)

$ErrorActionPreference = "Continue"

# Initialize counters for statistics
$stats = @{
    TotalTypes = 0
    Classes = 0
    Interfaces = 0
    Enums = 0
    Structs = 0
    AbstractClasses = 0
    StaticClasses = 0
    TotalMethods = 0
    TotalProperties = 0
    TotalFields = 0
    TotalEvents = 0
    TotalConstructors = 0
    NestedTypes = 0
    ExtensionMethods = 0
}

$name = [System.IO.Path]::GetFileNameWithoutExtension($DllPath)

Write-Host "Loading assembly: $name..." -ForegroundColor Cyan

try {
    $asm = [System.Reflection.Assembly]::LoadFrom($DllPath)
} catch {
    $errorMsg = "# $name`n`n**Error loading assembly:** $_`n`nStack Trace:`n$($_.ScriptStackTrace)"
    $errorMsg | Out-File -Encoding UTF8 $OutPath
    Write-Host "ERROR: Failed to load assembly" -ForegroundColor Red
    exit 1
}

$sb = New-Object System.Text.StringBuilder

# Header with assembly information
[void]$sb.AppendLine("# $name")
[void]$sb.AppendLine("")
[void]$sb.AppendLine("## Assembly Information")
[void]$sb.AppendLine("")
[void]$sb.AppendLine("| Property | Value |")
[void]$sb.AppendLine("|----------|-------|")
[void]$sb.AppendLine("| **Name** | ``$($asm.GetName().Name)`` |")
[void]$sb.AppendLine("| **Version** | ``$($asm.GetName().Version)`` |")
[void]$sb.AppendLine("| **Runtime** | ``$($asm.ImageRuntimeVersion)`` |")
[void]$sb.AppendLine("| **Full Name** | ``$($asm.FullName)`` |")
[void]$sb.AppendLine("| **Location** | ``$($asm.Location)`` |")
[void]$sb.AppendLine("")

# Get all types (including non-exported for nested types)
$allTypes = $asm.GetTypes()
$publicTypes = $asm.GetExportedTypes()
$stats.TotalTypes = $publicTypes.Count

# Group by namespace
$nsGroups = $publicTypes | Group-Object Namespace | Sort-Object Name

# Function to get inheritance chain
function Get-InheritanceChain {
    param($type)

    $chain = @()
    $current = $type

    while ($current -ne $null) {
        $chain = ,@{ Name = $current.FullName; IsRoot = ($current.BaseType -eq $null) } + $chain
        $current = $current.BaseType
    }

    return $chain
}

# Function to get custom attributes as string
function Get-CustomAttributesString {
    param($memberInfo)

    try {
        $attrs = $memberInfo.GetCustomAttributes($false)
        if ($attrs.Count -eq 0) {
            return $null
        }

        $attrStrings = @()
        foreach ($attr in $attrs) {
            $attrName = $attr.GetType().Name
            # Show attributes ending with "Attribute" or known important ones
            if ($attrName.EndsWith("Attribute") -or
                $attrName -eq "SerializableAttribute" -or
                $attrName -eq "ExtensionAttribute" -or
                $attrName -eq "ObsoleteAttribute" -or
                $attrName -eq "FlagsAttribute") {

                $display = $attrName -replace 'Attribute$', ''

                # Try to get useful property values
                if ($attrName -eq "ObsoleteAttribute" -and $attr.Message) {
                    $display += "(Message: ``$($attr.Message)``)"
                }

                $attrStrings += $display
            }
        }

        if ($attrStrings.Count -gt 0) {
            return ($attrStrings -join ", ")
        }
    } catch {
        # Silently ignore attribute errors
    }

    return $null
}

# Function to check if method is an extension method
function Test-ExtensionMethod {
    param($method)

    try {
        $attrs = $method.GetCustomAttributes($false)
        foreach ($attr in $attrs) {
            if ($attr.GetType().Name -eq "ExtensionAttribute") {
                return $true
            }
        }
    } catch {
        # Ignore errors
    }

    return $false
}

# Function to format generic parameters with constraints
function Format-GenericParameters {
    param($type)

    try {
        if ($type.IsGenericType -or $type.ContainsGenericParameters) {
            $genericArgs = $type.GetGenericArguments()
            if ($genericArgs.Count -gt 0) {
                $paramStrings = @()
                foreach ($ga in $genericArgs) {
                    $paramStr = $ga.Name

                    # Get constraints
                    $constraints = @()
                    if ($ga.BaseType -ne $null -and $ga.BaseType.FullName -ne "System.Object") {
                        $constraints += $ga.BaseType.Name
                    }

                    $ifaceConstraints = $ga.GetInterfaces()
                    if ($ifaceConstraints.Count -gt 0) {
                        $constraints += ($ifaceConstraints | ForEach-Object { $_.Name })
                    }

                    if ($ga.IsClass) { $constraints += "class" }
                    if ($ga.IsValueType) { $constraints += "struct" }
                    if ($ga.IsGenericParameter -and $ga.GetGenericParameterConstraints().Count -gt 0) {
                        $constraints += ($ga.GetGenericParameterConstraints() | ForEach-Object { $_.Name })
                    }

                    if ($constraints.Count -gt 0) {
                        $paramStr += " where " + ($constraints -join ", ")
                    }

                    $paramStrings += $paramStr
                }

                return "<" + ($paramStrings -join ", ") + ">"
            }
        }
    } catch {
        # Ignore generic errors
    }

    return ""
}

# Function to get type with generic info
function Format-TypeName {
    param($type)

    try {
        if ($type -eq $null) {
            return "void"
        }

        if ($type.IsGenericType) {
            $genericDef = $type.GetGenericTypeDefinition()
            $baseName = $genericDef.Name -replace '`\d+$', ''
            $args = ($type.GetGenericArguments() | ForEach-Object { Format-TypeName -type $_ })
            return "$baseName<$args>"
        } elseif ($type.IsArray) {
            $elemType = Format-TypeName -type $type.GetElementType()
            return "$elemType[]"
        } elseif ($type.IsByRef) {
            $elemType = Format-TypeName -type $type.GetElementType()
            return "ref $elemType"
        } elseif ($type.IsPointer) {
            $elemType = Format-TypeName -type $type.GetElementType()
            return "$elemType*"
        } else {
            return $type.Name
        }
    } catch {
        return $type.Name
    }
}

# Process each namespace
foreach ($grp in $nsGroups) {
    $ns = $grp.Name
    [void]$sb.AppendLine("---")
    [void]$sb.AppendLine("## Namespace: ``$ns``")
    [void]$sb.AppendLine("")

    foreach ($t in ($grp.Group | Sort-Object Name)) {
        # Determine type kind
        $typeKind = "class"
        if ($t.IsInterface) {
            $typeKind = "interface"
            $stats.Interfaces++
        } elseif ($t.IsEnum) {
            $typeKind = "enum"
            $stats.Enums++
        } elseif ($t.IsValueType -and !$t.IsPrimitive -and !$t.IsEnum) {
            $typeKind = "struct"
            $stats.Structs++
        } elseif ($t.IsAbstract -and $t.IsSealed) {
            $typeKind = "static class"
            $stats.StaticClasses++
        } elseif ($t.IsAbstract) {
            $typeKind = "abstract class"
            $stats.AbstractClasses++
        } else {
            $typeKind = "class"
            $stats.Classes++
        }

        # Get generic parameters
        $genericParams = Format-GenericParameters -type $t

        # Get custom attributes on type
        $typeAttrs = Get-CustomAttributesString -memberInfo $t

        [void]$sb.AppendLine("### ``$($t.Name)$genericParams`` ($typeKind)")

        if ($typeAttrs) {
            [void]$sb.AppendLine("")
            [void]$sb.AppendLine("**Attributes**: [$typeAttrs]")
        }

        [void]$sb.AppendLine("")
        [void]$sb.AppendLine("| Property | Value |")
        [void]$sb.AppendLine("|----------|-------|")
        [void]$sb.AppendLine("| **Full Name** | ``$($t.FullName)`` |")
        [void]$sb.AppendLine("| **Base Type** | ``$(if ($t.BaseType) { $t.BaseType.FullName } else { 'none' })`` |")

        # Get interfaces
        $ifaces = $t.GetInterfaces()
        if ($ifaces.Count -gt 0) {
            $ifaceNames = ($ifaces | ForEach-Object { $_.FullName }) -join ', '
            [void]$sb.AppendLine("| **Implements** | ``$ifaceNames`` |")
        }

        # Visibility info
        $visibility = "public"
        if ($t.IsNestedPublic) { $visibility = "nested public" }
        elseif ($t.IsNestedPrivate) { $visibility = "nested private" }
        elseif ($t.IsNestedFamily) { $visibility = "nested protected" }
        elseif ($t.IsNestedAssembly) { $visibility = "nested internal" }

        [void]$sb.AppendLine("| **Visibility** | ``$visibility`` |")
        [void]$sb.AppendLine("| **Is Sealed** | ``$($t.IsSealed)`` |")
        [void]$sb.AppendLine("| **Is Abstract** | ``$($t.IsAbstract)`` |")
        [void]$sb.AppendLine("| **Is Generic** | ``$($t.IsGenericType)`` |")
        [void]$sb.AppendLine("")

        # Inheritance Chain
        if ($t.BaseType -ne $null -and $t.BaseType.FullName -ne "System.Object") {
            [void]$sb.AppendLine("#### Inheritance Chain")
            [void]$sb.AppendLine("")
            $chain = Get-InheritanceChain -type $t
            foreach ($level in $chain) {
                $indent = "  " * ($chain.IndexOf($level))
                if ($level.IsRoot) {
                    [void]$sb.AppendLine("$indent- ``$($level.Name)`` **(root)**")
                } else {
                    [void]$sb.AppendLine("$indent- ``$($level.Name)``")
                }
            }
            [void]$sb.AppendLine("")
        }

        # Constructors
        $ctors = $t.GetConstructors([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance -bor [System.Reflection.BindingFlags]::DeclaredOnly)
        if ($ctors.Count -gt 0) {
            $stats.TotalConstructors += $ctors.Count
            [void]$sb.AppendLine("#### Constructors ($($ctors.Count))")
            [void]$sb.AppendLine("")

            foreach ($c in ($ctors | Sort-Object { $_.GetParameters().Count })) {
                $params = $c.GetParameters()
                if ($params.Count -eq 0) {
                    [void]$sb.AppendLine("- ``.ctor()`` - **Default constructor**")
                } else {
                    $paramList = @()
                    foreach ($p in $params) {
                        $pName = if ($p.Name) { $p.Name } else { "param$($params.IndexOf($p))" }
                        $pType = Format-TypeName -type $p.ParameterType
                        $paramList += "$pType $pName"
                    }
                    [void]$sb.AppendLine("- ``.ctor($($paramList -join ', '))``")
                }
            }
            [void]$sb.AppendLine("")
        }

        # Properties with accessors
        $props = $t.GetProperties([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance -bor [System.Reflection.BindingFlags]::Static -bor [System.Reflection.BindingFlags]::DeclaredOnly)
        if ($props.Count -gt 0) {
            $stats.TotalProperties += $props.Count
            [void]$sb.AppendLine("#### Properties ($($props.Count))")
            [void]$sb.AppendLine("")
            [void]$sb.AppendLine("| Name | Type | Accessors | Static | Attributes |")
            [void]$sb.AppendLine("|------|------|------------|--------|------------|")

            foreach ($p in ($props | Sort-Object Name)) {
                $pType = Format-TypeName -type $p.PropertyType

                $accessors = @()
                if ($p.CanRead) { $accessors += "get" }
                if ($p.CanWrite) { $accessors += "set" }
                $accessStr = $accessors -join "/"

                $isStatic = if ($p.GetMethod -and $p.GetMethod.IsStatic) { "Yes" } else { "No" }

                $pAttrs = Get-CustomAttributesString -memberInfo $p
                if (-not $pAttrs) { $pAttrs = "" }

                [void]$sb.AppendLine("| ``$($p.Name)`` | ``$pType`` | ``$accessStr`` | $isStatic | ``$pAttrs`` |")
            }
            [void]$sb.AppendLine("")
        }

        # Instance Methods
        $methods = $t.GetMethods([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance -bor [System.Reflection.BindingFlags]::DeclaredOnly) | Where-Object { !$_.IsSpecialName }
        if ($methods.Count -gt 0) {
            $stats.TotalMethods += $methods.Count

            # Check for extension methods
            $extMethods = @($methods | Where-Object { Test-ExtensionMethod -method $_ })
            if ($extMethods.Count -gt 0) {
                $stats.ExtensionMethods += $extMethods.Count
            }

            [void]$sb.AppendLine("#### Instance Methods ($($methods.Count))")
            if ($extMethods.Count -gt 0) {
                [void]$sb.AppendLine(" **($($extMethods.Count) extension methods)**")
            }
            [void]$sb.AppendLine("")
            [void]$sb.AppendLine("| Name | Return Type | Parameters | Attributes |")
            [void]$sb.AppendLine("|------|-------------|------------|------------|")

            foreach ($m in ($methods | Sort-Object Name)) {
                $retType = Format-TypeName -type $m.ReturnType

                # Parameters with names
                $params = $m.GetParameters()
                $paramList = if ($params.Count -gt 0) {
                    $paramStrings = @()
                    foreach ($p in $params) {
                        $pName = if ($p.Name) { $p.Name } else { "param" }
                        $pType = Format-TypeName -type $p.ParameterType
                        $paramStrings += "$pType $pName"
                    }
                    $paramStrings -join ', '
                } else {
                    ""
                }

                $mAttrs = Get-CustomAttributesString -memberInfo $m
                if (-not $mAttrs) { $mAttrs = "" }
                if (Test-ExtensionMethod -method $m) {
                    if ($mAttrs) {
                        $mAttrs = "Extension, $mAttrs"
                    } else {
                        $mAttrs = "Extension"
                    }
                }

                [void]$sb.AppendLine("| ``$($m.Name)`` | ``$retType`` | ``$paramList`` | ``$mAttrs`` |")
            }
            [void]$sb.AppendLine("")
        }

        # Static Methods
        $staticMethods = $t.GetMethods([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Static -bor [System.Reflection.BindingFlags]::DeclaredOnly) | Where-Object { !$_.IsSpecialName }
        if ($staticMethods.Count -gt 0) {
            $stats.TotalMethods += $staticMethods.Count
            [void]$sb.AppendLine("#### Static Methods ($($staticMethods.Count))")
            [void]$sb.AppendLine("")
            [void]$sb.AppendLine("| Name | Return Type | Parameters | Attributes |")
            [void]$sb.AppendLine("|------|-------------|------------|------------|")

            foreach ($m in ($staticMethods | Sort-Object Name)) {
                $retType = Format-TypeName -type $m.ReturnType

                $params = $m.GetParameters()
                $paramList = if ($params.Count -gt 0) {
                    $paramStrings = @()
                    foreach ($p in $params) {
                        $pName = if ($p.Name) { $p.Name } else { "param" }
                        $pType = Format-TypeName -type $p.ParameterType
                        $paramStrings += "$pType $pName"
                    }
                    $paramStrings -join ', '
                } else {
                    ""
                }

                $mAttrs = Get-CustomAttributesString -memberInfo $m
                if (-not $mAttrs) { $mAttrs = "" }

                [void]$sb.AppendLine("| ``$($m.Name)`` | ``$retType`` | ``$paramList`` | ``$mAttrs`` |")
            }
            [void]$sb.AppendLine("")
        }

        # Fields (instance and static)
        $fields = $t.GetFields([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance -bor [System.Reflection.BindingFlags]::Static -bor [System.Reflection.BindingFlags]::DeclaredOnly)
        if ($fields.Count -gt 0) {
            $stats.TotalFields += $fields.Count
            [void]$sb.AppendLine("#### Fields ($($fields.Count))")
            [void]$sb.AppendLine("")
            [void]$sb.AppendLine("| Name | Type | Static | Value | Attributes |")
            [void]$sb.AppendLine("|------|------|--------|-------|------------|")

            foreach ($f in ($fields | Sort-Object Name)) {
                $fType = Format-TypeName -type $f.FieldType
                $isStatic = if ($f.IsStatic) { "Yes" } else { "No" }

                $fValue = ""
                if ($f.IsStatic -and $f.IsLiteral) {
                    try {
                        $fValue = $f.GetValue($null)
                        if ($fValue -ne $null) {
                            if ($fValue -is [string]) {
                                $fValue = "`"$fValue`""
                            } else {
                                $fValue = "$fValue"
                            }
                        }
                    } catch {
                        # Ignore value errors
                    }
                }

                $fAttrs = Get-CustomAttributesString -memberInfo $f
                if (-not $fAttrs) { $fAttrs = "" }

                [void]$sb.AppendLine("| ``$($f.Name)`` | ``$fType`` | $isStatic | ``$fValue`` | ``$fAttrs`` |")
            }
            [void]$sb.AppendLine("")
        }

        # Events
        $events = $t.GetEvents([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance -bor [System.Reflection.BindingFlags]::Static -bor [System.Reflection.BindingFlags]::DeclaredOnly)
        if ($events.Count -gt 0) {
            $stats.TotalEvents += $events.Count
            [void]$sb.AppendLine("#### Events ($($events.Count))")
            [void]$sb.AppendLine("")
            [void]$sb.AppendLine("| Name | Handler Type | Static | Attributes |")
            [void]$sb.AppendLine("|------|--------------|--------|------------|")

            foreach ($e in ($events | Sort-Object Name)) {
                $handlerType = Format-TypeName -type $e.EventHandlerType
                $isStatic = "No"

                try {
                    $mi = $e.GetAddMethod($true)
                    if ($mi -and $mi.IsStatic) { $isStatic = "Yes" }
                } catch {
                    # Ignore
                }

                $eAttrs = Get-CustomAttributesString -memberInfo $e
                if (-not $eAttrs) { $eAttrs = "" }

                [void]$sb.AppendLine("| ``$($e.Name)`` | ``$handlerType`` | $isStatic | ``$eAttrs`` |")
            }
            [void]$sb.AppendLine("")
        }

        # Nested Types
        $nestedTypes = $t.GetNestedTypes([System.Reflection.BindingFlags]::Public)
        if ($nestedTypes.Count -gt 0) {
            $stats.NestedTypes += $nestedTypes.Count
            [void]$sb.AppendLine("#### Nested Types ($($nestedTypes.Count))")
            [void]$sb.AppendLine("")

            foreach ($nt in ($nestedTypes | Sort-Object Name)) {
                $ntKind = if ($nt.IsInterface) { "interface" }
                          elseif ($nt.IsEnum) { "enum" }
                          elseif ($nt.IsValueType) { "struct" }
                          elseif ($nt.IsAbstract) { "abstract class" }
                          else { "class" }
                [void]$sb.AppendLine("- ``$($nt.Name)`` ($ntKind)")
            }
            [void]$sb.AppendLine("")
        }

        # Interface Implementation Mapping
        if ($ifaces.Count -gt 0 -and !$t.IsInterface) {
            [void]$sb.AppendLine("#### Interface Implementation")
            [void]$sb.AppendLine("")
            [void]$sb.AppendLine("| Interface | Implementation Method |")
            [void]$sb.AppendLine("|-----------|----------------------|")

            $interfaceMap = $t.GetInterfaceMap($null)
            foreach ($iface in $ifaces) {
                try {
                    $map = $t.GetInterfaceMap($iface)
                    foreach ($targetMethod in $map.TargetMethods) {
                        if ($targetMethod.DeclaringType -eq $t) {
                            $ifaceMethod = $map.InterfaceMethods[[Array]::IndexOf($map.TargetMethods, $targetMethod)]
                            [void]$sb.AppendLine("| ``$($iface.Name)`` | ``$($targetMethod.Name)`` |")
                        }
                    }
                } catch {
                    # Some interfaces can't be mapped
                }
            }
            [void]$sb.AppendLine("")
        }

        # Enum Values
        if ($t.IsEnum) {
            [void]$sb.AppendLine("#### Enum Values")
            [void]$sb.AppendLine("")
            [void]$sb.AppendLine("| Name | Value |")
            [void]$sb.AppendLine("|------|-------|")

            foreach ($eName in [System.Enum]::GetNames($t)) {
                try {
                    $val = [System.Convert]::ToInt64([System.Enum]::Parse($t, $eName))
                } catch {
                    try {
                        $val = [System.Convert]::ToUInt64([System.Enum]::Parse($t, $eName))
                    } catch {
                        $val = "?"
                    }
                }
                [void]$sb.AppendLine("| ``$eName`` | ``$val`` |")
            }
            [void]$sb.AppendLine("")

            # Enum underlying type
            $enumUnderlying = [System.Enum]::GetUnderlyingType($t)
            [void]$sb.AppendLine("**Underlying Type**: ``$($enumUnderlying.FullName)``")
            [void]$sb.AppendLine("")
        }
    }
}

# Summary Statistics
[void]$sb.AppendLine("---")
[void]$sb.AppendLine("## Summary Statistics")
[void]$sb.AppendLine("")
[void]$sb.AppendLine("| Metric | Count |")
[void]$sb.AppendLine("|--------|-------|")
[void]$sb.AppendLine("| **Total Types** | $($stats.TotalTypes) |")
[void]$sb.AppendLine("| **Classes** | $($stats.Classes) |")
[void]$sb.AppendLine("| **Interfaces** | $($stats.Interfaces) |")
[void]$sb.AppendLine("| **Enums** | $($stats.Enums) |")
[void]$sb.AppendLine("| **Structs** | $($stats.Structs) |")
[void]$sb.AppendLine("| **Abstract Classes** | $($stats.AbstractClasses) |")
[void]$sb.AppendLine("| **Static Classes** | $($stats.StaticClasses) |")
[void]$sb.AppendLine("| **Total Methods** | $($stats.TotalMethods) |")
[void]$sb.AppendLine("| **Total Properties** | $($stats.TotalProperties) |")
[void]$sb.AppendLine("| **Total Fields** | $($stats.TotalFields) |")
[void]$sb.AppendLine("| **Total Events** | $($stats.TotalEvents) |")
[void]$sb.AppendLine("| **Total Constructors** | $($stats.TotalConstructors) |")
[void]$sb.AppendLine("| **Nested Types** | $($stats.NestedTypes) |")
[void]$sb.AppendLine("| **Extension Methods** | $($stats.ExtensionMethods) |")
[void]$sb.AppendLine("")

# Output
$sb.ToString() | Out-File -Encoding UTF8 $OutPath

Write-Host "Done: $name" -ForegroundColor Green
Write-Host "  Types: $($stats.TotalTypes) (Classes: $($stats.Classes), Interfaces: $($stats.Interfaces), Enums: $($stats.Enums), Structs: $($stats.Structs))" -ForegroundColor Gray
Write-Host "  Members: Methods=$($stats.TotalMethods), Properties=$($stats.TotalProperties), Fields=$($stats.TotalFields), Events=$($stats.TotalEvents)" -ForegroundColor Gray
Write-Host "  Output: $OutPath" -ForegroundColor Gray
