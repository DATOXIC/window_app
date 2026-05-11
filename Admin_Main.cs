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
            header_label.Text = "APPROVE STUDENT ACCOUNTS";
            admin_content_panel.Controls.Clear();
            User2 us = new User2();
            admin_content_panel.Controls.Add(us);
        }
    }
}
