namespace window_app
{
    partial class Student_Main
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            pnlHeader       = new Panel();
            picLogo         = new PictureBox();
            lblSchoolName   = new Label();
            pnlHeaderRight  = new Panel();
            picBell         = new PictureBox();
            pnlDivider      = new Panel();
            picStudentPhoto = new PictureBox();
            pnlStudentInfo  = new Panel();
            lblStudentName  = new Label();
            lblStudentMSSV  = new Label();
            pnlBody         = new Panel();
            pnlSidebar      = new Panel();
            lblPersonalInfo = new Label();
            pnlMenuFlow     = new FlowLayoutPanel();
            btnCurriculum       = new Button();
            btnClassSchedule    = new Button();
            btnExamSchedule     = new Button();
            btnViewGrades       = new Button();
            btnTuitionPayment   = new Button();
            btnTuitionInvoices  = new Button();
            btnScholarships     = new Button();
            contentPanel    = new Panel();

            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBell).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStudentPhoto).BeginInit();
            SuspendLayout();

            // ── FORM ──────────────────────────────────────────
            BackColor     = Color.FromArgb(205, 225, 240);
            ClientSize    = new Size(1060, 640);
            MinimumSize   = new Size(860, 520);
            Name          = "Student_Main";
            Text          = "Cổng Sinh Viên - HCMUTE";
            StartPosition = FormStartPosition.CenterScreen;
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);

            // ── HEADER ────────────────────────────────────────
            pnlHeader.BackColor = Color.FromArgb(188, 212, 232);
            pnlHeader.Dock      = DockStyle.Top;
            pnlHeader.Height    = 74;
            pnlHeader.Controls.Add(pnlHeaderRight);
            pnlHeader.Controls.Add(lblSchoolName);
            pnlHeader.Controls.Add(picLogo);

            picLogo.Cursor   = Cursors.Hand;
            picLogo.Location = new Point(10, 7);
            picLogo.Size     = new Size(58, 58);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabStop  = false;
            picLogo.Click   += PicLogo_Click;

            lblSchoolName.AutoSize  = false;
            lblSchoolName.Location  = new Point(76, 8);
            lblSchoolName.Size      = new Size(400, 58);
            lblSchoolName.Font      = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblSchoolName.ForeColor = Color.FromArgb(25, 50, 85);
            lblSchoolName.Text      = "TRƯỜNG ĐẠI HỌC\r\nCÔNG NGHỆ KỸ THUẬT TP.HCM";
            lblSchoolName.TextAlign = ContentAlignment.MiddleLeft;

            // Header-right (bell + divider + photo + name/mssv)
            pnlHeaderRight.Anchor    = AnchorStyles.Top | AnchorStyles.Right;
            pnlHeaderRight.BackColor = Color.FromArgb(215, 232, 245);
            pnlHeaderRight.Size      = new Size(310, 54);
            pnlHeaderRight.Location  = new Point(1060 - 310 - 10, 10);
            pnlHeaderRight.Controls.Add(picBell);
            pnlHeaderRight.Controls.Add(pnlDivider);
            pnlHeaderRight.Controls.Add(picStudentPhoto);
            pnlHeaderRight.Controls.Add(pnlStudentInfo);

            picBell.Cursor   = Cursors.Hand;
            picBell.Location = new Point(10, 11);
            picBell.Size     = new Size(28, 28);
            picBell.SizeMode = PictureBoxSizeMode.Zoom;
            picBell.TabStop  = false;
            picBell.Click   += PicNotification_Click;

            pnlDivider.Location  = new Point(52, 7);
            pnlDivider.Size      = new Size(2, 40);
            pnlDivider.BackColor = Color.FromArgb(170, 192, 210);

            picStudentPhoto.Cursor   = Cursors.Hand;
            picStudentPhoto.Location = new Point(60, 4);
            picStudentPhoto.Size     = new Size(46, 46);
            picStudentPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picStudentPhoto.TabStop  = false;
            picStudentPhoto.Click   += PicStudentPhoto_Click;

            pnlStudentInfo.Location  = new Point(112, 5);
            pnlStudentInfo.Size      = new Size(190, 44);
            pnlStudentInfo.BackColor = Color.Transparent;
            pnlStudentInfo.Controls.Add(lblStudentMSSV);
            pnlStudentInfo.Controls.Add(lblStudentName);

            lblStudentName.Dock      = DockStyle.Top;
            lblStudentName.Height    = 22;
            lblStudentName.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudentName.ForeColor = Color.FromArgb(25, 48, 82);
            lblStudentName.Text      = "Sinh viên";

            lblStudentMSSV.Dock      = DockStyle.Top;
            lblStudentMSSV.Height    = 20;
            lblStudentMSSV.Font      = new Font("Segoe UI", 9F);
            lblStudentMSSV.ForeColor = Color.FromArgb(55, 85, 120);
            lblStudentMSSV.Text      = "MSSV";

            // ── BODY ──────────────────────────────────────────
            pnlBody.Dock      = DockStyle.Fill;
            pnlBody.BackColor = Color.FromArgb(205, 225, 240);
            pnlBody.Padding   = new Padding(8, 8, 8, 8);
            pnlBody.Controls.Add(contentPanel);
            pnlBody.Controls.Add(pnlSidebar);

            // ── SIDEBAR ───────────────────────────────────────
            pnlSidebar.Dock      = DockStyle.Left;
            pnlSidebar.Width     = 178;
            pnlSidebar.BackColor = Color.FromArgb(107, 148, 186);
            pnlSidebar.Padding   = new Padding(0, 6, 0, 6);
            pnlSidebar.Controls.Add(pnlMenuFlow);
            pnlSidebar.Controls.Add(lblPersonalInfo);

            lblPersonalInfo.Dock      = DockStyle.Top;
            lblPersonalInfo.Height    = 34;
            lblPersonalInfo.Padding   = new Padding(14, 6, 0, 0);
            lblPersonalInfo.Font      = new Font("Segoe UI", 10.5F, FontStyle.Bold | FontStyle.Italic);
            lblPersonalInfo.ForeColor = Color.FromArgb(245, 215, 45);
            lblPersonalInfo.Text      = "Personal Info";
            lblPersonalInfo.BackColor = Color.Transparent;

            // FlowLayoutPanel for scrollable menu
            pnlMenuFlow.Dock          = DockStyle.Fill;
            pnlMenuFlow.BackColor     = Color.FromArgb(107, 148, 186);
            pnlMenuFlow.AutoScroll    = true;
            pnlMenuFlow.FlowDirection = FlowDirection.TopDown;
            pnlMenuFlow.WrapContents  = false;
            pnlMenuFlow.Padding       = new Padding(0, 2, 0, 4);

            SetupSidebarButton(btnCurriculum,       "📋  Curriculum",      "btnCurriculum");
            SetupSidebarButton(btnClassSchedule,    "🗓  Class Schedule",   "btnClassSchedule");
            SetupSidebarButton(btnExamSchedule,     "📝  Exam Schedule",    "btnExamSchedule");
            SetupSidebarButton(btnViewGrades,       "A+  View Grades",      "btnViewGrades");
            SetupSidebarButton(btnTuitionPayment,   "💳  Tuition Payment",  "btnTuitionPayment");
            SetupSidebarButton(btnTuitionInvoices,  "📄  Tuition Invoices", "btnTuitionInvoices");
            SetupSidebarButton(btnScholarships,     "🎓  Scholarships &",   "btnScholarships");
            btnScholarships.Height = 52;

            pnlMenuFlow.Controls.AddRange(new Control[] {
                btnCurriculum, btnClassSchedule, btnExamSchedule,
                btnViewGrades, btnTuitionPayment, btnTuitionInvoices, btnScholarships
            });

            // ── CONTENT ───────────────────────────────────────
            contentPanel.Dock      = DockStyle.Fill;
            contentPanel.BackColor = Color.FromArgb(205, 225, 240);

            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBell).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStudentPhoto).EndInit();
            ResumeLayout(false);
        }
        /// <summary>
        /// Helper: khởi tạo style chung cho sidebar button.
        /// Tách ra ngoài InitializeComponent() để VS Designer không báo lỗi.
        /// </summary>
        private void SetupSidebarButton(Button btn, string text, string name)
        {
            btn.Name      = name;
            btn.Text      = text;
            btn.Size      = new Size(178, 40);
            btn.Margin    = new Padding(0, 1, 0, 1);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize          = 0;
            btn.FlatAppearance.MouseOverBackColor  = Color.FromArgb(80, 120, 158);
            btn.FlatAppearance.MouseDownBackColor  = Color.FromArgb(58, 98, 136);
            btn.BackColor = Color.FromArgb(107, 148, 186);
            btn.ForeColor = Color.White;
            btn.Font      = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding   = new Padding(14, 0, 0, 0);
            btn.Cursor    = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
            btn.Click    += SidebarButton_Click;
        }

        #endregion

        private Panel pnlHeader, pnlHeaderRight, pnlDivider, pnlStudentInfo, pnlBody, pnlSidebar, contentPanel;
        private PictureBox picLogo, picBell, picStudentPhoto;
        private Label lblSchoolName, lblStudentName, lblStudentMSSV, lblPersonalInfo;
        private FlowLayoutPanel pnlMenuFlow;
        private Button btnCurriculum, btnClassSchedule, btnExamSchedule,
                       btnViewGrades, btnTuitionPayment, btnTuitionInvoices, btnScholarships;
    }
}