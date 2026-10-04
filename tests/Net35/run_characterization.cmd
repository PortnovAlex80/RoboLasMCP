@echo off
rem Worker-local characterization runner (Wave 0 / PR-01). LEAD NOTE: this file
rem is deliberately separate from run.cmd; when the characterization suite is
rem promoted, add the production files listed below to run.cmd's csc line and
rem retire this script.
rem
rem Compiles the existing regression files UNCHANGED (Stubs.cs,
rem RegressionTests.cs) plus the characterization suite, and selects the
rem characterization entry point with /main (both files define a Main).
rem Same compiler contract as run.cmd: v3.5 csc, /noconfig /nostdlib+, refs
rem from %WINDIR%\Microsoft.NET\Framework\v2.0.50727 and v3.5. No .NET 4.
setlocal
set "F2=%WINDIR%\Microsoft.NET\Framework\v2.0.50727"
set "F35=%WINDIR%\Microsoft.NET\Framework\v3.5"
if not exist "%F35%\csc.exe" (
  echo ERROR: The .NET Framework 3.5 compiler is required. No fallback to .NET 4 is allowed.
  exit /b 2
)
rem DEVIATION from run.cmd (verified 2026-09-27): on this machine
rem %WINDIR%\Microsoft.NET\Framework\v3.5\System.Core.dll does NOT exist ??? the
rem 3.5 framework directory carries only compiler/tooling assemblies, so even
rem run.cmd fails with CS0006. Resolve System.Core from the installed
rem alternatives: reference assemblies first, then the GAC.
set "SYSCORE=%F35%\System.Core.dll"
if not exist "%SYSCORE%" set "SYSCORE=%ProgramFiles(x86)%\Reference Assemblies\Microsoft\Framework\v3.5\System.Core.dll"
if not exist "%SYSCORE%" set "SYSCORE=%WINDIR%\assembly\GAC_MSIL\System.Core\3.5.0.0__b77a5c561934e089\System.Core.dll"
if not exist "%SYSCORE%" (
  echo ERROR: No .NET 3.5 System.Core.dll found ^(framework dir, reference assemblies or GAC^).
  exit /b 2
)
pushd "%~dp0"
if not exist bin mkdir bin
rem v3.5 csc itself enforces C# 3.0; old compilers need /langversion:default, not :3.
rem Production files included (all verified C# 3.0-clean; see the Wave 0 report):
rem   Infrastructure/ParallelWorkRunner.cs        (unchanged from run.cmd)
rem   Domain/Models/PointKey2D.cs, PointKey3D.cs  (unchanged from run.cmd)
rem   Domain/Filters/SplitAndMergeAlgorithm.cs    (unchanged from run.cmd)
rem   Domain/Filters/OrderByX.cs, GraphGroundFilter.cs, GraphGroundDebugInfo.cs
rem   Domain/Filters/BreakDetector.cs, SegmentBoundary.cs
rem   tests/LegacyAlgorithms/SmoothingSplineFilter.cs
rem   Domain/Models/LasSectionPoints.cs
rem   Services/SamplingHelper.cs                  (needs Vector4D stub)
rem NOT included and why:
rem   RobustGroundSplineFilter.cs ??? C# 4 NAMED ARGUMENTS at line 344
rem       (solver.Solve(ys, ones, smooth: 0.0, ridgeEps: stableRidge))
rem   SmoothingBSplineFilter.cs   ??? C# 4 named arguments, lines 67-75
rem       (BSplineApproximator constructor call)
rem   FilterAggregator.cs, MinWeightedGroundLevelMedianFilter.cs,
rem   SmoothingCSplineFilter.cs  ??? C# 6 syntax (null-conditional / using static /
rem       expression-bodied property); FilterAggregator and SmoothingCSpline
rem       also need RuntimeConfig members the shared Stubs.cs lacks
rem   GraphGround3DFilter.cs     ??? C# 4 optional parameter + SDK Parallel/Vector4D
rem   LasFilterService.cs        ??? C#3-clean but needs Vector2D operators and a
rem                                Vector3D stub that Stubs.cs does not provide
rem   LasSectionPointsCollectorService.cs, GroundPointsCollector*.cs ??? SDK-bound
"%F35%\csc.exe" /nologo /noconfig /nostdlib+ /langversion:default /target:exe /main:LAS_TERRAIN.Tests.CharacterizationTests /out:bin\CharacterizationTests.exe /r:"%F2%\mscorlib.dll" /r:"%F2%\System.dll" /r:"%SYSCORE%" Stubs.cs CharacterizationStubs.cs RegressionTests.cs CharacterizationTests.cs ..\fixtures\FixtureData.cs ..\..\Infrastructure\ParallelWorkRunner.cs ..\..\Domain\Models\PointKey2D.cs ..\..\Domain\Models\PointKey3D.cs ..\..\Domain\Models\LasSectionPoints.cs ..\..\Domain\Models\FilterOperationSnapshot.cs ..\..\Domain\Filters\SplitAndMergeAlgorithm.cs ..\..\Domain\Filters\OrderByX.cs ..\..\Domain\Filters\GraphGroundFilter.cs ..\..\Domain\Filters\GraphGroundDebugInfo.cs ..\..\Domain\Filters\BreakDetector.cs ..\..\Domain\Filters\SegmentBoundary.cs ..\LegacyAlgorithms\SmoothingSplineFilter.cs ..\..\Services\SamplingHelper.cs
if errorlevel 1 (popd & exit /b 1)
bin\CharacterizationTests.exe
set "RESULT=%ERRORLEVEL%"
popd
exit /b %RESULT%
