using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
                admission_data_display.Columns["ProvisionalMSSV"].HeaderText = "MSSV Dự Kiến";
                admission_data_display.Columns["ProvisionalMSSV"].DefaultCellStyle.ForeColor = Color.Blue;
                admission_data_display.Columns["ProvisionalMSSV"].DefaultCellStyle.Font = new Font(admission_data_display.Font, FontStyle.Bold);
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
            try
            {
                // 1. Kiểm tra ảnh có trống không
                if (pictureboxStudent.Image == null)
                {
                    MessageBox.Show("Vui lòng chọn ảnh đại diện cho sinh viên trước khi phê duyệt!", "Thông báo");
                    return;
                }

                // 2. Kiểm tra xem có sinh viên nào được chọn trong bảng không
                if (admission_data_display.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một sinh viên trong danh sách!", "Thông báo");
                    return;
                }

                // 3. Xử lý ảnh an toàn
                using (MemoryStream ms = new MemoryStream())
                {
                    // Sử dụng định dạng chuẩn (ví dụ Png) thay vì RawFormat để tránh lỗi định dạng
                    pictureboxStudent.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
                    foreach (DataGridViewRow row in admission_data_display.SelectedRows)
                    {
                        // Kiểm tra xem hàng có hợp lệ không (tránh hàng trống cuối bảng)
                        if (row.Cells["CandidateID"].Value != null)
                        {
                            selectedRows.Add(row);
                        }
                    }

                    if (selectedRows.Count > 0)
                    {
                        Student stu = new Student();
                        if (stu.ApproveBatchStudents(selectedRows, ms))
                        {
                            MessageBox.Show("Phê duyệt thành công!");
                            RefreshAdmissionGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chi tiết: " + ex.Message);
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Select Image(*.jpg;*.png)|*.jpg;*.png";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureboxStudent.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
