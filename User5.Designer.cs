namespace window_app
{
    partial class User5
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
            course_display = new DataGridView();
            panel4 = new Panel();
            panel3 = new Panel();
            remove_course_button = new Button();
            add_course_button = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)course_display).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
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
            panel2.Controls.Add(course_display);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(15, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(525, 500);
            panel2.TabIndex = 0;
            // 
            // course_display
            // 
            course_display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            course_display.Dock = DockStyle.Fill;
            course_display.Location = new Point(0, 0);
            course_display.Name = "course_display";
            course_display.RowHeadersWidth = 51;
            course_display.Size = new Size(525, 500);
            course_display.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(557, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 532);
            panel4.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(remove_course_button);
            panel3.Controls.Add(add_course_button);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(565, 0);
            panel3.Margin = new Padding(3, 3, 15, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(227, 532);
            panel3.TabIndex = 10;
            // 
            // remove_course_button
            // 
            remove_course_button.Location = new Point(61, 305);
            remove_course_button.Name = "remove_course_button";
            remove_course_button.Size = new Size(94, 29);
            remove_course_button.TabIndex = 1;
            remove_course_button.Text = "DELETE";
            remove_course_button.UseVisualStyleBackColor = true;
            remove_course_button.Click += remove_course_button_Click;
            // 
            // add_course_button
            // 
            add_course_button.Location = new Point(61, 155);
            add_course_button.Name = "add_course_button";
            add_course_button.Size = new Size(94, 29);
            add_course_button.TabIndex = 0;
            add_course_button.Text = "ADD";
            add_course_button.UseVisualStyleBackColor = true;
            add_course_button.Click += add_course_button_Click;
            // 
            // User5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "User5";
            Size = new Size(792, 532);
            Load += User5_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)course_display).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView course_display;
        private Panel panel4;
        private Panel panel3;
        private Button remove_course_button;
        private Button add_course_button;
    }
}
