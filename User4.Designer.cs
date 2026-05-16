namespace window_app
{
    partial class User4
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
            panel1 = new Panel();
            panel3 = new Panel();
            student_account_display = new DataGridView();
            headerPanel = new Panel();
            headerTitle = new Label();
            headerIcon = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            buttonPanel = new Panel();
            btnDelete = new Button();
            filterPanel = new Panel();
            cboMajor = new ComboBox();
            lblMajor = new Label();
            yearPanel = new Panel();
            cboYear = new ComboBox();
            lblYear = new Label();
            searchPanel = new Panel();
            txtSearch = new TextBox();
            searchUnderline = new Panel();
            lblSearch = new Label();
            sidebarTitle = new Label();

            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)student_account_display).BeginInit();
            headerPanel.SuspendLayout();
            panel2.SuspendLayout();
            buttonPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            yearPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            SuspendLayout();

            // ========== panel1 (Left main) ==========
            panel1.BackColor = Color.FromArgb(245, 247, 251);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(headerPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 10, 20);

            // ========== headerPanel ==========
            headerPanel.BackColor = Color.Transparent;
            headerPanel.Controls.Add(headerTitle);
            headerPanel.Controls.Add(headerIcon);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(0, 15, 0, 10);
            headerPanel.Size = new Size(527, 60);

            headerIcon.AutoSize = true;
            headerIcon.Dock = DockStyle.Left;
            headerIcon.Font = new Font("Segoe UI", 18F);
            headerIcon.ForeColor = Color.FromArgb(41, 107, 191);
            headerIcon.Name = "headerIcon";
            headerIcon.Text = "👥";

            headerTitle.AutoSize = true;
            headerTitle.Dock = DockStyle.Left;
            headerTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            headerTitle.ForeColor = Color.FromArgb(32, 64, 113);
            headerTitle.Name = "headerTitle";
            headerTitle.Padding = new Padding(8, 4, 0, 0);
            headerTitle.Text = "Danh sách Sinh viên";

            // ========== panel3 (DataGridView wrapper) ==========
            panel3.BackColor = Color.White;
            panel3.Controls.Add(student_account_display);
            panel3.Dock = DockStyle.Fill;
            panel3.Name = "panel3";
            panel3.Padding = new Padding(1);

            // ========== student_account_display ==========
            student_account_display.AllowUserToAddRows = false;
            student_account_display.AllowUserToDeleteRows = false;
            student_account_display.AllowUserToResizeRows = false;
            student_account_display.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            student_account_display.BackgroundColor = Color.White;
            student_account_display.BorderStyle = BorderStyle.None;
            student_account_display.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            student_account_display.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            student_account_display.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(41, 107, 191),
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(0, 5, 0, 5),
                SelectionBackColor = Color.FromArgb(41, 107, 191),
                SelectionForeColor = Color.White
            };
            student_account_display.ColumnHeadersHeight = 42;
            student_account_display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            student_account_display.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(50, 50, 50),
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(220, 235, 252),
                SelectionForeColor = Color.FromArgb(32, 64, 113),
                Padding = new Padding(5, 4, 5, 4)
            };
            student_account_display.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(248, 250, 253),
                SelectionBackColor = Color.FromArgb(220, 235, 252),
                SelectionForeColor = Color.FromArgb(32, 64, 113)
            };
            student_account_display.Dock = DockStyle.Fill;
            student_account_display.EnableHeadersVisualStyles = false;
            student_account_display.GridColor = Color.FromArgb(230, 235, 240);
            student_account_display.MultiSelect = false;
            student_account_display.Name = "student_account_display";
            student_account_display.ReadOnly = true;
            student_account_display.RowHeadersVisible = false;
            student_account_display.RowTemplate.Height = 36;
            student_account_display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // ========== panel4 (Separator) ==========
            panel4.BackColor = Color.FromArgb(245, 247, 251);
            panel4.Dock = DockStyle.Right;
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 532);

            // ========== panel2 (Right sidebar) ==========
            panel2.BackColor = Color.FromArgb(245, 247, 251);
            panel2.Controls.Add(buttonPanel);
            panel2.Controls.Add(filterPanel);
            panel2.Controls.Add(yearPanel);
            panel2.Controls.Add(searchPanel);
            panel2.Controls.Add(sidebarTitle);
            panel2.Dock = DockStyle.Right;
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15);
            panel2.Size = new Size(219, 532);

            // sidebarTitle
            sidebarTitle.BackColor = Color.Transparent;
            sidebarTitle.Dock = DockStyle.Top;
            sidebarTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            sidebarTitle.ForeColor = Color.FromArgb(32, 64, 113);
            sidebarTitle.Name = "sidebarTitle";
            sidebarTitle.Padding = new Padding(0, 10, 0, 5);
            sidebarTitle.Size = new Size(189, 40);
            sidebarTitle.Text = "🔍 Tìm kiếm & Lọc";
            sidebarTitle.TextAlign = ContentAlignment.MiddleCenter;

            // ========== searchPanel ==========
            searchPanel.BackColor = Color.Transparent;
            searchPanel.Controls.Add(searchUnderline);
            searchPanel.Controls.Add(txtSearch);
            searchPanel.Controls.Add(lblSearch);
            searchPanel.Dock = DockStyle.Top;
            searchPanel.Name = "searchPanel";
            searchPanel.Padding = new Padding(0, 5, 0, 10);
            searchPanel.Size = new Size(189, 75);

            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Top;
            lblSearch.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(32, 64, 113);
            lblSearch.Name = "lblSearch";
            lblSearch.Padding = new Padding(0, 0, 0, 6);
            lblSearch.Text = "Tìm theo MSSV";

            txtSearch.BackColor = Color.FromArgb(248, 250, 253);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.ForeColor = Color.FromArgb(50, 50, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập MSSV...";
            txtSearch.Size = new Size(189, 23);
            txtSearch.TextChanged += txtSearch_TextChanged;

            searchUnderline.BackColor = Color.FromArgb(41, 107, 191);
            searchUnderline.Dock = DockStyle.Top;
            searchUnderline.Name = "searchUnderline";
            searchUnderline.Size = new Size(189, 2);

            // ========== yearPanel ==========
            yearPanel.BackColor = Color.Transparent;
            yearPanel.Controls.Add(cboYear);
            yearPanel.Controls.Add(lblYear);
            yearPanel.Dock = DockStyle.Top;
            yearPanel.Name = "yearPanel";
            yearPanel.Padding = new Padding(0, 5, 0, 10);
            yearPanel.Size = new Size(189, 75);

            lblYear.AutoSize = true;
            lblYear.Dock = DockStyle.Top;
            lblYear.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblYear.ForeColor = Color.FromArgb(32, 64, 113);
            lblYear.Name = "lblYear";
            lblYear.Padding = new Padding(0, 0, 0, 6);
            lblYear.Text = "Lọc theo năm";

            cboYear.BackColor = Color.White;
            cboYear.Dock = DockStyle.Top;
            cboYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYear.FlatStyle = FlatStyle.Flat;
            cboYear.Font = new Font("Segoe UI", 10F);
            cboYear.ForeColor = Color.FromArgb(50, 50, 50);
            cboYear.FormattingEnabled = true;
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(189, 31);

            // ========== filterPanel ==========
            filterPanel.BackColor = Color.Transparent;
            filterPanel.Controls.Add(cboMajor);
            filterPanel.Controls.Add(lblMajor);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(0, 5, 0, 10);
            filterPanel.Size = new Size(189, 75);

            lblMajor.AutoSize = true;
            lblMajor.Dock = DockStyle.Top;
            lblMajor.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblMajor.ForeColor = Color.FromArgb(32, 64, 113);
            lblMajor.Name = "lblMajor";
            lblMajor.Padding = new Padding(0, 0, 0, 6);
            lblMajor.Text = "Lọc theo ngành";

            cboMajor.BackColor = Color.White;
            cboMajor.Dock = DockStyle.Top;
            cboMajor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMajor.FlatStyle = FlatStyle.Flat;
            cboMajor.Font = new Font("Segoe UI", 10F);
            cboMajor.ForeColor = Color.FromArgb(50, 50, 50);
            cboMajor.FormattingEnabled = true;
            cboMajor.Name = "cboMajor";
            cboMajor.Size = new Size(189, 31);

            // ========== buttonPanel ==========
            buttonPanel.BackColor = Color.Transparent;
            buttonPanel.Controls.Add(btnDelete);
            buttonPanel.Dock = DockStyle.Top;
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(0, 15, 0, 0);
            buttonPanel.Size = new Size(189, 70);

            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Dock = DockStyle.Top;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 40, 55);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 70, 85);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(189, 48);
            btnDelete.Text = "🗑️  Xóa sinh viên";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;

            // ========== User4 ==========
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Name = "User4";
            Size = new Size(792, 532);

            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)student_account_display).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            panel2.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            yearPanel.ResumeLayout(false);
            yearPanel.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DataGridView student_account_display;
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
        private Panel yearPanel;
        private Label lblYear;
        private ComboBox cboYear;
        private Panel filterPanel;
        private Label lblMajor;
        private ComboBox cboMajor;
        private Panel buttonPanel;
        private Button btnDelete;
    }
}
