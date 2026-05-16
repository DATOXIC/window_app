namespace window_app
{
    partial class User1
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
            buttonPanel = new Panel();
            sellect_all_button = new Button();
            button2 = new Button();
            accept_button = new Button();
            rolePanel = new Panel();
            confirm_role_combobox = new ComboBox();
            label2 = new Label();
            filterPanel = new Panel();
            comboBox2 = new ComboBox();
            label3 = new Label();
            sidebarTitle = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            Display_Account_View = new DataGridView();
            headerPanel = new Panel();
            headerTitle = new Label();
            headerIcon = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            buttonPanel.SuspendLayout();
            rolePanel.SuspendLayout();
            filterPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Display_Account_View).BeginInit();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 247, 251);
            panel1.Controls.Add(buttonPanel);
            panel1.Controls.Add(rolePanel);
            panel1.Controls.Add(filterPanel);
            panel1.Controls.Add(sidebarTitle);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(573, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(219, 532);
            panel1.TabIndex = 9;
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = Color.Transparent;
            buttonPanel.Controls.Add(sellect_all_button);
            buttonPanel.Controls.Add(button2);
            buttonPanel.Controls.Add(accept_button);
            buttonPanel.Dock = DockStyle.Top;
            buttonPanel.Location = new Point(15, 223);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(0, 15, 0, 0);
            buttonPanel.Size = new Size(189, 210);
            buttonPanel.TabIndex = 3;
            // 
            // sellect_all_button
            // 
            sellect_all_button.BackColor = Color.FromArgb(41, 107, 191);
            sellect_all_button.Cursor = Cursors.Hand;
            sellect_all_button.Dock = DockStyle.Bottom;
            sellect_all_button.FlatAppearance.BorderSize = 0;
            sellect_all_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 80, 150);
            sellect_all_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 210);
            sellect_all_button.FlatStyle = FlatStyle.Flat;
            sellect_all_button.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            sellect_all_button.ForeColor = Color.White;
            sellect_all_button.Location = new Point(0, 162);
            sellect_all_button.Name = "sellect_all_button";
            sellect_all_button.Size = new Size(189, 48);
            sellect_all_button.TabIndex = 2;
            sellect_all_button.Text = "☑️  Chọn tất cả";
            sellect_all_button.UseVisualStyleBackColor = false;
            sellect_all_button.Click += sellect_all_button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(220, 53, 69);
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 40, 55);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 70, 85);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 63);
            button2.Margin = new Padding(0, 10, 0, 0);
            button2.Name = "button2";
            button2.Size = new Size(189, 48);
            button2.TabIndex = 1;
            button2.Text = "❌  Từ chối";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // accept_button
            // 
            accept_button.BackColor = Color.FromArgb(40, 167, 69);
            accept_button.Cursor = Cursors.Hand;
            accept_button.Dock = DockStyle.Top;
            accept_button.FlatAppearance.BorderSize = 0;
            accept_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 130, 55);
            accept_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 185, 85);
            accept_button.FlatStyle = FlatStyle.Flat;
            accept_button.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            accept_button.ForeColor = Color.White;
            accept_button.Location = new Point(0, 15);
            accept_button.Name = "accept_button";
            accept_button.Size = new Size(189, 48);
            accept_button.TabIndex = 0;
            accept_button.Text = "✅  Phê duyệt";
            accept_button.UseVisualStyleBackColor = false;
            accept_button.Click += accept_button_Click;
            // 
            // rolePanel
            // 
            rolePanel.BackColor = Color.Transparent;
            rolePanel.Controls.Add(confirm_role_combobox);
            rolePanel.Controls.Add(label2);
            rolePanel.Dock = DockStyle.Top;
            rolePanel.Location = new Point(15, 148);
            rolePanel.Name = "rolePanel";
            rolePanel.Padding = new Padding(0, 5, 0, 10);
            rolePanel.Size = new Size(189, 75);
            rolePanel.TabIndex = 2;
            // 
            // confirm_role_combobox
            // 
            confirm_role_combobox.BackColor = Color.White;
            confirm_role_combobox.Dock = DockStyle.Top;
            confirm_role_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            confirm_role_combobox.FlatStyle = FlatStyle.Flat;
            confirm_role_combobox.Font = new Font("Segoe UI", 10F);
            confirm_role_combobox.ForeColor = Color.FromArgb(50, 50, 50);
            confirm_role_combobox.FormattingEnabled = true;
            confirm_role_combobox.Items.AddRange(new object[] { "Admin", "Teacher", "Student" });
            confirm_role_combobox.Location = new Point(0, 32);
            confirm_role_combobox.Name = "confirm_role_combobox";
            confirm_role_combobox.Size = new Size(189, 31);
            confirm_role_combobox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(32, 64, 113);
            label2.Location = new Point(0, 5);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 6);
            label2.Size = new Size(166, 27);
            label2.TabIndex = 0;
            label2.Text = "Gán vai trò phê duyệt";
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.Transparent;
            filterPanel.Controls.Add(comboBox2);
            filterPanel.Controls.Add(label3);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(15, 73);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(0, 5, 0, 10);
            filterPanel.Size = new Size(189, 75);
            filterPanel.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.White;
            comboBox2.Dock = DockStyle.Top;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Segoe UI", 10F);
            comboBox2.ForeColor = Color.FromArgb(50, 50, 50);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Tất cả", "Admin", "Teacher", "Student" });
            comboBox2.Location = new Point(0, 32);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(189, 31);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(32, 64, 113);
            label3.Location = new Point(0, 5);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 6);
            label3.Size = new Size(124, 27);
            label3.TabIndex = 0;
            label3.Text = "Lọc theo vai trò";
            // 
            // sidebarTitle
            // 
            sidebarTitle.BackColor = Color.Transparent;
            sidebarTitle.Dock = DockStyle.Top;
            sidebarTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            sidebarTitle.ForeColor = Color.FromArgb(32, 64, 113);
            sidebarTitle.Location = new Point(15, 15);
            sidebarTitle.Name = "sidebarTitle";
            sidebarTitle.Padding = new Padding(0, 20, 0, 10);
            sidebarTitle.Size = new Size(189, 58);
            sidebarTitle.TabIndex = 0;
            sidebarTitle.Text = "⚡ Thao tác";
            sidebarTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(245, 247, 251);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(headerPanel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 0, 10, 20);
            panel2.Size = new Size(565, 532);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(Display_Account_View);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(20, 60);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(1);
            panel3.Size = new Size(535, 452);
            panel3.TabIndex = 0;
            // 
            // Display_Account_View
            // 
            Display_Account_View.AllowUserToAddRows = false;
            Display_Account_View.AllowUserToDeleteRows = false;
            Display_Account_View.AllowUserToResizeRows = false;
            Display_Account_View.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Display_Account_View.BackgroundColor = Color.White;
            Display_Account_View.BorderStyle = BorderStyle.None;
            Display_Account_View.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Display_Account_View.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Display_Account_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Display_Account_View.ColumnHeadersHeight = 42;
            Display_Account_View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Display_Account_View.Dock = DockStyle.Fill;
            Display_Account_View.EnableHeadersVisualStyles = false;
            Display_Account_View.GridColor = Color.FromArgb(230, 235, 240);
            Display_Account_View.Location = new Point(1, 1);
            Display_Account_View.Name = "Display_Account_View";
            Display_Account_View.ReadOnly = true;
            Display_Account_View.RowHeadersVisible = false;
            Display_Account_View.RowHeadersWidth = 51;
            Display_Account_View.RowTemplate.Height = 36;
            Display_Account_View.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Display_Account_View.Size = new Size(533, 450);
            Display_Account_View.TabIndex = 0;
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
            headerTitle.Size = new Size(284, 41);
            headerTitle.TabIndex = 1;
            headerTitle.Text = "Phê duyệt Tài khoản";
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
            headerIcon.Text = "🛡️";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(245, 247, 251);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(565, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 532);
            panel4.TabIndex = 11;
            // 
            // User1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "User1";
            Size = new Size(792, 532);
            Load += UserControl1_Load;
            panel1.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            rolePanel.ResumeLayout(false);
            rolePanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Display_Account_View).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel buttonPanel;
        private Button sellect_all_button;
        private Button button2;
        private Button accept_button;
        private Panel rolePanel;
        private ComboBox confirm_role_combobox;
        private Label label2;
        private Panel filterPanel;
        private ComboBox comboBox2;
        private Label label3;
        private Label sidebarTitle;
        private Panel panel2;
        private Panel panel3;
        private DataGridView Display_Account_View;
        private Panel headerPanel;
        private Label headerTitle;
        private Label headerIcon;
        private Panel panel4;
    }
}
