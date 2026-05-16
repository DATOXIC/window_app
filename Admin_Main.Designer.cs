namespace window_app
{
    partial class Admin_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            course_class_button = new Button();
            user_mangament_button = new Button();
            button3 = new Button();
            add_student_button = new Button();
            approve_button = new Button();
            dashboard_button = new Button();
            logoPanel = new Panel();
            lblLogoSub = new Label();
            lblLogo = new Label();
            headerPanel = new Panel();
            header_label = new Label();
            headerIcon = new Label();
            admin_content_panel = new Panel();
            panel1.SuspendLayout();
            logoPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 50, 92);
            panel1.Controls.Add(course_class_button);
            panel1.Controls.Add(user_mangament_button);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(add_student_button);
            panel1.Controls.Add(approve_button);
            panel1.Controls.Add(dashboard_button);
            panel1.Controls.Add(logoPanel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 603);
            panel1.TabIndex = 2;
            // 
            // course_class_button
            // 
            course_class_button.BackColor = Color.Transparent;
            course_class_button.Cursor = Cursors.Hand;
            course_class_button.Dock = DockStyle.Top;
            course_class_button.FlatAppearance.BorderSize = 0;
            course_class_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 107, 191);
            course_class_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 65, 115);
            course_class_button.FlatStyle = FlatStyle.Flat;
            course_class_button.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            course_class_button.ForeColor = Color.FromArgb(200, 215, 235);
            course_class_button.Location = new Point(0, 310);
            course_class_button.Name = "course_class_button";
            course_class_button.Padding = new Padding(15, 0, 0, 0);
            course_class_button.Size = new Size(220, 48);
            course_class_button.TabIndex = 0;
            course_class_button.Text = "📚  Khóa học";
            course_class_button.TextAlign = ContentAlignment.MiddleLeft;
            course_class_button.UseVisualStyleBackColor = false;
            course_class_button.Click += course_class_button_Click;
            // 
            // user_mangament_button
            // 
            user_mangament_button.BackColor = Color.Transparent;
            user_mangament_button.Cursor = Cursors.Hand;
            user_mangament_button.Dock = DockStyle.Top;
            user_mangament_button.FlatAppearance.BorderSize = 0;
            user_mangament_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 107, 191);
            user_mangament_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 65, 115);
            user_mangament_button.FlatStyle = FlatStyle.Flat;
            user_mangament_button.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            user_mangament_button.ForeColor = Color.FromArgb(200, 215, 235);
            user_mangament_button.Location = new Point(0, 262);
            user_mangament_button.Name = "user_mangament_button";
            user_mangament_button.Padding = new Padding(15, 0, 0, 0);
            user_mangament_button.Size = new Size(220, 48);
            user_mangament_button.TabIndex = 1;
            user_mangament_button.Text = "👥  Quản lý SV";
            user_mangament_button.TextAlign = ContentAlignment.MiddleLeft;
            user_mangament_button.UseVisualStyleBackColor = false;
            user_mangament_button.Click += user_mangament_button_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 107, 191);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 65, 115);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(200, 215, 235);
            button3.Location = new Point(0, 214);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 0, 0);
            button3.Size = new Size(220, 48);
            button3.TabIndex = 2;
            button3.Text = "🎓  Thêm Sinh viên";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // add_student_button
            // 
            add_student_button.BackColor = Color.Transparent;
            add_student_button.Cursor = Cursors.Hand;
            add_student_button.Dock = DockStyle.Top;
            add_student_button.FlatAppearance.BorderSize = 0;
            add_student_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 107, 191);
            add_student_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 65, 115);
            add_student_button.FlatStyle = FlatStyle.Flat;
            add_student_button.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            add_student_button.ForeColor = Color.FromArgb(200, 215, 235);
            add_student_button.Location = new Point(0, 166);
            add_student_button.Name = "add_student_button";
            add_student_button.Padding = new Padding(15, 0, 0, 0);
            add_student_button.Size = new Size(220, 48);
            add_student_button.TabIndex = 3;
            add_student_button.Text = "📋  Phê duyệt TS";
            add_student_button.TextAlign = ContentAlignment.MiddleLeft;
            add_student_button.UseVisualStyleBackColor = false;
            add_student_button.Click += add_student_button_Click;
            // 
            // approve_button
            // 
            approve_button.BackColor = Color.Transparent;
            approve_button.Cursor = Cursors.Hand;
            approve_button.Dock = DockStyle.Top;
            approve_button.FlatAppearance.BorderSize = 0;
            approve_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 107, 191);
            approve_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 65, 115);
            approve_button.FlatStyle = FlatStyle.Flat;
            approve_button.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            approve_button.ForeColor = Color.FromArgb(200, 215, 235);
            approve_button.ImageAlign = ContentAlignment.MiddleLeft;
            approve_button.Location = new Point(0, 118);
            approve_button.Name = "approve_button";
            approve_button.Padding = new Padding(15, 0, 0, 0);
            approve_button.Size = new Size(220, 48);
            approve_button.TabIndex = 4;
            approve_button.Text = "🔐  Kiểm duyệt TK";
            approve_button.TextAlign = ContentAlignment.MiddleLeft;
            approve_button.UseVisualStyleBackColor = false;
            approve_button.Click += approve_button_Click;
            // 
            // dashboard_button
            // 
            dashboard_button.BackColor = Color.FromArgb(41, 107, 191);
            dashboard_button.Cursor = Cursors.Hand;
            dashboard_button.Dock = DockStyle.Top;
            dashboard_button.FlatAppearance.BorderSize = 0;
            dashboard_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 107, 191);
            dashboard_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 65, 115);
            dashboard_button.FlatStyle = FlatStyle.Flat;
            dashboard_button.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dashboard_button.ForeColor = Color.White;
            dashboard_button.Location = new Point(0, 70);
            dashboard_button.Name = "dashboard_button";
            dashboard_button.Padding = new Padding(15, 0, 0, 0);
            dashboard_button.Size = new Size(220, 48);
            dashboard_button.TabIndex = 5;
            dashboard_button.Text = "📊  Dashboard";
            dashboard_button.TextAlign = ContentAlignment.MiddleLeft;
            dashboard_button.UseVisualStyleBackColor = false;
            dashboard_button.Click += dashboard_button_Click;
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.FromArgb(16, 38, 72);
            logoPanel.Controls.Add(lblLogoSub);
            logoPanel.Controls.Add(lblLogo);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Padding = new Padding(15, 12, 15, 12);
            logoPanel.Size = new Size(220, 70);
            logoPanel.TabIndex = 5;
            // 
            // lblLogoSub
            // 
            lblLogoSub.AutoSize = true;
            lblLogoSub.Dock = DockStyle.Bottom;
            lblLogoSub.Font = new Font("Segoe UI", 8F);
            lblLogoSub.ForeColor = Color.FromArgb(130, 160, 200);
            lblLogoSub.Location = new Point(15, 39);
            lblLogoSub.Name = "lblLogoSub";
            lblLogoSub.Size = new Size(120, 19);
            lblLogoSub.TabIndex = 0;
            lblLogoSub.Text = "Quản trị hệ thống";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(15, 12);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(200, 32);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "🛡️ Admin Panel";
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(41, 107, 191);
            headerPanel.Controls.Add(header_label);
            headerPanel.Controls.Add(headerIcon);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(220, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(20, 0, 0, 0);
            headerPanel.Size = new Size(762, 55);
            headerPanel.TabIndex = 1;
            // 
            // header_label
            // 
            header_label.AutoSize = true;
            header_label.Dock = DockStyle.Left;
            header_label.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            header_label.ForeColor = Color.White;
            header_label.Location = new Point(79, 0);
            header_label.Name = "header_label";
            header_label.Padding = new Padding(0, 12, 0, 0);
            header_label.Size = new Size(266, 47);
            header_label.TabIndex = 0;
            header_label.Text = "ADMIN DASHBOARD";
            // 
            // headerIcon
            // 
            headerIcon.AutoSize = true;
            headerIcon.Dock = DockStyle.Left;
            headerIcon.Font = new Font("Segoe UI", 16F);
            headerIcon.ForeColor = Color.White;
            headerIcon.Location = new Point(20, 0);
            headerIcon.Name = "headerIcon";
            headerIcon.Padding = new Padding(0, 8, 5, 0);
            headerIcon.Size = new Size(59, 45);
            headerIcon.TabIndex = 1;
            headerIcon.Text = "⚙️";
            // 
            // admin_content_panel
            // 
            admin_content_panel.BackColor = Color.FromArgb(245, 247, 251);
            admin_content_panel.Dock = DockStyle.Fill;
            admin_content_panel.Location = new Point(220, 55);
            admin_content_panel.Name = "admin_content_panel";
            admin_content_panel.Size = new Size(762, 548);
            admin_content_panel.TabIndex = 0;
            // 
            // Admin_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(982, 603);
            Controls.Add(admin_content_panel);
            Controls.Add(headerPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Admin_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard — Hệ thống Quản lý";
            Load += Admin_Main_Load;
            panel1.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel logoPanel;
        private Label lblLogo;
        private Label lblLogoSub;
        private Button approve_button;
        private Button add_student_button;
        private Button button3;
        private Button user_mangament_button;
        private Button course_class_button;
        private Panel headerPanel;
        private Label header_label;
        private Label headerIcon;
        private Panel admin_content_panel;
        private Button dashboard_button;
    }
}