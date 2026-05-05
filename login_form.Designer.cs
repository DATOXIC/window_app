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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // login_button
            // 
            login_button.Location = new Point(354, 217);
            login_button.Margin = new Padding(3, 2, 3, 2);
            login_button.Name = "login_button";
            login_button.Size = new Size(82, 27);
            login_button.TabIndex = 0;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(266, 217);
            cancel_button.Margin = new Padding(3, 2, 3, 2);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(82, 27);
            cancel_button.TabIndex = 1;
            cancel_button.Text = "Cancel";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // user_tb
            // 
            user_tb.Location = new Point(310, 106);
            user_tb.Margin = new Padding(3, 2, 3, 2);
            user_tb.Name = "user_tb";
            user_tb.Size = new Size(140, 23);
            user_tb.TabIndex = 2;
            // 
            // pass_tb
            // 
            pass_tb.Location = new Point(310, 168);
            pass_tb.Margin = new Padding(3, 2, 3, 2);
            pass_tb.Name = "pass_tb";
            pass_tb.Size = new Size(140, 23);
            pass_tb.TabIndex = 3;
            // 
            // user_lb
            // 
            user_lb.AutoSize = true;
            user_lb.Location = new Point(247, 109);
            user_lb.Name = "user_lb";
            user_lb.Size = new Size(60, 15);
            user_lb.TabIndex = 4;
            user_lb.Text = "Username";
            // 
            // pass_lb
            // 
            pass_lb.AutoSize = true;
            pass_lb.Location = new Point(247, 171);
            pass_lb.Name = "pass_lb";
            pass_lb.Size = new Size(57, 15);
            pass_lb.TabIndex = 5;
            pass_lb.Text = "Password";
            // 
            // signup_button
            // 
            signup_button.Location = new Point(354, 248);
            signup_button.Margin = new Padding(3, 2, 3, 2);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(82, 27);
            signup_button.TabIndex = 6;
            signup_button.Text = "Sign up";
            signup_button.UseVisualStyleBackColor = true;
            signup_button.Click += signup_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.account_icon;
            pictureBox1.Location = new Point(319, 24);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBox1);
            Controls.Add(signup_button);
            Controls.Add(pass_lb);
            Controls.Add(user_lb);
            Controls.Add(pass_tb);
            Controls.Add(user_tb);
            Controls.Add(cancel_button);
            Controls.Add(login_button);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}
