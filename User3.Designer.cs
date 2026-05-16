namespace window_app
{
    partial class User3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            formCard = new Panel();
            // Row 1: Name + Email
            row1 = new Panel();
            fieldName = new Panel();
            txtName = new TextBox();
            nameUnderline = new Panel();
            label1 = new Label();
            fieldEmail = new Panel();
            txtEmail = new TextBox();
            emailUnderline = new Panel();
            label2 = new Label();
            // Row 2: Major + Sex
            row2 = new Panel();
            fieldMajor = new Panel();
            cboMajor = new ComboBox();
            label7 = new Label();
            fieldSex = new Panel();
            sexPanel = new Panel();
            radioButton2 = new RadioButton();
            rbMale = new RadioButton();
            label6 = new Label();
            // Row 3: Phone + Address
            row3 = new Panel();
            fieldPhone = new Panel();
            txtPhone = new TextBox();
            phoneUnderline = new Panel();
            label3 = new Label();
            fieldAddress = new Panel();
            txtAddress = new TextBox();
            addressUnderline = new Panel();
            label4 = new Label();
            // Row 4: DOB + Year
            row4 = new Panel();
            fieldDob = new Panel();
            dtpDob = new DateTimePicker();
            label5 = new Label();
            fieldYear = new Panel();
            numYear = new NumericUpDown();
            label8 = new Label();
            // Buttons
            buttonRow = new Panel();
            btnCancelStudent = new Button();
            btnAddStudent = new Button();
            // Header
            headerPanel = new Panel();
            headerTitle = new Label();
            headerIcon = new Label();
            headerSubtitle = new Label();

            mainPanel.SuspendLayout();
            formCard.SuspendLayout();
            row1.SuspendLayout();
            fieldName.SuspendLayout();
            fieldEmail.SuspendLayout();
            row2.SuspendLayout();
            fieldMajor.SuspendLayout();
            fieldSex.SuspendLayout();
            sexPanel.SuspendLayout();
            row3.SuspendLayout();
            fieldPhone.SuspendLayout();
            fieldAddress.SuspendLayout();
            row4.SuspendLayout();
            fieldDob.SuspendLayout();
            fieldYear.SuspendLayout();
            buttonRow.SuspendLayout();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            SuspendLayout();

            // ========== mainPanel ==========
            mainPanel.BackColor = Color.FromArgb(245, 247, 251);
            mainPanel.Controls.Add(formCard);
            mainPanel.Controls.Add(headerPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(30, 15, 30, 20);

            // ========== headerPanel ==========
            headerPanel.BackColor = Color.Transparent;
            headerPanel.Controls.Add(headerSubtitle);
            headerPanel.Controls.Add(headerTitle);
            headerPanel.Controls.Add(headerIcon);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(732, 70);

            headerIcon.AutoSize = true;
            headerIcon.Dock = DockStyle.Left;
            headerIcon.Font = new Font("Segoe UI", 18F);
            headerIcon.ForeColor = Color.FromArgb(41, 107, 191);
            headerIcon.Name = "headerIcon";
            headerIcon.Text = "🎓";

            headerTitle.AutoSize = true;
            headerTitle.Dock = DockStyle.Left;
            headerTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            headerTitle.ForeColor = Color.FromArgb(32, 64, 113);
            headerTitle.Name = "headerTitle";
            headerTitle.Padding = new Padding(8, 4, 0, 0);
            headerTitle.Text = "Thêm Sinh viên";

            headerSubtitle.AutoSize = true;
            headerSubtitle.Dock = DockStyle.Bottom;
            headerSubtitle.Font = new Font("Segoe UI", 9F);
            headerSubtitle.ForeColor = Color.FromArgb(130, 140, 160);
            headerSubtitle.Name = "headerSubtitle";
            headerSubtitle.Padding = new Padding(0, 0, 0, 8);
            headerSubtitle.Text = "Điền thông tin thí sinh để thêm vào danh sách chờ phê duyệt (Admission List).";

            // ========== formCard ==========
            formCard.BackColor = Color.White;
            formCard.Controls.Add(buttonRow);
            formCard.Controls.Add(row4);
            formCard.Controls.Add(row3);
            formCard.Controls.Add(row2);
            formCard.Controls.Add(row1);
            formCard.Dock = DockStyle.Fill;
            formCard.Name = "formCard";
            formCard.Padding = new Padding(30, 20, 30, 15);

            // ========== ROW 1: Name + Email ==========
            row1.Controls.Add(fieldEmail);
            row1.Controls.Add(fieldName);
            row1.Dock = DockStyle.Top;
            row1.Name = "row1";
            row1.Size = new Size(672, 80);

            fieldName.Controls.Add(nameUnderline);
            fieldName.Controls.Add(txtName);
            fieldName.Controls.Add(label1);
            fieldName.Dock = DockStyle.Left;
            fieldName.Name = "fieldName";
            fieldName.Padding = new Padding(0, 0, 20, 0);
            fieldName.Size = new Size(336, 80);

            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(32, 64, 113);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 6);
            label1.Text = "Họ và tên *";

            txtName.BackColor = Color.FromArgb(248, 250, 253);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Dock = DockStyle.Top;
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.ForeColor = Color.FromArgb(50, 50, 50);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nhập họ và tên...";
            txtName.Size = new Size(316, 25);

            nameUnderline.BackColor = Color.FromArgb(41, 107, 191);
            nameUnderline.Dock = DockStyle.Top;
            nameUnderline.Name = "nameUnderline";
            nameUnderline.Size = new Size(316, 2);

            fieldEmail.Controls.Add(emailUnderline);
            fieldEmail.Controls.Add(txtEmail);
            fieldEmail.Controls.Add(label2);
            fieldEmail.Dock = DockStyle.Fill;
            fieldEmail.Name = "fieldEmail";

            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(32, 64, 113);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 6);
            label2.Text = "Email *";

            txtEmail.BackColor = Color.FromArgb(248, 250, 253);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Dock = DockStyle.Top;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.ForeColor = Color.FromArgb(50, 50, 50);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "example@email.com";
            txtEmail.Size = new Size(336, 25);

            emailUnderline.BackColor = Color.FromArgb(41, 107, 191);
            emailUnderline.Dock = DockStyle.Top;
            emailUnderline.Name = "emailUnderline";
            emailUnderline.Size = new Size(336, 2);

            // ========== ROW 2: Major + Sex ==========
            row2.Controls.Add(fieldSex);
            row2.Controls.Add(fieldMajor);
            row2.Dock = DockStyle.Top;
            row2.Name = "row2";
            row2.Padding = new Padding(0, 10, 0, 0);
            row2.Size = new Size(672, 80);

            fieldMajor.Controls.Add(cboMajor);
            fieldMajor.Controls.Add(label7);
            fieldMajor.Dock = DockStyle.Left;
            fieldMajor.Name = "fieldMajor";
            fieldMajor.Padding = new Padding(0, 0, 20, 0);
            fieldMajor.Size = new Size(336, 70);

            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(32, 64, 113);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 0, 0, 6);
            label7.Text = "Ngành học";

            cboMajor.BackColor = Color.FromArgb(248, 250, 253);
            cboMajor.Dock = DockStyle.Top;
            cboMajor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMajor.FlatStyle = FlatStyle.Flat;
            cboMajor.Font = new Font("Segoe UI", 10F);
            cboMajor.ForeColor = Color.FromArgb(50, 50, 50);
            cboMajor.FormattingEnabled = true;
            cboMajor.Name = "cboMajor";
            cboMajor.Size = new Size(316, 31);

            fieldSex.Controls.Add(sexPanel);
            fieldSex.Controls.Add(label6);
            fieldSex.Dock = DockStyle.Fill;
            fieldSex.Name = "fieldSex";

            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(32, 64, 113);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 0, 6);
            label6.Text = "Giới tính";

            sexPanel.Controls.Add(radioButton2);
            sexPanel.Controls.Add(rbMale);
            sexPanel.Dock = DockStyle.Top;
            sexPanel.Name = "sexPanel";
            sexPanel.Size = new Size(336, 32);

            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Font = new Font("Segoe UI", 10F);
            rbMale.ForeColor = Color.FromArgb(50, 50, 50);
            rbMale.Location = new Point(0, 3);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 27);
            rbMale.TabStop = true;
            rbMale.Text = "Nam";

            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10F);
            radioButton2.ForeColor = Color.FromArgb(50, 50, 50);
            radioButton2.Location = new Point(90, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(53, 27);
            radioButton2.Text = "Nữ";

            // ========== ROW 3: Phone + Address ==========
            row3.Controls.Add(fieldAddress);
            row3.Controls.Add(fieldPhone);
            row3.Dock = DockStyle.Top;
            row3.Name = "row3";
            row3.Padding = new Padding(0, 10, 0, 0);
            row3.Size = new Size(672, 80);

            fieldPhone.Controls.Add(phoneUnderline);
            fieldPhone.Controls.Add(txtPhone);
            fieldPhone.Controls.Add(label3);
            fieldPhone.Dock = DockStyle.Left;
            fieldPhone.Name = "fieldPhone";
            fieldPhone.Padding = new Padding(0, 0, 20, 0);
            fieldPhone.Size = new Size(336, 70);

            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(32, 64, 113);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 6);
            label3.Text = "Số điện thoại *";

            txtPhone.BackColor = Color.FromArgb(248, 250, 253);
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Dock = DockStyle.Top;
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.ForeColor = Color.FromArgb(50, 50, 50);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "0912 345 678";
            txtPhone.Size = new Size(316, 25);

            phoneUnderline.BackColor = Color.FromArgb(41, 107, 191);
            phoneUnderline.Dock = DockStyle.Top;
            phoneUnderline.Name = "phoneUnderline";
            phoneUnderline.Size = new Size(316, 2);

            fieldAddress.Controls.Add(addressUnderline);
            fieldAddress.Controls.Add(txtAddress);
            fieldAddress.Controls.Add(label4);
            fieldAddress.Dock = DockStyle.Fill;
            fieldAddress.Name = "fieldAddress";

            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(32, 64, 113);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 0, 6);
            label4.Text = "Địa chỉ";

            txtAddress.BackColor = Color.FromArgb(248, 250, 253);
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Dock = DockStyle.Top;
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.ForeColor = Color.FromArgb(50, 50, 50);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Nhập địa chỉ...";
            txtAddress.Size = new Size(336, 25);

            addressUnderline.BackColor = Color.FromArgb(41, 107, 191);
            addressUnderline.Dock = DockStyle.Top;
            addressUnderline.Name = "addressUnderline";
            addressUnderline.Size = new Size(336, 2);

            // ========== ROW 4: DOB + Year ==========
            row4.Controls.Add(fieldYear);
            row4.Controls.Add(fieldDob);
            row4.Dock = DockStyle.Top;
            row4.Name = "row4";
            row4.Padding = new Padding(0, 10, 0, 0);
            row4.Size = new Size(672, 75);

            fieldDob.Controls.Add(dtpDob);
            fieldDob.Controls.Add(label5);
            fieldDob.Dock = DockStyle.Left;
            fieldDob.Name = "fieldDob";
            fieldDob.Padding = new Padding(0, 0, 20, 0);
            fieldDob.Size = new Size(336, 65);

            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(32, 64, 113);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 0, 6);
            label5.Text = "Ngày sinh";

            dtpDob.Dock = DockStyle.Top;
            dtpDob.Font = new Font("Segoe UI", 10F);
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(316, 30);

            fieldYear.Controls.Add(numYear);
            fieldYear.Controls.Add(label8);
            fieldYear.Dock = DockStyle.Fill;
            fieldYear.Name = "fieldYear";

            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(32, 64, 113);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 0, 0, 6);
            label8.Text = "Năm nhập học";

            numYear.BackColor = Color.FromArgb(248, 250, 253);
            numYear.Dock = DockStyle.Top;
            numYear.Font = new Font("Segoe UI", 10F);
            numYear.Name = "numYear";
            numYear.Size = new Size(336, 30);

            // ========== BUTTONS ==========
            buttonRow.Controls.Add(btnCancelStudent);
            buttonRow.Controls.Add(btnAddStudent);
            buttonRow.Dock = DockStyle.Top;
            buttonRow.Name = "buttonRow";
            buttonRow.Padding = new Padding(0, 20, 0, 0);
            buttonRow.Size = new Size(672, 68);

            btnAddStudent.BackColor = Color.FromArgb(41, 107, 191);
            btnAddStudent.Cursor = Cursors.Hand;
            btnAddStudent.Dock = DockStyle.Left;
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 80, 150);
            btnAddStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 210);
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(220, 45);
            btnAddStudent.Text = "✅  Thêm sinh viên";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;

            btnCancelStudent.BackColor = Color.White;
            btnCancelStudent.Cursor = Cursors.Hand;
            btnCancelStudent.Dock = DockStyle.Right;
            btnCancelStudent.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnCancelStudent.FlatAppearance.BorderSize = 1;
            btnCancelStudent.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 232, 236);
            btnCancelStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 242, 246);
            btnCancelStudent.FlatStyle = FlatStyle.Flat;
            btnCancelStudent.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnCancelStudent.ForeColor = Color.FromArgb(80, 90, 110);
            btnCancelStudent.Name = "btnCancelStudent";
            btnCancelStudent.Size = new Size(220, 45);
            btnCancelStudent.Text = "🔄  Xóa trắng";
            btnCancelStudent.UseVisualStyleBackColor = false;
            btnCancelStudent.Click += btnCancelStudent_Click;

            // ========== User3 ==========
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            Controls.Add(mainPanel);
            Name = "User3";
            Size = new Size(792, 532);
            Load += UC_AddStudent_Load;

            mainPanel.ResumeLayout(false);
            formCard.ResumeLayout(false);
            row1.ResumeLayout(false);
            fieldName.ResumeLayout(false);
            fieldName.PerformLayout();
            fieldEmail.ResumeLayout(false);
            fieldEmail.PerformLayout();
            row2.ResumeLayout(false);
            fieldMajor.ResumeLayout(false);
            fieldMajor.PerformLayout();
            fieldSex.ResumeLayout(false);
            fieldSex.PerformLayout();
            sexPanel.ResumeLayout(false);
            sexPanel.PerformLayout();
            row3.ResumeLayout(false);
            fieldPhone.ResumeLayout(false);
            fieldPhone.PerformLayout();
            fieldAddress.ResumeLayout(false);
            fieldAddress.PerformLayout();
            row4.ResumeLayout(false);
            fieldDob.ResumeLayout(false);
            fieldDob.PerformLayout();
            fieldYear.ResumeLayout(false);
            fieldYear.PerformLayout();
            buttonRow.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel headerPanel;
        private Label headerIcon;
        private Label headerTitle;
        private Label headerSubtitle;
        private Panel formCard;
        private Panel row1;
        private Panel fieldName;
        private TextBox txtName;
        private Panel nameUnderline;
        private Label label1;
        private Panel fieldEmail;
        private TextBox txtEmail;
        private Panel emailUnderline;
        private Label label2;
        private Panel row2;
        private Panel fieldMajor;
        private ComboBox cboMajor;
        private Label label7;
        private Panel fieldSex;
        private Panel sexPanel;
        private RadioButton radioButton2;
        private RadioButton rbMale;
        private Label label6;
        private Panel row3;
        private Panel fieldPhone;
        private TextBox txtPhone;
        private Panel phoneUnderline;
        private Label label3;
        private Panel fieldAddress;
        private TextBox txtAddress;
        private Panel addressUnderline;
        private Label label4;
        private Panel row4;
        private Panel fieldDob;
        private DateTimePicker dtpDob;
        private Label label5;
        private Panel fieldYear;
        private NumericUpDown numYear;
        private Label label8;
        private Panel buttonRow;
        private Button btnCancelStudent;
        private Button btnAddStudent;
    }
}
