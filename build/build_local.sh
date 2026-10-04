#!/usr/bin/env bash
# Git Bash wrapper for the safe PowerShell build/package path.
set -euo pipefail

version="${1:-1.0.0}"
output_path="${2:-D:\\LAS_TERRAIN_BUILD}"
sdk_path="${TOPOMATIC_PATH:-}"
if [[ -z "$sdk_path" ]]; then
  echo 'Set TOPOMATIC_PATH to the intended Topomatic SDK copy.' >&2
  exit 2
fi
if ! command -v cygpath >/dev/null 2>&1; then
  echo 'This wrapper requires Git Bash cygpath.' >&2
  exit 2
fi

script_dir="$(cd -- "$(dirname -- "$0")" && pwd)"
script_win="$(cygpath -w "$script_dir/build_local.ps1")"
powershell.exe -NoProfile -ExecutionPolicy Bypass -File "$script_win" \
  -Version "$version" -OutputPath "$output_path" -TopomaticPath "$sdk_path"
