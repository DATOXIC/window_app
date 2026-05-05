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
            string user = textBox1.Text.Trim(); // Username[cite: 3]
            string pass = textBox2.Text.Trim(); // Password[cite: 3]
            string rePass = textBox3.Text.Trim(); // Retype password[cite: 3]

            // 1. Kiểm tra không được để trống
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Username và Password!");
                return;
            }

            // 2. Kiểm tra mật khẩu nhập lại có khớp không
            if (pass != rePass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }

            myDB db = new myDB();

            try
            {
                // 3. Kiểm tra trùng Username (Sử dụng hàm GetHashedPassword có sẵn)[cite: 6]
                if (db.GetHashedPassword(user) != null)
                {
                    MessageBox.Show("Username này đã tồn tại. Vui lòng đặt tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 4. Nếu hợp lệ, tiến hành mã hóa và đăng ký
                string hashedPass = db.HashPassword(pass); // Mã hóa SHA256[cite: 6]

                if (db.AddUser(user, hashedPass))
                {
                    MessageBox.Show("Đăng ký thành công! Vui lòng chờ Admin phê duyệt tài khoản.", "Thành công");
                    this.Close(); // Đóng form sau khi xong[cite: 1]
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }
    }
}
