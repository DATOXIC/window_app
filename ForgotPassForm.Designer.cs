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
            this.cardPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.returnPB = new System.Windows.Forms.LinkLabel();
            
            // Step 1
            this.pnlStep1 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lineUsername = new System.Windows.Forms.Panel();
            this.btnSendOtp = new System.Windows.Forms.Button();
            
            // Step 2
            this.pnlStep2 = new System.Windows.Forms.Panel();
            this.lblEmailHint = new System.Windows.Forms.Label();
            this.lblOtp = new System.Windows.Forms.Label();
            this.txtOtp = new System.Windows.Forms.TextBox();
            this.lineOtp = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lnkResend = new System.Windows.Forms.LinkLabel();
            this.btnVerifyOtp = new System.Windows.Forms.Button();
            
            // Step 3
            this.pnlStep3 = new System.Windows.Forms.Panel();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lineNewPass = new System.Windows.Forms.Panel();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lineConfirmPass = new System.Windows.Forms.Panel();
            this.btnChangePass = new System.Windows.Forms.Button();

            this.cardPanel.SuspendLayout();
            this.pnlStep1.SuspendLayout();
            this.pnlStep2.SuspendLayout();
            this.pnlStep3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardPanel
            // 
            this.cardPanel.BackColor = System.Drawing.Color.White;
            this.cardPanel.Controls.Add(this.lblSubtitle);
            this.cardPanel.Controls.Add(this.lblTitle);
            this.cardPanel.Controls.Add(this.pnlStep1);
            this.cardPanel.Controls.Add(this.pnlStep2);
            this.cardPanel.Controls.Add(this.pnlStep3);
            this.cardPanel.Controls.Add(this.returnPB);
            this.cardPanel.Location = new System.Drawing.Point(175, 40);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(450, 560);
            this.cardPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(113)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "KHÔI PHỤC TÀI KHOẢN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.lblSubtitle.Location = new System.Drawing.Point(0, 70);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(450, 30);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Subtitle text here";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnPB (Quay lại)
            // 
            this.returnPB.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.returnPB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.returnPB.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.returnPB.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.returnPB.Location = new System.Drawing.Point(40, 510);
            this.returnPB.Name = "returnPB";
            this.returnPB.Size = new System.Drawing.Size(370, 25);
            this.returnPB.TabIndex = 14;
            this.returnPB.TabStop = true;
            this.returnPB.Text = "← Quay lại Đăng nhập";
            this.returnPB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returnPB.Click += new System.EventHandler(this.returnPB_Click);

            // ==========================================
            // pnlStep1: NHẬP USERNAME
            // ==========================================
            this.pnlStep1.Controls.Add(this.btnSendOtp);
            this.pnlStep1.Controls.Add(this.lineUsername);
            this.pnlStep1.Controls.Add(this.txtUsername);
            this.pnlStep1.Controls.Add(this.lblUsername);
            this.pnlStep1.Location = new System.Drawing.Point(0, 130);
            this.pnlStep1.Name = "pnlStep1";
            this.pnlStep1.Size = new System.Drawing.Size(450, 360);
            this.pnlStep1.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(113)))));
            this.lblUsername.Location = new System.Drawing.Point(40, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Tên đăng nhập";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtUsername.Location = new System.Drawing.Point(40, 60);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(370, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // lineUsername
            // 
            this.lineUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.lineUsername.Location = new System.Drawing.Point(40, 85);
            this.lineUsername.Name = "lineUsername";
            this.lineUsername.Size = new System.Drawing.Size(370, 2);
            this.lineUsername.TabIndex = 3;
            // 
            // btnSendOtp
            // 
            this.btnSendOtp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnSendOtp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendOtp.FlatAppearance.BorderSize = 0;
            this.btnSendOtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendOtp.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSendOtp.ForeColor = System.Drawing.Color.White;
            this.btnSendOtp.Location = new System.Drawing.Point(40, 150);
            this.btnSendOtp.Name = "btnSendOtp";
            this.btnSendOtp.Size = new System.Drawing.Size(370, 45);
            this.btnSendOtp.TabIndex = 13;
            this.btnSendOtp.Text = "Gửi mã OTP";
            this.btnSendOtp.UseVisualStyleBackColor = false;
            this.btnSendOtp.Click += new System.EventHandler(this.btnSendOtp_Click);

            // ==========================================
            // pnlStep2: NHẬP MÃ OTP
            // ==========================================
            this.pnlStep2.Controls.Add(this.btnVerifyOtp);
            this.pnlStep2.Controls.Add(this.lnkResend);
            this.pnlStep2.Controls.Add(this.lblTimer);
            this.pnlStep2.Controls.Add(this.lineOtp);
            this.pnlStep2.Controls.Add(this.txtOtp);
            this.pnlStep2.Controls.Add(this.lblOtp);
            this.pnlStep2.Controls.Add(this.lblEmailHint);
            this.pnlStep2.Location = new System.Drawing.Point(0, 130);
            this.pnlStep2.Name = "pnlStep2";
            this.pnlStep2.Size = new System.Drawing.Size(450, 360);
            this.pnlStep2.TabIndex = 3;
            // 
            // lblEmailHint
            // 
            this.lblEmailHint.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblEmailHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblEmailHint.Location = new System.Drawing.Point(40, 0);
            this.lblEmailHint.Name = "lblEmailHint";
            this.lblEmailHint.Size = new System.Drawing.Size(370, 25);
            this.lblEmailHint.TabIndex = 0;
            this.lblEmailHint.Text = "OTP đã gửi tới email...";
            this.lblEmailHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOtp
            // 
            this.lblOtp.AutoSize = true;
            this.lblOtp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblOtp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(113)))));
            this.lblOtp.Location = new System.Drawing.Point(40, 45);
            this.lblOtp.Name = "lblOtp";
            this.lblOtp.Size = new System.Drawing.Size(126, 17);
            this.lblOtp.TabIndex = 1;
            this.lblOtp.Text = "Mã OTP (6 chữ số)";
            // 
            // txtOtp
            // 
            this.txtOtp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOtp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtOtp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.txtOtp.Location = new System.Drawing.Point(40, 75);
            this.txtOtp.MaxLength = 6;
            this.txtOtp.Name = "txtOtp";
            this.txtOtp.Size = new System.Drawing.Size(370, 25);
            this.txtOtp.TabIndex = 2;
            this.txtOtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lineOtp
            // 
            this.lineOtp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.lineOtp.Location = new System.Drawing.Point(40, 105);
            this.lineOtp.Name = "lineOtp";
            this.lineOtp.Size = new System.Drawing.Size(370, 2);
            this.lineOtp.TabIndex = 3;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimer.ForeColor = System.Drawing.Color.Gray;
            this.lblTimer.Location = new System.Drawing.Point(40, 115);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(200, 20);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "Mã OTP hết hạn sau: 05:00";
            // 
            // lnkResend
            // 
            this.lnkResend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkResend.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkResend.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.lnkResend.Location = new System.Drawing.Point(260, 115);
            this.lnkResend.Name = "lnkResend";
            this.lnkResend.Size = new System.Drawing.Size(150, 20);
            this.lnkResend.TabIndex = 5;
            this.lnkResend.TabStop = true;
            this.lnkResend.Text = "Gửi lại mã";
            this.lnkResend.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lnkResend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkResend_LinkClicked);
            // 
            // btnVerifyOtp
            // 
            this.btnVerifyOtp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnVerifyOtp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyOtp.FlatAppearance.BorderSize = 0;
            this.btnVerifyOtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyOtp.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnVerifyOtp.ForeColor = System.Drawing.Color.White;
            this.btnVerifyOtp.Location = new System.Drawing.Point(40, 160);
            this.btnVerifyOtp.Name = "btnVerifyOtp";
            this.btnVerifyOtp.Size = new System.Drawing.Size(370, 45);
            this.btnVerifyOtp.TabIndex = 13;
            this.btnVerifyOtp.Text = "Xác nhận OTP";
            this.btnVerifyOtp.UseVisualStyleBackColor = false;
            this.btnVerifyOtp.Click += new System.EventHandler(this.btnVerifyOtp_Click);

            // ==========================================
            // pnlStep3: ĐỔI MẬT KHẨU
            // ==========================================
            this.pnlStep3.Controls.Add(this.btnChangePass);
            this.pnlStep3.Controls.Add(this.lineConfirmPass);
            this.pnlStep3.Controls.Add(this.txtConfirmPass);
            this.pnlStep3.Controls.Add(this.lblConfirmPass);
            this.pnlStep3.Controls.Add(this.lineNewPass);
            this.pnlStep3.Controls.Add(this.txtNewPass);
            this.pnlStep3.Controls.Add(this.lblNewPass);
            this.pnlStep3.Location = new System.Drawing.Point(0, 130);
            this.pnlStep3.Name = "pnlStep3";
            this.pnlStep3.Size = new System.Drawing.Size(450, 360);
            this.pnlStep3.TabIndex = 4;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(113)))));
            this.lblNewPass.Location = new System.Drawing.Point(40, 20);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(95, 17);
            this.lblNewPass.TabIndex = 1;
            this.lblNewPass.Text = "Mật khẩu mới";
            // 
            // txtNewPass
            // 
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNewPass.Location = new System.Drawing.Point(40, 50);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.Size = new System.Drawing.Size(370, 20);
            this.txtNewPass.TabIndex = 2;
            // 
            // lineNewPass
            // 
            this.lineNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.lineNewPass.Location = new System.Drawing.Point(40, 75);
            this.lineNewPass.Name = "lineNewPass";
            this.lineNewPass.Size = new System.Drawing.Size(370, 2);
            this.lineNewPass.TabIndex = 3;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(113)))));
            this.lblConfirmPass.Location = new System.Drawing.Point(40, 100);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(126, 17);
            this.lblConfirmPass.TabIndex = 4;
            this.lblConfirmPass.Text = "Xác nhận mật khẩu";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtConfirmPass.Location = new System.Drawing.Point(40, 130);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '●';
            this.txtConfirmPass.Size = new System.Drawing.Size(370, 20);
            this.txtConfirmPass.TabIndex = 5;
            // 
            // lineConfirmPass
            // 
            this.lineConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.lineConfirmPass.Location = new System.Drawing.Point(40, 155);
            this.lineConfirmPass.Name = "lineConfirmPass";
            this.lineConfirmPass.Size = new System.Drawing.Size(370, 2);
            this.lineConfirmPass.TabIndex = 6;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(40, 195);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(370, 45);
            this.btnChangePass.TabIndex = 13;
            this.btnChangePass.Text = "Cập nhật mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);

            // ==========================================
            // FORGOT PASS FORM 
            // ==========================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.cardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ForgotPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khôi phục Mật khẩu";
            this.Load += new System.EventHandler(this.ForgotPassForm_Load);
            this.cardPanel.ResumeLayout(false);
            this.pnlStep1.ResumeLayout(false);
            this.pnlStep1.PerformLayout();
            this.pnlStep2.ResumeLayout(false);
            this.pnlStep2.PerformLayout();
            this.pnlStep3.ResumeLayout(false);
            this.pnlStep3.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel cardPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.LinkLabel returnPB;
        
        // Step 1
        private System.Windows.Forms.Panel pnlStep1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel lineUsername;
        private System.Windows.Forms.Button btnSendOtp;
        
        // Step 2
        private System.Windows.Forms.Panel pnlStep2;
        private System.Windows.Forms.Label lblEmailHint;
        private System.Windows.Forms.Label lblOtp;
        private System.Windows.Forms.TextBox txtOtp;
        private System.Windows.Forms.Panel lineOtp;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.LinkLabel lnkResend;
        private System.Windows.Forms.Button btnVerifyOtp;
        
        // Step 3
        private System.Windows.Forms.Panel pnlStep3;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Panel lineNewPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Panel lineConfirmPass;
        private System.Windows.Forms.Button btnChangePass;
    }
}