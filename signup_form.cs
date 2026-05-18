using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
                // if(!ValidatePasswordStrength(pass)) return; // kiểm tra
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

        /// <summary>
        /// Hàm kiểm tra độ mạnh mật khẩu
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool ValidatePasswordStrength(string password)
        {
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            
            if (!Regex.IsMatch(password, passwordPattern))
            {
                MessageBox.Show("Mật khẩu không đủ độ bảo mật an toàn!\n\nYêu cầu:\n" +
                                "- Phải dài tối thiểu từ 8 ký tự trở lên.\n" +
                                "- Phải chứa ít nhất 1 chữ cái viết HOA.\n" +
                                "- Phải chứa ít nhất 1 chữ cái viết thường.\n" +
                                "- Phải chứa ít nhất 1 chữ số.\n" +
                                "- Phải chứa ít nhất 1 ký tự đặc biệt (@, $, !, %, *, ?, &).", 
                                "Mật khẩu yếu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Mật khẩu không hợp lệ
            }
            return true; // Mật khẩu hợp lệ
        }

        private void lnk_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); // Đóng form quay về giao diện Login
        }
    }
}