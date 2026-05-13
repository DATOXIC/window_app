namespace window_app
{
    partial class User4
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
            panel2 = new Panel();
            cboMajor = new ComboBox();
            cboYear = new ComboBox();
            panel4 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            student_account_display = new DataGridView();
            btnDelete = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)student_account_display).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(cboMajor);
            panel2.Controls.Add(cboYear);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(550, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 502);
            panel2.TabIndex = 3;
            // 
            // cboMajor
            // 
            cboMajor.FormattingEnabled = true;
            cboMajor.Location = new Point(46, 311);
            cboMajor.Name = "cboMajor";
            cboMajor.Size = new Size(151, 28);
            cboMajor.TabIndex = 4;
            // 
            // cboYear
            // 
            cboYear.FormattingEnabled = true;
            cboYear.Location = new Point(46, 162);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(151, 28);
            cboYear.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(542, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 502);
            panel4.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(15, 15);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(527, 502);
            panel1.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Controls.Add(student_account_display);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(15, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(495, 470);
            panel3.TabIndex = 0;
            // 
            // student_account_display
            // 
            student_account_display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            student_account_display.Dock = DockStyle.Fill;
            student_account_display.Location = new Point(0, 0);
            student_account_display.Name = "student_account_display";
            student_account_display.RowHeadersWidth = 51;
            student_account_display.Size = new Size(495, 470);
            student_account_display.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(46, 388);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 49);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // User4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Name = "User4";
            Padding = new Padding(15);
            Size = new Size(792, 532);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)student_account_display).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private ComboBox cboMajor;
        private ComboBox cboYear;
        private Panel panel1;
        private Panel panel3;
        private DataGridView student_account_display;
        private Button btnDelete;
    }
}
