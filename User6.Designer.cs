namespace window_app
{
    partial class User6
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel3 = new Panel();
            teacher_display = new DataGridView();
            headerPanel = new Panel();
            headerTitle = new Label();
            headerIcon = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            buttonPanel = new Panel();
            btnDelete = new Button();
            btnResetPassword = new Button();
            filterPanel = new Panel();
            cboDepartment = new ComboBox();
            lblDepartment = new Label();
            searchPanel = new Panel();
            searchUnderline = new Panel();
            txtSearch = new TextBox();
            lblSearch = new Label();
            sidebarTitle = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teacher_display).BeginInit();
            headerPanel.SuspendLayout();
            panel2.SuspendLayout();
            buttonPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 247, 251);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(headerPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 10, 20);
            panel1.Size = new Size(565, 532);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(teacher_display);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(20, 60);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(1);
            panel3.Size = new Size(535, 452);
            panel3.TabIndex = 0;
            // 
            // teacher_display
            // 
            teacher_display.AllowUserToAddRows = false;
            teacher_display.AllowUserToDeleteRows = false;
            teacher_display.AllowUserToResizeRows = false;
            teacher_display.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            teacher_display.BackgroundColor = Color.White;
            teacher_display.BorderStyle = BorderStyle.None;
            teacher_display.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            teacher_display.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            teacher_display.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            teacher_display.ColumnHeadersHeight = 42;
            teacher_display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            teacher_display.Dock = DockStyle.Fill;
            teacher_display.EnableHeadersVisualStyles = false;
            teacher_display.GridColor = Color.FromArgb(230, 235, 240);
            teacher_display.Location = new Point(1, 1);
            teacher_display.MultiSelect = false;
            teacher_display.Name = "teacher_display";
            teacher_display.ReadOnly = true;
            teacher_display.RowHeadersVisible = false;
            teacher_display.RowHeadersWidth = 51;
            teacher_display.RowTemplate.Height = 36;
            teacher_display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            teacher_display.Size = new Size(533, 450);
            teacher_display.TabIndex = 0;
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
            headerTitle.Size = new Size(265, 41);
            headerTitle.TabIndex = 0;
            headerTitle.Text = "Quản lý Giảng viên";
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
            headerIcon.TabIndex = 1;
            headerIcon.Text = "👨‍🏫";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(245, 247, 251);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(565, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 532);
            panel4.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(245, 247, 251);
            panel2.Controls.Add(buttonPanel);
            panel2.Controls.Add(filterPanel);
            panel2.Controls.Add(searchPanel);
            panel2.Controls.Add(sidebarTitle);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(573, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15);
            panel2.Size = new Size(219, 532);
            panel2.TabIndex = 2;
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = Color.Transparent;
            buttonPanel.Controls.Add(btnDelete);
            buttonPanel.Controls.Add(btnResetPassword);
            buttonPanel.Dock = DockStyle.Top;
            buttonPanel.Location = new Point(15, 200);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(0, 15, 0, 0);
            buttonPanel.Size = new Size(189, 130);
            buttonPanel.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Dock = DockStyle.Top;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 40, 55);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 70, 85);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(0, 63);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(189, 48);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "🗑️  Xóa giảng viên";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.FromArgb(255, 152, 0);
            btnResetPassword.Cursor = Cursors.Hand;
            btnResetPassword.Dock = DockStyle.Top;
            btnResetPassword.FlatAppearance.BorderSize = 0;
            btnResetPassword.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 125, 0);
            btnResetPassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 170, 40);
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(0, 15);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(189, 48);
            btnResetPassword.TabIndex = 1;
            btnResetPassword.Text = "🔑  Reset mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.Transparent;
            filterPanel.Controls.Add(cboDepartment);
            filterPanel.Controls.Add(lblDepartment);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(15, 125);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(0, 5, 0, 10);
            filterPanel.Size = new Size(189, 75);
            filterPanel.TabIndex = 1;
            // 
            // cboDepartment
            // 
            cboDepartment.BackColor = Color.White;
            cboDepartment.Dock = DockStyle.Top;
            cboDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartment.FlatStyle = FlatStyle.Flat;
            cboDepartment.Font = new Font("Segoe UI", 10F);
            cboDepartment.ForeColor = Color.FromArgb(50, 50, 50);
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Location = new Point(0, 32);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(189, 31);
            cboDepartment.TabIndex = 0;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Dock = DockStyle.Top;
            lblDepartment.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblDepartment.ForeColor = Color.FromArgb(32, 64, 113);
            lblDepartment.Location = new Point(0, 5);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Padding = new Padding(0, 0, 0, 6);
            lblDepartment.Size = new Size(115, 27);
            lblDepartment.TabIndex = 1;
            lblDepartment.Text = "Lọc theo Khoa";
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.Transparent;
            searchPanel.Controls.Add(searchUnderline);
            searchPanel.Controls.Add(txtSearch);
            searchPanel.Controls.Add(lblSearch);
            searchPanel.Dock = DockStyle.Top;
            searchPanel.Location = new Point(15, 55);
            searchPanel.Name = "searchPanel";
            searchPanel.Padding = new Padding(0, 5, 0, 10);
            searchPanel.Size = new Size(189, 70);
            searchPanel.TabIndex = 2;
            // 
            // searchUnderline
            // 
            searchUnderline.BackColor = Color.FromArgb(41, 107, 191);
            searchUnderline.Dock = DockStyle.Top;
            searchUnderline.Location = new Point(0, 55);
            searchUnderline.Name = "searchUnderline";
            searchUnderline.Size = new Size(189, 2);
            searchUnderline.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(248, 250, 253);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.ForeColor = Color.FromArgb(50, 50, 50);
            txtSearch.Location = new Point(0, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập mã GV...";
            txtSearch.Size = new Size(189, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Top;
            lblSearch.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(32, 64, 113);
            lblSearch.Location = new Point(0, 5);
            lblSearch.Name = "lblSearch";
            lblSearch.Padding = new Padding(0, 0, 0, 6);
            lblSearch.Size = new Size(127, 27);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Tìm theo Mã GV";
            // 
            // sidebarTitle
            // 
            sidebarTitle.BackColor = Color.Transparent;
            sidebarTitle.Dock = DockStyle.Top;
            sidebarTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            sidebarTitle.ForeColor = Color.FromArgb(32, 64, 113);
            sidebarTitle.Location = new Point(15, 15);
            sidebarTitle.Name = "sidebarTitle";
            sidebarTitle.Padding = new Padding(0, 10, 0, 5);
            sidebarTitle.Size = new Size(189, 40);
            sidebarTitle.TabIndex = 3;
            sidebarTitle.Text = "🔍 Tìm kiếm & Lọc";
            sidebarTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // User6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Name = "User6";
            Size = new Size(792, 532);
            Load += User6_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teacher_display).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            panel2.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DataGridView teacher_display;
        private Panel headerPanel;
        private Label headerTitle;
        private Label headerIcon;
        private Panel panel4;
        private Panel panel2;
        private Label sidebarTitle;
        private Panel searchPanel;
        private Label lblSearch;
        private TextBox txtSearch;
        private Panel searchUnderline;
        private Panel filterPanel;
        private Label lblDepartment;
        private ComboBox cboDepartment;
        private Panel buttonPanel;
        private Button btnDelete;
        private Button btnResetPassword;
    }
}
