namespace window_app
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
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
                // 2. Login + phân biệt đúng sai / chưa phê duyệt
                var loginStatus = acc.LoginWithStatus(user, pass);
                if (loginStatus == Account.LoginResult.Success)
                {
                    // 3. Nếu đăng nhập thành công, lấy thêm thông tin quyền hạn và MSSV
                    int position = acc.GetUserPosition(user);
                    //string mssv = acc.GetStudentID(user);

                    // 4. Lưu vào biến toàn cục để các Form sau (như f_Main) có thể sử dụng
                    // Giả sử bạn lưu MSSV vào Globals để hiện thông tin cá nhân sau này
                    //if (!string.IsNullOrEmpty(mssv))
                    //{
                    //    // Globals.SetGlobalUserId(int.Parse(mssv)); 
                    //}

                    MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5. Phân quyền và chuyển Form
                    this.Hide(); // Ẩn form Login đi

                    if (position == 0) // Admin
                    {
                        // MainFormAdmin fAdmin = new MainFormAdmin();
                        // fAdmin.ShowDialog();
                    }
                    else if (position == 1) // Sinh viên
                    {
                        // MainFormStudent fStudent = new MainFormStudent();
                        // fStudent.ShowDialog();
                    }
                    else if (position == 2) // HR
                    {
                        // MainFormHR fHR = new MainFormHR();
                        // fHR.ShowDialog();
                    }

                    this.Close(); // Đóng hẳn form login khi user thoát khỏi form chính
                }
                else
                {
                    if (loginStatus == Account.LoginResult.NotApproved)
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

        private void signup_button_Click(object sender, EventArgs e)
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
        private void forgetPassword_button_Click(object sender, EventArgs e)
        {
            // Khởi tạo instance của ForgotPassForm đã có trong project
            ForgotPassForm fpf = new ForgotPassForm();
            
            // Hiển thị form dưới dạng hội thoại (người dùng phải đóng form này mới quay lại được login)
            fpf.ShowDialog(); 
        }
    }
}
