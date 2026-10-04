@echo off
rem Shared Net35 test entry point (lead-owned). Two-stage compile+run:
rem   stage 1: original regression suite (original file set, no /main needed)
rem   stage 2: characterization suite (Wave 0 / PR-01); /main picks its entry
rem            point because RegressionTests.cs also defines a Main
rem Same compiler contract as before: v3.5 csc, /noconfig /nostdlib+, refs
rem from %WINDIR%\Microsoft.NET\Framework\v2.0.50727 and v3.5. No .NET 4.
setlocal
set "F2=%WINDIR%\Microsoft.NET\Framework\v2.0.50727"
set "F35=%WINDIR%\Microsoft.NET\Framework\v3.5"
set "F30=%WINDIR%\Microsoft.NET\Framework\v3.0"
if not exist "%F35%\csc.exe" (
  echo ERROR: The .NET Framework 3.5 compiler is required. No fallback to .NET 4 is allowed.
  exit /b 2
)
rem On this machine %F35%\System.Core.dll does NOT exist (the 3.5 framework
rem dir carries only compiler/tooling assemblies); resolve it from reference
rem assemblies, then the GAC. Verified 2026-09-27 (Wave 0 report).
set "SYSCORE=%F35%\System.Core.dll"
if not exist "%SYSCORE%" set "SYSCORE=%ProgramFiles(x86)%\Reference Assemblies\Microsoft\Framework\v3.5\System.Core.dll"
if not exist "%SYSCORE%" set "SYSCORE=%WINDIR%\assembly\GAC_MSIL\System.Core\3.5.0.0__b77a5c561934e089\System.Core.dll"
if not exist "%SYSCORE%" (
  echo ERROR: No .NET 3.5 System.Core.dll found ^(framework dir, reference assemblies or GAC^).
  exit /b 2
)
set "SYSWEB=%ProgramFiles(x86)%\Reference Assemblies\Microsoft\Framework\v3.5\System.ServiceModel.Web.dll"
if not exist "%SYSWEB%" set "SYSWEB=%WINDIR%\assembly\GAC_MSIL\System.ServiceModel.Web\3.5.0.0__31bf3856ad364e35\System.ServiceModel.Web.dll"
pushd "%~dp0"
if not exist bin mkdir bin
set "RC=0"

rem ---- Stage 1: regression suite ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /out:bin\RegressionTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" Stubs.cs RegressionTests.cs ..\..\Infrastructure\ParallelWorkRunner.cs ..\..\Domain\Models\PointKey2D.cs ..\..\Domain\Models\PointKey3D.cs ..\..\Domain\Filters\SplitAndMergeAlgorithm.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\RegressionTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 2: characterization suite ----
rem Production files beyond stage 1 are C# 3.0-clean per the Wave 0 report.
rem Excluded files (C#4+ syntax or SDK-bound) are listed in the header of
rem CharacterizationTests.cs and in run_characterization.cmd.
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.CharacterizationTests /out:bin\CharacterizationTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" Stubs.cs CharacterizationStubs.cs RegressionTests.cs CharacterizationTests.cs ..\fixtures\FixtureData.cs ..\..\Infrastructure\ParallelWorkRunner.cs ..\..\Domain\Models\PointKey2D.cs ..\..\Domain\Models\PointKey3D.cs ..\..\Domain\Models\LasSectionPoints.cs ..\..\Domain\Models\FilterOperationSnapshot.cs ..\..\Domain\Filters\SplitAndMergeAlgorithm.cs ..\..\Domain\Filters\OrderByX.cs ..\..\Domain\Filters\GraphGroundFilter.cs ..\..\Domain\Filters\GraphGroundDebugInfo.cs ..\..\Domain\Filters\BreakDetector.cs ..\..\Domain\Filters\SegmentBoundary.cs ..\LegacyAlgorithms\SmoothingSplineFilter.cs ..\..\Services\SamplingHelper.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\CharacterizationTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 3: hand-checkable production algorithm contracts ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.AlgorithmContractTests /out:bin\AlgorithmContractTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" Stubs.cs CharacterizationStubs.cs AlgorithmContractTests.cs ..\..\Domain\Models\PointKey2D.cs ..\..\Domain\Models\PointKey3D.cs ..\..\Domain\Models\FilterOperationSnapshot.cs ..\..\Domain\Filters\SplitAndMergeAlgorithm.cs ..\..\Domain\Filters\OrderByX.cs ..\..\Domain\Filters\GraphGroundFilter.cs ..\..\Domain\Filters\GraphGroundDebugInfo.cs ..\..\Services\SamplingHelper.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\AlgorithmContractTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 5: deterministic reservoir sampling contracts ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.SamplingDeterminismTests /out:bin\SamplingDeterminismTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" CharacterizationStubs.cs SamplingDeterminismTests.cs ..\..\Services\SamplingHelper.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\SamplingDeterminismTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 6: validate station lists before CAD mutation ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.SectionStationPlannerTests /out:bin\SectionStationPlannerTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" SectionStationPlannerTests.cs ..\..\Services\SectionStationPlanner.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\SectionStationPlannerTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 7: a filter run keeps captured settings despite later global edits ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.FilterOperationSnapshotTests /out:bin\FilterOperationSnapshotTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" Stubs.cs CharacterizationStubs.cs FilterSnapshotAggregatorStub.cs FilterOperationSnapshotTests.cs ..\fixtures\FixtureData.cs ..\..\Domain\Models\FilterOperationSnapshot.cs ..\..\Domain\Filters\GraphGroundFilter.cs ..\..\Domain\Filters\GraphGroundDebugInfo.cs ..\..\Domain\Filters\BreakDetector.cs ..\..\Domain\Filters\SegmentBoundary.cs ..\..\Domain\Filters\RobustGroundSplineFilter.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\FilterOperationSnapshotTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 8: reject stale CRS polygon section associations ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.CrsSectionAssociationTests /out:bin\CrsSectionAssociationTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" CrsSectionAssociationTests.cs ..\..\Domain\Service\CrsSectionAssociation.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\CrsSectionAssociationTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 9: dialog-free section calculation and cancellation ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.SectionWorkflowTests /out:bin\SectionWorkflowTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" Stubs.cs CharacterizationStubs.cs SectionWorkflowTests.cs ..\..\Infrastructure\ParallelWorkRunner.cs ..\..\Domain\Models\PointKey2D.cs ..\..\Domain\Models\PointKey3D.cs ..\..\Domain\Models\LasSectionPoints.cs ..\..\Domain\Models\FilterOperationSnapshot.cs ..\..\Application\OperationResult.cs ..\..\Application\SectionRequest.cs ..\..\Application\SectionWorkflow.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\SectionWorkflowTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 10: explicit LAS finalization, publication, and pair recovery ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.LasWriterFinalizationTests /out:bin\LasWriterFinalizationTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" CharacterizationStubs.cs LasWriterCharacterizationStubs.cs LasWriterFinalizationTests.cs ..\..\Infrastructure\LidarIntensity.cs ..\..\Infrastructure\PreparedLasFile.cs ..\..\Infrastructure\LasBatchStreamWriter.cs ..\..\Infrastructure\LasColoredPoint.cs "..\..\Infrastructure\LasStreamWriter .cs"
if errorlevel 1 (set "RC=1" & goto :done)
bin\LasWriterFinalizationTests.exe
if errorlevel 1 set "RC=1"

"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.LasPairPublicationTests /out:bin\LasPairPublicationTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" CharacterizationStubs.cs LasWriterCharacterizationStubs.cs LasPairPublicationTests.cs ..\..\Infrastructure\PreparedLasFile.cs ..\..\Infrastructure\LasPairPublication.cs "..\..\Infrastructure\LasStreamWriter .cs"
if errorlevel 1 (set "RC=1" & goto :done)
bin\LasPairPublicationTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 11: project/align scoped v2 repository ----
if not exist "%SYSWEB%" (echo ERROR: .NET 3.5 System.ServiceModel.Web.dll is required. & set "RC=1" & goto :done)
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.ScopedPolygonRepositoryTests /out:bin\ScopedPolygonRepositoryTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%F2%\System.Xml.dll" /r:"%F30%\Windows Communication Foundation\System.Runtime.Serialization.dll" /r:"%SYSWEB%" /r:"%SYSCORE%" Stubs.cs ScopedPolygonRepositoryTests.cs ..\..\Domain\Persistence\PolygonScope.cs ..\..\Domain\Persistence\ScopedPolygonRecord.cs ..\..\Domain\Persistence\ScopedPolygonRepository.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\ScopedPolygonRepositoryTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 12: actual surface append source with fault-injecting SDK stubs ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.FastSurfaceBuilderFailureTests /out:bin\FastSurfaceBuilderFailureTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" FastSurfaceBuilderFailureStubs.cs FastSurfaceBuilderFailureTests.cs ..\..\Domain\Service\FastSurfaceBuilder.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\FastSurfaceBuilderFailureTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 13: captured surface target and delegated apply ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.TopomaticSurfaceWriterTests /out:bin\TopomaticSurfaceWriterTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" FastSurfaceBuilderFailureStubs.cs TopomaticSurfaceWriterTests.cs ..\..\Domain\Service\FastSurfaceBuilder.cs ..\..\Application\TopomaticSurfaceWriter.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\TopomaticSurfaceWriterTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 14: CRS drawing remains bound to its captured context ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.CrsDrawLineContextTests /out:bin\CrsDrawLineContextTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" CrsDrawLineContextTests.cs ..\..\Domain\Service\CrsDrawLineContext.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\CrsDrawLineContextTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 15: interactive polygon fill cannot stall on flat geometry ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.ScanlineFillPlannerTests /out:bin\ScanlineFillPlannerTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" ScanlineFillPlannerTests.cs ..\..\Domain\Service\ScanlineFillPlanner.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\ScanlineFillPlannerTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 16: 3D ground options remain fixed across export batches ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.GraphGround3DSnapshotTests /out:bin\GraphGround3DSnapshotTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" CharacterizationStubs.cs GraphGround3DSnapshotTests.cs SettingsDefaultsStub.cs ..\..\Infrastructure\ParallelWorkRunner.cs ..\..\Infrastructure\TopomaticIndexScheduler.cs ..\..\Infrastructure\GraphGround3DSettingsAdapter.cs ..\..\Domain\Models\GraphGround3DOptions.cs ..\..\Domain\Filters\GraphGround3DFilter.cs ..\..\Infrastructure\RuntimeConfig.cs ..\..\Domain\Models\PlanSurfaceSettings.cs ..\..\Domain\Models\FilterOperationSnapshot.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\GraphGround3DSnapshotTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 17: existing non-spline ground path remains bit-exact ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.MinWeightedGroundBaselineTests /out:bin\MinWeightedGroundBaselineTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" Stubs.cs MinWeightedGroundBaselineTests.cs ..\..\Domain\Filters\MinWeightedGroundLevelMedianFilter.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\MinWeightedGroundBaselineTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 18: shared Plan/CRS polygon membership preserves boundary rules ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.PolygonGeometryHelperTests /out:bin\PolygonGeometryHelperTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" Stubs.cs PolygonGeometryHelperTests.cs ..\..\Domain\Service\PolygonGeometry.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\PolygonGeometryHelperTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 19: shared Plan polygon bounds preserve inflation semantics ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.PolygonBoundsHelperTests /out:bin\PolygonBoundsHelperTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" Stubs.cs PolygonBoundsHelperTests.cs ..\..\Domain\Models\PlanPolygonEntry.cs ..\..\Domain\Service\PolygonBounds.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\PolygonBoundsHelperTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 20: operation-scoped SDK collection status and raw point ownership ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_collection_status.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 20b: actual OnePass collection parity for planned stations ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_station_onepass.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 21: both batch reduction commands suppress partial publication ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_reduce_command_status.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 22: Plan polygon scan cancellation and worker faults ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.PlanPolygonScanStateTests /out:bin\PlanPolygonScanStateTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" PlanPolygonScanStateTests.cs ..\..\Infrastructure\ParallelWorkRunner.cs ..\..\UseCases\PlanPolygonScanState.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\PlanPolygonScanStateTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 23: Plan surface settings remain fixed for one operation ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.PlanSurfaceSettingsTests /out:bin\PlanSurfaceSettingsTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" PlanSurfaceSettingsTests.cs ..\..\Domain\Models\PlanSurfaceSettings.cs ..\..\Domain\Models\FilterOperationSnapshot.cs ..\..\Infrastructure\RuntimeConfig.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\PlanSurfaceSettingsTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 24: execute both production Plan surface commands with SDK fault injection ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_plan_surface_commands.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 25: production polynomial fit on known planes and grids ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.PolynomialSurfaceFitterTests /out:bin\PolynomialSurfaceFitterTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" PolynomialSurfaceFitterTests.cs ..\..\Domain\Service\PolynomialSurfaceFitter.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\PolynomialSurfaceFitterTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 26: production CRS delete command with bounded export and fault injection ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_crs_delete_command.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 27: production Plan delete command and real LAS publication ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_plan_delete_command.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 28: project-owned polygon context resolution ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_polygon_context_resolver.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 29: v2 CRS polygons bind by section ID and station ----
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.CrsScopedSectionAssociationTests /out:bin\CrsScopedSectionAssociationTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" Stubs.cs CrsScopedSectionAssociationTests.cs ..\..\Domain\Persistence\PolygonScope.cs ..\..\Domain\Persistence\ScopedPolygonRecord.cs ..\..\Domain\Service\CrsSectionAssociation.cs ..\..\Domain\Service\CrsScopedSectionAssociation.cs
if errorlevel 1 (set "RC=1" & goto :done)
bin\CrsScopedSectionAssociationTests.exe
if errorlevel 1 set "RC=1"

rem ---- Stage 30: production split command leaves CAD sections intact ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_split_command.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 30b: disk-backed split input preserves seeded sampling and cleans up ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_spilled_point_list.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 31: plugin commands reject concurrent and nested execution ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_plugin_operation_gate.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 32: diagnostic IPC model access runs under the UI dispatcher ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_diagnostic_ui_dispatcher.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 33: production LAS save service and pair publication ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_save_lidar_points_service.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 34: CRS interactive command retains one border setting ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_crs_draw_thickness_command.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 35: fixed and prompted section steps select the correct path ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_section_step_command.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 36: production Plan drawing stays bound to its captured context ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_plan_draw_command.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 37: confirmed polygon clear stays bound to captured context ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_polygon_clear_commands.ps1
if errorlevel 1 set "RC=1"

rem ---- Portable polygon save/load commands ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_polygon_file_commands.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 38: selected LAS export source remains fixed through dialogs ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_las_export_source_context.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 39: real LiDAR provider enumeration stays stable and ordered ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_lidar_buffer_service.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 40: extracted grid feature detector retains golden XYZ output ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_grid_feature_detector.ps1
if errorlevel 1 set "RC=1"

rem ---- Stage 41: grid minimum-Z reduction preserves signed cells and ties ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_grid_min_z.ps1
if errorlevel 1 set "RC=1"

rem ---- MCP section density/probe ----
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_section_density.ps1
if errorlevel 1 set "RC=1"
powershell.exe -NoProfile -ExecutionPolicy Bypass -File run_section_probe.ps1
if errorlevel 1 set "RC=1"

:done
popd
exit /b %RC%
