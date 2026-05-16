namespace window_app
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
            // Căn giữa card khi form resize
            this.Resize += (s, e) => CenterCard();
            this.Load += (s, e) => CenterCard();
        }

        private void CenterCard()
        {
            cardPanel.Left = (this.ClientSize.Width - cardPanel.Width) / 2;
            cardPanel.Top = (this.ClientSize.Height - cardPanel.Height) / 2;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string user = user_tb.Text.Trim();
            string pass = pass_tb.Text.Trim();

            // 1. Kiểm tra nhanh đầu vào
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Username và Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Account acc = new Account();

            try
            {
                if (acc.LoginWithStatus(user, pass) == Account.LoginResult.Success)
                {
                    // 3. Lấy thêm thông tin quyền hạn và MSSV
                    int position = acc.GetUserPosition(user);
                    string mssv = acc.GetStudentID(user);

                    // 4. Lưu vào Globals để các Form sau sử dụng
                    Globals.SetLoginSession(0, user, position, mssv ?? "");

                    MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide(); // Ẩn form Login đi

                    if (position == 0) // Admin
                    {
                        Admin_Main fadmin = new Admin_Main();
                        fadmin.ShowDialog();
                    }
                    else if (position == 1) // Sinh viên
                    {
                        Student_Main fstudent = new Student_Main();
                        fstudent.ShowDialog();
                    }
                    else if (position == 2) // HR
                    {
                        HR_Main fHR = new HR_Main();
                        fHR.ShowDialog();
                    }

                    this.Close();
                }
                else
                {
                    if (acc.LoginWithStatus(user,pass) == Account.LoginResult.NotApproved)
                    {
                        MessageBox.Show(
                                        "Tài khoản đúng nhưng chưa được Admin phê duyệt (valid = 0).\n\n" +
                                        "Hãy liên hệ Admin để bật valid = 1.",
                                        "Chưa được phê duyệt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Thông báo chung để bảo mật thông tin
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!",
                                        "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // LinkLabel dùng LinkClicked thay vì Click
        private void signup_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signup_form sg = new signup_form();
            sg.ShowDialog();
            this.Show();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // LinkLabel dùng LinkClicked thay vì Click
        private void forgetPassword_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassForm fpf = new ForgotPassForm();
            fpf.ShowDialog();
        }
    }
}
