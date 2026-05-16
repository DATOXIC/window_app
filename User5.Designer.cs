namespace window_app
{
    partial class User5
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            course_display = new DataGridView();
            headerPanel = new Panel();
            headerTitle = new Label();
            headerIcon = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            buttonPanel = new Panel();
            remove_course_button = new Button();
            add_course_button = new Button();
            sidebarTitle = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)course_display).BeginInit();
            headerPanel.SuspendLayout();
            panel3.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 247, 251);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(headerPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 10, 20);
            panel1.Size = new Size(565, 532);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(course_display);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(20, 60);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(1);
            panel2.Size = new Size(535, 452);
            panel2.TabIndex = 0;
            // 
            // course_display
            // 
            course_display.AllowUserToAddRows = false;
            course_display.AllowUserToDeleteRows = false;
            course_display.AllowUserToResizeRows = false;
            course_display.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            course_display.BackgroundColor = Color.White;
            course_display.BorderStyle = BorderStyle.None;
            course_display.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            course_display.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            course_display.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            course_display.ColumnHeadersHeight = 42;
            course_display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            course_display.Dock = DockStyle.Fill;
            course_display.EnableHeadersVisualStyles = false;
            course_display.GridColor = Color.FromArgb(230, 235, 240);
            course_display.Location = new Point(1, 1);
            course_display.MultiSelect = false;
            course_display.Name = "course_display";
            course_display.ReadOnly = true;
            course_display.RowHeadersVisible = false;
            course_display.RowHeadersWidth = 51;
            course_display.RowTemplate.Height = 36;
            course_display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            course_display.Size = new Size(533, 450);
            course_display.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.Transparent;
            headerPanel.Controls.Add(headerTitle);
            headerPanel.Controls.Add(headerIcon);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(20, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(0, 15, 0, 10);
            headerPanel.Size = new Size(535, 60);
            headerPanel.TabIndex = 1;
            // 
            // headerTitle
            // 
            headerTitle.AutoSize = true;
            headerTitle.Dock = DockStyle.Left;
            headerTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            headerTitle.ForeColor = Color.FromArgb(32, 64, 113);
            headerTitle.Location = new Point(59, 15);
            headerTitle.Name = "headerTitle";
            headerTitle.Padding = new Padding(8, 4, 0, 0);
            headerTitle.Size = new Size(248, 41);
            headerTitle.TabIndex = 1;
            headerTitle.Text = "Quản lý Khóa học";
            // 
            // headerIcon
            // 
            headerIcon.AutoSize = true;
            headerIcon.Dock = DockStyle.Left;
            headerIcon.Font = new Font("Segoe UI", 18F);
            headerIcon.ForeColor = Color.FromArgb(41, 107, 191);
            headerIcon.Location = new Point(0, 15);
            headerIcon.Name = "headerIcon";
            headerIcon.Size = new Size(59, 41);
            headerIcon.TabIndex = 0;
            headerIcon.Text = "📚";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(245, 247, 251);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(565, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 532);
            panel4.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(245, 247, 251);
            panel3.Controls.Add(buttonPanel);
            panel3.Controls.Add(sidebarTitle);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(573, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(15);
            panel3.Size = new Size(219, 532);
            panel3.TabIndex = 10;
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = Color.Transparent;
            buttonPanel.Controls.Add(remove_course_button);
            buttonPanel.Controls.Add(add_course_button);
            buttonPanel.Dock = DockStyle.Top;
            buttonPanel.Location = new Point(15, 105);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(189, 180);
            buttonPanel.TabIndex = 3;
            // 
            // remove_course_button
            // 
            remove_course_button.BackColor = Color.FromArgb(220, 53, 69);
            remove_course_button.Cursor = Cursors.Hand;
            remove_course_button.Dock = DockStyle.Bottom;
            remove_course_button.FlatAppearance.BorderSize = 0;
            remove_course_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 40, 55);
            remove_course_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 70, 85);
            remove_course_button.FlatStyle = FlatStyle.Flat;
            remove_course_button.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            remove_course_button.ForeColor = Color.White;
            remove_course_button.Location = new Point(0, 132);
            remove_course_button.Name = "remove_course_button";
            remove_course_button.Size = new Size(189, 48);
            remove_course_button.TabIndex = 1;
            remove_course_button.Text = "🗑️  Xóa khóa học";
            remove_course_button.UseVisualStyleBackColor = false;
            remove_course_button.Click += remove_course_button_Click;
            // 
            // add_course_button
            // 
            add_course_button.BackColor = Color.FromArgb(41, 107, 191);
            add_course_button.Cursor = Cursors.Hand;
            add_course_button.Dock = DockStyle.Top;
            add_course_button.FlatAppearance.BorderSize = 0;
            add_course_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 80, 150);
            add_course_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 210);
            add_course_button.FlatStyle = FlatStyle.Flat;
            add_course_button.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            add_course_button.ForeColor = Color.White;
            add_course_button.Location = new Point(0, 0);
            add_course_button.Margin = new Padding(0, 0, 0, 12);
            add_course_button.Name = "add_course_button";
            add_course_button.Size = new Size(189, 48);
            add_course_button.TabIndex = 0;
            add_course_button.Text = "➕  Thêm khóa học";
            add_course_button.UseVisualStyleBackColor = false;
            add_course_button.Click += add_course_button_Click;
            // 
            // sidebarTitle
            // 
            sidebarTitle.BackColor = Color.Transparent;
            sidebarTitle.Dock = DockStyle.Top;
            sidebarTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            sidebarTitle.ForeColor = Color.FromArgb(32, 64, 113);
            sidebarTitle.Location = new Point(15, 15);
            sidebarTitle.Name = "sidebarTitle";
            sidebarTitle.Padding = new Padding(0, 48, 0, 15);
            sidebarTitle.Size = new Size(189, 90);
            sidebarTitle.TabIndex = 2;
            sidebarTitle.Text = "⚡ Thao tác";
            sidebarTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // User5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "User5";
            Size = new Size(792, 532);
            Load += User5_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)course_display).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            panel3.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel headerPanel;
        private Label headerIcon;
        private Label headerTitle;
        private Panel panel2;
        private DataGridView course_display;
        private Panel panel4;
        private Panel panel3;
        private Label sidebarTitle;
        private Panel buttonPanel;
        private Button remove_course_button;
        private Button add_course_button;
    }
}
