namespace window_app
{
    partial class login_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login_button = new Button();
            cancel_button = new Button();
            user_tb = new TextBox();
            pass_tb = new TextBox();
            user_lb = new Label();
            pass_lb = new Label();
            signup_button = new Button();
            pictureBox1 = new PictureBox();
            forgetPassword_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // login_button
            // 
            login_button.Location = new Point(407, 279);
            login_button.Name = "login_button";
            login_button.Size = new Size(94, 36);
            login_button.TabIndex = 0;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(306, 279);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(94, 36);
            cancel_button.TabIndex = 1;
            cancel_button.Text = "Cancel";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // user_tb
            // 
            user_tb.Location = new Point(357, 161);
            user_tb.Name = "user_tb";
            user_tb.Size = new Size(166, 27);
            user_tb.TabIndex = 2;
            // 
            // pass_tb
            // 
            pass_tb.Location = new Point(357, 217);
            pass_tb.Name = "pass_tb";
            pass_tb.Size = new Size(166, 27);
            pass_tb.TabIndex = 3;
            // 
            // user_lb
            // 
            user_lb.AutoSize = true;
            user_lb.Location = new Point(285, 165);
            user_lb.Name = "user_lb";
            user_lb.Size = new Size(75, 20);
            user_lb.TabIndex = 4;
            user_lb.Text = "Username";
            // 
            // pass_lb
            // 
            pass_lb.AutoSize = true;
            pass_lb.Location = new Point(285, 221);
            pass_lb.Name = "pass_lb";
            pass_lb.Size = new Size(70, 20);
            pass_lb.TabIndex = 5;
            pass_lb.Text = "Password";
            // 
            // signup_button
            // 
            signup_button.Location = new Point(407, 320);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(94, 36);
            signup_button.TabIndex = 6;
            signup_button.Text = "Sign up";
            signup_button.UseVisualStyleBackColor = true;
            signup_button.Click += signup_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.account_icon;
            pictureBox1.Location = new Point(371, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // forgetPassword_button
            // 
            forgetPassword_button.Location = new Point(594, 268);
            forgetPassword_button.Name = "forgetPassword_button";
            forgetPassword_button.Size = new Size(149, 29);
            forgetPassword_button.TabIndex = 8;
            forgetPassword_button.Text = "forget password";
            forgetPassword_button.UseVisualStyleBackColor = true;
            forgetPassword_button.Click += forgetPassword_button_Click;
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(forgetPassword_button);
            Controls.Add(pictureBox1);
            Controls.Add(signup_button);
            Controls.Add(pass_lb);
            Controls.Add(user_lb);
            Controls.Add(pass_tb);
            Controls.Add(user_tb);
            Controls.Add(cancel_button);
            Controls.Add(login_button);
            Name = "login_form";
            Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_button;
        private Button cancel_button;
        private TextBox user_tb;
        private TextBox pass_tb;
        private Label user_lb;
        private Label pass_lb;
        private Button signup_button;
        private PictureBox pictureBox1;
        private Button forgetPassword_button;
    }
}
