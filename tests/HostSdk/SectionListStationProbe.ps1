param([string]$HostCopyPath = 'D:\Development\Robolas\host-test\Rail16')

# A detached, in-memory SectionList probe. It opens no project or GUI and
# writes nothing to the copied installation or the user's Topomatic profile.
$ErrorActionPreference = 'Stop'
$hostRoot = (Resolve-Path -LiteralPath $HostCopyPath).Path
if ($hostRoot.StartsWith('C:\Program Files\', [StringComparison]::OrdinalIgnoreCase) -or
    $hostRoot.StartsWith('D:\Program Files\', [StringComparison]::OrdinalIgnoreCase)) {
    throw 'Use a copied Rail16 directory, not the installed host.'
}
$assembly = [Reflection.Assembly]::LoadFrom((Join-Path $hostRoot 'Topomatic.Alg.dll'))
$sectionListType = $assembly.GetType('Topomatic.Alg.Crs.SectionList', $true)
$sections = [Activator]::CreateInstance($sectionListType, ([object[]]@($null)))
$add = $sectionListType.GetMethod('Add')
$item = $sectionListType.GetProperty('Item')
$stations = [double[]]@(0.0, 0.1, 0.3, 1.0, 1234.56789)
for ($i = 0; $i -lt $stations.Length; $i++) {
    $index = [int]$add.Invoke($sections, @($stations[$i]))
    if ($index -ne $i) { throw "Section insertion index changed at $i" }
    $section = $item.GetValue($sections, @($index))
    if ([BitConverter]::DoubleToInt64Bits([double]$section.Station) -ne
        [BitConverter]::DoubleToInt64Bits($stations[$i])) {
        throw "Section station bits changed at $i"
    }
}
if ($sections.Count -ne $stations.Length) { throw 'Section count changed.' }
Write-Host 'Copied Rail 16 detached SectionList: station order and bits preserved.'
$transactionManager = $sectionListType.GetProperty('TransactionManager').GetValue($sections, $null)
if ($null -eq $transactionManager) {
    Write-Host 'Detached SectionList has no TransactionManager; Undo/Redo requires a project-owned host probe.'
} else {
    Write-Host "Detached SectionList TransactionManager: $($transactionManager.GetType().FullName)"
}
