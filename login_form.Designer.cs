namespace window_app
{
    partial class login_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cardPanel = new Panel();
            // Links row
            linksPanel = new Panel();
            forgetPassword_button = new LinkLabel();
            signup_button = new LinkLabel();
            // Buttons row
            buttonsPanel = new Panel();
            cancel_button = new Button();
            login_button = new Button();
            // Password field
            passFieldPanel = new Panel();
            passUnderline = new Panel();
            pass_tb = new TextBox();
            pass_lb = new Label();
            // Username field
            userFieldPanel = new Panel();
            userUnderline = new Panel();
            user_tb = new TextBox();
            user_lb = new Label();
            // Header
            headerSection = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            lblIcon = new Label();

            cardPanel.SuspendLayout();
            linksPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            passFieldPanel.SuspendLayout();
            userFieldPanel.SuspendLayout();
            headerSection.SuspendLayout();
            SuspendLayout();

            // ========== cardPanel (Card trung tâm) ==========
            cardPanel.BackColor = Color.White;
            cardPanel.Controls.Add(linksPanel);
            cardPanel.Controls.Add(buttonsPanel);
            cardPanel.Controls.Add(passFieldPanel);
            cardPanel.Controls.Add(userFieldPanel);
            cardPanel.Controls.Add(headerSection);
            cardPanel.Location = new Point(100, 40);
            cardPanel.Name = "cardPanel";
            cardPanel.Padding = new Padding(40, 25, 40, 25);
            cardPanel.Size = new Size(400, 420);

            // ========== headerSection ==========
            headerSection.BackColor = Color.Transparent;
            headerSection.Controls.Add(lblSubtitle);
            headerSection.Controls.Add(lblTitle);
            headerSection.Controls.Add(lblIcon);
            headerSection.Dock = DockStyle.Top;
            headerSection.Name = "headerSection";
            headerSection.Padding = new Padding(0, 5, 0, 15);
            headerSection.Size = new Size(320, 110);

            lblIcon.Dock = DockStyle.Top;
            lblIcon.Font = new Font("Segoe UI", 32F);
            lblIcon.ForeColor = Color.FromArgb(41, 107, 191);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(320, 50);
            lblIcon.Text = "🔐";
            lblIcon.TextAlign = ContentAlignment.MiddleCenter;

            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(22, 50, 92);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(320, 35);
            lblTitle.Text = "Đăng nhập";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            lblSubtitle.AutoSize = true;
            lblSubtitle.Dock = DockStyle.Top;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(130, 140, 160);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Text = "Nhập tài khoản của bạn để tiếp tục";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            // ========== userFieldPanel ==========
            userFieldPanel.BackColor = Color.Transparent;
            userFieldPanel.Controls.Add(userUnderline);
            userFieldPanel.Controls.Add(user_tb);
            userFieldPanel.Controls.Add(user_lb);
            userFieldPanel.Dock = DockStyle.Top;
            userFieldPanel.Name = "userFieldPanel";
            userFieldPanel.Padding = new Padding(0, 5, 0, 10);
            userFieldPanel.Size = new Size(320, 65);

            user_lb.AutoSize = true;
            user_lb.Dock = DockStyle.Top;
            user_lb.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            user_lb.ForeColor = Color.FromArgb(32, 64, 113);
            user_lb.Name = "user_lb";
            user_lb.Padding = new Padding(0, 0, 0, 5);
            user_lb.Text = "Tên đăng nhập";

            user_tb.BackColor = Color.FromArgb(248, 250, 253);
            user_tb.BorderStyle = BorderStyle.None;
            user_tb.Dock = DockStyle.Top;
            user_tb.Font = new Font("Segoe UI", 11F);
            user_tb.ForeColor = Color.FromArgb(50, 50, 50);
            user_tb.Name = "user_tb";
            user_tb.PlaceholderText = "Nhập username...";
            user_tb.Size = new Size(320, 25);

            userUnderline.BackColor = Color.FromArgb(41, 107, 191);
            userUnderline.Dock = DockStyle.Top;
            userUnderline.Name = "userUnderline";
            userUnderline.Size = new Size(320, 2);

            // ========== passFieldPanel ==========
            passFieldPanel.BackColor = Color.Transparent;
            passFieldPanel.Controls.Add(passUnderline);
            passFieldPanel.Controls.Add(pass_tb);
            passFieldPanel.Controls.Add(pass_lb);
            passFieldPanel.Dock = DockStyle.Top;
            passFieldPanel.Name = "passFieldPanel";
            passFieldPanel.Padding = new Padding(0, 5, 0, 10);
            passFieldPanel.Size = new Size(320, 65);

            pass_lb.AutoSize = true;
            pass_lb.Dock = DockStyle.Top;
            pass_lb.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            pass_lb.ForeColor = Color.FromArgb(32, 64, 113);
            pass_lb.Name = "pass_lb";
            pass_lb.Padding = new Padding(0, 0, 0, 5);
            pass_lb.Text = "Mật khẩu";

            pass_tb.BackColor = Color.FromArgb(248, 250, 253);
            pass_tb.BorderStyle = BorderStyle.None;
            pass_tb.Dock = DockStyle.Top;
            pass_tb.Font = new Font("Segoe UI", 11F);
            pass_tb.ForeColor = Color.FromArgb(50, 50, 50);
            pass_tb.Name = "pass_tb";
            pass_tb.PlaceholderText = "Nhập mật khẩu...";
            pass_tb.Size = new Size(320, 25);
            pass_tb.UseSystemPasswordChar = true;

            passUnderline.BackColor = Color.FromArgb(41, 107, 191);
            passUnderline.Dock = DockStyle.Top;
            passUnderline.Name = "passUnderline";
            passUnderline.Size = new Size(320, 2);

            // ========== buttonsPanel ==========
            buttonsPanel.BackColor = Color.Transparent;
            buttonsPanel.Controls.Add(cancel_button);
            buttonsPanel.Controls.Add(login_button);
            buttonsPanel.Dock = DockStyle.Top;
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Padding = new Padding(0, 12, 0, 5);
            buttonsPanel.Size = new Size(320, 65);

            login_button.BackColor = Color.FromArgb(41, 107, 191);
            login_button.Cursor = Cursors.Hand;
            login_button.Dock = DockStyle.Top;
            login_button.FlatAppearance.BorderSize = 0;
            login_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 80, 150);
            login_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 210);
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            login_button.ForeColor = Color.White;
            login_button.Name = "login_button";
            login_button.Size = new Size(320, 44);
            login_button.Text = "Đăng nhập";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;

            cancel_button.BackColor = Color.Transparent;
            cancel_button.Cursor = Cursors.Hand;
            cancel_button.Dock = DockStyle.Top;
            cancel_button.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            cancel_button.FlatAppearance.BorderSize = 0;
            cancel_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 247, 251);
            cancel_button.FlatStyle = FlatStyle.Flat;
            cancel_button.Font = new Font("Segoe UI", 9F);
            cancel_button.ForeColor = Color.FromArgb(150, 160, 175);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(320, 30);
            cancel_button.Text = "Thoát ứng dụng";
            cancel_button.UseVisualStyleBackColor = false;
            cancel_button.Click += cancel_button_Click;

            // ========== linksPanel ==========
            linksPanel.BackColor = Color.Transparent;
            linksPanel.Controls.Add(signup_button);
            linksPanel.Controls.Add(forgetPassword_button);
            linksPanel.Dock = DockStyle.Top;
            linksPanel.Name = "linksPanel";
            linksPanel.Padding = new Padding(0, 8, 0, 0);
            linksPanel.Size = new Size(320, 40);

            forgetPassword_button.AutoSize = true;
            forgetPassword_button.Dock = DockStyle.Left;
            forgetPassword_button.Font = new Font("Segoe UI", 9F);
            forgetPassword_button.LinkColor = Color.FromArgb(41, 107, 191);
            forgetPassword_button.ActiveLinkColor = Color.FromArgb(24, 80, 150);
            forgetPassword_button.Name = "forgetPassword_button";
            forgetPassword_button.Text = "Quên mật khẩu?";
            forgetPassword_button.LinkClicked += forgetPassword_button_LinkClicked;

            signup_button.AutoSize = true;
            signup_button.Dock = DockStyle.Right;
            signup_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            signup_button.LinkColor = Color.FromArgb(41, 107, 191);
            signup_button.ActiveLinkColor = Color.FromArgb(24, 80, 150);
            signup_button.Name = "signup_button";
            signup_button.Text = "Đăng ký tài khoản →";
            signup_button.LinkClicked += signup_button_LinkClicked;

            // ========== login_form ==========
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 240, 248);
            ClientSize = new Size(600, 500);
            Controls.Add(cardPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "login_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập — Hệ thống Quản lý";

            cardPanel.ResumeLayout(false);
            linksPanel.ResumeLayout(false);
            linksPanel.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            passFieldPanel.ResumeLayout(false);
            passFieldPanel.PerformLayout();
            userFieldPanel.ResumeLayout(false);
            userFieldPanel.PerformLayout();
            headerSection.ResumeLayout(false);
            headerSection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel cardPanel;
        private Panel headerSection;
        private Label lblIcon;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel userFieldPanel;
        private Panel userUnderline;
        private TextBox user_tb;
        private Label user_lb;
        private Panel passFieldPanel;
        private Panel passUnderline;
        private TextBox pass_tb;
        private Label pass_lb;
        private Panel buttonsPanel;
        private Button login_button;
        private Button cancel_button;
        private Panel linksPanel;
        private LinkLabel forgetPassword_button;
        private LinkLabel signup_button;
    }
}
