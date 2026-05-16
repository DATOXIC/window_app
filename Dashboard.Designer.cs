namespace window_app
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            mainPanel = new Panel();
            cardsFlow = new FlowLayoutPanel();
            welcomePanel = new Panel();
            lblWelcomeSub = new Label();
            lblWelcome = new Label();
            lblWelcomeIcon = new Label();

            mainPanel.SuspendLayout();
            welcomePanel.SuspendLayout();
            SuspendLayout();

            // ========== mainPanel ==========
            mainPanel.BackColor = Color.FromArgb(245, 247, 251);
            mainPanel.Controls.Add(cardsFlow);
            mainPanel.Controls.Add(welcomePanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(30, 15, 30, 20);

            // ========== welcomePanel ==========
            welcomePanel.BackColor = Color.Transparent;
            welcomePanel.Controls.Add(lblWelcomeSub);
            welcomePanel.Controls.Add(lblWelcome);
            welcomePanel.Controls.Add(lblWelcomeIcon);
            welcomePanel.Dock = DockStyle.Top;
            welcomePanel.Name = "welcomePanel";
            welcomePanel.Size = new Size(732, 80);

            lblWelcomeIcon.AutoSize = true;
            lblWelcomeIcon.Dock = DockStyle.Left;
            lblWelcomeIcon.Font = new Font("Segoe UI", 22F);
            lblWelcomeIcon.ForeColor = Color.FromArgb(41, 107, 191);
            lblWelcomeIcon.Name = "lblWelcomeIcon";
            lblWelcomeIcon.Padding = new Padding(0, 8, 0, 0);
            lblWelcomeIcon.Text = "📊";

            lblWelcome.AutoSize = true;
            lblWelcome.Dock = DockStyle.Left;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(22, 50, 92);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Padding = new Padding(10, 12, 0, 0);
            lblWelcome.Text = "Tổng quan Hệ thống";

            lblWelcomeSub.AutoSize = true;
            lblWelcomeSub.Dock = DockStyle.Bottom;
            lblWelcomeSub.Font = new Font("Segoe UI", 9.5F);
            lblWelcomeSub.ForeColor = Color.FromArgb(130, 140, 160);
            lblWelcomeSub.Name = "lblWelcomeSub";
            lblWelcomeSub.Padding = new Padding(0, 0, 0, 10);
            lblWelcomeSub.Text = "Dữ liệu được cập nhật theo thời gian thực từ cơ sở dữ liệu.";

            // ========== cardsFlow ==========
            cardsFlow.AutoScroll = true;
            cardsFlow.BackColor = Color.Transparent;
            cardsFlow.Dock = DockStyle.Fill;
            cardsFlow.Name = "cardsFlow";
            cardsFlow.Padding = new Padding(0, 10, 0, 0);

            // ========== Dashboard ==========
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            Controls.Add(mainPanel);
            Name = "Dashboard";
            Size = new Size(792, 532);
            Load += Dashboard_Load;

            mainPanel.ResumeLayout(false);
            welcomePanel.ResumeLayout(false);
            welcomePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel welcomePanel;
        private Label lblWelcomeIcon;
        private Label lblWelcome;
        private Label lblWelcomeSub;
        private FlowLayoutPanel cardsFlow;
    }
}
