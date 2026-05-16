using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace window_app
{
    public partial class Admin_Main : Form
    {
        private Button _activeButton = null;

        public Admin_Main()
        {
            InitializeComponent();
        }

        private void Admin_Main_Load(object sender, EventArgs e)
        {
            // Mặc định hiện Dashboard khi mở app
            dashboard_button_Click(dashboard_button, EventArgs.Empty);
        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            SetActiveButton(dashboard_button, "Tổng quan Hệ thống", "📊");
            admin_content_panel.Controls.Clear();
            Dashboard db = new Dashboard();
            db.Dock = DockStyle.Fill;
            admin_content_panel.Controls.Add(db);
        }

        /// <summary>
        /// Highlight nút đang active trên sidebar (đổi màu nền + chữ trắng sáng)
        /// </summary>
        private void SetActiveButton(Button btn, string headerText, string icon)
        {
            // Reset nút cũ
            if (_activeButton != null)
            {
                _activeButton.BackColor = Color.Transparent;
                _activeButton.ForeColor = Color.FromArgb(200, 215, 235);
            }

            // Highlight nút mới
            _activeButton = btn;
            _activeButton.BackColor = Color.FromArgb(41, 107, 191);
            _activeButton.ForeColor = Color.White;

            // Cập nhật header
            header_label.Text = headerText;
            headerIcon.Text = icon;
        }

        private void approve_button_Click(object sender, EventArgs e)
        {
            SetActiveButton(approve_button, "Kiểm duyệt Tài khoản", "🔐");
            admin_content_panel.Controls.Clear();
            User1 us = new User1();
            admin_content_panel.Controls.Add(us);
        }

        private void add_student_button_Click(object sender, EventArgs e)
        {
            SetActiveButton(add_student_button, "Phê duyệt Tuyển sinh", "📋");
            admin_content_panel.Controls.Clear();
            User2 us = new User2();
            admin_content_panel.Controls.Add(us);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetActiveButton(button3, "Thêm Sinh viên", "🎓");
            admin_content_panel.Controls.Clear();
            User3 us = new User3();
            us.Dock = DockStyle.Fill;
            admin_content_panel.Controls.Add(us);
        }

        private void user_mangament_button_Click(object sender, EventArgs e)
        {
            SetActiveButton(user_mangament_button, "Quản lý Sinh viên", "👥");
            admin_content_panel.Controls.Clear();
            User4 us = new User4();
            us.Dock = DockStyle.Fill;
            admin_content_panel.Controls.Add(us);
        }

        private void course_class_button_Click(object sender, EventArgs e)
        {
            SetActiveButton(course_class_button, "Quản lý Khóa học", "📚");
            admin_content_panel.Controls.Clear();
            User5 us = new User5();
            us.Dock = DockStyle.Fill;
            admin_content_panel.Controls.Add(us);
        }
    }
}
