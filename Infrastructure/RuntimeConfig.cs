using System;
using LAS_TERRAIN.Domain.Models;
using LAS_TERRAIN.Models;

namespace LAS_TERRAIN.Configuration
{
    /// <summary>
    /// Глобальная конфигурация приложения с поддержкой фиче-флагов через переменные окружения.
    /// Фиче-флаги позволяют переопределять поведение без перекомпиляции.
    /// </summary>
    public static class RuntimeConfig
    {
        /// <summary>
        /// Максимальная толщина коридора для ФИЛЬТРАЦИИ (расчёт poly).
        /// Если пользователь ввёл больше — отображаем все точки, но фильтруем только по этому лимиту.
        /// </summary>
        public const double MAX_FILTER_BORDER = 10.0;

        private static readonly object _lock = new object();
        internal static object SyncRoot { get { return _lock; } }

        // Глобальное значение по умолчанию
        private static double _splitMergeTolerance = LAS_TERRAIN.SettingsDefaults.SplitMergeTolerance;

        private static double _cSplineSmooth = 0.0;
        private static double _crsOverlayBorder = 1.0;

        // Preferences for the next filter operation. A running operation uses
        // only the immutable snapshot captured under _lock.
        private static bool _enableBreakDetection = true;
        private static double _graphBinX = 1.0;
        private static double _graphBinY = 1.0;
        private static int _graphMinPts = 1;
        private static int _breakSlopeWindow = 5;
        private static int _breakR2Window = 8;
        private static double _breakAngleThreshold = 0.175;
        private static double _breakMinR2 = 0.80;
        private static int _breakMinSegmentPoints = 6;
        private static int _breakSuppressRadius = 5;
        private static int _splineDegree = 3;
        private static int _splineMaxIterations = 8;
        private static double _splineSigma = 0.25;
        private static double _splineGridStep = 0.05;
        private static double _splineConvergenceTol = 1e-4;
        private static int _splineAutoCtrlMax = 256;
        private static double _splineRidgeEps = 1e-9;
        private static double _splineMaxGapMeters = 1.0;
        private static bool _splineEnableRailFilter = false;
        private static double _splineRailFilterWindowMeters = 0.3;

        // Collection settings
        private static bool _onePassActive = true; // false = old collection (per-section), true = new OnePass (all-at-once)



        private static double _gridStep = 1.0;

        // Polynomial surface fitting settings
        private static int _polynomialDegree = 2;
        private static double _polynomialRegularization = 0.001;
        private static double _polynomialGridStep = 1.0;

        internal static PlanSurfaceSettings CapturePlanSurfaceSettings()
        {
            lock (_lock)
            {
                return new PlanSurfaceSettings(_gridStep, _polynomialDegree,
                    _polynomialRegularization, _polynomialGridStep);
            }
        }

        // Ground filter algorithm: true = RobustGroundSplineFilter, false = MinWeightedGroundLevelMedianFilter
        private static bool _useSplineFilter = true;

        public static bool EnableBreakDetection
        {
            get { lock (_lock) return _enableBreakDetection; }
            set { lock (_lock) _enableBreakDetection = value; }
        }

        public static double GraphBinX
        {
            get { lock (_lock) return _graphBinX; }
            set { lock (_lock) _graphBinX = value; }
        }

        public static double GraphBinY
        {
            get { lock (_lock) return _graphBinY; }
            set { lock (_lock) _graphBinY = value; }
        }

        public static int GraphMinPts
        {
            get { lock (_lock) return _graphMinPts; }
            set { lock (_lock) _graphMinPts = value; }
        }

        public static int BreakSlopeWindow
        {
            get { lock (_lock) return _breakSlopeWindow; }
            set { lock (_lock) _breakSlopeWindow = value; }
        }

        public static int BreakR2Window
        {
            get { lock (_lock) return _breakR2Window; }
            set { lock (_lock) _breakR2Window = value; }
        }

        public static double BreakAngleThreshold
        {
            get { lock (_lock) return _breakAngleThreshold; }
            set { lock (_lock) _breakAngleThreshold = value; }
        }

        public static double BreakMinR2
        {
            get { lock (_lock) return _breakMinR2; }
            set { lock (_lock) _breakMinR2 = value; }
        }

        public static int BreakMinSegmentPoints
        {
            get { lock (_lock) return _breakMinSegmentPoints; }
            set { lock (_lock) _breakMinSegmentPoints = value; }
        }

        public static int BreakSuppressRadius
        {
            get { lock (_lock) return _breakSuppressRadius; }
            set { lock (_lock) _breakSuppressRadius = value; }
        }

        public static int SplineDegree
        {
            get { lock (_lock) return _splineDegree; }
            set { lock (_lock) _splineDegree = value; }
        }

        public static int SplineMaxIterations
        {
            get { lock (_lock) return _splineMaxIterations; }
            set { lock (_lock) _splineMaxIterations = value; }
        }

        public static double SplineSigma
        {
            get { lock (_lock) return _splineSigma; }
            set { lock (_lock) _splineSigma = value; }
        }

        public static double SplineGridStep
        {
            get { lock (_lock) return _splineGridStep; }
            set { lock (_lock) _splineGridStep = value; }
        }

        public static double SplineConvergenceTol
        {
            get { lock (_lock) return _splineConvergenceTol; }
            set { lock (_lock) _splineConvergenceTol = value; }
        }

        public static int SplineAutoCtrlMax
        {
            get { lock (_lock) return _splineAutoCtrlMax; }
            set { lock (_lock) _splineAutoCtrlMax = value; }
        }

        public static double SplineRidgeEps
        {
            get { lock (_lock) return _splineRidgeEps; }
            set { lock (_lock) _splineRidgeEps = value; }
        }

        public static double SplineMaxGapMeters
        {
            get { lock (_lock) return _splineMaxGapMeters; }
            set { lock (_lock) _splineMaxGapMeters = value; }
        }

        public static bool SplineEnableRailFilter
        {
            get { lock (_lock) return _splineEnableRailFilter; }
            set { lock (_lock) _splineEnableRailFilter = value; }
        }

        public static double SplineRailFilterWindowMeters
        {
            get { lock (_lock) return _splineRailFilterWindowMeters; }
            set { lock (_lock) _splineRailFilterWindowMeters = value; }
        }

        internal static FilterOperationSnapshot CaptureFilterSnapshot()
        {
            lock (_lock)
            {
                return new FilterOperationSnapshot(
                    _useSplineFilter, _enableBreakDetection, _splitMergeTolerance,
                    _graphBinX, _graphBinY, _graphMinPts,
                    _breakSlopeWindow, _breakR2Window, _breakAngleThreshold, _breakMinR2, _breakMinSegmentPoints, _breakSuppressRadius,
                    _splineDegree, _splineMaxIterations, _splineSigma, _cSplineSmooth, _splineGridStep, _splineConvergenceTol,
                    _splineAutoCtrlMax, _splineRidgeEps, _splineMaxGapMeters, _splineEnableRailFilter, _splineRailFilterWindowMeters);
            }
        }

        // Publish the five persisted preferences as one generation.
        public static void ApplyStoredPreferences(double splitMergeTolerance,
            double cSplineSmooth, double crsOverlayBorder, double gridStep,
            bool useSplineFilter)
        {
            lock (_lock)
            {
                SplitMergeTolerance = splitMergeTolerance;
                CSplineSmooth = cSplineSmooth;
                CrsOverlayBorder = crsOverlayBorder;
                GridStep = gridStep;
                UseSplineFilter = useSplineFilter;
            }
        }



        public static double SplitMergeTolerance
        {
            get
            {
                lock (_lock)
                {
                    return _splitMergeTolerance;
                }
            }
            set
            {
                lock (_lock)
                {
                    _splitMergeTolerance = value;
                }
            }
        }

        public static double CSplineSmooth
        {
            get { lock (_lock) return _cSplineSmooth; }
            set
            {
                lock (_lock)
                {
                    // защита от мусора
                    if (double.IsNaN(value) || double.IsInfinity(value) || value < 0) value = 0.0;
                    _cSplineSmooth = value;
                }
            }
        }

        public static double CrsOverlayBorder
        {
            get { lock (_lock) return _crsOverlayBorder; }
            set
            {
                lock (_lock)
                {
                    if (double.IsNaN(value) || double.IsInfinity(value) || value <= 0) value = 0.001;
                    _crsOverlayBorder = value;
                }
            }
        }

        /// <summary>
        /// Эффективная толщина коридора для ФИЛЬТРАЦИИ.
        /// Возвращает минимум из (CrsOverlayBorder, MAX_FILTER_BORDER).
        /// Используется для оптимизации: фильтрация всегда на <= 10м.
        /// </summary>
        public static double EffectiveFilterBorder
        {
            get { return Math.Min(CrsOverlayBorder, MAX_FILTER_BORDER); }
        }

        public static double GridStep
        {
            get { lock (_lock) return _gridStep; }
            set
            {
                lock (_lock)
                {
                    if (double.IsNaN(value) || double.IsInfinity(value) || value <= 0) value = 0.1;
                    if (value > 100.0) value = 100.0; // «страховка»
                    _gridStep = value;
                }
            }
        }

        /// <summary>
        /// Степень полинома для подгонки поверхности (1=linear, 2=quadratic, 3=cubic).
        /// </summary>
        public static int PolynomialDegree
        {
            get { lock (_lock) return _polynomialDegree; }
            set
            {
                lock (_lock)
                {
                    if (value < 1) value = 1;
                    if (value > 3) value = 3;
                    _polynomialDegree = value;
                }
            }
        }

        /// <summary>
        /// Параметр регуляризации для полиномиальной подгонки (ridge regression).
        /// Типичные значения: 1e-6 to 1e-3.
        /// </summary>
        public static double PolynomialRegularization
        {
            get { lock (_lock) return _polynomialRegularization; }
            set
            {
                lock (_lock)
                {
                    if (double.IsNaN(value) || double.IsInfinity(value) || value < 0) value = 1e-6;
                    if (value > 1.0) value = 1.0;
                    _polynomialRegularization = value;
                }
            }
        }

        /// <summary>
        /// Шаг сетки для генерации точек из полиномиальной поверхности.
        /// </summary>
        public static double PolynomialGridStep
        {
            get { lock (_lock) return _polynomialGridStep; }
            set
            {
                lock (_lock)
                {
                    if (double.IsNaN(value) || double.IsInfinity(value) || value <= 0) value = 0.1;
                    if (value > 100.0) value = 100.0;
                    _polynomialGridStep = value;
                }
            }
        }

        /// <summary>
        /// Выбор алгоритма фильтрации земли:
        /// true = RobustGroundSplineFilter (B-сплайн с IRLS)
        /// false = MinWeightedGroundLevelMedianFilter (морфологический)
        /// </summary>
        public static bool UseSplineFilter
        {
            get { lock (_lock) return _useSplineFilter; }
            set { lock (_lock) _useSplineFilter = value; }
        }

        /// <summary>
        /// Выбор метода сбора точек:
        /// false = старый (per-section collection)
        /// true = новый OnePass (all sections at once)
        /// </summary>
        public static bool OnePassActive
        {
            get { lock (_lock) return _onePassActive; }
            set { lock (_lock) _onePassActive = value; }
        }

    }
}
