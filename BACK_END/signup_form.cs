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
            this.createAccount_button.Click += new System.EventHandler(this.createAccount_button_Click);
        }
        private void createAccount_button_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox và loại bỏ khoảng trắng
            string user = textBox1.Text.Trim(); // Username
            string pass = textBox2.Text.Trim(); // Password
            string rePass = textBox3.Text.Trim(); // Retype password
            string email = textBox4.Text.Trim(); // Email 

            // Kiểm tra không được để trống
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass)|| string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email, Username và Password!");
                return;
            }

            // Kiểm tra mật khẩu nhập lại có khớp không
            if (pass != rePass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }

            Account acc = new Account();
            try
            {
             
                if (acc.Register(user, pass, email))
                {
                    MessageBox.Show("Đăng ký thành công! Vui lòng chờ Admin phê duyệt.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Dọn dẹp các TextBox sau khi đăng ký xong
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
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
    private void BacktoLogInBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
