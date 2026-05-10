namespace window_app
{
    partial class UserControl1
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
            comboBox2 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(565, 0);
            panel1.Margin = new Padding(3, 3, 15, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 532);
            panel1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Admin", "Teacher", "Student" });
            comboBox2.Location = new Point(14, 48);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(177, 28);
            comboBox2.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(14, 25);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 14;
            label3.Text = "SORT BY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(14, 116);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 13;
            label2.Text = "CONFIRM ROLE";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Teacher", "Student" });
            comboBox1.Location = new Point(14, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 28);
            comboBox1.TabIndex = 12;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(21, 398);
            button3.Name = "button3";
            button3.Size = new Size(177, 58);
            button3.TabIndex = 11;
            button3.Text = "SELLECT ALL";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(21, 303);
            button2.Name = "button2";
            button2.Size = new Size(177, 58);
            button2.TabIndex = 10;
            button2.Text = "REJECT";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(21, 208);
            button1.Name = "button1";
            button1.Size = new Size(177, 53);
            button1.TabIndex = 9;
            button1.Text = "APPROVE";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15);
            panel2.Size = new Size(557, 532);
            panel2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, -1);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 1;
            label1.Text = "APPROVAL LIST";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(15, 15);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 12, 0, 0);
            panel3.Size = new Size(525, 500);
            panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(525, 488);
            dataGridView1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(557, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 532);
            panel4.TabIndex = 11;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "UserControl1";
            Size = new Size(792, 532);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Label label1;
    }
}
