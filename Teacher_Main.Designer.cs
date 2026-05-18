using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            panelSidebar = new Panel();
            btnDashboard = new Button();
            logoPanel = new Panel();
            lblLogoSub = new Label();
            lblLogo = new Label();
            panelHeader = new Panel();
            lblHeaderUser = new Label();
            lblHeaderTitle = new Label();
            lblHeaderIcon = new Label();
            contentPanel = new Panel();
            lblWelcomeSub = new Label();
            lblWelcomeTitle = new Label();
            lblWelcomeIcon = new Label();
            panelSidebar.SuspendLayout();
            logoPanel.SuspendLayout();
            panelHeader.SuspendLayout();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(22, 50, 92);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(logoPanel);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 603);
            panelSidebar.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(41, 107, 191);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 107, 191);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 65, 115);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 70);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 0, 0);
            btnDashboard.Size = new Size(220, 48);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "📊  Tổng quan";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
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
            logoPanel.TabIndex = 1;
            // 
            // lblLogoSub
            // 
            lblLogoSub.AutoSize = true;
            lblLogoSub.Dock = DockStyle.Bottom;
            lblLogoSub.Font = new Font("Segoe UI", 8F);
            lblLogoSub.ForeColor = Color.FromArgb(130, 160, 200);
            lblLogoSub.Location = new Point(15, 39);
            lblLogoSub.Name = "lblLogoSub";
            lblLogoSub.Size = new Size(172, 19);
            lblLogoSub.TabIndex = 0;
            lblLogoSub.Text = "Cổng thông tin Giảng viên";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(15, 12);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(177, 32);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "👨‍🏫 Giảng viên";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 107, 191);
            panelHeader.Controls.Add(lblHeaderUser);
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Controls.Add(lblHeaderIcon);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(220, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20, 0, 20, 0);
            panelHeader.Size = new Size(762, 55);
            panelHeader.TabIndex = 1;
            // 
            // lblHeaderUser
            // 
            lblHeaderUser.AutoSize = true;
            lblHeaderUser.Dock = DockStyle.Right;
            lblHeaderUser.Font = new Font("Segoe UI", 9F);
            lblHeaderUser.ForeColor = Color.FromArgb(200, 220, 255);
            lblHeaderUser.Location = new Point(742, 0);
            lblHeaderUser.Name = "lblHeaderUser";
            lblHeaderUser.Padding = new Padding(0, 18, 0, 0);
            lblHeaderUser.Size = new Size(0, 38);
            lblHeaderUser.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Dock = DockStyle.Left;
            lblHeaderTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(82, 0);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Padding = new Padding(0, 12, 0, 0);
            lblHeaderTitle.Size = new Size(140, 47);
            lblHeaderTitle.TabIndex = 1;
            lblHeaderTitle.Text = "Tổng quan";
            // 
            // lblHeaderIcon
            // 
            lblHeaderIcon.AutoSize = true;
            lblHeaderIcon.Dock = DockStyle.Left;
            lblHeaderIcon.Font = new Font("Segoe UI", 16F);
            lblHeaderIcon.ForeColor = Color.White;
            lblHeaderIcon.Location = new Point(20, 0);
            lblHeaderIcon.Name = "lblHeaderIcon";
            lblHeaderIcon.Padding = new Padding(0, 8, 8, 0);
            lblHeaderIcon.Size = new Size(62, 45);
            lblHeaderIcon.TabIndex = 2;
            lblHeaderIcon.Text = "📊";
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(245, 247, 251);
            contentPanel.Controls.Add(lblWelcomeSub);
            contentPanel.Controls.Add(lblWelcomeTitle);
            contentPanel.Controls.Add(lblWelcomeIcon);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(220, 55);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(762, 548);
            contentPanel.TabIndex = 0;
            // 
            // lblWelcomeSub
            // 
            lblWelcomeSub.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcomeSub.Font = new Font("Segoe UI", 11F);
            lblWelcomeSub.ForeColor = Color.FromArgb(120, 135, 160);
            lblWelcomeSub.Location = new Point(0, 290);
            lblWelcomeSub.Name = "lblWelcomeSub";
            lblWelcomeSub.Size = new Size(1122, 60);
            lblWelcomeSub.TabIndex = 0;
            lblWelcomeSub.Text = "Hồ sơ của bạn đã được kích hoạt.\nCác chức năng sẽ được cập nhật trong thời gian tới.";
            lblWelcomeSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcomeTitle
            // 
            lblWelcomeTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcomeTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcomeTitle.ForeColor = Color.FromArgb(32, 64, 113);
            lblWelcomeTitle.Location = new Point(0, 240);
            lblWelcomeTitle.Name = "lblWelcomeTitle";
            lblWelcomeTitle.Size = new Size(1122, 40);
            lblWelcomeTitle.TabIndex = 1;
            lblWelcomeTitle.Text = "Chào mừng đến với Cổng thông tin Giảng viên!";
            lblWelcomeTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcomeIcon
            // 
            lblWelcomeIcon.Font = new Font("Segoe UI", 56F);
            lblWelcomeIcon.Location = new Point(0, 107);
            lblWelcomeIcon.Name = "lblWelcomeIcon";
            lblWelcomeIcon.Size = new Size(1122, 123);
            lblWelcomeIcon.TabIndex = 2;
            lblWelcomeIcon.Text = "🎉";
            lblWelcomeIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Teacher_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(982, 603);
            Controls.Add(contentPanel);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            Name = "Teacher_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cổng Giảng viên — EduSystem";
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
