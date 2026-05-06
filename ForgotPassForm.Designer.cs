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
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            returnPB = new PictureBox();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            groupBox2 = new GroupBox();
            searchButton = new Button();
            confirmButton = new Button();
            groupBox3.SuspendLayout();
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
            // textBox1
            // 
            textBox1.Location = new Point(140, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(255, 348);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(290, 27);
            textBox5.TabIndex = 10;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(255, 394);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(290, 27);
            textBox7.TabIndex = 12;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(115, 313);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(580, 125);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Change Password";
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
            // textBox4
            // 
            textBox4.Location = new Point(140, 199);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(290, 27);
            textBox4.TabIndex = 9;
            textBox4.Text = "What is your favorite animal ?";
            textBox4.UseWaitCursor = true;
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
            // textBox2
            // 
            textBox2.Location = new Point(140, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 27);
            textBox2.TabIndex = 7;
            textBox2.Text = "What color do you like ?";
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Black", "", "Blue", "", "Brown", "", "Green", "", "Grey", "", "Orange", "", "Pink", "", "Red", "", "White", "", "Yellow" });
            comboBox1.Location = new Point(140, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(290, 28);
            comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ant", "", "Bear", "", "Cat", "", "Dog", "", "Elephant", "", "Fish", "", "Giraffe", "", "Horse", "", "Iguana", "", "Jellyfish" });
            comboBox2.Location = new Point(140, 244);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(290, 28);
            comboBox2.TabIndex = 13;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(confirmButton);
            groupBox2.Controls.Add(searchButton);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(115, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(580, 295);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Security Questions and Answers";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(471, 35);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 14;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(471, 243);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(94, 29);
            confirmButton.TabIndex = 15;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            // 
            // ForgotPassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(returnPB);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "ForgotPassForm";
            Text = "ForgotPassForm";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)returnPB).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox7;
        private Label label7;
        private GroupBox groupBox3;
        private PictureBox returnPB;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Label label5;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private GroupBox groupBox2;
        private Button confirmButton;
        private Button searchButton;
    }
}