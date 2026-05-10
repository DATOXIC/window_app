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
            button3 = new Button();
            button2 = new Button();
            approve_button = new Button();
            pictureBox1 = new PictureBox();
            header_label = new TextBox();
            admin_content_panel = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            admin_content_panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 64, 113);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(approve_button);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 603);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 140);
            button3.Name = "button3";
            button3.Size = new Size(165, 42);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(0, 98);
            button2.Name = "button2";
            button2.Size = new Size(165, 42);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
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
            approve_button.Text = "Approve Account";
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
            admin_content_panel.Controls.Add(label1);
            admin_content_panel.Controls.Add(label2);
            admin_content_panel.Dock = DockStyle.Fill;
            admin_content_panel.Location = new Point(165, 50);
            admin_content_panel.Name = "admin_content_panel";
            admin_content_panel.Padding = new Padding(5);
            admin_content_panel.Size = new Size(817, 553);
            admin_content_panel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 5);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(613, 1);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
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
            admin_content_panel.ResumeLayout(false);
            admin_content_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button approve_button;
        private TextBox header_label;
        private Panel admin_content_panel;
        private Label label2;
        private Label label1;
    }
}