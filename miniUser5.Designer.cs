namespace window_app
{
    partial class miniUser5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            courseName_tb = new TextBox();
            coursePeriod_tb = new TextBox();
            courseScript_tb = new TextBox();
            addCourse_bt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(122, 83);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "NAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(122, 176);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 1;
            label2.Text = "PERIOD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(122, 313);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 2;
            label3.Text = "DESCRIPTION:";
            // 
            // courseName_tb
            // 
            courseName_tb.Location = new Point(287, 81);
            courseName_tb.Name = "courseName_tb";
            courseName_tb.Size = new Size(125, 27);
            courseName_tb.TabIndex = 3;
            // 
            // coursePeriod_tb
            // 
            coursePeriod_tb.Location = new Point(287, 174);
            coursePeriod_tb.Name = "coursePeriod_tb";
            coursePeriod_tb.Size = new Size(125, 27);
            coursePeriod_tb.TabIndex = 4;
            // 
            // courseScript_tb
            // 
            courseScript_tb.Location = new Point(287, 267);
            courseScript_tb.Multiline = true;
            courseScript_tb.Name = "courseScript_tb";
            courseScript_tb.ScrollBars = ScrollBars.Vertical;
            courseScript_tb.Size = new Size(425, 121);
            courseScript_tb.TabIndex = 5;
            // 
            // addCourse_bt
            // 
            addCourse_bt.Location = new Point(646, 167);
            addCourse_bt.Name = "addCourse_bt";
            addCourse_bt.Size = new Size(94, 29);
            addCourse_bt.TabIndex = 6;
            addCourse_bt.Text = "ADD";
            addCourse_bt.UseVisualStyleBackColor = true;
            addCourse_bt.Click += addCourse_bt_Click;
            // 
            // miniUser5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addCourse_bt);
            Controls.Add(courseScript_tb);
            Controls.Add(coursePeriod_tb);
            Controls.Add(courseName_tb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "miniUser5";
            Text = "ADD COURSE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox courseName_tb;
        private TextBox coursePeriod_tb;
        private TextBox courseScript_tb;
        private Button addCourse_bt;
    }
}