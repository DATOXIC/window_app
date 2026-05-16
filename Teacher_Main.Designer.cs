namespace window_app
{
    partial class Teacher_Main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelSidebar     = new Panel();
            logoPanel        = new Panel();
            lblLogo          = new Label();
            lblLogoSub       = new Label();
            btnDashboard     = new Button();
            panelHeader      = new Panel();
            lblHeaderIcon    = new Label();
            lblHeaderTitle   = new Label();
            lblHeaderUser    = new Label();
            contentPanel     = new Panel();
            lblWelcomeIcon   = new Label();
            lblWelcomeTitle  = new Label();
            lblWelcomeSub    = new Label();

            panelSidebar.SuspendLayout();
            logoPanel.SuspendLayout();
            panelHeader.SuspendLayout();
            contentPanel.SuspendLayout();
            SuspendLayout();

            // ── panelSidebar ──────────────────────────────────────────
            panelSidebar.BackColor = Color.FromArgb(22, 50, 92);
            panelSidebar.Dock      = DockStyle.Left;
            panelSidebar.Width     = 220;
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(logoPanel);

            // ── logoPanel ─────────────────────────────────────────────
            logoPanel.BackColor = Color.FromArgb(16, 38, 72);
            logoPanel.Dock      = DockStyle.Top;
            logoPanel.Height    = 70;
            logoPanel.Padding   = new Padding(15, 12, 15, 12);
            logoPanel.Controls.Add(lblLogoSub);
            logoPanel.Controls.Add(lblLogo);

            lblLogo.Text      = "👨‍🏫 Giảng viên";
            lblLogo.Font      = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.AutoSize  = true;
            lblLogo.Dock      = DockStyle.Top;

            lblLogoSub.Text      = "Cổng thông tin Giảng viên";
            lblLogoSub.Font      = new Font("Segoe UI", 8F);
            lblLogoSub.ForeColor = Color.FromArgb(130, 160, 200);
            lblLogoSub.AutoSize  = true;
            lblLogoSub.Dock      = DockStyle.Bottom;

            // ── btnDashboard (sidebar nav, only one for now) ──────────
            btnDashboard.Text      = "📊  Tổng quan";
            btnDashboard.Font      = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.BackColor = Color.FromArgb(41, 107, 191);
            btnDashboard.Dock      = DockStyle.Top;
            btnDashboard.Height    = 48;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.FlatAppearance.BorderSize            = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor    = Color.FromArgb(41, 107, 191);
            btnDashboard.FlatAppearance.MouseOverBackColor    = Color.FromArgb(30, 65, 115);
            btnDashboard.Padding   = new Padding(15, 0, 0, 0);
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Cursor    = Cursors.Hand;
            btnDashboard.UseVisualStyleBackColor = false;

            // ── panelHeader ───────────────────────────────────────────
            panelHeader.BackColor = Color.FromArgb(41, 107, 191);
            panelHeader.Dock      = DockStyle.Top;
            panelHeader.Height    = 55;
            panelHeader.Padding   = new Padding(20, 0, 20, 0);
            panelHeader.Controls.Add(lblHeaderUser);
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Controls.Add(lblHeaderIcon);

            lblHeaderIcon.Text      = "📊";
            lblHeaderIcon.Font      = new Font("Segoe UI", 16F);
            lblHeaderIcon.ForeColor = Color.White;
            lblHeaderIcon.AutoSize  = true;
            lblHeaderIcon.Dock      = DockStyle.Left;
            lblHeaderIcon.Padding   = new Padding(0, 8, 8, 0);

            lblHeaderTitle.Text      = "Tổng quan";
            lblHeaderTitle.Font      = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.AutoSize  = true;
            lblHeaderTitle.Dock      = DockStyle.Left;
            lblHeaderTitle.Padding   = new Padding(0, 12, 0, 0);

            lblHeaderUser.Font      = new Font("Segoe UI", 9F);
            lblHeaderUser.ForeColor = Color.FromArgb(200, 220, 255);
            lblHeaderUser.AutoSize  = true;
            lblHeaderUser.Dock      = DockStyle.Right;
            lblHeaderUser.Padding   = new Padding(0, 18, 0, 0);
            lblHeaderUser.Text      = $"👤 {Globals.GlobalUsername}";

            // ── contentPanel (welcome screen) ─────────────────────────
            contentPanel.BackColor = Color.FromArgb(245, 247, 251);
            contentPanel.Dock      = DockStyle.Fill;
            contentPanel.Controls.Add(lblWelcomeSub);
            contentPanel.Controls.Add(lblWelcomeTitle);
            contentPanel.Controls.Add(lblWelcomeIcon);

            lblWelcomeIcon.Text      = "🎉";
            lblWelcomeIcon.Font      = new Font("Segoe UI", 56F);
            lblWelcomeIcon.AutoSize  = false;
            lblWelcomeIcon.Size      = new Size(120, 90);
            lblWelcomeIcon.Location  = new Point(0, 140);
            lblWelcomeIcon.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcomeIcon.Anchor    = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcomeIcon.Width     = 560;

            lblWelcomeTitle.Text      = "Chào mừng đến với Cổng thông tin Giảng viên!";
            lblWelcomeTitle.Font      = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcomeTitle.ForeColor = Color.FromArgb(32, 64, 113);
            lblWelcomeTitle.AutoSize  = false;
            lblWelcomeTitle.Size      = new Size(560, 40);
            lblWelcomeTitle.Location  = new Point(0, 240);
            lblWelcomeTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcomeTitle.Anchor    = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            lblWelcomeSub.Text      = "Hồ sơ của bạn đã được kích hoạt.\nCác chức năng sẽ được cập nhật trong thời gian tới.";
            lblWelcomeSub.Font      = new Font("Segoe UI", 11F);
            lblWelcomeSub.ForeColor = Color.FromArgb(120, 135, 160);
            lblWelcomeSub.AutoSize  = false;
            lblWelcomeSub.Size      = new Size(560, 60);
            lblWelcomeSub.Location  = new Point(0, 290);
            lblWelcomeSub.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcomeSub.Anchor    = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // ── Form ──────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode       = AutoScaleMode.Font;
            ClientSize          = new Size(982, 603);
            StartPosition       = FormStartPosition.CenterScreen;
            Text                = "Cổng Giảng viên — EduSystem";
            BackColor           = Color.FromArgb(245, 247, 251);
            Controls.Add(contentPanel);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);

            Load += Teacher_Main_Load;

            panelSidebar.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            contentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel  panelSidebar, logoPanel, panelHeader, contentPanel;
        private Label  lblLogo, lblLogoSub;
        private Button btnDashboard;
        private Label  lblHeaderIcon, lblHeaderTitle, lblHeaderUser;
        private Label  lblWelcomeIcon, lblWelcomeTitle, lblWelcomeSub;
    }
}
