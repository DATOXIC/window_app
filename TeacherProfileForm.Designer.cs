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
            // ── Outer layout ──────────────────────────────────────────
            panelLeft   = new Panel();
            panelRight  = new Panel();
            panelForm   = new Panel();

            // ── Left decorative panel ─────────────────────────────────
            lblBrand    = new Label();
            lblBrandSub = new Label();
            lblWelcome  = new Label();

            // ── Right form controls ───────────────────────────────────
            panelHeader   = new Panel();
            lblHeaderIcon  = new Label();
            lblHeaderTitle = new Label();
            lblHeaderSub   = new Label();

            // Fields
            lblTeacherId  = new Label();
            txtTeacherId  = new TextBox();
            lblFname      = new Label();
            txtFname      = new TextBox();
            lblLname      = new Label();
            txtLname      = new TextBox();
            lblDept       = new Label();
            cboDept       = new ComboBox();
            lblEmail      = new Label();
            txtEmail      = new TextBox();
            lblPhone      = new Label();
            txtPhone      = new TextBox();
            lblDob        = new Label();
            dtpDob        = new DateTimePicker();
            lblGender     = new Label();
            cboGender     = new ComboBox();

            // Buttons
            panelButtons  = new Panel();
            btnComplete    = new Button();
            btnExit        = new Button();

            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            panelForm.SuspendLayout();
            panelHeader.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();

            // ── panelLeft (decorative) ────────────────────────────────
            panelLeft.BackColor  = Color.FromArgb(22, 50, 92);
            panelLeft.Dock       = DockStyle.Left;
            panelLeft.Width      = 240;
            panelLeft.Controls.Add(lblWelcome);
            panelLeft.Controls.Add(lblBrandSub);
            panelLeft.Controls.Add(lblBrand);

            lblBrand.Text      = "👨‍🏫 EduSystem";
            lblBrand.Font      = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.AutoSize  = false;
            lblBrand.Bounds    = new Rectangle(20, 40, 200, 40);

            lblBrandSub.Text      = "Hệ thống Quản lý Giáo dục";
            lblBrandSub.Font      = new Font("Segoe UI", 9F);
            lblBrandSub.ForeColor = Color.FromArgb(130, 160, 200);
            lblBrandSub.AutoSize  = false;
            lblBrandSub.Bounds    = new Rectangle(20, 82, 200, 24);

            lblWelcome.Text      = "Chào mừng!\n\nVui lòng hoàn thành\nthông tin cá nhân để\nbắt đầu sử dụng hệ thống.";
            lblWelcome.Font      = new Font("Segoe UI", 11F);
            lblWelcome.ForeColor = Color.FromArgb(180, 205, 240);
            lblWelcome.AutoSize  = false;
            lblWelcome.Bounds    = new Rectangle(20, 180, 200, 160);

            // ── panelRight (scrollable form area) ─────────────────────
            panelRight.BackColor  = Color.FromArgb(245, 247, 251);
            panelRight.Dock       = DockStyle.Fill;
            panelRight.Padding    = new Padding(30, 20, 30, 20);
            panelRight.AutoScroll = true;
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

            // ── panelHeader ───────────────────────────────────────────
            panelHeader.BackColor = Color.Transparent;
            panelHeader.Bounds    = new Rectangle(30, 20, 430, 80);
            panelHeader.Controls.Add(lblHeaderSub);
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Controls.Add(lblHeaderIcon);

            lblHeaderIcon.Text      = "📋";
            lblHeaderIcon.Font      = new Font("Segoe UI", 28F);
            lblHeaderIcon.AutoSize  = false;
            lblHeaderIcon.Bounds    = new Rectangle(0, 0, 50, 55);

            lblHeaderTitle.Text      = "Hoàn thiện Hồ sơ Giảng viên";
            lblHeaderTitle.Font      = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(32, 64, 113);
            lblHeaderTitle.AutoSize  = false;
            lblHeaderTitle.Bounds    = new Rectangle(58, 5, 370, 32);

            lblHeaderSub.Text      = "Vui lòng điền đầy đủ thông tin bên dưới để kích hoạt tài khoản.";
            lblHeaderSub.Font      = new Font("Segoe UI", 9F);
            lblHeaderSub.ForeColor = Color.FromArgb(120, 135, 160);
            lblHeaderSub.AutoSize  = false;
            lblHeaderSub.Bounds    = new Rectangle(58, 40, 370, 20);

            // ── Field helper: Y positions ─────────────────────────────
            // Row starts at y=120, each row = 58px
            int x1 = 30, x2 = 255, w = 200, lh = 20, ih = 34, gap = 4;

            // Row 0: TeacherID (full width, readonly)
            SetLabel(lblTeacherId, "Mã Giảng viên (tự sinh)", x1, 115);
            SetInput(txtTeacherId, x1, 115 + lh + gap, 420, ih);
            txtTeacherId.ReadOnly  = true;
            txtTeacherId.BackColor = Color.FromArgb(230, 235, 245);
            txtTeacherId.ForeColor = Color.FromArgb(41, 107, 191);
            txtTeacherId.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Row 1: Fname | Lname
            int r1y = 115 + lh + gap + ih + 16;
            SetLabel(lblFname, "Họ", x1, r1y);
            SetInput(txtFname, x1, r1y + lh + gap, w, ih);
            SetLabel(lblLname, "Tên", x2, r1y);
            SetInput(txtLname, x2, r1y + lh + gap, w, ih);

            // Row 2: Department (full width)
            int r2y = r1y + lh + gap + ih + 16;
            SetLabel(lblDept, "Khoa / Bộ môn", x1, r2y);
            SetCombo(cboDept, x1, r2y + lh + gap, 420, ih);

            // Row 3: Email (full width)
            int r3y = r2y + lh + gap + ih + 16;
            SetLabel(lblEmail, "Email", x1, r3y);
            SetInput(txtEmail, x1, r3y + lh + gap, 420, ih);

            // Row 4: Phone | Gender
            int r4y = r3y + lh + gap + ih + 16;
            SetLabel(lblPhone, "Số điện thoại", x1, r4y);
            SetInput(txtPhone, x1, r4y + lh + gap, w, ih);
            SetLabel(lblGender, "Giới tính", x2, r4y);
            SetCombo(cboGender, x2, r4y + lh + gap, w, ih);
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGender.SelectedIndex = 0;

            // Row 5: Date of Birth (full width)
            int r5y = r4y + lh + gap + ih + 16;
            SetLabel(lblDob, "Ngày sinh", x1, r5y);
            dtpDob.Bounds  = new Rectangle(x1, r5y + lh + gap, 420, ih);
            dtpDob.Font    = new Font("Segoe UI", 10F);
            dtpDob.Format  = DateTimePickerFormat.Short;
            dtpDob.Value   = new DateTime(1990, 1, 1);
            dtpDob.MaxDate = DateTime.Today.AddYears(-18);

            // ── Buttons ───────────────────────────────────────────────
            int r6y = r5y + lh + gap + ih + 28;
            panelButtons.BackColor = Color.Transparent;
            panelButtons.Bounds    = new Rectangle(x1, r6y, 420, 46);
            panelButtons.Controls.Add(btnExit);
            panelButtons.Controls.Add(btnComplete);

            btnComplete.Text      = "✅  Hoàn thành & Vào hệ thống";
            btnComplete.Font      = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnComplete.BackColor = Color.FromArgb(40, 167, 69);
            btnComplete.ForeColor = Color.White;
            btnComplete.FlatStyle = FlatStyle.Flat;
            btnComplete.FlatAppearance.BorderSize = 0;
            btnComplete.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 185, 85);
            btnComplete.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 130, 55);
            btnComplete.Cursor    = Cursors.Hand;
            btnComplete.Bounds    = new Rectangle(0, 0, 280, 46);
            btnComplete.Click    += btnComplete_Click;

            btnExit.Text      = "🚪  Thoát";
            btnExit.Font      = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnExit.BackColor = Color.FromArgb(108, 117, 125);
            btnExit.ForeColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(130, 140, 150);
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 93, 100);
            btnExit.Cursor    = Cursors.Hand;
            btnExit.Bounds    = new Rectangle(290, 0, 130, 46);
            btnExit.Click    += btnExit_Click;

            // ── Form ──────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode       = AutoScaleMode.Font;
            ClientSize          = new Size(730, 570);
            FormBorderStyle     = FormBorderStyle.FixedDialog;
            MaximizeBox         = false;
            MinimizeBox         = false;
            StartPosition       = FormStartPosition.CenterScreen;
            Text                = "Hoàn thiện Hồ sơ Giảng viên";
            BackColor           = Color.FromArgb(245, 247, 251);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);

            FormClosing += TeacherProfileForm_FormClosing;
            Load        += TeacherProfileForm_Load;

            panelLeft.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        // ── Layout helpers ────────────────────────────────────────────
        private void SetLabel(Label lbl, string text, int x, int y)
        {
            lbl.Text      = text;
            lbl.Font      = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(32, 64, 113);
            lbl.AutoSize  = false;
            lbl.Bounds    = new Rectangle(x, y, 220, 20);
        }

        private void SetInput(TextBox tb, int x, int y, int w, int h)
        {
            tb.Font        = new Font("Segoe UI", 10F);
            tb.ForeColor   = Color.FromArgb(50, 50, 50);
            tb.BackColor   = Color.White;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Bounds      = new Rectangle(x, y, w, h);
        }

        private void SetCombo(ComboBox cb, int x, int y, int w, int h)
        {
            cb.Font             = new Font("Segoe UI", 10F);
            cb.ForeColor        = Color.FromArgb(50, 50, 50);
            cb.BackColor        = Color.White;
            cb.FlatStyle        = FlatStyle.Flat;
            cb.DropDownStyle    = ComboBoxStyle.DropDownList;
            cb.FormattingEnabled = true;
            cb.Bounds           = new Rectangle(x, y, w, h);
        }

        #endregion

        // ── Controls ──────────────────────────────────────────────────
        private Panel       panelLeft, panelRight, panelForm, panelHeader, panelButtons;
        private Label       lblBrand, lblBrandSub, lblWelcome;
        private Label       lblHeaderIcon, lblHeaderTitle, lblHeaderSub;
        private Label       lblTeacherId, lblFname, lblLname, lblDept, lblEmail, lblPhone, lblDob, lblGender;
        private TextBox     txtTeacherId, txtFname, txtLname, txtEmail, txtPhone;
        private ComboBox    cboDept, cboGender;
        private DateTimePicker dtpDob;
        private Button      btnComplete, btnExit;
    }
}
