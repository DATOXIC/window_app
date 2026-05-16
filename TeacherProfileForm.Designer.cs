namespace window_app
{
    partial class TeacherProfileForm
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
            panelLeft = new Panel();
            lblWelcome = new Label();
            lblBrandSub = new Label();
            lblBrand = new Label();
            panelRight = new Panel();
            panelButtons = new Panel();
            btnExit = new Button();
            btnComplete = new Button();
            cboGender = new ComboBox();
            lblGender = new Label();
            dtpDob = new DateTimePicker();
            lblDob = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            cboDept = new ComboBox();
            lblDept = new Label();
            txtLname = new TextBox();
            lblLname = new Label();
            txtFname = new TextBox();
            lblFname = new Label();
            txtTeacherId = new TextBox();
            lblTeacherId = new Label();
            panelHeader = new Panel();
            lblHeaderSub = new Label();
            lblHeaderTitle = new Label();
            lblHeaderIcon = new Label();
            panelForm = new Panel();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            panelButtons.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(22, 50, 92);
            panelLeft.Controls.Add(lblWelcome);
            panelLeft.Controls.Add(lblBrandSub);
            panelLeft.Controls.Add(lblBrand);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(223, 638);
            panelLeft.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 11F);
            lblWelcome.ForeColor = Color.FromArgb(180, 205, 240);
            lblWelcome.Location = new Point(20, 180);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(200, 160);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Chào mừng!\r\n\r\nVui lòng hoàn thành\r\nthông tin cá nhân để\r\nbắt đầu sử dụng hệ thống.";
            // 
            // lblBrandSub
            // 
            lblBrandSub.Font = new Font("Segoe UI", 9F);
            lblBrandSub.ForeColor = Color.FromArgb(130, 160, 200);
            lblBrandSub.Location = new Point(20, 82);
            lblBrandSub.Name = "lblBrandSub";
            lblBrandSub.Size = new Size(200, 24);
            lblBrandSub.TabIndex = 1;
            lblBrandSub.Text = "Hệ thống Quản lý Giáo dục";
            // 
            // lblBrand
            // 
            lblBrand.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(20, 40);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(200, 40);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "👨‍🏫 EduSystem";
            // 
            // panelRight
            // 
            panelRight.AutoScroll = true;
            panelRight.BackColor = Color.FromArgb(245, 247, 251);
            panelRight.Controls.Add(panelButtons);
            panelRight.Controls.Add(cboGender);
            panelRight.Controls.Add(lblGender);
            panelRight.Controls.Add(dtpDob);
            panelRight.Controls.Add(lblDob);
            panelRight.Controls.Add(txtPhone);
            panelRight.Controls.Add(lblPhone);
            panelRight.Controls.Add(txtEmail);
            panelRight.Controls.Add(lblEmail);
            panelRight.Controls.Add(cboDept);
            panelRight.Controls.Add(lblDept);
            panelRight.Controls.Add(txtLname);
            panelRight.Controls.Add(lblLname);
            panelRight.Controls.Add(txtFname);
            panelRight.Controls.Add(lblFname);
            panelRight.Controls.Add(txtTeacherId);
            panelRight.Controls.Add(lblTeacherId);
            panelRight.Controls.Add(panelHeader);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(223, 0);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(30, 20, 30, 20);
            panelRight.Size = new Size(507, 638);
            panelRight.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.Transparent;
            panelButtons.Controls.Add(btnExit);
            panelButtons.Controls.Add(btnComplete);
            panelButtons.Location = new Point(30, 571);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(420, 46);
            panelButtons.TabIndex = 17;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(108, 117, 125);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 93, 100);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(130, 140, 150);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(290, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(130, 46);
            btnExit.TabIndex = 1;
            btnExit.Text = "🚪  Thoát";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.FromArgb(40, 167, 69);
            btnComplete.Cursor = Cursors.Hand;
            btnComplete.FlatAppearance.BorderSize = 0;
            btnComplete.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 130, 55);
            btnComplete.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 185, 85);
            btnComplete.FlatStyle = FlatStyle.Flat;
            btnComplete.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnComplete.ForeColor = Color.White;
            btnComplete.Location = new Point(0, 0);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(280, 46);
            btnComplete.TabIndex = 0;
            btnComplete.Text = "✅  Hoàn thành";
            btnComplete.UseVisualStyleBackColor = false;
            // 
            // cboGender
            // 
            cboGender.BackColor = Color.White;
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FlatStyle = FlatStyle.Flat;
            cboGender.Font = new Font("Segoe UI", 10F);
            cboGender.ForeColor = Color.FromArgb(50, 50, 50);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGender.Location = new Point(255, 435);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(200, 31);
            cboGender.TabIndex = 14;
            // 
            // lblGender
            // 
            lblGender.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(32, 64, 113);
            lblGender.Location = new Point(255, 411);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(220, 20);
            lblGender.TabIndex = 13;
            lblGender.Text = "Giới tính";
            // 
            // dtpDob
            // 
            dtpDob.Font = new Font("Segoe UI", 10F);
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(30, 509);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(420, 30);
            dtpDob.TabIndex = 16;
            dtpDob.Value = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // lblDob
            // 
            lblDob.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblDob.ForeColor = Color.FromArgb(32, 64, 113);
            lblDob.Location = new Point(30, 485);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(220, 20);
            lblDob.TabIndex = 15;
            lblDob.Text = "Ngày sinh";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.ForeColor = Color.FromArgb(50, 50, 50);
            txtPhone.Location = new Point(30, 435);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 30);
            txtPhone.TabIndex = 12;
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(32, 64, 113);
            lblPhone.Location = new Point(30, 411);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(220, 20);
            lblPhone.TabIndex = 11;
            lblPhone.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.FromArgb(50, 50, 50);
            txtEmail.Location = new Point(30, 361);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(420, 30);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(32, 64, 113);
            lblEmail.Location = new Point(30, 337);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(220, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // cboDept
            // 
            cboDept.BackColor = Color.White;
            cboDept.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDept.FlatStyle = FlatStyle.Flat;
            cboDept.Font = new Font("Segoe UI", 10F);
            cboDept.ForeColor = Color.FromArgb(50, 50, 50);
            cboDept.FormattingEnabled = true;
            cboDept.Location = new Point(30, 287);
            cboDept.Name = "cboDept";
            cboDept.Size = new Size(420, 31);
            cboDept.TabIndex = 8;
            // 
            // lblDept
            // 
            lblDept.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblDept.ForeColor = Color.FromArgb(32, 64, 113);
            lblDept.Location = new Point(30, 263);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(220, 20);
            lblDept.TabIndex = 7;
            lblDept.Text = "Khoa / Bộ môn";
            // 
            // txtLname
            // 
            txtLname.BackColor = Color.White;
            txtLname.BorderStyle = BorderStyle.FixedSingle;
            txtLname.Font = new Font("Segoe UI", 10F);
            txtLname.ForeColor = Color.FromArgb(50, 50, 50);
            txtLname.Location = new Point(255, 213);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(200, 30);
            txtLname.TabIndex = 6;
            // 
            // lblLname
            // 
            lblLname.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblLname.ForeColor = Color.FromArgb(32, 64, 113);
            lblLname.Location = new Point(255, 189);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(220, 20);
            lblLname.TabIndex = 5;
            lblLname.Text = "Tên";
            // 
            // txtFname
            // 
            txtFname.BackColor = Color.White;
            txtFname.BorderStyle = BorderStyle.FixedSingle;
            txtFname.Font = new Font("Segoe UI", 10F);
            txtFname.ForeColor = Color.FromArgb(50, 50, 50);
            txtFname.Location = new Point(30, 213);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(200, 30);
            txtFname.TabIndex = 4;
            // 
            // lblFname
            // 
            lblFname.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblFname.ForeColor = Color.FromArgb(32, 64, 113);
            lblFname.Location = new Point(30, 189);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(220, 20);
            lblFname.TabIndex = 3;
            lblFname.Text = "Họ";
            // 
            // txtTeacherId
            // 
            txtTeacherId.BackColor = Color.FromArgb(230, 235, 245);
            txtTeacherId.BorderStyle = BorderStyle.FixedSingle;
            txtTeacherId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTeacherId.ForeColor = Color.FromArgb(41, 107, 191);
            txtTeacherId.Location = new Point(30, 139);
            txtTeacherId.Name = "txtTeacherId";
            txtTeacherId.ReadOnly = true;
            txtTeacherId.Size = new Size(420, 30);
            txtTeacherId.TabIndex = 2;
            // 
            // lblTeacherId
            // 
            lblTeacherId.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblTeacherId.ForeColor = Color.FromArgb(32, 64, 113);
            lblTeacherId.Location = new Point(30, 115);
            lblTeacherId.Name = "lblTeacherId";
            lblTeacherId.Size = new Size(220, 20);
            lblTeacherId.TabIndex = 1;
            lblTeacherId.Text = "Mã Giảng viên (tự sinh)";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Transparent;
            panelHeader.Controls.Add(lblHeaderSub);
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Controls.Add(lblHeaderIcon);
            panelHeader.Location = new Point(30, 20);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(430, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.Font = new Font("Segoe UI", 9F);
            lblHeaderSub.ForeColor = Color.FromArgb(120, 135, 160);
            lblHeaderSub.Location = new Point(58, 40);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(370, 20);
            lblHeaderSub.TabIndex = 2;
            lblHeaderSub.Text = "Vui lòng điền đầy đủ thông tin bên dưới để kích hoạt tài khoản.";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(32, 64, 113);
            lblHeaderTitle.Location = new Point(58, 5);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(370, 32);
            lblHeaderTitle.TabIndex = 1;
            lblHeaderTitle.Text = "Hoàn thiện Hồ sơ Giảng viên";
            // 
            // lblHeaderIcon
            // 
            lblHeaderIcon.Font = new Font("Segoe UI", 28F);
            lblHeaderIcon.Location = new Point(9, 4);
            lblHeaderIcon.Name = "lblHeaderIcon";
            lblHeaderIcon.Size = new Size(52, 55);
            lblHeaderIcon.TabIndex = 0;
            lblHeaderIcon.Text = "📋";
            lblHeaderIcon.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelForm
            // 
            panelForm.Location = new Point(0, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(200, 100);
            panelForm.TabIndex = 0;
            // 
            // TeacherProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(730, 638);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TeacherProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hoàn thiện Hồ sơ Giảng viên";
            panelLeft.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Label lblTeacherId;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnExit;
    }
}