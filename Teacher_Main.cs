using System;
using System.Windows.Forms;

namespace window_app
{
    public partial class Teacher_Main : Form
    {
        public Teacher_Main()
        {
            InitializeComponent();
        }

        private void Teacher_Main_Load(object sender, EventArgs e)
        {
            // Cập nhật tên giảng viên trên header
            lblHeaderUser.Text = $"👤 {Globals.GlobalUsername}";

            // Căn giữa các label welcome theo chiều ngang của content panel
            CenterWelcomeLabels();
        }

        private void CenterWelcomeLabels()
        {
            int panelW = contentPanel.ClientSize.Width;
            lblWelcomeIcon.Left  = (panelW - lblWelcomeIcon.Width)  / 2;
            lblWelcomeTitle.Left = (panelW - lblWelcomeTitle.Width) / 2;
            lblWelcomeSub.Left   = (panelW - lblWelcomeSub.Width)   / 2;
        }
    }
}
