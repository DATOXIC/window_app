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
            mainPanel = new Panel();
            inputPanel = new Panel();
            buttonPanel = new Panel();
            cancelButton = new Button();
            addCourse_bt = new Button();
            courseScript_tb = new TextBox();
            label3 = new Label();
            periodUnderline = new Panel();
            coursePeriod_tb = new TextBox();
            label2 = new Label();
            nameUnderline = new Panel();
            courseName_tb = new TextBox();
            label1 = new Label();
            formSubtitle = new Label();
            formTitle = new Label();
            mainPanel.SuspendLayout();
            inputPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(245, 247, 251);
            mainPanel.Controls.Add(inputPanel);
            mainPanel.Controls.Add(formSubtitle);
            mainPanel.Controls.Add(formTitle);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(40, 30, 40, 30);
            mainPanel.Size = new Size(580, 520);
            mainPanel.TabIndex = 0;
            // 
            // inputPanel
            // 
            inputPanel.BackColor = Color.White;
            inputPanel.Controls.Add(buttonPanel);
            inputPanel.Controls.Add(courseScript_tb);
            inputPanel.Controls.Add(label3);
            inputPanel.Controls.Add(periodUnderline);
            inputPanel.Controls.Add(coursePeriod_tb);
            inputPanel.Controls.Add(label2);
            inputPanel.Controls.Add(nameUnderline);
            inputPanel.Controls.Add(courseName_tb);
            inputPanel.Controls.Add(label1);
            inputPanel.Dock = DockStyle.Fill;
            inputPanel.Location = new Point(40, 117);
            inputPanel.Name = "inputPanel";
            inputPanel.Padding = new Padding(30, 25, 30, 20);
            inputPanel.Size = new Size(500, 373);
            inputPanel.TabIndex = 2;
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = Color.Transparent;
            buttonPanel.Controls.Add(cancelButton);
            buttonPanel.Controls.Add(addCourse_bt);
            buttonPanel.Dock = DockStyle.Top;
            buttonPanel.Location = new Point(30, 286);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(0, 20, 0, 0);
            buttonPanel.Size = new Size(440, 68);
            buttonPanel.TabIndex = 8;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.Dock = DockStyle.Right;
            cancelButton.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            cancelButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 232, 236);
            cancelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 242, 246);
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            cancelButton.ForeColor = Color.FromArgb(80, 90, 110);
            cancelButton.Location = new Point(230, 20);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(210, 48);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "❌  Hủy";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // addCourse_bt
            // 
            addCourse_bt.BackColor = Color.FromArgb(41, 107, 191);
            addCourse_bt.Cursor = Cursors.Hand;
            addCourse_bt.Dock = DockStyle.Left;
            addCourse_bt.FlatAppearance.BorderSize = 0;
            addCourse_bt.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 80, 150);
            addCourse_bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 210);
            addCourse_bt.FlatStyle = FlatStyle.Flat;
            addCourse_bt.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            addCourse_bt.ForeColor = Color.White;
            addCourse_bt.Location = new Point(0, 20);
            addCourse_bt.Name = "addCourse_bt";
            addCourse_bt.Size = new Size(210, 48);
            addCourse_bt.TabIndex = 0;
            addCourse_bt.Text = "✅  Thêm khóa học";
            addCourse_bt.UseVisualStyleBackColor = false;
            addCourse_bt.Click += addCourse_bt_Click;
            // 
            // courseScript_tb
            // 
            courseScript_tb.BackColor = Color.FromArgb(248, 250, 253);
            courseScript_tb.BorderStyle = BorderStyle.FixedSingle;
            courseScript_tb.Dock = DockStyle.Top;
            courseScript_tb.Font = new Font("Segoe UI", 10F);
            courseScript_tb.ForeColor = Color.FromArgb(50, 50, 50);
            courseScript_tb.Location = new Point(30, 196);
            courseScript_tb.Multiline = true;
            courseScript_tb.Name = "courseScript_tb";
            courseScript_tb.PlaceholderText = "Nhập mô tả khóa học...";
            courseScript_tb.ScrollBars = ScrollBars.Vertical;
            courseScript_tb.Size = new Size(440, 90);
            courseScript_tb.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(32, 64, 113);
            label3.Location = new Point(30, 152);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 15, 0, 6);
            label3.Size = new Size(56, 44);
            label3.TabIndex = 6;
            label3.Text = "Mô tả";
            // 
            // periodUnderline
            // 
            periodUnderline.BackColor = Color.FromArgb(41, 107, 191);
            periodUnderline.Dock = DockStyle.Top;
            periodUnderline.Location = new Point(30, 150);
            periodUnderline.Name = "periodUnderline";
            periodUnderline.Size = new Size(440, 2);
            periodUnderline.TabIndex = 5;
            // 
            // coursePeriod_tb
            // 
            coursePeriod_tb.BackColor = Color.FromArgb(248, 250, 253);
            coursePeriod_tb.BorderStyle = BorderStyle.None;
            coursePeriod_tb.Dock = DockStyle.Top;
            coursePeriod_tb.Font = new Font("Segoe UI", 11F);
            coursePeriod_tb.ForeColor = Color.FromArgb(50, 50, 50);
            coursePeriod_tb.Location = new Point(30, 125);
            coursePeriod_tb.Name = "coursePeriod_tb";
            coursePeriod_tb.PlaceholderText = "Nhập số tiết (VD: 45)...";
            coursePeriod_tb.Size = new Size(440, 25);
            coursePeriod_tb.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(32, 64, 113);
            label2.Location = new Point(30, 81);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 15, 0, 6);
            label2.Size = new Size(92, 44);
            label2.TabIndex = 3;
            label2.Text = "Số tiết học";
            // 
            // nameUnderline
            // 
            nameUnderline.BackColor = Color.FromArgb(41, 107, 191);
            nameUnderline.Dock = DockStyle.Top;
            nameUnderline.Location = new Point(30, 79);
            nameUnderline.Name = "nameUnderline";
            nameUnderline.Size = new Size(440, 2);
            nameUnderline.TabIndex = 2;
            // 
            // courseName_tb
            // 
            courseName_tb.BackColor = Color.FromArgb(248, 250, 253);
            courseName_tb.BorderStyle = BorderStyle.None;
            courseName_tb.Dock = DockStyle.Top;
            courseName_tb.Font = new Font("Segoe UI", 11F);
            courseName_tb.ForeColor = Color.FromArgb(50, 50, 50);
            courseName_tb.Location = new Point(30, 54);
            courseName_tb.Name = "courseName_tb";
            courseName_tb.PlaceholderText = "Nhập tên khóa học...";
            courseName_tb.Size = new Size(440, 25);
            courseName_tb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(32, 64, 113);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 6);
            label1.Size = new Size(112, 29);
            label1.TabIndex = 0;
            label1.Text = "Tên khóa học";
            // 
            // formSubtitle
            // 
            formSubtitle.AutoSize = true;
            formSubtitle.Dock = DockStyle.Top;
            formSubtitle.Font = new Font("Segoe UI", 9.5F);
            formSubtitle.ForeColor = Color.FromArgb(130, 140, 160);
            formSubtitle.Location = new Point(40, 76);
            formSubtitle.Name = "formSubtitle";
            formSubtitle.Padding = new Padding(0, 0, 0, 20);
            formSubtitle.Size = new Size(375, 41);
            formSubtitle.TabIndex = 1;
            formSubtitle.Text = "Điền đầy đủ thông tin bên dưới để tạo khóa học mới.";
            // 
            // formTitle
            // 
            formTitle.AutoSize = true;
            formTitle.Dock = DockStyle.Top;
            formTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            formTitle.ForeColor = Color.FromArgb(32, 64, 113);
            formTitle.Location = new Point(40, 30);
            formTitle.Name = "formTitle";
            formTitle.Padding = new Padding(0, 0, 0, 5);
            formTitle.Size = new Size(354, 46);
            formTitle.TabIndex = 0;
            formTitle.Text = "📚 Thêm Khóa Học Mới";
            // 
            // miniUser5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(580, 520);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "miniUser5";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm Khóa Học";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            inputPanel.ResumeLayout(false);
            inputPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label formTitle;
        private Label formSubtitle;
        private Panel inputPanel;
        private Label label1;
        private TextBox courseName_tb;
        private Panel nameUnderline;
        private Label label2;
        private TextBox coursePeriod_tb;
        private Panel periodUnderline;
        private Label label3;
        private TextBox courseScript_tb;
        private Panel buttonPanel;
        private Button addCourse_bt;
        private Button cancelButton;
    }
}