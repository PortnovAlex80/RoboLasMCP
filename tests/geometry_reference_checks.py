"""Independent Python geometry checks and source smoke checks.
These execute mathematical models, NOT the production C# or the Topomatic SDK.
Run the separate Net35/run.cmd harness on Windows to execute the linked C# core.
"""
import math
import random
import re
import unittest
import xml.etree.ElementTree as ET
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]


def simplify(points, tolerance):
    """Model of the revised iterative point-to-segment algorithm."""
    if not math.isfinite(tolerance) or tolerance < 0:
        raise ValueError('tolerance')
    tolerance = max(tolerance, 1e-9)
    if any(not math.isfinite(v) for p in points for v in p):
        raise ValueError('points')
    if len(points) < 2:
        return list(points)
    keep = {0, len(points) - 1}
    stack = [(0, len(points) - 1)]
    while stack:
        start, end = stack.pop()
        first, last = points[start], points[end]
        dx, dy = last[0] - first[0], last[1] - first[1]
        scale = max(abs(dx), abs(dy))
        length = ux = uy = 0.0
        if scale:
            norm = math.sqrt((dx / scale) ** 2 + (dy / scale) ** 2)
            length, ux, uy = scale * norm, dx / scale / norm, dy / scale / norm
        maximum, split = tolerance * tolerance, -1
        for i in range(start + 1, end):
            px, py = points[i][0] - first[0], points[i][1] - first[1]
            along = px * ux + py * uy
            if not length or along <= 0:
                distance = px * px + py * py
            elif along >= length:
                distance = (points[i][0] - last[0]) ** 2 + (points[i][1] - last[1]) ** 2
            else:
                distance = (px * uy - py * ux) ** 2
            if distance > maximum:
                maximum, split = distance, i
        if split >= 0:
            keep.add(split)
            stack.extend(((split, end), (start, split)))
    result = []
    for i in sorted(keep):
        if not result or result[-1] != points[i]:
            result.append(points[i])
    return result


def reference_segment_distance(p, a, b):
    """Independent projection formula for the error-bound oracle."""
    dx, dy = b[0] - a[0], b[1] - a[1]
    denominator = dx * dx + dy * dy
    t = 0 if not denominator else max(0, min(1, ((p[0] - a[0]) * dx + (p[1] - a[1]) * dy) / denominator))
    return math.hypot(p[0] - (a[0] + t * dx), p[1] - (a[1] + t * dy))


def old_xy_key(x, y):
    return ((int(x * 1000) & 0xffffffff) << 32) | (int(y * 1000) & 0xffffffff)


def xy_cell(x, y):
    return math.floor(x * 1000), math.floor(y * 1000)


class GeometryReferenceChecks(unittest.TestCase):
    def test_old_coordinate_wrap_reproduced_and_removed(self):
        self.assertEqual(old_xy_key(0, 0), old_xy_key(4294967.296, 0))
        self.assertNotEqual(xy_cell(0, 0), xy_cell(4294967.296, 0))

    def test_negative_grid_and_raw_z_semantics(self):
        self.assertNotEqual(xy_cell(-0.0001, 0), xy_cell(0.0001, 0))
        self.assertEqual(xy_cell(-0.0001, 0), xy_cell(-0.0002, 0))
        self.assertEqual(len({(1., 2., 3.), (1., 2., 4.)}), 2)
        self.assertEqual(len({xy_cell(1., 2.), xy_cell(1., 2.)}), 1)

    def test_closed_and_backtracking_profiles(self):
        for points in [[(0, 0), (1, 1), (0, 0)], [(0, 0), (2, 0), (1, 0)]]:
            self.assertEqual(simplify(points, 0.01), points)

    def test_lines_duplicates_and_empty(self):
        self.assertEqual(simplify([(0, 0), (1, 1), (2, 2)], 0.01), [(0, 0), (2, 2)])
        self.assertEqual(simplify([(1, 1)] * 5, 0.01), [(1, 1)])
        self.assertEqual(simplify([], 0.01), [])

    def test_error_bound_on_500_profiles(self):
        rng = random.Random(3501)
        for _ in range(500):
            points = [(i * 0.25, math.sin(i * 0.17) + rng.uniform(-0.2, 0.2)) for i in range(50)]
            result = simplify(points, 0.12)
            self.assertEqual((result[0], result[-1]), (points[0], points[-1]))
            for point in points:
                distance = min(reference_segment_distance(point, a, b) for a, b in zip(result, result[1:]))
                self.assertLessEqual(distance, 0.12 + 1e-10)

    def test_large_coordinate_translation(self):
        points = [(0., 0.), (1., .025), (2., 0.), (3., .05), (4., 0.)]
        shifted = [(x + 1e9, y + 1e9) for x, y in points]
        a, b = simplify(points, .01), simplify(shifted, .01)
        self.assertEqual([p[0] for p in a], [p[0] - 1e9 for p in b])

    def test_projection_origin_for_custom_width(self):
        left_world_x, custom_left = 90.0, 10.0
        along, world_z = 13.0, 123.45
        lateral = along - custom_left
        self.assertEqual(lateral, 3.0)
        self.assertEqual(left_world_x + custom_left + lateral, 103.0)
        self.assertEqual(world_z, 123.45)

    def test_rotated_and_negative_scale_culling_2000_boxes(self):
        rng = random.Random(3502)
        for _ in range(2000):
            angle = rng.uniform(-math.pi, math.pi)
            ux, uy = math.cos(angle), math.sin(angle)
            length, half_border = rng.uniform(1, 200), rng.uniform(.01, 1)
            along, normal = rng.uniform(0, length), rng.uniform(-half_border, half_border)
            px, py = along * ux + normal * uy, along * uy - normal * ux
            # Build a box containing this accepted point, then reverse its endpoints
            # to model a negative indexer scale. Culling must never reject it.
            x1, x2 = px + rng.random(), px - rng.random()
            y1, y2 = py + rng.random(), py - rng.random()
            lo_x, hi_x, lo_y, hi_y = min(x1, x2), max(x1, x2), min(y1, y2), max(y1, y2)
            rx, ry = (hi_x - lo_x) / 2, (hi_y - lo_y) / 2
            cx, cy = lo_x + rx, lo_y + ry
            self.assertLessEqual(abs(cx * uy - cy * ux), half_border + rx * abs(uy) + ry * abs(ux) + 1e-10)
            radius, center = rx * abs(ux) + ry * abs(uy), cx * ux + cy * uy
            self.assertGreaterEqual(center, -radius - 1e-10)
            self.assertLessEqual(center, length + radius + 1e-10)

    def test_project_stays_net35_and_links_new_files(self):
        tree = ET.parse(ROOT / 'LAS_TERRAIN.csproj')
        ns = {'m': 'http://schemas.microsoft.com/developer/msbuild/2003'}
        self.assertEqual(tree.find('.//m:TargetFrameworkVersion', ns).text, 'v3.5')
        includes = [x.attrib['Include'].replace('\\', '/') for x in tree.findall('.//m:Compile', ns)]
        for path in ['Infrastructure/ParallelWorkRunner.cs', 'Domain/Models/PointKey2D.cs', 'Domain/Models/PointKey3D.cs']:
            self.assertEqual(includes.count(path), 1)
        self.assertFalse(any(x.startswith('tests/') for x in includes))

    def test_changed_sources_have_no_obvious_modern_syntax_or_tpl(self):
        # A lexical smoke check, explicitly NOT a compiler or API compatibility proof.
        changed = [
            'Infrastructure/ParallelWorkRunner.cs',
            'Domain/Models/PointKey2D.cs', 'Domain/Models/PointKey3D.cs',
            'Domain/Models/LasSectionPoints.cs',
            'Domain/Service/LasFilterService.cs',
            'Domain/Service/LasSectionPointsCollectorService.cs',
            'Services/GroundPointsCollector.cs',
            'Services/GroundPointsCollector.OnePass.cs',
            'Services/RawPointsCollector.cs',
            'Domain/Filters/SplitAndMergeAlgorithm.cs',
            'tests/Net35/Stubs.cs', 'tests/Net35/RegressionTests.cs',
        ]
        for name in changed:
            path = ROOT / name
            source = path.read_text(encoding='utf-8-sig')
            source = re.sub(r'//[^\n]*|/\*.*?\*/', '', source, flags=re.S)
            for pattern in [r'\?\.', r'\$"', r'\b(?:await|async|dynamic|nameof|record)\b', r'\bout\s+(?:var|_)\b', r'\d_\d', r'\bTask\b', r'\bConcurrentDictionary\b', r'\bCancellationToken\b']:
                self.assertIsNone(re.search(pattern, source), (str(path), pattern))


if __name__ == '__main__':
    unittest.main(verbosity=2)
