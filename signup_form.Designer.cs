namespace window_app
{
    partial class signup_form
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
            createAccount_button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // createAccount_button
            // 
            createAccount_button.BackColor = SystemColors.ActiveCaption;
            createAccount_button.Font = new Font("Segoe UI", 13F);
            createAccount_button.ForeColor = SystemColors.ButtonHighlight;
            createAccount_button.Location = new Point(287, 301);
            createAccount_button.Name = "createAccount_button";
            createAccount_button.Size = new Size(229, 35);
            createAccount_button.TabIndex = 0;
            createAccount_button.Text = "Create account";
            createAccount_button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(227, 145);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(227, 197);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(227, 249);
            label3.Name = "label3";
            label3.Size = new Size(113, 19);
            label3.TabIndex = 3;
            label3.Text = "Retype password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(348, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(348, 196);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(348, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(231, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(357, 32);
            label4.Name = "label4";
            label4.Size = new Size(93, 31);
            label4.TabIndex = 7;
            label4.Text = "Sign up";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(287, 348);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 8;
            label5.Text = "Already have an account?";
            // 
            // button2
            // 
            button2.AllowDrop = true;
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.System;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(435, 344);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Log In";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BacktoLogInBtn_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(348, 92);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(231, 23);
            textBox4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(227, 92);
            label6.Name = "label6";
            label6.Size = new Size(41, 19);
            label6.TabIndex = 10;
            label6.Text = "Email";
            // 
            // signup_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(createAccount_button);
            Controls.Add(button2);
            Name = "signup_form";
            Text = "signup_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createAccount_button;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Button button2;
        private TextBox textBox4;
        private Label label6;
    }
}