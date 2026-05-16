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
        public Admin_Main()
        {
            InitializeComponent();
        }

        private void approve_button_Click(object sender, EventArgs e)
        {
            header_label.Text = "APPROVE MANAGEMENT ACCOUNTS";
            admin_content_panel.Controls.Clear();
            User1 us = new User1();
            admin_content_panel.Controls.Add(us);
        }

        private void add_student_button_Click(object sender, EventArgs e)
        {
            header_label.Text = "VERIFY STUDENT ACCOUNTS";
            admin_content_panel.Controls.Clear();
            User2 us = new User2();
            admin_content_panel.Controls.Add(us);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            header_label.Text = "ADD STUDENT TO ADMISSION";
            admin_content_panel.Controls.Clear();
            User3 us = new User3();
            us.Dock = DockStyle.Fill;
            admin_content_panel.Controls.Add(us);
        }

        private void user_mangament_button_Click(object sender, EventArgs e)
        {
            header_label.Text = "USER ACCOUNT MANAGEMENT";
            admin_content_panel.Controls.Clear();
            User4 us = new User4();
            us.Dock = DockStyle.Fill;
            admin_content_panel.Controls.Add(us);
        }

        private void course_class_button_Click(object sender, EventArgs e)
        {
            header_label.Text = "COURSE & CLASS MANAGEMENT";
            admin_content_panel.Controls.Clear();
            User5 us = new User5();
            us.Dock = DockStyle.Fill;
            admin_content_panel.Controls.Add(us);
        }
    }
}
