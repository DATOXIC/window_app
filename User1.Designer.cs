namespace window_app
{
    partial class User1
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
            confirm_role_combobox = new ComboBox();
            sellect_all_button = new Button();
            button2 = new Button();
            accept_button = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            Display_Account_View = new DataGridView();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Display_Account_View).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(confirm_role_combobox);
            panel1.Controls.Add(sellect_all_button);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(accept_button);
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
            // confirm_role_combobox
            // 
            confirm_role_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            confirm_role_combobox.FormattingEnabled = true;
            confirm_role_combobox.Items.AddRange(new object[] { "Admin", "Teacher", "Student" });
            confirm_role_combobox.Location = new Point(14, 138);
            confirm_role_combobox.Name = "confirm_role_combobox";
            confirm_role_combobox.Size = new Size(177, 28);
            confirm_role_combobox.TabIndex = 12;
            // 
            // sellect_all_button
            // 
            sellect_all_button.BackColor = Color.SteelBlue;
            sellect_all_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sellect_all_button.ForeColor = Color.White;
            sellect_all_button.Location = new Point(21, 398);
            sellect_all_button.Name = "sellect_all_button";
            sellect_all_button.Size = new Size(177, 58);
            sellect_all_button.TabIndex = 11;
            sellect_all_button.Text = "SELLECT ALL";
            sellect_all_button.UseVisualStyleBackColor = false;
            sellect_all_button.Click += sellect_all_button_Click;
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
            // accept_button
            // 
            accept_button.BackColor = Color.LimeGreen;
            accept_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accept_button.ForeColor = Color.White;
            accept_button.Location = new Point(21, 208);
            accept_button.Name = "accept_button";
            accept_button.Size = new Size(177, 53);
            accept_button.TabIndex = 9;
            accept_button.Text = "APPROVE";
            accept_button.UseVisualStyleBackColor = false;
            accept_button.Click += accept_button_Click;
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
            panel3.Controls.Add(Display_Account_View);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(15, 15);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 12, 0, 0);
            panel3.Size = new Size(525, 500);
            panel3.TabIndex = 0;
            // 
            // Display_Account_View
            // 
            Display_Account_View.BackgroundColor = SystemColors.ButtonHighlight;
            Display_Account_View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Display_Account_View.Dock = DockStyle.Fill;
            Display_Account_View.Location = new Point(0, 12);
            Display_Account_View.Name = "Display_Account_View";
            Display_Account_View.RowHeadersWidth = 51;
            Display_Account_View.Size = new Size(525, 488);
            Display_Account_View.TabIndex = 4;
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
            Load += UserControl1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Display_Account_View).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label2;
        private ComboBox confirm_role_combobox;
        private Button sellect_all_button;
        private Button button2;
        private Button accept_button;
        private Panel panel2;
        private Panel panel3;
        private DataGridView Display_Account_View;
        private Panel panel4;
        private Label label1;
    }
}
