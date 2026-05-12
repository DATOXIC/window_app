using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace window_app
{
    public partial class NotificationPage : UserControl
    {
        private string _currentTab  = "General";
        private string _currentMSSV = "";

        public NotificationPage()
        {
            InitializeComponent();
            _currentMSSV = Globals.GlobalStudentID ?? "";
            SetActiveTab("General");
            LoadNotifications();
        }

        // ====================================================
        // Chuyển tab active
        // ====================================================
        private void SetActiveTab(string tab)
        {
            _currentTab = tab;
            bool isGeneral = (tab == "General");

            lblGeneral.Font      = new Font("Segoe UI", 10F, isGeneral ? FontStyle.Bold : FontStyle.Regular);
            lblGeneral.ForeColor = isGeneral ? Color.FromArgb(35, 55, 88) : Color.FromArgb(85, 105, 130);
            lblPersonal.Font     = new Font("Segoe UI", 10F, isGeneral ? FontStyle.Regular : FontStyle.Bold);
            lblPersonal.ForeColor= isGeneral ? Color.FromArgb(85, 105, 130) : Color.FromArgb(35, 55, 88);

            // Di chuyển gạch đỏ sang tab active
            pnlTabUnderline.Location = new Point(isGeneral ? lblGeneral.Left : lblPersonal.Left, 42);
            pnlTabUnderline.Width    = isGeneral ? lblGeneral.Width : lblPersonal.Width;
        }

        // ====================================================
        // Load thông báo
        // ====================================================
        private void LoadNotifications()
        {
            try
            {
                var notif = new Notification();
                string kw = txtSearch.Text.Trim();
                DataTable dt;

                if (!string.IsNullOrEmpty(kw))
                    dt = notif.SearchNotifications(kw, _currentTab, _currentMSSV);
                else if (_currentTab == "General")
                    dt = notif.GetGeneralNotifications();
                else
                    dt = notif.GetPersonalNotifications(_currentMSSV);

                dgvNotifications.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông báo: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================================================
        // Sự kiện
        // ====================================================
        private void LblGeneral_Click(object sender, EventArgs e)
        {
            SetActiveTab("General");
            LoadNotifications();
        }

        private void LblPersonal_Click(object sender, EventArgs e)
        {
            SetActiveTab("Personal");
            LoadNotifications();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
            => LoadNotifications();
    }
}
