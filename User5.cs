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
            // Kiểm tra đã chọn dòng nào chưa
            if (course_display.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khóa học cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin từ dòng được chọn
            int courseId = Convert.ToInt32(course_display.SelectedRows[0].Cells[0].Value);
            string courseName = course_display.SelectedRows[0].Cells[1].Value.ToString();

            // Xác nhận trước khi xóa
            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa khóa học \"{courseName}\"?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                if (course.Delete(courseId))
                {
                    MessageBox.Show("Xóa khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    User5_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa khóa học thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
