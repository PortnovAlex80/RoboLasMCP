"""Focused tests for the computation dependency guard."""

import sys
import tempfile
import unittest
from pathlib import Path


sys.path.insert(0, str(Path(__file__).resolve().parents[2] / "tools" / "architecture"))
from check_boundaries import check_tree, inspect_source  # noqa: E402


class BoundaryCheckerTests(unittest.TestCase):
    def references(self, source):
        return {reference for _, _, reference in inspect_source(source)}

    def test_using_and_using_static(self):
        refs = self.references("using System.IO;\nusing static Topomatic.Controls.NativeMethods;")
        self.assertIn("System.IO", refs)
        self.assertIn("Topomatic.Controls.NativeMethods", refs)

    def test_qualified_references_without_using(self):
        refs = self.references(
            "var f = global::System.IO.File.Exists(path);\n"
            "var c = LAS_TERRAIN.Configuration.RuntimeConfig.CSplineSmooth;\n"
            "Topomatic.Cad.View.CadView view;"
        )
        self.assertIn("System.IO.File.Exists", refs)
        self.assertIn("LAS_TERRAIN.Configuration.RuntimeConfig.CSplineSmooth", refs)
        self.assertIn("Topomatic.Cad.View.CadView", refs)

    def test_geometry_allowlist(self):
        self.assertEqual([], inspect_source(
            "using Topomatic.Cad.Foundation;\n"
            "var x = Topomatic.Cad.Foundation.Vector2D.Zero.X;"
        ))
        self.assertIn("Topomatic.Cad.Foundation.Surface.Points.Add",
                      self.references("Topomatic.Cad.Foundation.Surface.Points.Add(p);"))

    def test_comments_and_literals_are_ignored(self):
        self.assertEqual([], inspect_source(
            '/* using System.IO; */\n'
            '// Topomatic.Cad.View.CadView\n'
            'var s = "RuntimeConfig // System.IO.File";\n'
            "var c = 'x';\n"
        ))

    def test_unqualified_global_and_ui_symbols(self):
        refs = self.references("var n = RuntimeConfig.SplitMergeTolerance; MessageBox.Show(n);")
        self.assertIn("RuntimeConfig", refs)
        self.assertIn("MessageBox", refs)

    def test_missing_sources_are_checker_errors(self):
        with tempfile.TemporaryDirectory() as directory:
            findings, errors = check_tree(Path(directory))
        self.assertEqual([], findings)
        self.assertTrue(errors)

    def test_mutable_static_parameter_but_not_readonly_or_method(self):
        refs = self.references(
            "public static double BinX = 1.0;\n"
            "private static readonly double DefaultBinX = 1.0;\n"
            "public static double Smooth { get; set; }\n"
            "public static double Computed { get { return 1.0; } }\n"
            "public static double Apply(double input) { return input; }"
        )
        self.assertIn("BinX", refs)
        self.assertIn("Smooth", refs)
        self.assertNotIn("DefaultBinX", refs)
        self.assertNotIn("Computed", refs)
        self.assertNotIn("Apply", refs)


if __name__ == "__main__":
    unittest.main()
