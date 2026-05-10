namespace window_app
{
    partial class ForgotPassForm
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            returnPB = new PictureBox();
            // Step 1 controls
            pnlStep1 = new Panel();
            lblUsername = new Label();
            txtUsername = new TextBox();
            btnSendOtp = new Button();
            lblEmailHint = new Label();
            // Step 2 controls
            pnlStep2 = new Panel();
            lblOtpLabel = new Label();
            txtOtp = new TextBox();
            lblTimer = new Label();
            btnVerifyOtp = new Button();
            lnkResend = new LinkLabel();
            // Step 3 controls
            pnlStep3 = new Panel();
            lblNewPassLabel = new Label();
            txtNewPass = new TextBox();
            lblConfirmLabel = new Label();
            txtConfirmPass = new TextBox();
            btnChangePass = new Button();

            ((System.ComponentModel.ISupportInitialize)returnPB).BeginInit();
            pnlStep1.SuspendLayout();
            pnlStep2.SuspendLayout();
            pnlStep3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Desktop;
            lblTitle.Location = new Point(268, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(245, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Forgot Password";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(0, 80);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(800, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Enter your username to receive OTP";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // returnPB
            // 
            returnPB.Image = Properties.Resources.circle_arrow_left_solid_full;
            returnPB.Location = new Point(12, 12);
            returnPB.Name = "returnPB";
            returnPB.Size = new Size(42, 31);
            returnPB.SizeMode = PictureBoxSizeMode.Zoom;
            returnPB.TabIndex = 2;
            returnPB.TabStop = false;
            returnPB.Cursor = Cursors.Hand;
            returnPB.Click += returnPB_Click;
            // 
            // ===== PANEL STEP 1 =====
            // 
            pnlStep1.Controls.Add(lblEmailHint);
            pnlStep1.Controls.Add(btnSendOtp);
            pnlStep1.Controls.Add(txtUsername);
            pnlStep1.Controls.Add(lblUsername);
            pnlStep1.Location = new Point(100, 130);
            pnlStep1.Name = "pnlStep1";
            pnlStep1.Size = new Size(600, 220);
            pnlStep1.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.Location = new Point(50, 30);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 23);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(200, 27);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(263, 30);
            txtUsername.TabIndex = 1;
            // 
            // btnSendOtp
            // 
            btnSendOtp.BackColor = SystemColors.ActiveCaption;
            btnSendOtp.Font = new Font("Segoe UI", 13F);
            btnSendOtp.ForeColor = SystemColors.ButtonHighlight;
            btnSendOtp.Location = new Point(170, 80);
            btnSendOtp.Name = "btnSendOtp";
            btnSendOtp.Size = new Size(262, 47);
            btnSendOtp.TabIndex = 2;
            btnSendOtp.Text = "Gửi mã OTP";
            btnSendOtp.UseVisualStyleBackColor = false;
            btnSendOtp.Click += btnSendOtp_Click;
            // 
            // lblEmailHint
            // 
            lblEmailHint.AutoSize = true;
            lblEmailHint.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblEmailHint.ForeColor = Color.Gray;
            lblEmailHint.Location = new Point(170, 145);
            lblEmailHint.Name = "lblEmailHint";
            lblEmailHint.Size = new Size(0, 20);
            lblEmailHint.TabIndex = 3;
            // 
            // ===== PANEL STEP 2 =====
            // 
            pnlStep2.Controls.Add(lnkResend);
            pnlStep2.Controls.Add(btnVerifyOtp);
            pnlStep2.Controls.Add(lblTimer);
            pnlStep2.Controls.Add(txtOtp);
            pnlStep2.Controls.Add(lblOtpLabel);
            pnlStep2.Location = new Point(100, 130);
            pnlStep2.Name = "pnlStep2";
            pnlStep2.Size = new Size(600, 220);
            pnlStep2.TabIndex = 4;
            // 
            // lblOtpLabel
            // 
            lblOtpLabel.AutoSize = true;
            lblOtpLabel.Font = new Font("Segoe UI", 10F);
            lblOtpLabel.Location = new Point(50, 30);
            lblOtpLabel.Name = "lblOtpLabel";
            lblOtpLabel.Size = new Size(83, 23);
            lblOtpLabel.TabIndex = 0;
            lblOtpLabel.Text = "OTP Code";
            // 
            // txtOtp
            // 
            txtOtp.Font = new Font("Segoe UI", 14F);
            txtOtp.Location = new Point(200, 23);
            txtOtp.MaxLength = 6;
            txtOtp.Name = "txtOtp";
            txtOtp.Size = new Size(263, 38);
            txtOtp.TabIndex = 1;
            txtOtp.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 9F);
            lblTimer.ForeColor = Color.Gray;
            lblTimer.Location = new Point(200, 70);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(0, 20);
            lblTimer.TabIndex = 2;
            // 
            // btnVerifyOtp
            // 
            btnVerifyOtp.BackColor = SystemColors.ActiveCaption;
            btnVerifyOtp.Font = new Font("Segoe UI", 13F);
            btnVerifyOtp.ForeColor = SystemColors.ButtonHighlight;
            btnVerifyOtp.Location = new Point(170, 100);
            btnVerifyOtp.Name = "btnVerifyOtp";
            btnVerifyOtp.Size = new Size(262, 47);
            btnVerifyOtp.TabIndex = 3;
            btnVerifyOtp.Text = "Xác nhận";
            btnVerifyOtp.UseVisualStyleBackColor = false;
            btnVerifyOtp.Click += btnVerifyOtp_Click;
            // 
            // lnkResend
            // 
            lnkResend.AutoSize = true;
            lnkResend.Font = new Font("Segoe UI", 9F);
            lnkResend.Location = new Point(250, 160);
            lnkResend.Name = "lnkResend";
            lnkResend.Size = new Size(106, 20);
            lnkResend.TabIndex = 4;
            lnkResend.TabStop = true;
            lnkResend.Text = "Gửi lại mã OTP";
            lnkResend.Visible = false;
            lnkResend.LinkClicked += lnkResend_LinkClicked;
            // 
            // ===== PANEL STEP 3 =====
            // 
            pnlStep3.Controls.Add(btnChangePass);
            pnlStep3.Controls.Add(txtConfirmPass);
            pnlStep3.Controls.Add(lblConfirmLabel);
            pnlStep3.Controls.Add(txtNewPass);
            pnlStep3.Controls.Add(lblNewPassLabel);
            pnlStep3.Location = new Point(100, 130);
            pnlStep3.Name = "pnlStep3";
            pnlStep3.Size = new Size(600, 250);
            pnlStep3.TabIndex = 5;
            // 
            // lblNewPassLabel
            // 
            lblNewPassLabel.AutoSize = true;
            lblNewPassLabel.Font = new Font("Segoe UI", 10F);
            lblNewPassLabel.Location = new Point(30, 30);
            lblNewPassLabel.Name = "lblNewPassLabel";
            lblNewPassLabel.Size = new Size(117, 23);
            lblNewPassLabel.TabIndex = 0;
            lblNewPassLabel.Text = "New Password";
            // 
            // txtNewPass
            // 
            txtNewPass.Font = new Font("Segoe UI", 10F);
            txtNewPass.Location = new Point(200, 27);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(263, 30);
            txtNewPass.TabIndex = 1;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // lblConfirmLabel
            // 
            lblConfirmLabel.AutoSize = true;
            lblConfirmLabel.Font = new Font("Segoe UI", 10F);
            lblConfirmLabel.Location = new Point(30, 80);
            lblConfirmLabel.Name = "lblConfirmLabel";
            lblConfirmLabel.Size = new Size(145, 23);
            lblConfirmLabel.TabIndex = 2;
            lblConfirmLabel.Text = "Confirm Password";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Segoe UI", 10F);
            txtConfirmPass.Location = new Point(200, 77);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(263, 30);
            txtConfirmPass.TabIndex = 3;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = SystemColors.ActiveCaption;
            btnChangePass.Font = new Font("Segoe UI", 13F);
            btnChangePass.ForeColor = SystemColors.ButtonHighlight;
            btnChangePass.Location = new Point(170, 135);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(262, 47);
            btnChangePass.TabIndex = 4;
            btnChangePass.Text = "Đổi mật khẩu";
            btnChangePass.UseVisualStyleBackColor = false;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // ForgotPassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(pnlStep3);
            Controls.Add(pnlStep2);
            Controls.Add(pnlStep1);
            Controls.Add(returnPB);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "ForgotPassForm";
            Text = "Forgot Password";
            Load += ForgotPassForm_Load;
            ((System.ComponentModel.ISupportInitialize)returnPB).EndInit();
            pnlStep1.ResumeLayout(false);
            pnlStep1.PerformLayout();
            pnlStep2.ResumeLayout(false);
            pnlStep2.PerformLayout();
            pnlStep3.ResumeLayout(false);
            pnlStep3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private PictureBox returnPB;
        // Step 1
        private Panel pnlStep1;
        private Label lblUsername;
        private TextBox txtUsername;
        private Button btnSendOtp;
        private Label lblEmailHint;
        // Step 2
        private Panel pnlStep2;
        private Label lblOtpLabel;
        private TextBox txtOtp;
        private Label lblTimer;
        private Button btnVerifyOtp;
        private LinkLabel lnkResend;
        // Step 3
        private Panel pnlStep3;
        private Label lblNewPassLabel;
        private TextBox txtNewPass;
        private Label lblConfirmLabel;
        private TextBox txtConfirmPass;
        private Button btnChangePass;
    }
}