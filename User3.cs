using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace window_app
{
    public partial class User3 : UserControl
    {
        private readonly myDB db = new myDB();
        private readonly Student stuLogic = new Student();
        public User3()
        {
            InitializeComponent();
        }

        private void UC_AddStudent_Load(object sender, EventArgs e)
        {
            // 1. Thiết lập năm hiện tại cho NumericUpDown
            numYear.Minimum = 2000;
            numYear.Maximum = 2100;
            numYear.Value = DateTime.Now.Year;

            // 2. Nạp dữ liệu ngành học từ database
            DataTable dtbMajors = getAllMajors();
            cboMajor.DataSource = dtbMajors;
            cboMajor.DisplayMember = "MajorName";
            cboMajor.ValueMember = "MajorCode";

            // 3. Đặt ngày sinh mặc định (18 tuổi)
            dtpDob.Value = DateTime.Now.AddYears(-18);
            rbMale.Checked = true;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // BƯỚC 1: Kiểm tra tính hợp lệ (Validation)
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            if (cboMajor.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn ngành học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMajor.Focus();
                return;
            }

            // BƯỚC 2: Thu thập dữ liệu từ các Control
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string majorCode = cboMajor.SelectedValue.ToString();
            int year = (int)numYear.Value;
            DateTime dob = dtpDob.Value;

            // Logic lấy giới tính từ RadioButton
            string sex = rbMale.Checked ? "Nam" : "Nữ";

            try
            {
                bool success = stuLogic.AddCandidateToAdmission(name, majorCode, year, email, phone, dob, sex, address);

                if (success)
                {
                    MessageBox.Show($"Đã thêm thí sinh {name} vào danh sách chờ phê duyệt!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Xóa trắng form
        private void btnCancelStudent_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

            // Đưa về giá trị mặc định
            if (cboMajor.Items.Count > 0) cboMajor.SelectedIndex = 0;
            numYear.Value = DateTime.Now.Year;
            dtpDob.Value = DateTime.Now.AddYears(-18);
            rbMale.Checked = true;

            txtName.Focus();
        }

        private DataTable getAllMajors()
        {
            string sql = "SELECT MajorCode, MajorName FROM Majors";
            SqlCommand command = new SqlCommand(sql, db.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            try
            {
                db.openConnection();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tải danh sách ngành: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
            return table;
        }
    }
}
