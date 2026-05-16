using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace window_app
{
    public partial class User5 : UserControl
    {
        Course course = new Course();
        public User5()
        {
            InitializeComponent();
        }

        private void User5_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = course.GetAllCourses();

                course_display.DataSource = dt;

                course_display.Columns[0].HeaderText = "MAMH";
                course_display.Columns[1].HeaderText = "Tên môn học";
                course_display.Columns[2].HeaderText = "Số tiết";
                course_display.Columns[3].HeaderText = "Mô tả";

                course_display.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nạp dữ liệu: " + ex.Message);
            }
        }

        private void remove_course_button_Click(object sender, EventArgs e)
        {

        }

        private void add_course_button_Click(object sender, EventArgs e)
        {
            miniUser5 mUser5 = new miniUser5();
            if (mUser5.ShowDialog() == DialogResult.OK)
            {
                // Reload danh sách sau khi thêm thành công
                User5_Load(sender, e);
            }
        }
    }
}
