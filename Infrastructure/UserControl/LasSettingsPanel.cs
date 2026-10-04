using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using LAS_TERRAIN;                   // <— нужно для Settings.Instance
using LAS_TERRAIN.Configuration;    // RuntimeConfig

namespace LAS_TERRAIN.UI
{
    // ====== ТЕМА ROBO-LAS ====================================================
    static class RoboTheme
    {
        public static readonly Color Accent = Color.FromArgb(0, 200, 255);       // электро-циан
        public static readonly Color CardBorder = Color.FromArgb(70, 0, 0, 0);   // полупрозрачная рамка
        public static readonly Color CardBorderActive = Color.FromArgb(180, 0, 200, 255);
        public static readonly Color CardFill = Color.FromArgb(12, 0, 0, 0);     // легкий дымчатый фон
        public static readonly int Radius = 6;
    }

    // ====== СКРУГЛЁННАЯ КАРТОЧКА =============================================
    sealed class CardPanel : Panel
    {
        private bool _active;
        public bool Active
        {
            get { return _active; }
            set { _active = value; Invalidate(); }
        }

        public CardPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            BackColor = Color.Transparent;
            Padding = new Padding(10, 8, 10, 8);
            Margin = new Padding(0, 6, 0, 6);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = ClientRectangle;
            rect.Inflate(-1, -1);

            using (GraphicsPath path = Rounded(rect, RoboTheme.Radius))
            using (SolidBrush fill = new SolidBrush(RoboTheme.CardFill))
            using (Pen pen = new Pen(_active ? RoboTheme.CardBorderActive : RoboTheme.CardBorder, 1f))
            {
                g.FillPath(fill, path);
                g.DrawPath(pen, path);
            }
        }

        private static GraphicsPath Rounded(Rectangle r, int radius)
        {
            int d = radius * 2;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            gp.CloseFigure();
            return gp;
        }
    }

    // ====== ШАПКА =============================================================
    sealed class HeaderBar : Panel
    {
        public readonly Label Title = new Label();
        public readonly LinkLabel Reset = new LinkLabel();

        public HeaderBar()
        {
            Dock = DockStyle.Top;
            Height = 44;
            Padding = new Padding(12, 6, 12, 6);

            Title.AutoSize = true;
            Title.Text = "ROBOLAS";
            Title.Font = new Font("Segoe UI Semibold", 11f);
            Title.ForeColor = SystemColors.ControlText;
            Title.Dock = DockStyle.Left;

            Reset.Text = "Сбросить значения";
            Reset.LinkBehavior = LinkBehavior.HoverUnderline;
            Reset.LinkColor = RoboTheme.Accent;
            Reset.ActiveLinkColor = RoboTheme.Accent;
            Reset.VisitedLinkColor = RoboTheme.Accent;
            Reset.AutoSize = true;
            Reset.Dock = DockStyle.Right;

            Controls.Add(Reset);
            Controls.Add(Title);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen p = new Pen(Color.FromArgb(90, RoboTheme.Accent), 1))
            {
                e.Graphics.DrawLine(p, 0, Height - 1, Width, Height - 1);
            }
        }
    }

    // ====== ОСНОВНАЯ ПАНЕЛЬ ==================================================
    public sealed class LasSettingsPanel : UserControl
    {
        // defaults
        private const decimal SMOOTH_MIN = 0.0m, SMOOTH_MAX = 10.0m, SMOOTH_DEF = 0.0m;
        private const decimal TOL_MIN = 0.000000001m, TOL_DEF = 0.01m;
        private const decimal CRS_MIN = 0.001m, CRS_MAX = 1000000.0m, CRS_DEF = 1.0m;
        private const decimal GRID_MIN = 0.1m, GRID_MAX = 100.0m, GRID_DEF = 1.0m;

        private bool _updating;
        private readonly HeaderBar header;
        private readonly TableLayoutPanel root;

        private NumericUpDown nudSmooth, nudTol, nudCrs, nudGrid;
        private ComboBox cmbAlgorithm;

        public LasSettingsPanel()
        {
            AutoScaleMode = AutoScaleMode.Dpi;
            Dock = DockStyle.Fill;

            header = new HeaderBar();
            header.Reset.Click += delegate { ResetToDefaults(); };

            root = new TableLayoutPanel();
            root.Dock = DockStyle.Fill;
            root.AutoSize = true;
            root.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            root.ColumnCount = 1;
            root.RowCount = 5;
            root.Padding = new Padding(12, 6, 12, 12);

            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            // пять строк — каждая авто‑высоты
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // порядок карточек: Algorithm, λ, tol, CRS, Grid
            root.Controls.Add(MakeAlgorithmCard());

            // порядок карточек: λ, tol, CRS, Grid
            root.Controls.Add(MakeCard("Сглаживание сплайна (λ):", out nudSmooth, "0…10",
                SMOOTH_MIN, SMOOTH_MAX, 3, 0.010m, ApplySmooth));

            root.Controls.Add(MakeCard("Погрешность точности рельефа, м:", out nudTol, "> 0",
                TOL_MIN, decimal.MaxValue / 2m, 6, 0.001m, ApplyTol));

            root.Controls.Add(MakeCard("Толщина проекции CRS (м):", out nudCrs, "> 0",
                CRS_MIN, CRS_MAX, 3, 0.100m, ApplyCrs));

            root.Controls.Add(MakeCard("Шаг сетки (м):", out nudGrid, "0.1…100",
                GRID_MIN, GRID_MAX, 2, 0.1m, ApplyGrid));

            // сначала шапка, затем контент — безопаснее для Dock‑раскладки

            Controls.Add(root);
            Controls.Add(header);

            // таб-индексы
            cmbAlgorithm.TabIndex = 0;
            nudSmooth.TabIndex = 1;
            nudTol.TabIndex = 2;
            nudCrs.TabIndex = 3;
            nudGrid.TabIndex = 4;
            header.Reset.TabIndex = 5;

            RefreshFromSettings();
        }

        private Control MakeCard(string labelText, out NumericUpDown nud, string hint,
                                 decimal min, decimal max, int decimals, decimal step, EventHandler onChange)
        {
            CardPanel card = new CardPanel();
            card.Dock = DockStyle.Top;

            var grid = new TableLayoutPanel();
            grid.Dock = DockStyle.Fill;
            grid.ColumnCount = 3;
            grid.RowCount = 1;

            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            grid.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            grid.Padding = new Padding(0, 4, 0, 4);

            var lbl = new Label();
            lbl.Text = labelText;
            lbl.AutoSize = true;
            lbl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            lbl.Margin = new Padding(0, 0, 6, 0);
            lbl.Font = new Font("Segoe UI", 10f);

            nud = new NumericUpDown();
            nud.Minimum = min;
            nud.Maximum = max;
            nud.DecimalPlaces = decimals;
            nud.Increment = step;
            nud.ThousandsSeparator = false;
            nud.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            nud.Height = nud.PreferredHeight;
            nud.Margin = new Padding(6, 0, 6, 0);
            nud.Font = new Font("Consolas", 10f);

            var hintLbl = new Label();
            hintLbl.Text = hint;
            hintLbl.AutoSize = true;
            hintLbl.ForeColor = SystemColors.GrayText;
            hintLbl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            hintLbl.Margin = new Padding(6, 0, 0, 0);
            hintLbl.Font = new Font("Segoe UI", 9f);

            // подсветка карточки по фокусу
            nud.Enter += delegate { card.Active = true; };
            nud.Leave += delegate { card.Active = false; };
            nud.ValueChanged += onChange;

            grid.Controls.Add(lbl, 0, 0);
            grid.Controls.Add(nud, 1, 0);
            grid.Controls.Add(hintLbl, 2, 0);

            card.Controls.Add(grid);
            return card;
        }

        private Control MakeAlgorithmCard()
        {
            CardPanel card = new CardPanel();
            card.Dock = DockStyle.Top;

            var grid = new TableLayoutPanel();
            grid.Dock = DockStyle.Fill;
            grid.ColumnCount = 3;
            grid.RowCount = 1;

            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            grid.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            grid.Padding = new Padding(0, 4, 0, 4);

            var lbl = new Label();
            lbl.Text = "Алгоритм фильтрации:";
            lbl.AutoSize = true;
            lbl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            lbl.Margin = new Padding(0, 0, 6, 0);
            lbl.Font = new Font("Segoe UI", 10f);

            cmbAlgorithm = new ComboBox();
            cmbAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgorithm.Items.Add("B-сплайн (IRLS)");
            cmbAlgorithm.Items.Add("Мин. вес (морфология)");
            cmbAlgorithm.SelectedIndex = 0;
            cmbAlgorithm.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            cmbAlgorithm.Margin = new Padding(6, 0, 6, 0);
            cmbAlgorithm.Font = new Font("Segoe UI", 10f);

            var hintLbl = new Label();
            hintLbl.Text = "Spline/MinW";
            hintLbl.AutoSize = true;
            hintLbl.ForeColor = SystemColors.GrayText;
            hintLbl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            hintLbl.Margin = new Padding(6, 0, 0, 0);
            hintLbl.Font = new Font("Segoe UI", 9f);

            // подсветка карточки по фокусу
            cmbAlgorithm.Enter += delegate { card.Active = true; };
            cmbAlgorithm.Leave += delegate { card.Active = false; };
            cmbAlgorithm.SelectedIndexChanged += ApplyAlgorithm;

            grid.Controls.Add(lbl, 0, 0);
            grid.Controls.Add(cmbAlgorithm, 1, 0);
            grid.Controls.Add(hintLbl, 2, 0);

            card.Controls.Add(grid);
            return card;
        }

        // -------- data <-> UI ------------------------------------------------
        public void RefreshFromSettings()
        {
            _updating = true;
            try
            {
                // Algorithm
                cmbAlgorithm.SelectedIndex = RuntimeConfig.UseSplineFilter ? 0 : 1;

                // λ
                double s = RuntimeConfig.CSplineSmooth;
                if (Double.IsNaN(s) || Double.IsInfinity(s) || s < (double)SMOOTH_MIN) s = (double)SMOOTH_DEF;
                if (s > (double)SMOOTH_MAX) s = (double)SMOOTH_MAX;
                nudSmooth.Value = (decimal)s;

                // tol
                double tol = RuntimeConfig.SplitMergeTolerance;
                if (Double.IsNaN(tol) || Double.IsInfinity(tol) || tol <= 0) tol = (double)TOL_DEF;
                nudTol.Value = Clamp((decimal)tol, TOL_MIN, decimal.MaxValue / 2m);

                // CRS
                double b = RuntimeConfig.CrsOverlayBorder;
                if (Double.IsNaN(b) || Double.IsInfinity(b) || b <= 0) b = (double)CRS_DEF;
                nudCrs.Value = Clamp((decimal)b, CRS_MIN, CRS_MAX);

                // GRID
                double g = RuntimeConfig.GridStep;
                if (Double.IsNaN(g) || Double.IsInfinity(g) || g <= 0) g = (double)GRID_DEF;
                nudGrid.Value = Clamp((decimal)g, GRID_MIN, GRID_MAX);
            }
            finally { _updating = false; }
        }

        private void ApplySmooth(object sender, EventArgs e)
        {
            if (_updating) return;
            double v = (double)nudSmooth.Value;
            // При 0 идут выбросы — используем минимальное значение
            if (v < 0.01) v = 0.01;
            RuntimeConfig.CSplineSmooth = v;
            Settings.Instance.CsplineSmooth = v;
        }

        private void ApplyTol(object sender, EventArgs e)
        {
            if (_updating) return;
            double v = (double)nudTol.Value;
            if (v <= 0) v = (double)TOL_MIN;
            RuntimeConfig.SplitMergeTolerance = v;
            Settings.Instance.SplitMergeTolerance = v;
        }

        private void ApplyCrs(object sender, EventArgs e)
        {
            if (_updating) return;
            double v = (double)nudCrs.Value;
            RuntimeConfig.CrsOverlayBorder = v;
            Settings.Instance.CrsOverlayBorder = v;
        }

        private void ApplyGrid(object sender, EventArgs e)
        {
            if (_updating) return;
            double v = (double)nudGrid.Value;
            RuntimeConfig.GridStep = v;
            Settings.Instance.GridStep = v;
        }

        private void ApplyAlgorithm(object sender, EventArgs e)
        {
            if (_updating) return;
            bool useSpline = cmbAlgorithm.SelectedIndex == 0;
            RuntimeConfig.UseSplineFilter = useSpline;
            Settings.Instance.UseSplineFilter = useSpline;
        }

        private void ResetToDefaults()
        {
            _updating = true;
            try
            {
                cmbAlgorithm.SelectedIndex = 0; // Spline by default
                nudSmooth.Value = SMOOTH_DEF;
                nudTol.Value = TOL_DEF;
                nudCrs.Value = CRS_DEF;
                nudGrid.Value = GRID_DEF;
            }
            finally { _updating = false; }
            ApplyAlgorithm(null, EventArgs.Empty);
            ApplySmooth(null, EventArgs.Empty);
            ApplyTol(null, EventArgs.Empty);
            ApplyCrs(null, EventArgs.Empty);
            ApplyGrid(null, EventArgs.Empty);
        }

        private static decimal Clamp(decimal v, decimal lo, decimal hi)
        {
            if (v < lo) return lo;
            if (v > hi) return hi;
            return v;
        }
    }
}
