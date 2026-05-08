namespace window_app
{
    partial class ForgotPassForm
    {
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
            label1 = new Label();
            label6 = new Label();
            txtUsername = new TextBox();
            txtConfirmPass = new TextBox();
            label7 = new Label();
            grbChangePass = new GroupBox();
            btnChange = new Button();
            txtNewPass = new TextBox();
            returnPB = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            cbbAnswer1 = new ComboBox();
            cbbAnswer2 = new ComboBox();
            groupBox2 = new GroupBox();
            lblQuestion2 = new Label();
            lblQuestion1 = new Label();
            btnConfirm = new Button();
            btnSearch = new Button();
            grbChangePass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)returnPB).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 44);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 42);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 5;
            label6.Text = "New Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(140, 37);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(290, 27);
            txtUsername.TabIndex = 6;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(140, 81);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(290, 27);
            txtConfirmPass.TabIndex = 12;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 88);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 13;
            label7.Text = "Confirm";
            // 
            // grbChangePass
            // 
            grbChangePass.Controls.Add(btnChange);
            grbChangePass.Controls.Add(label7);
            grbChangePass.Controls.Add(txtConfirmPass);
            grbChangePass.Controls.Add(label6);
            grbChangePass.Controls.Add(txtNewPass);
            grbChangePass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbChangePass.Location = new Point(115, 322);
            grbChangePass.Name = "grbChangePass";
            grbChangePass.Size = new Size(580, 125);
            grbChangePass.TabIndex = 16;
            grbChangePass.TabStop = false;
            grbChangePass.Text = "Change Password";
            // 
            // btnChange
            // 
            btnChange.Location = new Point(471, 77);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(94, 31);
            btnChange.TabIndex = 14;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(140, 39);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(290, 27);
            txtNewPass.TabIndex = 10;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // returnPB
            // 
            returnPB.Image = Properties.Resources.circle_arrow_left_solid_full;
            returnPB.Location = new Point(12, 12);
            returnPB.Name = "returnPB";
            returnPB.Size = new Size(42, 31);
            returnPB.SizeMode = PictureBoxSizeMode.Zoom;
            returnPB.TabIndex = 12;
            returnPB.TabStop = false;
            returnPB.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 9F);
            label4.Location = new Point(13, 206);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Question 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 9F);
            label3.Location = new Point(13, 159);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Answer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 9F);
            label5.Location = new Point(13, 252);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 4;
            label5.Text = "Answer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 9F);
            label2.Location = new Point(13, 107);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Question 1";
            // 
            // cbbAnswer1
            // 
            cbbAnswer1.FormattingEnabled = true;
            cbbAnswer1.Items.AddRange(new object[] { "Black", "Blue", "Brown", "Green", "Grey", "Orange", "Pink", "Red", "White", "Yellow" });
            cbbAnswer1.Location = new Point(140, 151);
            cbbAnswer1.Name = "cbbAnswer1";
            cbbAnswer1.Size = new Size(290, 28);
            cbbAnswer1.TabIndex = 12;
            // 
            // cbbAnswer2
            // 
            cbbAnswer2.FormattingEnabled = true;
            cbbAnswer2.Items.AddRange(new object[] { "Ant", "Bear", "Cat", "Dog", "Elephant", "Fish", "Giraffe", "Horse", "Iguana", "Jellyfish" });
            cbbAnswer2.Location = new Point(140, 244);
            cbbAnswer2.Name = "cbbAnswer2";
            cbbAnswer2.Size = new Size(290, 28);
            cbbAnswer2.TabIndex = 13;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblQuestion2);
            groupBox2.Controls.Add(lblQuestion1);
            groupBox2.Controls.Add(btnConfirm);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cbbAnswer2);
            groupBox2.Controls.Add(txtUsername);
            groupBox2.Controls.Add(cbbAnswer1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(115, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(580, 295);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Security Questions and Answers";
            // 
            // lblQuestion2
            // 
            lblQuestion2.AutoSize = true;
            lblQuestion2.Location = new Point(140, 206);
            lblQuestion2.Name = "lblQuestion2";
            lblQuestion2.Size = new Size(161, 20);
            lblQuestion2.TabIndex = 17;
            lblQuestion2.Text = "Waiting for question..";
            // 
            // lblQuestion1
            // 
            lblQuestion1.AutoSize = true;
            lblQuestion1.Location = new Point(140, 107);
            lblQuestion1.Name = "lblQuestion1";
            lblQuestion1.Size = new Size(165, 20);
            lblQuestion1.TabIndex = 16;
            lblQuestion1.Text = "Waiting for question...";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(471, 243);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(471, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += searchButton_Click;
            // 
            // ForgotPassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbChangePass);
            Controls.Add(returnPB);
            Controls.Add(groupBox2);
            Name = "ForgotPassForm";
            Text = "ForgotPassForm";
            Load += ForgotPassForm_Load;
            grbChangePass.ResumeLayout(false);
            grbChangePass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)returnPB).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label6;
        private TextBox txtUsername;
        private TextBox txtConfirmPass;
        private Label label7;
        private GroupBox grbChangePass;
        private PictureBox returnPB;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
        private ComboBox cbbAnswer1;
        private ComboBox cbbAnswer2;
        private GroupBox groupBox2;
        private Button btnConfirm;
        private Button btnSearch;
        private Label lblQuestion2;
        private Label lblQuestion1;
        private TextBox txtNewPass;
        private Button btnChange;
    }
}