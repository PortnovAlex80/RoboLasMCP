# Topomatic API Catalog -- Verification Report

> Generated: 2026-05-19
> Target: Topomatic Robur Rail 16.0 (build 16.0.42.24)
> Source path: `C:\Program Files\Topomatic Robur Rail 16.0\`

---

## 1. Completeness Summary

| Metric | Count |
|--------|-------|
| DLLs on disk (Topomatic.*.dll) | 189 |
| Catalog files (.md in dlls/) | 171 |
| Missing from catalog | 18 |
| Extra in catalog (not on disk) | 0 |
| **Completeness** | **90.5%** |

## 2. Missing DLLs (18 total)

### ACAX Platform Wrappers -- 14 DLLs (Low Priority)

These are AutoCAD interop bridges for different ACAD versions. They contain only COM wrappers and are not useful for plugin development.

| DLL | Notes |
|-----|-------|
| Topomatic.Acax18x64.Com | AutoCAD 2018 x64 COM bridge |
| Topomatic.Acax18x86.Com | AutoCAD 2018 x86 COM bridge |
| Topomatic.Acax19x64.Com | AutoCAD 2019 x64 COM bridge |
| Topomatic.Acax19x86.Com | AutoCAD 2019 x86 COM bridge |
| Topomatic.Acax20x64.Com | AutoCAD 2020 x64 COM bridge |
| Topomatic.Acax20x86.Com | AutoCAD 2020 x86 COM bridge |
| Topomatic.Acax21x64.Com | AutoCAD 2021 x64 COM bridge |
| Topomatic.Acax21x86.Com | AutoCAD 2021 x86 COM bridge |
| Topomatic.Acax22x32.Com | AutoCAD 2022 x32 COM bridge |
| Topomatic.Acax22x64.Com | AutoCAD 2022 x64 COM bridge |
| Topomatic.Acax23x64.Com | AutoCAD 2023 x64 COM bridge |
| Topomatic.Acax23x86.Com | AutoCAD 2023 x86 COM bridge |
| Topomatic.Acax24x64.Com | AutoCAD 2024 x64 COM bridge |

**Recommendation**: Safe to skip. These are versioned COM interop shims with no public API value for LAS_TERRAIN.

### Rail Alignment -- 1 DLL (Medium Priority)

| DLL | Notes |
|-----|-------|
| Topomatic.Alg.Rail.Sheets | Rail alignment sheet/document generation |

**Recommendation**: Should be cataloged. May contain relevant sheet layout APIs for rail sections.

### Intelligent Transport Systems -- 4 DLLs (Low-Medium Priority)

| DLL | Notes |
|-----|-------|
| Topomatic.Its | ITS core module |
| Topomatic.Its.Controller | ITS controller/plugin host |
| Topomatic.Its.Core | ITS data model |
| Topomatic.Its.Layers | ITS visualization layers |

**Recommendation**: Low priority for LAS_TERRAIN (ITS = road signage/traffic systems), but should be cataloged for completeness.

## 3. Quality Assessment

### 3a. Format Consistency

The catalog has **4 distinct format styles** across the 171 files, reflecting generation from different scripts/iterations:

| Format | Count | Description |
|--------|-------|-------------|
| Format A | 86 | `Assembly: \`name\`` header, `### Type (class)` headings, table-based methods/properties |
| Format B | 28 | `Assembly: name` (no backtick), similar structure to A |
| Format C | 5 | `**Assembly**: name` (bold), narrative descriptions with code blocks |
| Format D | 52 | Mixed: `.dll` in title, `**Runtime**:`, `**Full Name**:`, `**Size**:` headers |

**Impact**: No functional impact -- all formats contain usable type information. But inconsistent formatting makes bulk parsing harder.

### 3b. Content Depth

| Size Category | Count | Description |
|---------------|-------|-------------|
| Large (>1000 lines) | 26 | Comprehensive coverage (e.g., Topomatic.Pipes = 6907 lines, 362 types) |
| Medium (100-1000 lines) | 71 | Good coverage of main types |
| Small (<100 lines) | 74 | Minimal types or small assemblies |

**Notable large catalogs**: Topomatic.Pipes (6907 lines, 362 types), Topomatic.Pipes.Layers (5089 lines, 278 types), Topomatic.Alg.Road (4369 lines, 151 types), Topomatic.Controls (3019 lines, 163 types).

### 3c. Empty/Stub Files

**Zero** catalog files are empty stubs. All 171 files contain at least one type definition with properties or methods. No files have fewer than 10 lines.

### 3d. Sample Quality Check (10 random files)

| File | Types | Verdict |
|------|-------|---------|
| Topomatic.Visualization.Tools.md | 1+ classes with static methods | Good -- real method signatures |
| Topomatic.ExportDocumentation.md | Classes with properties | Good -- inheritance chain documented |
| Topomatic.EmtDwg.Controller.md | 3 classes | Good -- method params documented |
| Topomatic.Dwg.Controller.md | 2 classes | Good -- constructor and properties |
| Topomatic.Alg.CogoController.md | Classes, enums | Good -- enum values listed |
| Topomatic.Genplan.Controller.md | Abstract classes | Good -- static methods documented |
| Topomatic.Arrangements.md | Class with 10+ interfaces | Good -- complex interface chains |
| Topomatic.Alg.Road.Crossing.md | 25 public types | Good -- constructors, properties, methods |
| Topomatic.Cartograms.md | Class with properties | Good -- property types documented |
| Topomatic.Brep.Controller.md | 2 classes | Good -- minimal but accurate |

**All 10 sampled files contain real, usable API data.**

## 4. our-api-usage.md

| Metric | Value |
|--------|-------|
| Exists | Yes |
| Size | 910 lines |
| Sections | 15 |

Sections cover: DLL references, namespaces, plugin hosting, command registration, alignment/trace access, surface/TIN access, LiDAR data access, dialogs, custom layers, geometry, settings persistence, parallel processing, stream extensions, key class reference, and data flow patterns.

**Verdict**: Comprehensive and well-structured. Directly maps LAS_TERRAIN code to Topomatic API usage.

## 5. Overall Assessment

| Criterion | Rating | Notes |
|-----------|--------|-------|
| Coverage | 90.5% | 171/189 DLLs cataloged |
| Functional coverage | ~96% | 14 missing DLLs are ACAX wrappers (irrelevant); only 4 ITS + 1 Rail missing |
| Content quality | Good | All files have real type data, no empty stubs |
| Format consistency | Fair | 4 different format styles; should normalize |
| API usage doc | Excellent | 910-line our-api-usage.md with 15 sections |

## 6. Recommendations

1. **Catalog 4 ITS DLLs** (Topomatic.Its.*) -- low effort, improves completeness
2. **Catalog Topomatic.Alg.Rail.Sheets** -- directly relevant to rail alignment work
3. **Skip 14 ACAX DLLs** -- COM wrappers with no plugin API value
4. **Normalize format** -- pick one canonical format and re-generate inconsistent files
5. **With ACAX excluded, effective completeness is 171/175 = 97.7%**
