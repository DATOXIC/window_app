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
            panel1 = new Panel();
            btnCancelStudent = new Button();
            btnAddStudent = new Button();
            label8 = new Label();
            numYear = new NumericUpDown();
            cboMajor = new ComboBox();
            label7 = new Label();
            radioButton2 = new RadioButton();
            rbMale = new RadioButton();
            dtpDob = new DateTimePicker();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCancelStudent);
            panel1.Controls.Add(btnAddStudent);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(numYear);
            panel1.Controls.Add(cboMajor);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(rbMale);
            panel1.Controls.Add(dtpDob);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 512);
            panel1.TabIndex = 0;
            // 
            // btnCancelStudent
            // 
            btnCancelStudent.Location = new Point(614, 268);
            btnCancelStudent.Name = "btnCancelStudent";
            btnCancelStudent.Size = new Size(94, 29);
            btnCancelStudent.TabIndex = 18;
            btnCancelStudent.Text = "CANCEL";
            btnCancelStudent.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(614, 165);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(94, 29);
            btnAddStudent.TabIndex = 17;
            btnAddStudent.Text = "ADD";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(58, 452);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 16;
            label8.Text = "Enroll Year:";
            // 
            // numYear
            // 
            numYear.Location = new Point(207, 445);
            numYear.Name = "numYear";
            numYear.Size = new Size(258, 27);
            numYear.TabIndex = 15;
            // 
            // cboMajor
            // 
            cboMajor.FormattingEnabled = true;
            cboMajor.Location = new Point(207, 169);
            cboMajor.Name = "cboMajor";
            cboMajor.Size = new Size(258, 28);
            cboMajor.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(58, 169);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 13;
            label7.Text = "Major:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(276, 224);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(207, 224);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 11;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(207, 397);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(258, 27);
            dtpDob.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(207, 331);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(258, 27);
            txtAddress.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(207, 268);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(258, 27);
            txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(207, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(258, 27);
            txtEmail.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(58, 218);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 6;
            label6.Text = "Sex:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 397);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 5;
            label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 331);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 268);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 117);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // txtName
            // 
            txtName.Location = new Point(207, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(258, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 56);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // User3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "User3";
            Padding = new Padding(10);
            Size = new Size(792, 532);
            Load += UC_AddStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Label label7;
        private RadioButton radioButton2;
        private RadioButton rbMale;
        private DateTimePicker dtpDob;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private NumericUpDown numYear;
        private ComboBox cboMajor;
        private Button btnCancelStudent;
        private Button btnAddStudent;
    }
}
