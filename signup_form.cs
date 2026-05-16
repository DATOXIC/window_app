using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace window_app
{
    public partial class signup_form : Form
    {
        public signup_form()
        {
            InitializeComponent();

            // Tận dụng cơ chế tự động căn giữa Card từ login_form của bạn
            this.Resize += (s, e) => CenterCard();
            this.Load += (s, e) => CenterCard();

            // Đăng ký sự kiện nút bấm bằng code-behind để tránh mất liên kết
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            this.lnk_cancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_cancel_LinkClicked);
        }

        private void CenterCard()
        {
            cardPanel.Left = (this.ClientSize.Width - cardPanel.Width) / 2;
            cardPanel.Top = (this.ClientSize.Height - cardPanel.Height) / 2;
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox mới đã được chuẩn hóa
            string email = txt_email.Text.Trim();
            string user = txt_username.Text.Trim();
            string pass = txt_password.Text.Trim();
            string rePass = txt_repass.Text.Trim();

            // Kiểm tra không được để trống dữ liệu
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Email, Username và Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mật khẩu nhập lại có khớp hay không
            if (pass != rePass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Account acc = new Account(); // Khởi tạo lớp tài khoản
            try
            {
                if (acc.Register(user, pass, email)) // Gọi hàm đăng ký hệ thống
                {
                    MessageBox.Show("Đăng ký thành công! Vui lòng chờ Admin phê duyệt.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Dọn dẹp các TextBox sau khi đăng ký xong
                    txt_email.Clear();
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_repass.Clear();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại. Tên đăng nhập có thể đã tồn tại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnk_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); // Đóng form quay về giao diện Login
        }
    }
}