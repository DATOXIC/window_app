using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace window_app
{
    public partial class Student_Main : Form
    {
        private readonly myDB db = new myDB();
        private Panel pnlDropdown;

        public Student_Main()
        {
            InitializeComponent();
            this.Load   += Student_Main_Load;
            this.Resize += Student_Main_Resize;
        }

        // ====================================================
        // LOAD
        // ====================================================
        private void Student_Main_Load(object sender, EventArgs e)
        {
            LoadLogo();
            DrawBellIcon();
            LoadStudentInfo();
            RoundSidebar();
            RoundHeaderRight();
            RepositionHeaderRight();
            ShowNotificationPage();
            BuildDropdownMenu();
        }

        private void Student_Main_Resize(object sender, EventArgs e)
        {
            RoundSidebar();
            RoundHeaderRight();
            RepositionHeaderRight();
            HideDropdown();
        }

        private void RepositionHeaderRight()
        {
            pnlHeaderRight.Left = pnlHeader.Width - pnlHeaderRight.Width - 14;
        }

        // ====================================================
        // Logo trường
        // ====================================================
        private void LoadLogo()
        {
            try
            {
                string p = FindFile(Path.Combine("images", "ute_logo.png"));
                if (p != null)
                {
                    using (var src = Image.FromFile(p))
                    {
                        int w = picLogo.Width, h = picLogo.Height;
                        var bmp = new Bitmap(w, h);
                        using (var g = Graphics.FromImage(bmp))
                        {
                            g.InterpolationMode  = InterpolationMode.HighQualityBicubic;
                            g.SmoothingMode      = SmoothingMode.HighQuality;
                            g.PixelOffsetMode    = PixelOffsetMode.HighQuality;
                            g.CompositingQuality = CompositingQuality.HighQuality;
                            g.DrawImage(src, 0, 0, w, h);
                        }
                        picLogo.Image = bmp;
                    }
                }
            }
            catch { }
        }

        // ====================================================
        // Icon chuông – modern flat style
        // ====================================================
        private void DrawBellIcon()
        {
            int w = picBell.Width, h = picBell.Height;
            int scale = 4;
            int sw = w * scale, sh = h * scale;

            Bitmap hiBmp = new Bitmap(sw, sh);
            using (Graphics g = Graphics.FromImage(hiBmp))
            {
                g.SmoothingMode     = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode   = PixelOffsetMode.HighQuality;
                g.Clear(Color.Transparent);

                Color bellColor = Color.FromArgb(45, 75, 115);
                float cx = sw / 2f;

                using (var bellBrush = new SolidBrush(bellColor))
                {
                    // Bell body using path for smooth shape
                    using (var path = new GraphicsPath())
                    {
                        float bellTop    = sh * 0.12f;
                        float bellBottom = sh * 0.72f;
                        float bellWidth  = sw * 0.7f;
                        float bellLeft   = (sw - bellWidth) / 2f;

                        // Dome (top arc)
                        path.AddArc(bellLeft, bellTop, bellWidth, bellWidth * 0.9f, 180, 180);
                        // Right side
                        path.AddLine(bellLeft + bellWidth, bellTop + bellWidth * 0.45f, sw * 0.88f, bellBottom);
                        // Bottom bar
                        path.AddLine(sw * 0.88f, bellBottom, sw * 0.88f, sh * 0.80f);
                        path.AddLine(sw * 0.88f, sh * 0.80f, sw * 0.12f, sh * 0.80f);
                        path.AddLine(sw * 0.12f, sh * 0.80f, sw * 0.12f, bellBottom);
                        // Left side
                        path.AddLine(sw * 0.12f, bellBottom, bellLeft, bellTop + bellWidth * 0.45f);
                        path.CloseFigure();

                        g.FillPath(bellBrush, path);
                    }

                    // Knob on top
                    float knobSize = sw * 0.12f;
                    g.FillEllipse(bellBrush, cx - knobSize / 2, sh * 0.04f, knobSize, knobSize);
                    // Stem line
                    using (var stemPen = new Pen(bellColor, scale * 1.5f))
                    {
                        g.DrawLine(stemPen, cx, sh * 0.04f + knobSize, cx, sh * 0.12f);
                    }

                    // Clapper at bottom
                    float clapW = sw * 0.18f;
                    float clapH = sh * 0.12f;
                    g.FillEllipse(bellBrush, cx - clapW / 2, sh * 0.82f, clapW, clapH);
                }
            }

            // Downscale with high quality
            Bitmap bmp = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode  = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode      = SmoothingMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.DrawImage(hiBmp, 0, 0, w, h);
            }
            hiBmp.Dispose();
            picBell.Image = bmp;
        }

        // ====================================================
        // Thông tin sinh viên từ DB
        // ====================================================
        private void LoadStudentInfo()
        {
            string mssv = Globals.GlobalStudentID ?? "";
            lblStudentMSSV.Text = mssv;

            if (string.IsNullOrEmpty(mssv))
            {
                lblStudentName.Text = Globals.GlobalUsername ?? "Sinh viên";
                LoadDefaultAvatar();
                return;
            }

            try
            {
                string sql = "SELECT Name, Fname, Lname, Pture FROM Student WHERE CAST(MSSV AS NVARCHAR) = @m OR RTRIM(CAST(MSSV AS NVARCHAR)) = @m";
                
                using (SqlCommand cmd = new SqlCommand(sql, db.getConnection()))
                {
                    cmd.Parameters.AddWithValue("@m", mssv.Trim());

                    db.openConnection();
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            string name = rdr["Name"] != DBNull.Value
                                ? rdr["Name"].ToString()
                                : ((rdr["Fname"] != DBNull.Value ? rdr["Fname"].ToString() : "")
                                + " " + (rdr["Lname"] != DBNull.Value ? rdr["Lname"].ToString() : "")).Trim();
                            lblStudentName.Text = string.IsNullOrWhiteSpace(name) ? (Globals.GlobalUsername ?? "Sinh viên") : name;

                            if (rdr["Pture"] != DBNull.Value)
                            {
                                byte[] bytes = (byte[])rdr["Pture"];
                                using var ms = new MemoryStream(bytes);
                                picStudentPhoto.Image = MakeCircle(Image.FromStream(ms), picStudentPhoto.Width);
                            }
                            else LoadDefaultAvatar();
                        }
                        else
                        {
                            lblStudentName.Text = Globals.GlobalUsername ?? "Sinh viên";
                            LoadDefaultAvatar();
                        }
                    }
                    db.closeConnection();
                }   
            }
                
            catch
            {
                lblStudentName.Text = Globals.GlobalUsername ?? "Sinh viên";
                LoadDefaultAvatar();
            }
        }

        private Image MakeCircle(Image src, int size)
        {
            var bmp = new Bitmap(size, size);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.Clear(Color.Transparent);

            // Crop center square để không bị biến dạng
            int srcSize = Math.Min(src.Width, src.Height);
            int srcX = (src.Width  - srcSize) / 2;
            int srcY = (src.Height - srcSize) / 2;
            var srcRect = new Rectangle(srcX, srcY, srcSize, srcSize);

            using var path = new GraphicsPath();
            path.AddEllipse(0, 0, size, size);
            g.SetClip(path);
            g.DrawImage(src, new Rectangle(0, 0, size, size), srcRect, GraphicsUnit.Pixel);
            return bmp;
        }

        private void LoadDefaultAvatar()
        {
            try
            {
                string p = FindFile(Path.Combine("images", "account_icon.png"));
                if (p != null) { picStudentPhoto.Image = Image.FromFile(p); return; }
            }
            catch { }

            var bmp = new Bitmap(picStudentPhoto.Width, picStudentPhoto.Height);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int s = picStudentPhoto.Width;
            g.FillEllipse(new SolidBrush(Color.FromArgb(160, 195, 225)), 0, 0, s, s);
            g.FillEllipse(Brushes.White, s / 2 - 9, s / 4 - 4, 18, 18);
            g.FillEllipse(Brushes.White, s / 2 - 15, s / 2 + 4, 30, 22);
            picStudentPhoto.Image = bmp;
        }

        // ====================================================
        // Bo góc Sidebar (phải)
        // ====================================================
        private void RoundSidebar()
        {
            int w = pnlSidebar.Width, h = pnlSidebar.Height, r = 22;
            var path = new GraphicsPath();
            path.AddArc(0, 0, r, r, 180, 90);          // top-left
            path.AddArc(w - r, 0, r, r, 270, 90);       // top-right
            path.AddArc(w - r, h - r, r, r, 0, 90);     // bottom-right
            path.AddArc(0, h - r, r, r, 90, 90);        // bottom-left
            path.CloseFigure();
            pnlSidebar.Region = new Region(path);
        }

        // ====================================================
        // Bo góc vùng thông tin header phải
        // ====================================================
        private void RoundHeaderRight()
        {
            int w = pnlHeaderRight.Width, h = pnlHeaderRight.Height, r = 30;
            var path = new GraphicsPath();
            path.AddArc(0, 0, r, r, 180, 90);
            path.AddArc(w - r, 0, r, r, 270, 90);
            path.AddArc(w - r, h - r, r, r, 0, 90);
            path.AddArc(0, h - r, r, r, 90, 90);
            path.CloseFigure();
            pnlHeaderRight.Region = new Region(path);
        }

        // ====================================================
        // Dropdown Menu (My Profile, Change Password, Log Out)
        // ====================================================
        private void BuildDropdownMenu()
        {
            pnlDropdown = new Panel
            {
                Size      = new Size(230, 0),   // height will be set on show
                BackColor = Color.White,
                Visible   = false,
                Padding   = new Padding(0),
            };
            pnlDropdown.Paint += (s, e) =>
            {
                // Shadow border
                using var pen = new Pen(Color.FromArgb(40, 0, 0, 0), 1);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlDropdown.Width - 1, pnlDropdown.Height - 1);
            };

            // ── Header: name + MSSV ──
            var pnlDropHeader = new Panel
            {
                Dock      = DockStyle.Top,
                Height    = 52,
                BackColor = Color.White,
                Padding   = new Padding(16, 8, 16, 4)
            };
            var lblDropName = new Label
            {
                Name      = "lblDropName",
                Dock      = DockStyle.Top,
                Height    = 22,
                Text      = lblStudentName.Text + " - " + lblStudentMSSV.Text,
                Font      = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 55, 85),
                TextAlign = ContentAlignment.MiddleLeft
            };
            var pnlDropSep = new Panel
            {
                Dock      = DockStyle.Bottom,
                Height    = 1,
                BackColor = Color.FromArgb(215, 225, 235)
            };
            pnlDropHeader.Controls.Add(lblDropName);
            pnlDropHeader.Controls.Add(pnlDropSep);
            pnlDropdown.Controls.Add(pnlDropHeader);

            // ── Menu items ──
            var pnlMenuItems = new FlowLayoutPanel
            {
                Dock          = DockStyle.Top,
                Height        = 76,
                BackColor     = Color.White,
                FlowDirection = FlowDirection.TopDown,
                WrapContents  = false,
                Padding       = new Padding(0, 4, 0, 4)
            };

            var btnProfile = CreateDropdownItem("👤   My Profile", OnMyProfileClick);
            var btnChangePass = CreateDropdownItem("🔑   Change Password", OnChangePasswordClick);
            pnlMenuItems.Controls.Add(btnProfile);
            pnlMenuItems.Controls.Add(btnChangePass);
            pnlDropdown.Controls.Add(pnlMenuItems);

            // ── Separator + Log Out ──
            var pnlBottomSep = new Panel
            {
                Dock      = DockStyle.Top,
                Height    = 1,
                BackColor = Color.FromArgb(215, 225, 235)
            };
            pnlDropdown.Controls.Add(pnlBottomSep);

            var btnLogout = new Button
            {
                Text      = "Log Out",
                Dock      = DockStyle.Top,
                Height    = 36,
                FlatStyle = FlatStyle.Flat,
                Font      = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(55, 85, 120),
                BackColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor    = Cursors.Hand,
                Margin    = new Padding(16, 4, 16, 4)
            };
            btnLogout.FlatAppearance.BorderColor     = Color.FromArgb(180, 195, 215);
            btnLogout.FlatAppearance.BorderSize       = 1;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 244, 250);
            btnLogout.Click += OnLogoutClick;

            var pnlLogoutWrap = new Panel
            {
                Dock      = DockStyle.Top,
                Height    = 50,
                BackColor = Color.White,
                Padding   = new Padding(24, 6, 24, 8)
            };
            pnlLogoutWrap.Controls.Add(btnLogout);
            btnLogout.Dock = DockStyle.Fill;
            pnlDropdown.Controls.Add(pnlLogoutWrap);

            // Total height: 52 + 76 + 1 + 50 = 179
            pnlDropdown.Size = new Size(230, 179);

            // Add to form
            Controls.Add(pnlDropdown);
            pnlDropdown.BringToFront();

            // Close dropdown when clicking elsewhere
            this.Click += (s, e) => HideDropdown();
            contentPanel.Click += (s, e) => HideDropdown();
            pnlHeader.Click += (s, e) => HideDropdown();
            pnlBody.Click += (s, e) => HideDropdown();
        }

        private Button CreateDropdownItem(string text, EventHandler onClick)
        {
            var btn = new Button
            {
                Text      = text,
                Size      = new Size(228, 34),
                FlatStyle = FlatStyle.Flat,
                Font      = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(50, 70, 100),
                BackColor = Color.White,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding   = new Padding(14, 0, 0, 0),
                Cursor    = Cursors.Hand,
                Margin    = new Padding(0, 0, 0, 0)
            };
            btn.FlatAppearance.BorderSize          = 0;
            btn.FlatAppearance.MouseOverBackColor  = Color.FromArgb(235, 242, 250);
            btn.FlatAppearance.MouseDownBackColor  = Color.FromArgb(218, 230, 242);
            btn.Click += onClick;
            return btn;
        }

        private void ShowDropdown()
        {
            if (pnlDropdown == null) return;

            // Update name in header
            foreach (Control c in pnlDropdown.Controls[0].Controls)
            {
                if (c.Name == "lblDropName")
                {
                    string mssv = lblStudentMSSV.Text;
                    string name = lblStudentName.Text;
                    c.Text = string.IsNullOrWhiteSpace(mssv)
                        ? name
                        : name + " - " + mssv;
                }
            }

            // Position below the header-right panel
            Point headerRightScreen = pnlHeaderRight.PointToScreen(new Point(pnlHeaderRight.Width - pnlDropdown.Width, pnlHeaderRight.Height));
            Point dropLoc = this.PointToClient(headerRightScreen);
            pnlDropdown.Location = new Point(dropLoc.X, dropLoc.Y + 4);
            pnlDropdown.Visible = true;
            pnlDropdown.BringToFront();
        }

        private void HideDropdown()
        {
            if (pnlDropdown != null) pnlDropdown.Visible = false;
        }

        // ====================================================
        // Dropdown actions
        // ====================================================
        private void OnMyProfileClick(object sender, EventArgs e)
        {
            HideDropdown();
            MessageBox.Show("My Profile feature will be available soon.",
                "My Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnChangePasswordClick(object sender, EventArgs e)
        {
            HideDropdown();
            var form = new ChangePasswordForm();
            form.ShowDialog(this);
        }

        private void OnLogoutClick(object sender, EventArgs e)
        {
            HideDropdown();
            var result = MessageBox.Show("Are you sure you want to log out?",
                "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Globals.Logout();
                this.Close();
            }
        }

        // ====================================================
        // Trang thông báo (trang chủ)
        // ====================================================
        private void ShowNotificationPage()
        {
            contentPanel.Controls.Clear();
            var page = new NotificationPage();
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(page);
        }

        // ====================================================
        // Sự kiện click
        // ====================================================
        private void PicLogo_Click(object sender, EventArgs e) => ShowNotificationPage();
        private void PicNotification_Click(object sender, EventArgs e) => ShowNotificationPage();
        private void PicStudentPhoto_Click(object sender, EventArgs e)
        {
            if (pnlDropdown != null && pnlDropdown.Visible)
                HideDropdown();
            else
                ShowDropdown();
        }

        private void SidebarButton_Click(object sender, EventArgs e)
        {
            HideDropdown();
            var btn = (Button)sender;
            string funcName = btn.Name switch
            {
                "btnCurriculum" => "Curriculum",
                "btnClassSchedule" => "Class Schedule",
                "btnExamSchedule" => "Exam Schedule",
                "btnViewGrades" => "View Grades",
                "btnTuitionPayment" => "Tuition Payment",
                "btnTuitionInvoices" => "Tuition Invoices",
                "btnScholarships" => "Scholarships & Financial Aid",
                _ => btn.Text
            };
            ShowPlaceholder(funcName);
        }

        private void ShowPlaceholder(string title)
        {
            contentPanel.Controls.Clear();
            var pnl = new Panel { Dock = DockStyle.Fill, BackColor = Color.White };
            var lbl = new Label
            {
                Text = title + "\n\nChức năng này sẽ được thêm vào sau.",
                Font = new Font("Segoe UI", 13F),
                ForeColor = Color.FromArgb(100, 130, 165),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            pnl.Controls.Add(lbl);
            contentPanel.Controls.Add(pnl);
        }

        // ====================================================
        // Helper: tìm file trong thư mục bin hoặc project
        // ====================================================
        private string FindFile(string relative)
        {
            string p = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relative);
            if (File.Exists(p)) return p;
            try
            {
                string proj = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)
                                       ?.Parent?.Parent?.Parent?.FullName;
                if (proj != null)
                {
                    p = Path.Combine(proj, relative);
                    if (File.Exists(p)) return p;
                }
            }
            catch { }
            return null;
        }

        private void lblSchoolName_Click(object sender, EventArgs e)
        {

        }
    }
}
