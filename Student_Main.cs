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
        }

        private void Student_Main_Resize(object sender, EventArgs e)
        {
            RoundSidebar();
            RoundHeaderRight();
            RepositionHeaderRight();
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
                if (p != null) picLogo.Image = Image.FromFile(p);
            }
            catch { }
        }

        // ====================================================
        // Icon chuông vẽ bằng GDI+
        // ====================================================
        private void DrawBellIcon()
        {
            int w = picBell.Width, h = picBell.Height;
            Bitmap bmp = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                using (Pen pen = new Pen(Color.FromArgb(50, 80, 120), 2f))
                using (SolidBrush br = new SolidBrush(Color.FromArgb(50, 80, 120)))
                {
                    // Thân chuông
                    g.DrawArc(pen, 5, 3, w - 10, h - 14, 180, 180);
                    g.DrawLine(pen, 5, (h - 14) / 2 + 3, 5, h - 8);
                    g.DrawLine(pen, w - 5, (h - 14) / 2 + 3, w - 5, h - 8);
                    g.DrawLine(pen, 2, h - 8, w - 2, h - 8);
                    // Núm
                    g.DrawLine(pen, w / 2, 0, w / 2, 3);
                    // Quả lắc
                    g.FillEllipse(br, w / 2 - 4, h - 6, 8, 6);
                }
            }
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
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
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
            => MessageBox.Show("Trang cá nhân sinh viên sẽ được thêm vào sau.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void SidebarButton_Click(object sender, EventArgs e)
        {
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
