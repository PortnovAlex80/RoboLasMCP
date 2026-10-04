"""Check computation sources for UI, host, persistence and global-setting dependencies.

Run from any directory: python tools/architecture/check_boundaries.py
Exit 0: clean; 1: boundary violations; 2: checker/input error.

This is a source dependency guard, not a C# compiler or call-graph analyzer.
It masks comments and literals, then inspects identifiers and qualified names.
The checked source list is intentional: CAD writers, collectors and file-backed
repositories are adapters, not computation modules.
"""

from __future__ import annotations

import argparse
import re
import sys
from pathlib import Path


COMPUTATION_FILES = (
    "Domain/Filters/*.cs",
    "Domain/Service/LasFilterService.cs",
    "Domain/Service/PolynomialSurfaceFitter.cs",
    "Domain/Service/GridCellIndex.cs",
    "Domain/Service/GridFeatureDetector.cs",
    "Domain/Service/GridMinZAccumulator.cs",
    "Domain/Service/CrsSectionAssociation.cs",
    "Domain/Models/FilterOperationSnapshot.cs",
    "Domain/Models/LasFilterOptions.cs",
    "Domain/Models/LasSectionPoints.cs",
    "Domain/Models/PointKey2D.cs",
    "Domain/Models/PointKey3D.cs",
    "Application/SectionWorkflow.cs",
    "Application/SectionRequest.cs",
    "Application/OperationResult.cs",
    "Services/SamplingHelper.cs",
    "Services/SectionStationPlanner.cs",
    "Infrastructure/ParallelWorkRunner.cs",
)

# Only the Foundation vector types are approved SDK dependencies in this core.
# A namespace using is permitted so existing unqualified Vector2D/3D/4D compile.
ALLOWED_SDK_QUALIFIED = {
    "Topomatic.Cad.Foundation.Vector2D",
    "Topomatic.Cad.Foundation.Vector3D",
    "Topomatic.Cad.Foundation.Vector4D",
}
ALLOWED_SDK_USING = "Topomatic.Cad.Foundation"

FORBIDDEN_PREFIXES = {
    "Topomatic.Alg": "SDK model",
    "Topomatic.ApplicationPlatform": "active host/document",
    "Topomatic.Cad.View": "CAD UI",
    "Topomatic.Controls": "Topomatic UI",
    "Topomatic.FoundationClasses": "non-geometry SDK",
    "Topomatic.Lidar": "live LiDAR SDK",
    "Topomatic.Sfc": "surface SDK",
    "System.IO": "file persistence",
    "System.Windows.Forms": "UI",
    "System.Runtime.Serialization": "serialization",
    "System.Xml": "serialization",
    "Microsoft.Win32": "host settings",
    "LAS_TERRAIN.Configuration": "global configuration",
    "LAS_TERRAIN.Infrastructure.RuntimeConfig": "global configuration",
    "LAS_TERRAIN.Settings": "global settings",
    "LAS_TERRAIN.SettingsDefaults": "global settings",
}

FORBIDDEN_IDENTIFIERS = {
    "ApplicationHost": "active host/document",
    "CadView": "CAD UI",
    "MessageBox": "UI",
    "WaitProgress": "UI progress",
    "RuntimeConfig": "global configuration",
    "Settings": "global settings",
    "SettingsDefaults": "global settings",
    "File": "file persistence",
    "Directory": "file persistence",
    "FileInfo": "file persistence",
    "DirectoryInfo": "file persistence",
    "FileStream": "file persistence",
    "StreamReader": "file persistence",
    "StreamWriter": "file persistence",
    "BinaryReader": "file persistence",
    "BinaryWriter": "file persistence",
    "Surface": "SDK surface mutation",
    "Alignment": "live SDK model",
    "LidarBuffer": "live LiDAR SDK",
}

# Sequential matching means a // inside a string is treated as literal text.
MASK = re.compile(
    r"/\*[\s\S]*?\*/|//[^\r\n]*|@\"(?:\"\"|[^\"])*\"|"
    r"\"(?:\\.|[^\"\\])*\"|'(?:\\.|[^'\\])*'"
)
TOKEN = re.compile(r"[A-Za-z_][A-Za-z_0-9]*|::|\.")
MUTABLE_STATIC = re.compile(
    r"(?m)^\s*(?:public|internal|private|protected)\s+static\s+"
    r"(?!readonly\b|class\b)(?:[\w.<>,?\[\]]+)\s+"
    r"([A-Za-z_][A-Za-z_0-9]*)\s*([=;{])"
)


def mask_literals(source: str) -> str:
    def blank(match: re.Match[str]) -> str:
        return re.sub(r"[^\r\n]", " ", match.group())

    return MASK.sub(blank, source)


def property_has_setter(clean: str, open_brace: int) -> bool:
    depth = 0
    for position in range(open_brace, len(clean)):
        if clean[position] == "{":
            depth += 1
        elif clean[position] == "}":
            depth -= 1
            if depth == 0:
                body = clean[open_brace:position]
                return re.search(r"\bset\b", body) is not None
    return False


def inspect_source(source: str) -> list[tuple[int, str, str]]:
    """Return (line, rule, reference) for disallowed source references."""
    clean = mask_literals(source)
    tokens = list(TOKEN.finditer(clean))
    findings: list[tuple[int, str, str]] = []
    line_by_offset = [0] * (len(clean) + 1)
    line = 1
    for offset, char in enumerate(clean):
        line_by_offset[offset] = line
        if char == "\n":
            line += 1

    for index, token in enumerate(tokens):
        word = token.group()
        if word in FORBIDDEN_IDENTIFIERS:
            findings.append((line_by_offset[token.start()],
                             FORBIDDEN_IDENTIFIERS[word], word))

        if word in (".", "::") or (index > 0 and tokens[index - 1].group() in (".", "::")):
            continue
        names = [word]
        end = token.end()
        cursor = index + 1
        while cursor + 1 < len(tokens):
            separator, following = tokens[cursor], tokens[cursor + 1]
            if (separator.group() not in (".", "::") or
                    clean[end:separator.start()].strip() or
                    clean[separator.end():following.start()].strip() or
                    not re.fullmatch(r"[A-Za-z_][A-Za-z_0-9]*", following.group())):
                break
            names.append(following.group())
            end = following.end()
            cursor += 2
        if len(names) < 2:
            continue
        qualified = ".".join(names)
        if qualified.startswith("global."):
            qualified = qualified[7:]
        if qualified == ALLOWED_SDK_USING:
            continue
        if qualified.startswith(ALLOWED_SDK_USING + "."):
            if any(qualified == allowed or qualified.startswith(allowed + ".")
                   for allowed in ALLOWED_SDK_QUALIFIED):
                continue
            reason = "unapproved SDK type"
        else:
            reason = next((label for prefix, label in FORBIDDEN_PREFIXES.items()
                           if qualified == prefix or qualified.startswith(prefix + ".")), None)
        if reason:
            findings.append((line_by_offset[token.start()], reason, qualified))

    for declaration in MUTABLE_STATIC.finditer(clean):
        if declaration.group(2) == "{" and not property_has_setter(clean, declaration.start(2)):
            continue
        findings.append((line_by_offset[declaration.start(1)],
                         "mutable static parameter", declaration.group(1)))

    return sorted(set(findings))


def check_tree(root: Path) -> tuple[list[tuple[str, int, str, str]], list[str]]:
    findings: list[tuple[str, int, str, str]] = []
    errors: list[str] = []
    for pattern in COMPUTATION_FILES:
        matches = sorted(root.glob(pattern))
        if not matches:
            errors.append("No source matched " + pattern)
            continue
        for path in matches:
            try:
                source = path.read_text(encoding="utf-8-sig")
            except (OSError, UnicodeError) as error:
                errors.append(str(path) + ": " + str(error))
                continue
            relative = path.relative_to(root).as_posix()
            findings.extend((relative, line, rule, reference)
                            for line, rule, reference in inspect_source(source))
    return sorted(findings), errors


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--root", type=Path,
                        default=Path(__file__).resolve().parents[2],
                        help="LAS_TERRAIN repository root")
    args = parser.parse_args()
    findings, errors = check_tree(args.root.resolve())
    for error in errors:
        print("CHECKER ERROR: " + error, file=sys.stderr)
    for path, line, rule, reference in findings:
        print("{}:{}: {}: {}".format(path, line, rule, reference))
    print("Architecture boundary: {} violation(s), {} checker error(s).".format(
        len(findings), len(errors)))
    return 2 if errors else (1 if findings else 0)


if __name__ == "__main__":
    raise SystemExit(main())
