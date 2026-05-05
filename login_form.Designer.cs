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
            SuspendLayout();
            // 
            // login_button
            // 
            login_button.Location = new Point(409, 322);
            login_button.Name = "login_button";
            login_button.Size = new Size(94, 29);
            login_button.TabIndex = 0;
            login_button.Text = "button1";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(152, 322);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(94, 29);
            cancel_button.TabIndex = 1;
            cancel_button.Text = "button2";
            cancel_button.UseVisualStyleBackColor = true;
            // 
            // user_tb
            // 
            user_tb.Location = new Point(314, 104);
            user_tb.Name = "user_tb";
            user_tb.Size = new Size(125, 27);
            user_tb.TabIndex = 2;
            // 
            // pass_tb
            // 
            pass_tb.Location = new Point(314, 187);
            pass_tb.Name = "pass_tb";
            pass_tb.Size = new Size(125, 27);
            pass_tb.TabIndex = 3;
            // 
            // user_lb
            // 
            user_lb.AutoSize = true;
            user_lb.Location = new Point(118, 104);
            user_lb.Name = "user_lb";
            user_lb.Size = new Size(73, 20);
            user_lb.TabIndex = 4;
            user_lb.Text = "username";
            // 
            // pass_lb
            // 
            pass_lb.AutoSize = true;
            pass_lb.Location = new Point(119, 190);
            pass_lb.Name = "pass_lb";
            pass_lb.Size = new Size(72, 20);
            pass_lb.TabIndex = 5;
            pass_lb.Text = "password";
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pass_lb);
            Controls.Add(user_lb);
            Controls.Add(pass_tb);
            Controls.Add(user_tb);
            Controls.Add(cancel_button);
            Controls.Add(login_button);
            Name = "login_form";
            Text = "Form1";
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
    }
}
