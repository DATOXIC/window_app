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
            header_label.Text = "APPROVE STUDENT ACCOUNTS";
            admin_content_panel.Controls.Clear();
            UserControl1 us = new UserControl1();
            admin_content_panel.Controls.Add(us);
        }
    }
}
