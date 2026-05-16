namespace window_app
{
    partial class User2
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
            admission_data_display = new DataGridView();
            headerPanel = new Panel();
            headerTitle = new Label();
            headerIcon = new Label();
            panel3 = new Panel();
            statsPanel = new Panel();
            statsDetails = new Panel();
            lblTotalLabel = new Label();
            lblTotalCount = new Label();
            lblStatTitle = new Label();
            buttonPanel = new Panel();
            sellect_all_button = new Button();
            button2 = new Button();
            accept_button = new Button();
            sidebarTitle = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)admission_data_display).BeginInit();
            headerPanel.SuspendLayout();
            panel3.SuspendLayout();
            statsPanel.SuspendLayout();
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
            panel2.Controls.Add(admission_data_display);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(20, 60);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(1);
            panel2.Size = new Size(535, 452);
            panel2.TabIndex = 0;
            // 
            // admission_data_display
            // 
            admission_data_display.AllowUserToAddRows = false;
            admission_data_display.AllowUserToDeleteRows = false;
            admission_data_display.AllowUserToResizeRows = false;
            admission_data_display.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            admission_data_display.BackgroundColor = Color.White;
            admission_data_display.BorderStyle = BorderStyle.None;
            admission_data_display.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            admission_data_display.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            admission_data_display.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            admission_data_display.ColumnHeadersHeight = 42;
            admission_data_display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            admission_data_display.Dock = DockStyle.Fill;
            admission_data_display.EnableHeadersVisualStyles = false;
            admission_data_display.GridColor = Color.FromArgb(230, 235, 240);
            admission_data_display.Location = new Point(1, 1);
            admission_data_display.Name = "admission_data_display";
            admission_data_display.ReadOnly = true;
            admission_data_display.RowHeadersVisible = false;
            admission_data_display.RowHeadersWidth = 51;
            admission_data_display.RowTemplate.Height = 36;
            admission_data_display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            admission_data_display.Size = new Size(533, 450);
            admission_data_display.TabIndex = 0;
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
            headerTitle.Size = new Size(296, 41);
            headerTitle.TabIndex = 0;
            headerTitle.Text = "Phê duyệt Tuyển sinh";
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
            headerIcon.Text = "📋";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(245, 247, 251);
            panel3.Controls.Add(statsPanel);
            panel3.Controls.Add(buttonPanel);
            panel3.Controls.Add(sidebarTitle);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(573, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(15);
            panel3.Size = new Size(219, 532);
            panel3.TabIndex = 2;
            // 
            // statsPanel
            // 
            statsPanel.BackColor = Color.White;
            statsPanel.Controls.Add(statsDetails);
            statsPanel.Controls.Add(lblTotalLabel);
            statsPanel.Controls.Add(lblTotalCount);
            statsPanel.Controls.Add(lblStatTitle);
            statsPanel.Dock = DockStyle.Fill;
            statsPanel.Location = new Point(15, 225);
            statsPanel.Name = "statsPanel";
            statsPanel.Padding = new Padding(12, 10, 12, 10);
            statsPanel.Size = new Size(189, 292);
            statsPanel.TabIndex = 0;
            // 
            // statsDetails
            // 
            statsDetails.AutoScroll = true;
            statsDetails.BackColor = Color.White;
            statsDetails.Dock = DockStyle.Fill;
            statsDetails.Location = new Point(12, 116);
            statsDetails.Name = "statsDetails";
            statsDetails.Size = new Size(165, 166);
            statsDetails.TabIndex = 0;
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Dock = DockStyle.Top;
            lblTotalLabel.Font = new Font("Segoe UI", 9F);
            lblTotalLabel.ForeColor = Color.FromArgb(130, 140, 160);
            lblTotalLabel.Location = new Point(12, 88);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.Padding = new Padding(0, 0, 0, 8);
            lblTotalLabel.Size = new Size(154, 28);
            lblTotalLabel.TabIndex = 1;
            lblTotalLabel.Text = "thí sinh chờ phê duyệt";
            lblTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCount
            // 
            lblTotalCount.Dock = DockStyle.Top;
            lblTotalCount.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(41, 107, 191);
            lblTotalCount.Location = new Point(12, 38);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(165, 50);
            lblTotalCount.TabIndex = 2;
            lblTotalCount.Text = "0";
            lblTotalCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatTitle
            // 
            lblStatTitle.AutoSize = true;
            lblStatTitle.Dock = DockStyle.Top;
            lblStatTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblStatTitle.ForeColor = Color.FromArgb(32, 64, 113);
            lblStatTitle.Location = new Point(12, 10);
            lblStatTitle.Name = "lblStatTitle";
            lblStatTitle.Padding = new Padding(0, 0, 0, 5);
            lblStatTitle.Size = new Size(165, 28);
            lblStatTitle.TabIndex = 3;
            lblStatTitle.Text = "📊 Thống kê nhanh";
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = Color.Transparent;
            buttonPanel.Controls.Add(sellect_all_button);
            buttonPanel.Controls.Add(button2);
            buttonPanel.Controls.Add(accept_button);
            buttonPanel.Dock = DockStyle.Top;
            buttonPanel.Location = new Point(15, 55);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(0, 5, 0, 10);
            buttonPanel.Size = new Size(189, 170);
            buttonPanel.TabIndex = 1;
            // 
            // sellect_all_button
            // 
            sellect_all_button.BackColor = Color.FromArgb(41, 107, 191);
            sellect_all_button.Cursor = Cursors.Hand;
            sellect_all_button.Dock = DockStyle.Top;
            sellect_all_button.FlatAppearance.BorderSize = 0;
            sellect_all_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 80, 150);
            sellect_all_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 120, 210);
            sellect_all_button.FlatStyle = FlatStyle.Flat;
            sellect_all_button.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            sellect_all_button.ForeColor = Color.White;
            sellect_all_button.Location = new Point(0, 97);
            sellect_all_button.Name = "sellect_all_button";
            sellect_all_button.Size = new Size(189, 46);
            sellect_all_button.TabIndex = 0;
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
            button2.Location = new Point(0, 51);
            button2.Name = "button2";
            button2.Size = new Size(189, 46);
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
            accept_button.Location = new Point(0, 5);
            accept_button.Name = "accept_button";
            accept_button.Size = new Size(189, 46);
            accept_button.TabIndex = 2;
            accept_button.Text = "✅  Phê duyệt";
            accept_button.UseVisualStyleBackColor = false;
            accept_button.Click += btnApprove_Click;
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
            sidebarTitle.TabIndex = 2;
            sidebarTitle.Text = "⚡ Thao tác";
            sidebarTitle.TextAlign = ContentAlignment.MiddleCenter;
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
            // User2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "User2";
            Size = new Size(792, 532);
            Load += User2_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)admission_data_display).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            panel3.ResumeLayout(false);
            statsPanel.ResumeLayout(false);
            statsPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView admission_data_display;
        private Panel headerPanel;
        private Label headerTitle;
        private Label headerIcon;
        private Panel panel3;
        private Label sidebarTitle;
        private Panel statsPanel;
        private Label lblStatTitle;
        private Label lblTotalCount;
        private Label lblTotalLabel;
        private Panel statsDetails;
        private Panel buttonPanel;
        private Button sellect_all_button;
        private Button button2;
        private Button accept_button;
        private Panel panel4;
    }
}
