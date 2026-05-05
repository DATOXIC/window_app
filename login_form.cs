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

            myDB db = new myDB();
            try
            {
                string hashedInDB = db.GetHashedPassword(user);
                string hashedInput = db.HashPassword(pass);

                if (hashedInDB != null && hashedInDB == hashedInput)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            signup_form sg = new signup_form();
            sg.ShowDialog();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
