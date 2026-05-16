using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace window_app
{
    public partial class Dashboard : UserControl
    {
        private readonly myDB db = new myDB();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            LoadStats();
        }

        private void LoadStats()
        {
            cardsFlow.Controls.Clear();

            int totalStudents = GetCount("SELECT COUNT(*) FROM Student");
            int pendingAdmissions = GetCount("SELECT COUNT(*) FROM AdmissionList WHERE IsAccountCreated = 0");
            int pendingAccounts = GetCount("SELECT COUNT(*) FROM [Table] WHERE valid = 0");
            int totalCourses = GetCount("SELECT COUNT(*) FROM Course");
            int totalAccounts = GetCount("SELECT COUNT(*) FROM [Table]");
            int approvedAdmissions = GetCount("SELECT COUNT(*) FROM AdmissionList WHERE IsAccountCreated = 1");

            // Row 1: 3 thẻ chính
            AddCard("🎓", "Sinh viên", totalStudents.ToString(), "Đang hoạt động trong hệ thống",
                    Color.FromArgb(41, 107, 191), Color.FromArgb(225, 238, 255));

            AddCard("📋", "Chờ tuyển sinh", pendingAdmissions.ToString(), "Thí sinh đang chờ phê duyệt",
                    Color.FromArgb(230, 126, 34), Color.FromArgb(255, 243, 230));

            AddCard("🔐", "Chờ duyệt TK", pendingAccounts.ToString(), "Tài khoản chờ Admin phê duyệt",
                    Color.FromArgb(220, 53, 69), Color.FromArgb(255, 230, 233));

            // Row 2: 3 thẻ phụ
            AddCard("📚", "Khóa học", totalCourses.ToString(), "Tổng số khóa học hiện có",
                    Color.FromArgb(40, 167, 69), Color.FromArgb(230, 255, 237));

            AddCard("👤", "Tổng tài khoản", totalAccounts.ToString(), "Tất cả tài khoản trong hệ thống",
                    Color.FromArgb(108, 117, 125), Color.FromArgb(240, 242, 245));

            AddCard("✅", "Đã tuyển sinh", approvedAdmissions.ToString(), "Thí sinh đã được cấp tài khoản",
                    Color.FromArgb(23, 162, 184), Color.FromArgb(225, 248, 252));
        }

        /// <summary>
        /// Tạo một thẻ thống kê với giao diện hiện đại
        /// </summary>
        private void AddCard(string icon, string title, string value, string subtitle, Color accentColor, Color bgColor)
        {
            // Card container
            Panel card = new Panel
            {
                Size = new Size(220, 130),
                BackColor = Color.White,
                Margin = new Padding(8),
                Padding = new Padding(18, 15, 18, 15),
                Cursor = Cursors.Default
            };

            // Accent bar bên trái
            Panel accentBar = new Panel
            {
                Dock = DockStyle.Left,
                Width = 5,
                BackColor = accentColor
            };

            // Icon + Title row
            Label lblIcon = new Label
            {
                Text = icon,
                Font = new Font("Segoe UI", 20F),
                ForeColor = accentColor,
                AutoSize = true,
                Location = new Point(22, 12)
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(100, 110, 130),
                AutoSize = true,
                Location = new Point(60, 20)
            };

            // Big number
            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 28F, FontStyle.Bold),
                ForeColor = accentColor,
                AutoSize = true,
                Location = new Point(22, 50)
            };

            // Subtitle
            Label lblSub = new Label
            {
                Text = subtitle,
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(160, 170, 185),
                AutoSize = true,
                Location = new Point(22, 100)
            };

            card.Controls.Add(lblSub);
            card.Controls.Add(lblValue);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblIcon);
            card.Controls.Add(accentBar);

            // Hover effect
            card.MouseEnter += (s, e) => card.BackColor = bgColor;
            card.MouseLeave += (s, e) => card.BackColor = Color.White;
            foreach (Control c in card.Controls)
            {
                c.MouseEnter += (s, e) => card.BackColor = bgColor;
                c.MouseLeave += (s, e) => card.BackColor = Color.White;
            }

            cardsFlow.Controls.Add(card);
        }

        /// <summary>
        /// Thực thi câu lệnh COUNT và trả về kết quả
        /// </summary>
        private int GetCount(string sql)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, db.getConnection()))
                {
                    db.openConnection();
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    db.closeConnection();
                    return result;
                }
            }
            catch
            {
                db.closeConnection();
                return 0;
            }
        }
    }
}
