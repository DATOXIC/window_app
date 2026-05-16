using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace window_app
{
    public partial class miniUser5 : Form
    {
        Course cour = new Course();
        public miniUser5()
        {
            InitializeComponent();
        }

        private void addCourse_bt_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra không để trống
            if (string.IsNullOrWhiteSpace(courseName_tb.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khóa học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                courseName_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(coursePeriod_tb.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiết học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                coursePeriod_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(courseScript_tb.Text))
            {
                MessageBox.Show("Vui lòng nhập mô tả khóa học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                courseScript_tb.Focus();
                return;
            }

            // 2. Kiểm tra số tiết hợp lệ (phải là số nguyên dương)
            int period;
            if (!int.TryParse(coursePeriod_tb.Text.Trim(), out period) || period <= 0)
            {
                MessageBox.Show("Số tiết học phải là số nguyên dương!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                coursePeriod_tb.Focus();
                return;
            }

            // 3. Kiểm tra trùng tên khóa học
            string courseName = courseName_tb.Text.Trim();
            if (cour.CheckCourseName(courseName))
            {
                MessageBox.Show("Tên khóa học đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                courseName_tb.Focus();
                return;
            }

            // 4. Gán thuộc tính và thực hiện thêm
            cour.Id = cour.GetCount() + 1;
            cour.Label = courseName;
            cour.Period = period;
            cour.Description = courseScript_tb.Text.Trim();

            if (cour.Insert())
            {
                MessageBox.Show("Thêm khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Đóng form và báo cho User5 biết đã thêm thành công
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm khóa học thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
