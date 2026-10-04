using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.ComponentModel;
using System.Runtime.InteropServices;

using System.Windows.Forms;

namespace RoboLasInstaller
{

public class MainForm : Form
{
    // Color palette - classic light blue
    private static class Colors
    {
        public static readonly Color Background = Color.FromArgb(234, 242, 251);
        public static readonly Color Surface = Color.FromArgb(253, 254, 255);
        public static readonly Color SurfaceHover = Color.FromArgb(225, 236, 250);
        public static readonly Color SurfaceBorder = Color.FromArgb(183, 204, 232);
        public static readonly Color Primary = Color.FromArgb(0, 102, 204);
        public static readonly Color PrimaryHover = Color.FromArgb(10, 132, 255);
        public static readonly Color PrimaryGlow = Color.FromArgb(51, 161, 255);
        public static readonly Color Accent = Color.FromArgb(64, 180, 255);
        public static readonly Color Success = Color.FromArgb(158, 206, 106);
        public static readonly Color Error = Color.FromArgb(247, 118, 142);
        public static readonly Color Warning = Color.FromArgb(224, 175, 104);
        public static readonly Color TextPrimary = Color.FromArgb(15, 45, 82);
        public static readonly Color TextSecondary = Color.FromArgb(50, 90, 133);
        public static readonly Color TextMuted = Color.FromArgb(91, 124, 165);
        public static readonly Color Divider = Color.FromArgb(201, 217, 238);
    }

    private Panel headerPanel = null;
    private Panel contentPanel = null;
    private Label titleLabel = null;
    private Label subtitleLabel = null;
    private PictureBox logoBox = null;
    private ComboBox topomaticCombo = null;
    private TextBox topomaticPathTextBox = null;
    private Button browseTopomaticBtn = null;
    private TextBox packagePathTextBox = null;
    private Button browsePackageBtn = null;
    private Button installBtn = null;
    private CustomProgressBar progressBar = null;
    private Label statusLabel = null;
    private Button closeButton = null;
    private Button minimizeButton = null;

    private Panel topomaticCard = null;
    private Panel packageCard = null;
    private Panel progressCard = null;
    private Label topomaticLabel = null;
    private Label pathLabel = null;
    private Label packageLabel = null;

    private string initialPackagePath;

    public MainForm(string[] args)
    {
        initialPackagePath = args.Length > 0 ? args[0] : null;
        InitializeComponents();
        LoadTopomaticInstallations();
        if (!string.IsNullOrEmpty(initialPackagePath))
        {
            packagePathTextBox.Text = initialPackagePath;
        }
    }

    private void InitializeComponents()
    {
        // Form setup
        Text = "RoboLas Installer";
        Size = new Size(720, 680);
        MinimumSize = new Size(720, 680);
        FormBorderStyle = FormBorderStyle.None;
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = Colors.Background;
        DoubleBuffered = true;
        AutoScaleMode = AutoScaleMode.Dpi;
        KeyPreview = true;
        KeyDown += (s, e) =>
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        };

        // Make rounded corners
        Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 16, 16));

        // Header panel with gradient
        headerPanel = new Panel
        {
            Dock = DockStyle.Top,
            Height = 90,
            BackColor = Colors.Surface
        };
        headerPanel.Paint += HeaderPanel_Paint;
        headerPanel.Resize += (_, _) => UpdateWindowButtonsLayout();

        // Logo
        logoBox = new PictureBox
        {
            Size = new Size(56, 56),
            Location = new Point(28, 17),
            SizeMode = PictureBoxSizeMode.Zoom,
            BackColor = Color.Transparent
        };
        LoadLogo();
        LoadAppIcon();

        // Title with improved typography
        titleLabel = new Label
        {
            Text = "RoboLas",
            Font = new Font("Segoe UI", 24, FontStyle.Bold),
            ForeColor = Colors.TextPrimary,
            AutoSize = true,
            Location = new Point(96, 16)
        };

        // Subtitle
        subtitleLabel = new Label
        {
            Text = "PLUGIN INSTALLER FOR TOPOMATIC ROBUR",
            Font = new Font("Segoe UI", 8.5f, FontStyle.Regular),
            ForeColor = Colors.TextSecondary,
            AutoSize = true,
            Location = new Point(96, 50)
        };

        // Window controls - positioned to avoid rounded corner clipping
        minimizeButton = CreateWindowButton("-");
        minimizeButton.Location = new Point(0, 25);
        minimizeButton.Click += (s, e) => WindowState = FormWindowState.Minimized;

        closeButton = CreateWindowButton("X");
        closeButton.Location = new Point(0, 25);
        closeButton.Click += (s, e) => Close();
        closeButton.MouseEnter += (s, e) =>
        {
            closeButton.BackColor = Colors.Error;
            closeButton.ForeColor = Color.White;
            closeButton.Invalidate();
        };
        closeButton.MouseLeave += (s, e) =>
        {
            closeButton.BackColor = Color.Transparent;
            closeButton.ForeColor = Colors.TextSecondary;
            closeButton.Invalidate();
        };

        headerPanel.Controls.AddRange(new Control[] { logoBox, titleLabel, subtitleLabel, minimizeButton, closeButton });

        // Content panel
        contentPanel = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = Colors.Background,
            Padding = new Padding(32, 24, 32, 32)
        };

        int cardY = 0;

        // Topomatic card
        topomaticCard = CreateCard("TOPOMATIC INSTALLATION", ">", cardY, 175);
        cardY += 195;

        // Package card
        packageCard = CreateCard("PACKAGE SELECTION", "+", cardY, 120);
        cardY += 140;

        // Progress card (initially hidden content)
        progressCard = CreateCard("INSTALLATION PROGRESS", "o", cardY, 100);

        // === Topomatic Card Content ===
        topomaticLabel = CreateInputLabel("Select Version");
        topomaticLabel.Location = new Point(20, 45);
        topomaticCard.Controls.Add(topomaticLabel);

        topomaticCombo = CreateStyledComboBox();
        topomaticCombo.Location = new Point(20, 68);
        topomaticCombo.Width = topomaticCard.Width - 44;
        topomaticCombo.SelectedIndexChanged += TopomaticCombo_SelectedIndexChanged;
        topomaticCard.Controls.Add(topomaticCombo);

        pathLabel = CreateInputLabel("Installation Path");
        pathLabel.Location = new Point(20, 108);
        topomaticCard.Controls.Add(pathLabel);

        topomaticPathTextBox = CreateStyledTextBox();
        topomaticPathTextBox.Location = new Point(20, 131);
        topomaticPathTextBox.Width = topomaticCard.Width - 134;
        topomaticPathTextBox.ReadOnly = true;
        topomaticCard.Controls.Add(topomaticPathTextBox);

        browseTopomaticBtn = CreateStyledButton("Browse", Colors.Surface, Colors.TextPrimary);
        browseTopomaticBtn.Location = new Point(topomaticCard.Width - 106, 129);
        browseTopomaticBtn.Width = 86;
        browseTopomaticBtn.Click += BrowseTopomaticBtn_Click;
        topomaticCard.Controls.Add(browseTopomaticBtn);

        // === Package Card Content ===
        packageLabel = CreateInputLabel("Package File (*.tpm)");
        packageLabel.Location = new Point(20, 45);
        packageCard.Controls.Add(packageLabel);

        packagePathTextBox = CreateStyledTextBox();
        packagePathTextBox.Location = new Point(20, 68);
        packagePathTextBox.Width = packageCard.Width - 134;
        packageCard.Controls.Add(packagePathTextBox);

        browsePackageBtn = CreateStyledButton("Browse", Colors.Surface, Colors.TextPrimary);
        browsePackageBtn.Location = new Point(packageCard.Width - 106, 66);
        browsePackageBtn.Width = 86;
        browsePackageBtn.Click += BrowsePackageBtn_Click;
        packageCard.Controls.Add(browsePackageBtn);

        // === Progress Card Content ===
        statusLabel = new Label
        {
            Text = "Ready to install",
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = Colors.TextSecondary,
            Location = new Point(20, 45),
            AutoSize = true
        };
        progressCard.Controls.Add(statusLabel);

        progressBar = new CustomProgressBar
        {
            Location = new Point(20, 70),
            Size = new Size(progressCard.Width - 44, 8),
            Visible = false
        };
        progressCard.Controls.Add(progressBar);

        // Install button
        installBtn = new Button
        {
            Text = "INSTALL NOW",
            Font = new Font("Segoe UI", 11, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = Colors.Primary,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(240, 52),
            Location = new Point((ClientSize.Width - 240) / 2, contentPanel.Height - 80),
            Cursor = Cursors.Hand
        };
        installBtn.FlatAppearance.BorderSize = 0;
        installBtn.Paint += InstallBtn_Paint;
        installBtn.MouseEnter += (s, e) =>
        {
            installBtn.BackColor = Colors.PrimaryHover;
            installBtn.Invalidate();
        };
        installBtn.MouseLeave += (s, e) =>
        {
            installBtn.BackColor = Colors.Primary;
            installBtn.Invalidate();
        };
        installBtn.Click += InstallBtn_Click;

        contentPanel.Controls.AddRange(new Control[]
        {
            topomaticCard, packageCard, progressCard, installBtn
        });

        Controls.AddRange(new Control[] { contentPanel, headerPanel });

        contentPanel.Resize += (_, _) => UpdateResponsiveLayout();
        Resize += (_, _) => UpdateResponsiveLayout();
        Resize += (_, _) => UpdateWindowButtonsLayout();
        UpdateResponsiveLayout();
        UpdateWindowButtonsLayout();

        // Enable form dragging
        var dragHelper = new DragHelper(this);
    }

    private void UpdateWindowButtonsLayout()
    {
        if (headerPanel.ClientSize.Width <= 0)
        {
            return;
        }

        const int top = 25;
        const int rightPadding = 20;
        const int spacing = 8;

        closeButton.Location = new Point(
            headerPanel.ClientSize.Width - closeButton.Width - rightPadding,
            top);

        minimizeButton.Location = new Point(
            closeButton.Left - minimizeButton.Width - spacing,
            top);
    }

    private void UpdateResponsiveLayout()
    {
        int left = contentPanel.Padding.Left;
        int top = contentPanel.Padding.Top;
        int gap = 16;
        int availableWidth = Math.Max(460, contentPanel.ClientSize.Width - contentPanel.Padding.Horizontal);

        topomaticCard.SetBounds(left, top, availableWidth, 175);
        packageCard.SetBounds(left, topomaticCard.Bottom + gap, availableWidth, 120);
        progressCard.SetBounds(left, packageCard.Bottom + gap, availableWidth, 100);

        int browseWidth = 86;
        int hPadding = 20;
        int spacing = 8;

        topomaticCombo.SetBounds(hPadding, 68, topomaticCard.ClientSize.Width - (hPadding * 2), 32);
        topomaticPathTextBox.SetBounds(
            hPadding,
            131,
            topomaticCard.ClientSize.Width - (hPadding * 2) - browseWidth - spacing,
            28);
        browseTopomaticBtn.SetBounds(topomaticCard.ClientSize.Width - hPadding - browseWidth, 129, browseWidth, 38);

        packagePathTextBox.SetBounds(
            hPadding,
            68,
            packageCard.ClientSize.Width - (hPadding * 2) - browseWidth - spacing,
            28);
        browsePackageBtn.SetBounds(packageCard.ClientSize.Width - hPadding - browseWidth, 66, browseWidth, 38);

        progressBar.SetBounds(hPadding, 70, progressCard.ClientSize.Width - (hPadding * 2), 8);

        installBtn.Location = new Point(
            left + (availableWidth - installBtn.Width) / 2,
            progressCard.Bottom + 18);
    }

    private void HeaderPanel_Paint(object sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        // Draw subtle gradient overlay
        using (var brush = new LinearGradientBrush(
            new Point(0, 0),
            new Point(Width, 0),
            Color.FromArgb(255, Colors.Surface),
            Color.FromArgb(245, Colors.Surface)))
        {
            g.FillRectangle(brush, headerPanel.ClientRectangle);
        }

        // Draw bottom border
        using (var pen = new Pen(Colors.Divider, 1))
        {
            g.DrawLine(pen, 0, headerPanel.Height - 1, Width, headerPanel.Height - 1);
        }

        // Draw accent line at top
        using (var brush = new LinearGradientBrush(
            new Point(0, 0),
            new Point(Width, 0),
            Colors.Primary,
            Colors.Accent))
        {
            g.FillRectangle(brush, 0, 0, Width, 3);
        }
    }

    private void InstallBtn_Paint(object sender, PaintEventArgs e)
    {
        if (sender is not Button btn) return;
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        // Draw rounded rectangle background
        var path = GetRoundedRectPath(btn.ClientRectangle, 10);
        using (var brush = new SolidBrush(btn.BackColor))
        {
            g.FillPath(brush, path);
        }

        // Draw subtle glow at bottom
        using (var brush = new LinearGradientBrush(
            new Point(0, btn.Height - 10),
            new Point(0, btn.Height),
            Color.FromArgb(40, Colors.Primary),
            Color.Transparent))
        {
            var glowPath = GetRoundedRectPath(new Rectangle(0, btn.Height - 10, btn.Width, 10), 10);
            g.FillPath(brush, glowPath);
        }

        // Draw text
        var sf = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };
        using (var brush = new SolidBrush(btn.ForeColor))
        {
            g.DrawString(btn.Text, btn.Font, brush, btn.ClientRectangle, sf);
        }
    }

    private Panel CreateCard(string title, string icon, int top, int height)
    {
        var card = new Panel
        {
            Location = new Point(0, top),
            Size = new Size(contentPanel.Width - 64, height),
            BackColor = Colors.Surface
        };
        card.Paint += (s, e) => Card_Paint(e, title, icon, card);

        return card;
    }

    private void Card_Paint(PaintEventArgs e, string title, string icon, Panel card)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        // Draw card background with rounded corners
        var path = GetRoundedRectPath(card.ClientRectangle, 12);
        using (var brush = new SolidBrush(Colors.Surface))
        {
            g.FillPath(brush, path);
        }

        // Draw border
        using (var pen = new Pen(Colors.SurfaceBorder, 1))
        {
            g.DrawPath(pen, path);
        }

        // Draw subtle inner glow at top
        using (var brush = new LinearGradientBrush(
            new Point(0, 0),
            new Point(0, 30),
            Color.FromArgb(20, Colors.Primary),
            Color.Transparent))
        {
            g.FillRectangle(brush, new Rectangle(0, 0, card.Width, 30));
        }

        // Draw section header background
        var headerPath = GetRoundedRectPath(new Rectangle(0, 0, card.Width, 32), 12);
        headerPath.AddRectangle(new Rectangle(0, 12, card.Width, 20));
        using (var brush = new SolidBrush(Color.FromArgb(15, Colors.Primary)))
        {
            g.FillPath(brush, headerPath);
        }

        // Draw icon
        using (var brush = new SolidBrush(Colors.Primary))
        {
            g.DrawString(icon, new Font("Segoe UI", 10, FontStyle.Regular), brush, 20, 8);
        }

        // Draw title
        using (var brush = new SolidBrush(Colors.TextPrimary))
        {
            g.DrawString(title, new Font("Segoe UI", 9, FontStyle.Bold), brush, 44, 9);
        }
    }

    private Label CreateInputLabel(string text)
    {
        return new Label
        {
            Text = text,
            Font = new Font("Segoe UI", 9, FontStyle.Regular),
            ForeColor = Colors.TextSecondary,
            AutoSize = true
        };
    }

    private ComboBox CreateStyledComboBox()
    {
        var combo = new ComboBox
        {
            Height = 38,
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 10, FontStyle.Regular),
            BackColor = Colors.Background,
            ForeColor = Colors.TextPrimary,
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand
        };
        combo.DrawItem += StyledComboBox_DrawItem;
        return combo;
    }

    private void StyledComboBox_DrawItem(object sender, DrawItemEventArgs e)
    {
        if (e.Index < 0) return;

        if (sender is not ComboBox combo) return;
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        var isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
        var bgColor = isSelected ? Colors.SurfaceHover : Colors.Background;
        var textColor = Colors.TextPrimary;

        // Draw background
        using (var brush = new SolidBrush(bgColor))
        {
            e.DrawBackground();
            g.FillRectangle(brush, e.Bounds);
        }

        // Draw text
        var item = combo.Items[e.Index]?.ToString() ?? "";
        using (var brush = new SolidBrush(textColor))
        {
            var rect = new Rectangle(e.Bounds.X + 12, e.Bounds.Y + 2, e.Bounds.Width - 12, e.Bounds.Height);
            g.DrawString(item, e.Font, brush, rect);
        }

        // Draw focus rectangle if needed
        if (isSelected)
        {
            using (var pen = new Pen(Colors.Primary, 1))
            {
                g.DrawRectangle(pen, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1));
            }
        }
    }

    private TextBox CreateStyledTextBox()
    {
        var textBox = new TextBox
        {
            Height = 38,
            Font = new Font("Segoe UI", 10, FontStyle.Regular),
            BackColor = Colors.Background,
            ForeColor = Colors.TextPrimary,
            BorderStyle = BorderStyle.None
        };

        // Custom border handling
        textBox.Paint += (s, e) =>
        {
            if (s is TextBox tb)
            {
                var g = e.Graphics;
                using (var pen = new Pen(Colors.SurfaceBorder, 1))
                {
                    g.DrawRectangle(pen, new Rectangle(0, 0, tb.Width - 1, tb.Height - 1));
                }
            }
        };

        return textBox;
    }

    private Button CreateStyledButton(string text, Color backColor, Color foreColor)
    {
        var btn = new Button
        {
            Text = text,
            Font = new Font("Segoe UI", 9.5f, FontStyle.Regular),
            ForeColor = foreColor,
            BackColor = backColor,
            FlatStyle = FlatStyle.Flat,
            Height = 38,
            Cursor = Cursors.Hand
        };
        btn.FlatAppearance.BorderSize = 1;
        btn.FlatAppearance.BorderColor = Colors.SurfaceBorder;
        btn.Paint += (s, e) =>
        {
            if (s is Button b)
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                var path = GetRoundedRectPath(b.ClientRectangle, 8);
                using (var brush = new SolidBrush(b.BackColor))
                {
                    g.FillPath(brush, path);
                }
                using (var pen = new Pen(Colors.SurfaceBorder, 1))
                {
                    g.DrawPath(pen, path);
                }

                var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                using (var brush = new SolidBrush(b.ForeColor))
                {
                    g.DrawString(b.Text, b.Font, brush, b.ClientRectangle, sf);
                }
            }
        };
        btn.MouseEnter += (s, e) =>
        {
            btn.BackColor = Colors.SurfaceHover;
            btn.Invalidate();
        };
        btn.MouseLeave += (s, e) =>
        {
            btn.BackColor = backColor;
            btn.Invalidate();
        };

        return btn;
    }

    private Button CreateWindowButton(string text)
    {
        var btn = new Button
        {
            Text = text,
            Font = new Font("Segoe UI", 12, FontStyle.Bold),
            ForeColor = Colors.TextSecondary,
            BackColor = Color.Transparent,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(36, 36),
            Cursor = Cursors.Hand
        };
        btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btn.FlatAppearance.BorderSize = 0;
        btn.Paint += (s, e) =>
        {
            if (s is Button b)
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Always draw a subtle background circle
                var circleRect = new Rectangle(2, 2, 32, 32);
                var circlePath = GetRoundedRectPath(circleRect, 16);

                if (b.BackColor == Colors.Error)
                {
                    using (var brush = new SolidBrush(Colors.Error))
                    {
                        g.FillPath(brush, circlePath);
                    }
                }
                else if (b.BackColor == Colors.SurfaceHover)
                {
                    using (var brush = new SolidBrush(Colors.SurfaceHover))
                    {
                        g.FillPath(brush, circlePath);
                    }
                }
                else
                {
                    // Default: subtle visible background for light header
                    using (var brush = new SolidBrush(Color.FromArgb(40, Colors.Primary)))
                    {
                        g.FillPath(brush, circlePath);
                    }
                }

                // Draw border
                using (var pen = new Pen(Color.FromArgb(120, Colors.SurfaceBorder), 1))
                {
                    g.DrawPath(pen, circlePath);
                }

                var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                using (var brush = new SolidBrush(b.ForeColor))
                {
                    g.DrawString(b.Text, b.Font, brush, b.ClientRectangle, sf);
                }
            }
        };
        btn.MouseEnter += (s, e) =>
        {
            btn.BackColor = Colors.SurfaceHover;
            btn.ForeColor = Colors.TextPrimary;
            btn.Invalidate();
        };
        btn.MouseLeave += (s, e) =>
        {
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Colors.TextSecondary;
            btn.Invalidate();
        };

        return btn;
    }

    private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
    {
        var path = new GraphicsPath();
        int diameter = radius * 2;

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();

        return path;
    }

    private void LoadLogo()
    {
        try
        {
            var brandBitmap = TryLoadBrandBitmap();
            if (brandBitmap != null)
            {
                logoBox.Image = brandBitmap;
                return;
            }
        }
        catch
        {
            // Fallback below
        }

        // Fallback: create a stylized logo
        var fallback = CreateFallbackLogoBitmap();
        logoBox.Image = fallback;
    }

    private void LoadAppIcon()
    {
        try
        {
            using var bitmap = TryLoadBrandBitmap() ?? CreateFallbackLogoBitmap();
            IntPtr iconHandle = bitmap.GetHicon();
            try
            {
                Icon = (Icon)Icon.FromHandle(iconHandle).Clone();
                ShowIcon = true;
            }
            finally
            {
                DestroyIcon(iconHandle);
            }
        }
        catch
        {
            // Keep default icon if conversion fails
        }
    }

    private static Bitmap TryLoadBrandBitmap()
    {
        var logoPath = Path.Combine(Path.Combine(Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, ".."), "RobolasIcons"), "RoboLasLogoVer2.png");

        if (File.Exists(logoPath))
        {
            using var fileImage = Image.FromFile(logoPath);
            return new Bitmap(fileImage);
        }

        var assembly = typeof(MainForm).Assembly;
        using var resourceStream = assembly.GetManifestResourceStream("RoboLasInstaller.Resources.RoboLasLogoVer2.png");
        if (resourceStream != null)
        {
            using var resourceImage = Image.FromStream(resourceStream);
            return new Bitmap(resourceImage);
        }

        return null;
    }

    private static Bitmap CreateFallbackLogoBitmap()
    {
        var bmp = new Bitmap(56, 56);
        using var g = Graphics.FromImage(bmp);
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Color.Transparent);

        var path = new GraphicsPath();
        var points = new[]
        {
            new Point(28, 4),
            new Point(52, 18),
            new Point(52, 42),
            new Point(28, 56),
            new Point(4, 42),
            new Point(4, 18)
        };
        path.AddPolygon(points);

        using (var brush = new LinearGradientBrush(
            new Point(0, 0), new Point(56, 56),
            Colors.Primary, Colors.Accent))
        {
            g.FillPath(brush, path);
        }

        using (var brush = new SolidBrush(Color.White))
        {
            var sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString("RL", new Font("Segoe UI", 14, FontStyle.Bold), brush, new Rectangle(0, 0, 56, 56), sf);
        }

        return bmp;
    }

    private void LoadTopomaticInstallations()
    {
        topomaticCombo.Items.Clear();

        var possiblePaths = new TopomaticInstallation[]
        {
            new TopomaticInstallation("Topomatic Robur Rail 17.0", @"C:\Program Files\Topomatic Robur Rail 17.0"),
            new TopomaticInstallation("Topomatic Robur Road 17.0", @"C:\Program Files\Topomatic Robur Road 17.0"),
            new TopomaticInstallation("Topomatic Robur Rail 16.0", @"C:\Program Files\Topomatic Robur Rail 16.0"),
            new TopomaticInstallation("Topomatic Robur Road 16.0", @"C:\Program Files\Topomatic Robur Road 16.0"),
            new TopomaticInstallation("Topomatic Robur Rail 15.0", @"C:\Program Files\Topomatic Robur Rail 15.0"),
            new TopomaticInstallation("Topomatic Robur Road 15.0", @"C:\Program Files\Topomatic Robur Road 15.0"),
        };

        foreach (TopomaticInstallation installation in possiblePaths)
        {
            if (Directory.Exists(installation.Path))
            {
                topomaticCombo.Items.Add(installation);
            }
        }

        if (topomaticCombo.Items.Count > 0)
        {
            topomaticCombo.SelectedIndex = 0;
        }
        else
        {
            topomaticCombo.Items.Add(new TopomaticInstallation("Select manually...", ""));
            topomaticCombo.SelectedIndex = 0;
        }
    }

    private void TopomaticCombo_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (topomaticCombo.SelectedItem is TopomaticInstallation installation)
        {
            topomaticPathTextBox.Text = installation.Path;
        }
    }

    private void BrowseTopomaticBtn_Click(object sender, EventArgs e)
    {
        using var dialog = new FolderBrowserDialog
        {
            Description = "Select Topomatic installation folder",
            ShowNewFolderButton = false
        };

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            topomaticPathTextBox.Text = dialog.SelectedPath;
        }
    }

    private void BrowsePackageBtn_Click(object sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog
        {
            Filter = "Topomatic Package|*.tpm|All Files|*.*",
            Title = "Select package file"
        };

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            packagePathTextBox.Text = dialog.FileName;
        }
    }

    private void InstallBtn_Click(object sender, EventArgs e)
    {
        string topomaticPath = topomaticPathTextBox.Text;
        string packagePath = packagePathTextBox.Text;
        if (string.IsNullOrEmpty(topomaticPath) || !Directory.Exists(topomaticPath))
        {
            ShowTooltip("Please select a valid Topomatic installation folder.", Colors.Error);
            return;
        }
        if (string.IsNullOrEmpty(packagePath) || !File.Exists(packagePath))
        {
            ShowTooltip("Please select a valid package file.", Colors.Error);
            return;
        }
        installBtn.Enabled = false;
        installBtn.Text = "INSTALLING...";
        progressBar.Visible = true;
        statusLabel.Visible = true;
        statusLabel.ForeColor = Colors.TextSecondary;
        BackgroundWorker worker = new BackgroundWorker();
        worker.WorkerReportsProgress = true;
        worker.ProgressChanged += delegate(object ignored, ProgressChangedEventArgs progress)
        {
            progressBar.Value = progress.ProgressPercentage;
            statusLabel.Text = "Installing: " + (string)progress.UserState;
        };
        worker.DoWork += delegate(object ignored, DoWorkEventArgs work)
        {
            using (PackageArchive archive = new PackageArchive(packagePath))
            {
                string appDataPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Topomatic");
                PackageInstallPlan.Extract(archive, topomaticPath, appDataPath,
                    delegate(int percentage, string entryName) { worker.ReportProgress(percentage, entryName); });
            }
        };
        worker.RunWorkerCompleted += delegate(object ignored, RunWorkerCompletedEventArgs completed)
        {
            if (completed.Error == null)
            {
                statusLabel.Text = "Installation completed successfully!";
                statusLabel.ForeColor = Colors.Success;
                installBtn.Text = "INSTALLED";
                installBtn.BackColor = Colors.Success;
                var delayedToast = new System.Windows.Forms.Timer { Interval = 1500 };
                delayedToast.Tick += delegate(object timerSender, EventArgs timerEvent)
                {
                    delayedToast.Stop();
                    delayedToast.Dispose();
                    if (!IsDisposed) ShowTooltip("Package installed successfully!", Colors.Success);
                };
                delayedToast.Start();
            }
            else
            {
                statusLabel.Text = "Error: " + completed.Error.Message;
                statusLabel.ForeColor = Colors.Error;
                installBtn.Text = "INSTALL NOW";
                installBtn.Enabled = true;
                ShowTooltip("Installation failed: " + completed.Error.Message, Colors.Error);
            }
            worker.Dispose();
        };
        worker.RunWorkerAsync();
    }

    private void ShowTooltip(string message, Color color)
    {
        // Create a custom tooltip-style notification
        var tooltipForm = new Form
        {
            Size = new Size(400, 60),
            FormBorderStyle = FormBorderStyle.None,
            StartPosition = FormStartPosition.Manual,
            Location = new Point(Location.X + (Width - 400) / 2, Location.Y + Height - 100),
            BackColor = Colors.Surface,
            ShowInTaskbar = false,
            TopMost = true
        };

        var label = new Label
        {
            Text = message,
            Font = new Font("Segoe UI", 10, FontStyle.Regular),
            ForeColor = color,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };

        tooltipForm.Controls.Add(label);
        tooltipForm.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tooltipForm.Width, tooltipForm.Height, 10, 10));
        tooltipForm.Show();

        var t = new System.Windows.Forms.Timer { Interval = 3000 };
        t.Tick += (s, e) =>
        {
            tooltipForm.Close();
            t.Dispose();
        };
        t.Start();
    }

    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern bool DestroyIcon(IntPtr handle);
}

internal sealed class TopomaticInstallation
{
    internal readonly string Name;
    internal readonly string Path;
    internal TopomaticInstallation(string name, string path) { Name = name; Path = path; }
    public override string ToString() { return Name; }
}

// Custom progress bar with gradient fill
public class CustomProgressBar : Control
{
    private int _value = 0;
    private int _maximum = 100;

    public int Value
    {
        get => _value;
        set
        {
            _value = Math.Min(Math.Max(0, value), _maximum);
            Invalidate();
        }
    }

    public int Maximum
    {
        get => _maximum;
        set
        {
            _maximum = Math.Max(1, value);
            Invalidate();
        }
    }

    public CustomProgressBar()
    {
        Size = new Size(200, 8);
        DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        // Draw background
        var bgPath = GetRoundedRect(ClientRectangle, 4);
        using (var brush = new SolidBrush(Color.FromArgb(36, 40, 59)))
        {
            g.FillPath(brush, bgPath);
        }

        // Draw progress with gradient
        if (_value > 0)
        {
            var progressWidth = (int)((double)_value / _maximum * Width);
            var progressRect = new Rectangle(0, 0, progressWidth, Height);
            var progressPath = GetRoundedRect(progressRect, 4);

            using (var brush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(Width, 0),
                Color.FromArgb(122, 162, 247),
                Color.FromArgb(125, 207, 255)))
            {
                g.FillPath(brush, progressPath);
            }

            // Add subtle glow effect
            using (var brush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(0, Height / 2),
                Color.FromArgb(80, 122, 162, 247),
                Color.Transparent))
            {
                var glowRect = new Rectangle(0, 0, progressWidth, Height / 2);
                g.FillRectangle(brush, glowRect);
            }
        }

        // Draw border
        using (var pen = new Pen(Color.FromArgb(59, 65, 94), 1))
        {
            g.DrawPath(pen, bgPath);
        }
    }

    private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
    {
        var path = new GraphicsPath();
        int diameter = radius * 2;

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();

        return path;
    }
}

// Helper class for form dragging
internal class DragHelper
{
    private readonly Form _form;
    private bool _dragging;
    private Point _dragCursorPoint;
    private Point _dragFormPoint;

    public DragHelper(Form form)
    {
        _form = form;
        _form.MouseDown += Form_MouseDown;
        _form.MouseMove += Form_MouseMove;
        _form.MouseUp += Form_MouseUp;

        foreach (Control control in _form.Controls)
        {
            if (control is Panel panel && panel.Dock == DockStyle.Top)
            {
                panel.MouseDown += Form_MouseDown;
                panel.MouseMove += Form_MouseMove;
                panel.MouseUp += Form_MouseUp;
            }
        }
    }

    private void Form_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = _form.Location;
        }
    }

    private void Form_MouseMove(object sender, MouseEventArgs e)
    {
        if (_dragging)
        {
            var diff = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
            _form.Location = Point.Add(_dragFormPoint, new Size(diff));
        }
    }

    private void Form_MouseUp(object sender, MouseEventArgs e)
    {
        _dragging = false;
    }
}

}
