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
            pnlStep1 = new Panel();
            lblEmailHint = new Label();
            btnSendOtp = new Button();
            txtUsername = new TextBox();
            lblUsername = new Label();
            pnlStep2 = new Panel();
            lnkResend = new LinkLabel();
            btnVerifyOtp = new Button();
            lblTimer = new Label();
            txtOtp = new TextBox();
            lblOtpLabel = new Label();
            pnlStep3 = new Panel();
            btnChangePass = new Button();
            txtConfirmPass = new TextBox();
            lblConfirmLabel = new Label();
            txtNewPass = new TextBox();
            lblNewPassLabel = new Label();
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
            lblTitle.Location = new Point(274, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(189, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Forgot Password";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(21, 82);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(700, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Enter your username to receive OTP";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // returnPB
            // 
            returnPB.Cursor = Cursors.Hand;
            returnPB.Image = Properties.Resources.circle_arrow_left_solid_full;
            returnPB.Location = new Point(10, 9);
            returnPB.Margin = new Padding(3, 2, 3, 2);
            returnPB.Name = "returnPB";
            returnPB.Size = new Size(37, 23);
            returnPB.SizeMode = PictureBoxSizeMode.Zoom;
            returnPB.TabIndex = 2;
            returnPB.TabStop = false;
            returnPB.Click += returnPB_Click;
            // 
            // pnlStep1
            // 
            pnlStep1.Controls.Add(lblEmailHint);
            pnlStep1.Controls.Add(btnSendOtp);
            pnlStep1.Controls.Add(txtUsername);
            pnlStep1.Controls.Add(lblUsername);
            pnlStep1.Location = new Point(99, 120);
            pnlStep1.Margin = new Padding(3, 2, 3, 2);
            pnlStep1.Name = "pnlStep1";
            pnlStep1.Size = new Size(525, 165);
            pnlStep1.TabIndex = 3;
            // 
            // lblEmailHint
            // 
            lblEmailHint.AutoSize = true;
            lblEmailHint.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblEmailHint.ForeColor = Color.Gray;
            lblEmailHint.Location = new Point(149, 109);
            lblEmailHint.Name = "lblEmailHint";
            lblEmailHint.Size = new Size(0, 15);
            lblEmailHint.TabIndex = 3;
            // 
            // btnSendOtp
            // 
            btnSendOtp.BackColor = SystemColors.ActiveCaption;
            btnSendOtp.Font = new Font("Segoe UI", 13F);
            btnSendOtp.ForeColor = SystemColors.ButtonHighlight;
            btnSendOtp.Location = new Point(149, 60);
            btnSendOtp.Margin = new Padding(3, 2, 3, 2);
            btnSendOtp.Name = "btnSendOtp";
            btnSendOtp.Size = new Size(229, 35);
            btnSendOtp.TabIndex = 2;
            btnSendOtp.Text = "Send OTP";
            btnSendOtp.UseVisualStyleBackColor = false;
            btnSendOtp.Click += btnSendOtp_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(175, 20);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(231, 25);
            txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.Location = new Point(44, 22);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(71, 19);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // pnlStep2
            // 
            pnlStep2.Controls.Add(lnkResend);
            pnlStep2.Controls.Add(btnVerifyOtp);
            pnlStep2.Controls.Add(lblTimer);
            pnlStep2.Controls.Add(txtOtp);
            pnlStep2.Controls.Add(lblOtpLabel);
            pnlStep2.Location = new Point(99, 120);
            pnlStep2.Margin = new Padding(3, 2, 3, 2);
            pnlStep2.Name = "pnlStep2";
            pnlStep2.Size = new Size(525, 165);
            pnlStep2.TabIndex = 4;
            // 
            // lnkResend
            // 
            lnkResend.AutoSize = true;
            lnkResend.Font = new Font("Segoe UI", 9F);
            lnkResend.Location = new Point(226, 115);
            lnkResend.Name = "lnkResend";
            lnkResend.Size = new Size(70, 15);
            lnkResend.TabIndex = 4;
            lnkResend.TabStop = true;
            lnkResend.Text = "Resend OTP";
            lnkResend.Visible = false;
            lnkResend.LinkClicked += lnkResend_LinkClicked;
            // 
            // btnVerifyOtp
            // 
            btnVerifyOtp.BackColor = SystemColors.ActiveCaption;
            btnVerifyOtp.Font = new Font("Segoe UI", 13F);
            btnVerifyOtp.ForeColor = SystemColors.ButtonHighlight;
            btnVerifyOtp.Location = new Point(149, 75);
            btnVerifyOtp.Margin = new Padding(3, 2, 3, 2);
            btnVerifyOtp.Name = "btnVerifyOtp";
            btnVerifyOtp.Size = new Size(229, 35);
            btnVerifyOtp.TabIndex = 3;
            btnVerifyOtp.Text = "Confirm";
            btnVerifyOtp.UseVisualStyleBackColor = false;
            btnVerifyOtp.Click += btnVerifyOtp_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 9F);
            lblTimer.ForeColor = Color.Gray;
            lblTimer.Location = new Point(175, 52);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(0, 15);
            lblTimer.TabIndex = 2;
            // 
            // txtOtp
            // 
            txtOtp.Font = new Font("Segoe UI", 14F);
            txtOtp.Location = new Point(175, 17);
            txtOtp.Margin = new Padding(3, 2, 3, 2);
            txtOtp.MaxLength = 6;
            txtOtp.Name = "txtOtp";
            txtOtp.Size = new Size(231, 32);
            txtOtp.TabIndex = 1;
            txtOtp.TextAlign = HorizontalAlignment.Center;
            // 
            // lblOtpLabel
            // 
            lblOtpLabel.AutoSize = true;
            lblOtpLabel.Font = new Font("Segoe UI", 10F);
            lblOtpLabel.Location = new Point(44, 22);
            lblOtpLabel.Name = "lblOtpLabel";
            lblOtpLabel.Size = new Size(70, 19);
            lblOtpLabel.TabIndex = 0;
            lblOtpLabel.Text = "OTP Code";
            // 
            // pnlStep3
            // 
            pnlStep3.Controls.Add(btnChangePass);
            pnlStep3.Controls.Add(txtConfirmPass);
            pnlStep3.Controls.Add(lblConfirmLabel);
            pnlStep3.Controls.Add(txtNewPass);
            pnlStep3.Controls.Add(lblNewPassLabel);
            pnlStep3.Location = new Point(99, 120);
            pnlStep3.Margin = new Padding(3, 2, 3, 2);
            pnlStep3.Name = "pnlStep3";
            pnlStep3.Size = new Size(525, 188);
            pnlStep3.TabIndex = 5;
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = SystemColors.ActiveCaption;
            btnChangePass.Font = new Font("Segoe UI", 13F);
            btnChangePass.ForeColor = SystemColors.ButtonHighlight;
            btnChangePass.Location = new Point(149, 101);
            btnChangePass.Margin = new Padding(3, 2, 3, 2);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(229, 35);
            btnChangePass.TabIndex = 4;
            btnChangePass.Text = "Change password";
            btnChangePass.UseVisualStyleBackColor = false;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Segoe UI", 10F);
            txtConfirmPass.Location = new Point(175, 58);
            txtConfirmPass.Margin = new Padding(3, 2, 3, 2);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(231, 25);
            txtConfirmPass.TabIndex = 3;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // lblConfirmLabel
            // 
            lblConfirmLabel.AutoSize = true;
            lblConfirmLabel.Font = new Font("Segoe UI", 10F);
            lblConfirmLabel.Location = new Point(26, 60);
            lblConfirmLabel.Name = "lblConfirmLabel";
            lblConfirmLabel.Size = new Size(120, 19);
            lblConfirmLabel.TabIndex = 2;
            lblConfirmLabel.Text = "Confirm Password";
            // 
            // txtNewPass
            // 
            txtNewPass.Font = new Font("Segoe UI", 10F);
            txtNewPass.Location = new Point(175, 20);
            txtNewPass.Margin = new Padding(3, 2, 3, 2);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(231, 25);
            txtNewPass.TabIndex = 1;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // lblNewPassLabel
            // 
            lblNewPassLabel.AutoSize = true;
            lblNewPassLabel.Font = new Font("Segoe UI", 10F);
            lblNewPassLabel.Location = new Point(26, 22);
            lblNewPassLabel.Name = "lblNewPassLabel";
            lblNewPassLabel.Size = new Size(98, 19);
            lblNewPassLabel.TabIndex = 0;
            lblNewPassLabel.Text = "New Password";
            // 
            // ForgotPassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 375);
            Controls.Add(pnlStep3);
            Controls.Add(pnlStep2);
            Controls.Add(pnlStep1);
            Controls.Add(returnPB);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
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