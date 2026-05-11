using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace window_app
{
    public partial class User2 : UserControl
    {
        public User2()
        {
            InitializeComponent();
        }
        public void RefreshAdmissionGrid()
        {
            try
            {
                // Lấy danh sách từ database
                Student stu = new Student();
                DataTable dt = stu.GetPendingAdmissions();

                // Gán vào DataGridView của bạn
                admission_data_display.DataSource = dt;
                admission_data_display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                admission_data_display.MultiSelect = true;
                admission_data_display.ReadOnly = true;

                // Chỉnh sửa tiêu đề cột cho chuyên nghiệp
                if (admission_data_display.Columns["CandidateID"] != null)
                    admission_data_display.Columns["CandidateID"].HeaderText = "Mã hồ sơ";

                if (admission_data_display.Columns["FullName"] != null)
                    admission_data_display.Columns["FullName"].HeaderText = "Họ và Tên";

                if (admission_data_display.Columns["Email"] != null)
                    admission_data_display.Columns["Email"].HeaderText = "Email";

                if (admission_data_display.Columns["MajorCode"] != null)
                    admission_data_display.Columns["MajorCode"].HeaderText = "Mã ngành";

                if (admission_data_display.Columns["EnrollmentYear"] != null)
                    admission_data_display.Columns["EnrollmentYear"].HeaderText = "Năm học";

                if (admission_data_display.Columns["Dob"] != null)
                    admission_data_display.Columns["Dob"].HeaderText = "Ngày sinh";

                if (admission_data_display.Columns["Gender"] != null)
                    admission_data_display.Columns["Gender"].HeaderText = "Giới tính";

                // Để bảng tự dãn rộng hết cỡ
                admission_data_display.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách tài khoản: " + ex.Message);
            }
        }

        private void User2_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.BringToFront();
            RefreshAdmissionGrid();
        }

        private void sellect_all_button_Click(object sender, EventArgs e)
        {
            admission_data_display.SelectAll();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (admission_data_display.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một thí sinh để phê duyệt!", "Thông báo");
                return;
            }

            try
            {
                DataGridViewRow row = admission_data_display.CurrentRow;

                // Trích xuất thông tin (Bỏ phần xử lý ảnh)
                string cid = row.Cells["CandidateID"].Value.ToString();
                string fullName = row.Cells["FullName"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                string majorCode = row.Cells["MajorCode"].Value.ToString();
                int year = Convert.ToInt32(row.Cells["EnrollmentYear"].Value);
                DateTime dob = Convert.ToDateTime(row.Cells["Dob"].Value);
                string gender = row.Cells["Gender"].Value.ToString();
                string phone = row.Cells["Phone"].Value.ToString();
                string address = row.Cells["Address"].Value.ToString();

                Student student = new Student();

                DialogResult result = MessageBox.Show($"Xác nhận phê duyệt cho: {fullName}?",
                                                    "Xác nhận", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Gọi hàm không có tham số picture
                    if (student.AutoEnrollStudent(cid, fullName, email, majorCode, year, dob, gender, phone, address))
                    {
                        MessageBox.Show("Phê duyệt thành công!");
                        RefreshAdmissionGrid(); // Tải lại bảng để cập nhật danh sách
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi thực hiện phê duyệt.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chi tiết lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
