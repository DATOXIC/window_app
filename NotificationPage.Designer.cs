using System.Drawing;
using System.Windows.Forms;

namespace window_app
{
    partial class NotificationPage
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            tableMain       = new TableLayoutPanel();
            pnlTabRow       = new Panel();
            lblNotifTab     = new Label();
            lblGeneral      = new Label();
            lblPersonal     = new Label();
            pnlTabUnderline = new Panel();
            pnlSeparator    = new Panel();
            pnlSearchOuter  = new Panel();
            txtSearch       = new TextBox();
            lblSearchIcon   = new Label();
            dgvNotifications = new DataGridView();
            colSubject      = new DataGridViewTextBoxColumn();
            colSentBy       = new DataGridViewTextBoxColumn();
            colSentDate     = new DataGridViewTextBoxColumn();

            tableMain.SuspendLayout();
            pnlTabRow.SuspendLayout();
            pnlSearchOuter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).BeginInit();
            SuspendLayout();

            // ── UserControl ────────────────────────────────────
            Dock      = DockStyle.Fill;
            BackColor = Color.White;
            Controls.Add(tableMain);

            // ── TableLayoutPanel (4 rows) ──────────────────────
            tableMain.Dock        = DockStyle.Fill;
            tableMain.BackColor   = Color.White;
            tableMain.ColumnCount = 1;
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableMain.RowCount    = 4;
            tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));   // tab row
            tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));    // separator
            tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));   // search
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));   // grid
            tableMain.Controls.Add(pnlTabRow,        0, 0);
            tableMain.Controls.Add(pnlSeparator,     0, 1);
            tableMain.Controls.Add(pnlSearchOuter,   0, 2);
            tableMain.Controls.Add(dgvNotifications, 0, 3);

            // ── Tab Row ────────────────────────────────────────
            pnlTabRow.Dock      = DockStyle.Fill;
            pnlTabRow.BackColor = Color.White;
            pnlTabRow.Controls.Add(pnlTabUnderline);
            pnlTabRow.Controls.Add(lblPersonal);
            pnlTabRow.Controls.Add(lblGeneral);
            pnlTabRow.Controls.Add(lblNotifTab);

            lblNotifTab.Location  = new Point(8, 8);
            lblNotifTab.Size      = new Size(148, 30);
            lblNotifTab.Text      = "NOTIFICATION";
            lblNotifTab.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNotifTab.ForeColor = Color.White;
            lblNotifTab.BackColor = Color.FromArgb(93, 135, 175);
            lblNotifTab.TextAlign = ContentAlignment.MiddleCenter;

            lblGeneral.Location  = new Point(168, 8);
            lblGeneral.Size      = new Size(80, 30);
            lblGeneral.Text      = "General";
            lblGeneral.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGeneral.ForeColor = Color.FromArgb(35, 55, 88);
            lblGeneral.TextAlign = ContentAlignment.MiddleCenter;
            lblGeneral.Cursor    = Cursors.Hand;
            lblGeneral.Click    += LblGeneral_Click;

            lblPersonal.Location  = new Point(256, 8);
            lblPersonal.Size      = new Size(80, 30);
            lblPersonal.Text      = "Personal";
            lblPersonal.Font      = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblPersonal.ForeColor = Color.FromArgb(85, 105, 130);
            lblPersonal.TextAlign = ContentAlignment.MiddleCenter;
            lblPersonal.Cursor    = Cursors.Hand;
            lblPersonal.Click    += LblPersonal_Click;

            pnlTabUnderline.Location  = new Point(168, 42);
            pnlTabUnderline.Size      = new Size(80, 3);
            pnlTabUnderline.BackColor = Color.FromArgb(210, 35, 35);

            // ── Separator ─────────────────────────────────────
            pnlSeparator.Dock      = DockStyle.Fill;
            pnlSeparator.BackColor = Color.FromArgb(200, 215, 228);

            // ── Search ────────────────────────────────────────
            pnlSearchOuter.Dock      = DockStyle.Fill;
            pnlSearchOuter.BackColor = Color.FromArgb(236, 244, 251);
            pnlSearchOuter.Padding   = new Padding(10, 8, 10, 8);
            pnlSearchOuter.Controls.Add(lblSearchIcon);
            pnlSearchOuter.Controls.Add(txtSearch);

            lblSearchIcon.Anchor    = AnchorStyles.Left | AnchorStyles.Top;
            lblSearchIcon.Location  = new Point(16, 11);
            lblSearchIcon.Size      = new Size(28, 26);
            lblSearchIcon.Text      = "🔍";
            lblSearchIcon.Font      = new Font("Segoe UI", 11F);
            lblSearchIcon.BackColor = Color.Transparent;
            lblSearchIcon.TextAlign = ContentAlignment.MiddleCenter;

            txtSearch.Anchor          = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BorderStyle     = BorderStyle.None;
            txtSearch.Font            = new Font("Segoe UI", 10.5F);
            txtSearch.ForeColor       = Color.FromArgb(100, 120, 145);
            txtSearch.PlaceholderText = "Search for notifications";
            txtSearch.Location        = new Point(46, 14);
            txtSearch.Size            = new Size(500, 22);
            txtSearch.TextChanged    += TxtSearch_TextChanged;

            // ── DataGridView ──────────────────────────────────
            dgvNotifications.Dock                = DockStyle.Fill;
            dgvNotifications.AutoGenerateColumns = false;
            dgvNotifications.BackgroundColor     = Color.FromArgb(230, 242, 250);
            dgvNotifications.BorderStyle         = BorderStyle.None;
            dgvNotifications.CellBorderStyle     = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNotifications.GridColor           = Color.FromArgb(200, 218, 232);
            dgvNotifications.ReadOnly            = true;
            dgvNotifications.AllowUserToAddRows    = false;
            dgvNotifications.AllowUserToDeleteRows = false;
            dgvNotifications.AllowUserToResizeRows = false;
            dgvNotifications.RowHeadersVisible     = false;
            dgvNotifications.SelectionMode         = DataGridViewSelectionMode.FullRowSelect;
            dgvNotifications.AutoSizeColumnsMode   = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNotifications.ColumnHeadersHeight   = 38;
            dgvNotifications.EnableHeadersVisualStyles = false;
            dgvNotifications.RowTemplate.Height    = 35;

            dgvNotifications.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor          = Color.FromArgb(107, 142, 181),
                ForeColor          = Color.White,
                Font               = new Font("Segoe UI", 10F, FontStyle.Bold),
                SelectionBackColor = Color.FromArgb(107, 142, 181),
                SelectionForeColor = Color.White,
                Alignment          = DataGridViewContentAlignment.MiddleLeft,
                Padding            = new Padding(8, 0, 0, 0)
            };
            dgvNotifications.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvNotifications.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor          = Color.FromArgb(230, 242, 250),
                ForeColor          = Color.FromArgb(35, 55, 80),
                Font               = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(185, 210, 232),
                SelectionForeColor = Color.FromArgb(20, 44, 75),
                Padding            = new Padding(8, 0, 0, 0)
            };
            dgvNotifications.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor          = Color.FromArgb(215, 232, 246),
                ForeColor          = Color.FromArgb(35, 55, 80),
                SelectionBackColor = Color.FromArgb(185, 210, 232),
                SelectionForeColor = Color.FromArgb(20, 44, 75),
                Padding            = new Padding(8, 0, 0, 0)
            };

            colSubject.DataPropertyName = "Subject";
            colSubject.HeaderText       = "Subject";
            colSubject.FillWeight       = 55F;
            colSubject.ReadOnly         = true;

            colSentBy.DataPropertyName  = "SentBy";
            colSentBy.HeaderText        = "Sent by";
            colSentBy.FillWeight        = 25F;
            colSentBy.ReadOnly          = true;

            colSentDate.DataPropertyName = "SentDate";
            colSentDate.HeaderText       = "Sent date";
            colSentDate.FillWeight       = 20F;
            colSentDate.ReadOnly         = true;
            colSentDate.DefaultCellStyle = new DataGridViewCellStyle
            {
                Format  = "dd/MM/yyyy",
                Padding = new Padding(8, 0, 0, 0)
            };

            dgvNotifications.Columns.AddRange(colSubject, colSentBy, colSentDate);

            tableMain.ResumeLayout(false);
            pnlTabRow.ResumeLayout(false);
            pnlSearchOuter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private TableLayoutPanel tableMain;
        private Panel pnlTabRow, pnlSeparator, pnlSearchOuter;
        private Label lblNotifTab, lblGeneral, lblPersonal;
        private Panel pnlTabUnderline;
        private TextBox txtSearch;
        private Label lblSearchIcon;
        private DataGridView dgvNotifications;
        private DataGridViewTextBoxColumn colSubject, colSentBy, colSentDate;
    }
}
