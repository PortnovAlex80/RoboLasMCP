// tests/fixtures/FixtureData.cs
// Canonical, anonymized, deterministic characterization fixtures for the
// LAS_TERRAIN filtering pipeline (Wave 0 / PR-01 groundwork).
//
// WHY LITERAL .CS DATA AND NOT CSV: the only sanctioned test runner is the
// bare .NET Framework 3.5 csc build (tests/Net35/run.cmd). C# 3.0 has no
// built-in CSV facility, so loading CSVs would require parser code inside the
// test assembly — extra uncharacterized code that could itself diverge.
// This file is the single source of truth; tests/fixtures/*.csv are generated
// REVIEW COPIES (tests/fixtures/generate_fixtures.py) for human review and the
// Python cross-check model. The formulas are identical in both; regenerate the
// CSVs after changing anything here.
//
// DETERMINISM: all pseudo-randomness comes from a 32-bit LCG
// (state = state * 1664525 + 1013904223 mod 2^32, seed 123456789) defined
// below. No System.Random is used anywhere in the fixtures. Every fixture
// method resets the seed first, so fixture content does not depend on the
// order in which tests request fixtures.
//
// OWNERSHIP WARNING: every method returns a FRESH list on every call because
// pipeline stages mutate their input (OrderByX sorts in place). Callers must
// request a new list per test, never share one.
//
// Section fixtures use SECTION coordinates: X = distance along the section
// (metres, 0 at the left end), Y = elevation (metres).

using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests.Fixtures
{
    internal static class FixtureData
    {
        private static uint _lcgState;

        private static void ResetSeed()
        {
            _lcgState = 123456789u;
        }

        private static uint Lcg()
        {
            // uint arithmetic wraps mod 2^32 in the default (unchecked) context.
            _lcgState = _lcgState * 1664525u + 1013904223u;
            return _lcgState;
        }

        /// <summary>Deterministic noise uniform in [-amp, amp).</summary>
        private static double Noise(double amp)
        {
            return ((double)(Lcg() % 2000u) / 1000.0 - 1.0) * amp;
        }

        /// <summary>
        /// Fisher-Yates shuffle driven by the same LCG. Consumes LCG state, so
        /// only call it immediately after a fixture method that just reset the
        /// seed (the shuffled fixtures below do exactly that).
        /// </summary>
        private static List<Vector2D> Shuffled(List<Vector2D> source)
        {
            List<Vector2D> copy = new List<Vector2D>(source);
            for (int i = copy.Count - 1; i >= 1; i--)
            {
                int j = (int)(Lcg() % (uint)(i + 1));
                Vector2D tmp = copy[i];
                copy[i] = copy[j];
                copy[j] = tmp;
            }
            return copy;
        }

        // ── Fixture 1: ordinary section ─────────────────────────────────────
        // 41 points, x = 0..20 m step 0.5, gentle 2% rise, ±0.03 m noise.
        // Delivered UNSORTED (fixed LCG permutation) to exercise OrderByX.
        public static List<Vector2D> OrdinarySection()
        {
            ResetSeed();
            List<Vector2D> pts = new List<Vector2D>();
            for (int i = 0; i <= 40; i++)
            {
                double x = i * 0.5;
                pts.Add(new Vector2D(x, 100.0 + 0.02 * x + Noise(0.03)));
            }
            return Shuffled(pts);
        }

        // ── Fixture 2: profile break (embankment slope change) ──────────────
        // 65 points, SORTED by construction (BreakDetector's documented input
        // contract is X-ordered points). Approach ramp with slope 0.5 on
        // [0, 8.0] changing to slope 0.1 on [8.0, 16.0] — a 20.9° break at
        // x = 8.0, z = 14.0. Two-SLOPE design is deliberate: with the product
        // defaults (MinR2 = 0.80) BreakDetector's R² criterion rejects
        // noisy-FLAT windows (fit of pure noise explains ~0% of variance), so
        // a flat/ramp curb produces NO detection; see CurbSection below.
        public static List<Vector2D> ProfileBreakSection()
        {
            ResetSeed();
            List<Vector2D> pts = new List<Vector2D>();
            for (int i = 0; i <= 32; i++)                                  // 33 pts
            {
                double x = i * 0.25;
                pts.Add(new Vector2D(x, 10.0 + 0.5 * x + Noise(0.03)));
            }
            for (int i = 1; i <= 32; i++)                                  // 32 pts
            {
                double x = 8.0 + i * 0.25;
                pts.Add(new Vector2D(x, 14.0 + 0.1 * (x - 8.0) + Noise(0.03)));
            }
            return pts;
        }

        // ── Fixture 2b: curb that BreakDetector does NOT detect ─────────────
        // 65 points, SORTED. Flat lower berm z≈10.00 on [0, 8.0], 0.40 m curb
        // rise over [8.0, 8.75], upper berm z≈10.40 on [9.0, 16.0]. Recorded
        // FALSE NEGATIVE: with product defaults, every candidate window around
        // the curb spans a noisy-flat segment whose LSQ fit has R² < MinR2, so
        // BreakDetector.FindBreaks returns 0 breaks. This test pins that
        // behavior; changing it after PR-03/PR-04 is a documented deviation.
        public static List<Vector2D> CurbSection()
        {
            ResetSeed();
            List<Vector2D> pts = new List<Vector2D>();
            for (int i = 0; i <= 32; i++)                                  // 33 pts
                pts.Add(new Vector2D(i * 0.25, 10.0 + Noise(0.03)));
            for (int i = 1; i <= 3; i++)                                   // 3 curb pts
                pts.Add(new Vector2D(8.0 + i * 0.25,
                    10.0 + i * (0.4 / 3.0) + Noise(0.03)));
            for (int i = 0; i <= 28; i++)                                  // 29 pts
            {
                double x = 9.0 + i * 0.25;
                pts.Add(new Vector2D(x, 10.4 + 0.01 * (x - 9.0) + Noise(0.03)));
            }
            return pts;
        }

        // ── Fixture 3: duplicates ───────────────────────────────────────────
        // 26 points, SORTED by construction. Base profile x = 0..10 step 0.5
        // (21 pts) plus: an exact triple duplicate at x=2.0 (consecutive),
        // a same-X vertical stack at x=5.0 (ground 50.25±noise, then 53.0 and
        // 56.5 = vegetation), an exact double duplicate at x=7.5.
        public static List<Vector2D> DuplicateXYSection()
        {
            ResetSeed();
            List<Vector2D> pts = new List<Vector2D>();
            for (int i = 0; i <= 20; i++)
            {
                double x = i * 0.5;
                pts.Add(new Vector2D(x, 50.0 + 0.05 * x + Noise(0.03)));
                if (i == 4)
                {
                    pts.Add(new Vector2D(x, pts[pts.Count - 1].Y));
                    pts.Add(new Vector2D(x, pts[pts.Count - 1].Y));
                }
                if (i == 10)
                {
                    pts.Add(new Vector2D(x, 53.0));
                    pts.Add(new Vector2D(x, 56.5));
                }
                if (i == 15)
                {
                    pts.Add(new Vector2D(x, pts[pts.Count - 1].Y));
                }
            }
            return pts;
        }

        // ── Fixture 4: negative coordinates ─────────────────────────────────
        // 41 points, x in [-1000, -980], elevations ≈ -15 m, unsorted
        // (same fixed permutation scheme as fixture 1).
        public static List<Vector2D> NegativeCoordinatesSection()
        {
            ResetSeed();
            List<Vector2D> pts = new List<Vector2D>();
            for (int i = 0; i <= 40; i++)
            {
                double x = -1000.0 + i * 0.5;
                pts.Add(new Vector2D(x, -5.0 + 0.01 * x + Noise(0.03)));
            }
            return Shuffled(pts);
        }

        // ── Fixture 5: empty point cloud ────────────────────────────────────
        public static List<Vector2D> EmptySection()
        {
            return new List<Vector2D>();
        }

        // ── Fixture 6: large dataset ────────────────────────────────────────
        // 19501 points (20000 generated, 499 skipped by the open gap
        // condition 10.0 < x < 10.5), x = i*0.001 on [0, 19.999]. Contains:
        // a 0.5 m sensor gap (10.0, 10.5) that RobustGroundSplineFilter must
        // segment on, two vegetation clumps
        // (+4.5 m on [4.0, 4.3), +8.0 m on [12.0, 12.1)) that ground filters
        // must drop, and an embankment break at x=15.0 (0.8 m ramp over
        // [15.0, 15.1)). Size rationale: large enough to exercise grid,
        // break-window and spline-basis paths on real-scale data, small enough
        // for the whole suite to run in seconds. Heavy memory measurement is a
        // separate later step.
        public static List<Vector2D> LargeSection()
        {
            ResetSeed();
            List<Vector2D> pts = new List<Vector2D>();
            for (int i = 0; i < 20000; i++)
            {
                double x = i * 0.001;
                if (x > 10.0 && x < 10.5) continue; // sensor gap
                double z = 100.0 + 0.5 * Math.Sin(x / 3.0) + 0.02 * x + Noise(0.03);
                if (x >= 4.0 && x < 4.3) z += 4.5;                  // clump 1
                if (x >= 12.0 && x < 12.1) z += 8.0;                // clump 2
                if (x >= 15.0 && x < 15.1) z += 8.0 * (x - 15.0);   // ramp 0..0.8
                if (x >= 15.1) z += 0.8;                            // upper level
                pts.Add(new Vector2D(x, z));
            }
            return pts;
        }

        // ── Fixture 7: degenerate profiles (literal, no noise) ──────────────
        public static List<Vector2D> TinyTwoPoints()
        {
            List<Vector2D> pts = new List<Vector2D>();
            pts.Add(new Vector2D(0.0, 10.0));
            pts.Add(new Vector2D(1.0, 10.05));
            return pts;
        }

        public static List<Vector2D> SinglePoint()
        {
            List<Vector2D> pts = new List<Vector2D>();
            pts.Add(new Vector2D(5.0, 42.0));
            return pts;
        }

        // ── Fixture 8: world-space duplicate-XY cloud (Vector4D) ────────────
        // 10 points for characterizing the PointKey2D-millimetre dedup policy
        // used by GroundPointsCollector.RemoveDuplicatesByXY:
        //   p0..p2   same XY (10,20), Z = 100 / 103.5 / 105  → one cell kept
        //   p3, p4   exact duplicates, negative coords (-500.25, -1000.75)
        //   p5, p6   0.999 mm and 0.5 mm → same millimetre cell (floor(0.9999*1000)=0)
        //   p7       1.5 mm → next millimetre cell
        //   p8, p9   2^32 mm wrap sentinels (RegressionTests covers the wrap itself)
        // Expected first-wins dedup keeps Z = 100, 7, 3, 2, 5, 6 in order.
        public static List<Vector4D> DuplicateXYWorldPoints()
        {
            List<Vector4D> pts = new List<Vector4D>();
            pts.Add(new Vector4D(10.0, 20.0, 100.0, 1.0));       // p0 keep
            pts.Add(new Vector4D(10.0, 20.0, 103.5, 1.0));       // p1 same cell
            pts.Add(new Vector4D(10.0, 20.0, 105.0, 1.0));       // p2 same cell
            pts.Add(new Vector4D(-500.25, -1000.75, 7.0, 1.0));  // p3 keep
            pts.Add(new Vector4D(-500.25, -1000.75, 7.0, 1.0));  // p4 same cell
            pts.Add(new Vector4D(0.0009999, 0.0, 3.0, 1.0));     // p5 keep, cell (0,0)
            pts.Add(new Vector4D(0.0005, 0.0, 1.0, 1.0));        // p6 same cell (0,0)
            pts.Add(new Vector4D(0.0015, 0.0, 2.0, 1.0));        // p7 keep, cell (1,0)
            pts.Add(new Vector4D(4294967.296, 0.0, 5.0, 1.0));   // p8 keep
            pts.Add(new Vector4D(4294967.297, 0.0, 6.0, 1.0));   // p9 keep (distinct cell)
            return pts;
        }

        // ── Fixture 9: reservoir-sampling source ────────────────────────────
        // n deterministic Vector4D points; used for the structural
        // (seedless) characterization of Services/SamplingHelper.cs.
        public static List<Vector4D> SamplingSource(int n)
        {
            ResetSeed();
            List<Vector4D> pts = new List<Vector4D>(n);
            for (int i = 0; i < n; i++)
            {
                pts.Add(new Vector4D(i * 0.1, (i % 7) * 1.5, 100.0 + Noise(0.5), 1.0));
            }
            return pts;
        }
    }
}
