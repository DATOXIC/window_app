namespace window_app
{
    partial class User2
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
            panel2 = new Panel();
            admission_data_display = new DataGridView();
            panel3 = new Panel();
            sellect_all_button = new Button();
            button2 = new Button();
            accept_button = new Button();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)admission_data_display).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(557, 532);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(admission_data_display);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(15, 15);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 12, 0, 0);
            panel2.Size = new Size(527, 502);
            panel2.TabIndex = 0;
            // 
            // admission_data_display
            // 
            admission_data_display.BackgroundColor = SystemColors.ButtonHighlight;
            admission_data_display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            admission_data_display.Dock = DockStyle.Fill;
            admission_data_display.Location = new Point(0, 12);
            admission_data_display.Name = "admission_data_display";
            admission_data_display.RowHeadersWidth = 51;
            admission_data_display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            admission_data_display.Size = new Size(527, 490);
            admission_data_display.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(sellect_all_button);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(accept_button);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(565, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(227, 532);
            panel3.TabIndex = 1;
            // 
            // sellect_all_button
            // 
            sellect_all_button.BackColor = Color.SteelBlue;
            sellect_all_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sellect_all_button.ForeColor = Color.White;
            sellect_all_button.Location = new Point(25, 332);
            sellect_all_button.Name = "sellect_all_button";
            sellect_all_button.Size = new Size(177, 58);
            sellect_all_button.TabIndex = 14;
            sellect_all_button.Text = "SELLECT ALL";
            sellect_all_button.UseVisualStyleBackColor = false;
            sellect_all_button.Click += sellect_all_button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(25, 237);
            button2.Name = "button2";
            button2.Size = new Size(177, 58);
            button2.TabIndex = 13;
            button2.Text = "REJECT";
            button2.UseVisualStyleBackColor = false;
            // 
            // accept_button
            // 
            accept_button.BackColor = Color.LimeGreen;
            accept_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accept_button.ForeColor = Color.White;
            accept_button.Location = new Point(25, 142);
            accept_button.Name = "accept_button";
            accept_button.Size = new Size(177, 53);
            accept_button.TabIndex = 12;
            accept_button.Text = "APPROVE";
            accept_button.UseVisualStyleBackColor = false;
            accept_button.Click += btnApprove_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(557, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 532);
            panel4.TabIndex = 2;
            // 
            // User2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "User2";
            Size = new Size(792, 532);
            Load += User2_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)admission_data_display).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView admission_data_display;
        private Panel panel3;
        private Panel panel4;
        private Button sellect_all_button;
        private Button button2;
        private Button accept_button;
    }
}
