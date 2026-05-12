namespace window_app
{
    partial class Admin_Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            user_mangament_button = new Button();
            button3 = new Button();
            add_student_button = new Button();
            approve_button = new Button();
            pictureBox1 = new PictureBox();
            header_label = new TextBox();
            admin_content_panel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 64, 113);
            panel1.Controls.Add(user_mangament_button);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(add_student_button);
            panel1.Controls.Add(approve_button);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 603);
            panel1.TabIndex = 0;
            // 
            // user_mangament_button
            // 
            user_mangament_button.BackColor = Color.Transparent;
            user_mangament_button.Dock = DockStyle.Top;
            user_mangament_button.FlatAppearance.BorderSize = 0;
            user_mangament_button.FlatStyle = FlatStyle.Flat;
            user_mangament_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_mangament_button.ForeColor = Color.White;
            user_mangament_button.Location = new Point(0, 182);
            user_mangament_button.Name = "user_mangament_button";
            user_mangament_button.Size = new Size(165, 42);
            user_mangament_button.TabIndex = 4;
            user_mangament_button.Text = "User Management";
            user_mangament_button.UseVisualStyleBackColor = false;
            user_mangament_button.Click += user_mangament_button_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 140);
            button3.Name = "button3";
            button3.Size = new Size(165, 42);
            button3.TabIndex = 3;
            button3.Text = "Add Student";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // add_student_button
            // 
            add_student_button.BackColor = Color.Transparent;
            add_student_button.Dock = DockStyle.Top;
            add_student_button.FlatAppearance.BorderSize = 0;
            add_student_button.FlatStyle = FlatStyle.Flat;
            add_student_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_student_button.ForeColor = SystemColors.ControlLightLight;
            add_student_button.Location = new Point(0, 98);
            add_student_button.Name = "add_student_button";
            add_student_button.Size = new Size(165, 42);
            add_student_button.TabIndex = 2;
            add_student_button.Text = "Admission Review";
            add_student_button.UseVisualStyleBackColor = false;
            add_student_button.Click += add_student_button_Click;
            // 
            // approve_button
            // 
            approve_button.BackColor = Color.Transparent;
            approve_button.Dock = DockStyle.Top;
            approve_button.FlatAppearance.BorderSize = 0;
            approve_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 49, 87);
            approve_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 49, 87);
            approve_button.FlatStyle = FlatStyle.Flat;
            approve_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            approve_button.ForeColor = SystemColors.ControlLightLight;
            approve_button.Location = new Point(0, 56);
            approve_button.Name = "approve_button";
            approve_button.Size = new Size(165, 42);
            approve_button.TabIndex = 1;
            approve_button.Text = "Access Control";
            approve_button.TextAlign = ContentAlignment.MiddleRight;
            approve_button.UseVisualStyleBackColor = false;
            approve_button.Click += approve_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 56);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // header_label
            // 
            header_label.BackColor = Color.FromArgb(41, 107, 191);
            header_label.BorderStyle = BorderStyle.None;
            header_label.Dock = DockStyle.Top;
            header_label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header_label.ForeColor = SystemColors.Window;
            header_label.Location = new Point(165, 0);
            header_label.Multiline = true;
            header_label.Name = "header_label";
            header_label.Size = new Size(817, 50);
            header_label.TabIndex = 2;
            // 
            // admin_content_panel
            // 
            admin_content_panel.BackColor = SystemColors.ControlLight;
            admin_content_panel.BorderStyle = BorderStyle.FixedSingle;
            admin_content_panel.Dock = DockStyle.Fill;
            admin_content_panel.Location = new Point(165, 50);
            admin_content_panel.Name = "admin_content_panel";
            admin_content_panel.Padding = new Padding(5);
            admin_content_panel.Size = new Size(817, 553);
            admin_content_panel.TabIndex = 3;
            // 
            // Admin_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(admin_content_panel);
            Controls.Add(header_label);
            Controls.Add(panel1);
            Name = "Admin_Main";
            Text = "Admin_Main";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button add_student_button;
        private Button approve_button;
        private TextBox header_label;
        private Panel admin_content_panel;
        private Button user_mangament_button;
    }
}