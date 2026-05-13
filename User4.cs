using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
//
namespace window_app
{
    public partial class User4 : UserControl
    {
        private readonly Student stu = new Student();
        private readonly myDB db = new myDB();

        public User4()
        {
            InitializeComponent();
            this.Load += User4_Load;
        }

        private void User4_Load(object sender, EventArgs e)
        {
            this.Load -= User4_Load; // Tránh chạy sự kiện 2 lần nếu Designer đã tự đăng ký
            this.Dock = DockStyle.Fill;

            // 1. Tải danh sách bộ lọc Năm học
            cboYear.Items.Clear();
            cboYear.Items.Add("Tất cả");
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear - 5; i <= currentYear + 1; i++)
            {
                cboYear.Items.Add(i.ToString());
            }
            cboYear.SelectedIndex = 0;

            // 2. Tải danh sách bộ lọc Khoa/Ngành từ DB
            DataTable dtMajors = GetAllMajors();
            if (dtMajors != null)
            {
                DataRow allRow = dtMajors.NewRow();
                allRow["MajorCode"] = "";
                allRow["MajorName"] = "Tất cả";
                dtMajors.Rows.InsertAt(allRow, 0);

                cboMajor.DataSource = dtMajors;
                cboMajor.DisplayMember = "MajorName";
                cboMajor.ValueMember = "MajorCode";
                cboMajor.SelectedIndex = 0;
            }

            // Đăng ký sự kiện thay đổi lựa chọn để lọc trực tiếp DataGridView
            cboYear.SelectedIndexChanged += Filter_SelectedIndexChanged;
            cboMajor.SelectedIndexChanged += Filter_SelectedIndexChanged;

            // 3. Tải dữ liệu mặc định ban đầu (Hiển thị tất cả)
            LoadFilteredData();
        }

        private DataTable GetAllMajors()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MajorCode", typeof(string));
            table.Columns.Add("MajorName", typeof(string));

            string sql = "SELECT MajorCode, MajorName FROM Majors";
            using (SqlCommand cmd = new SqlCommand(sql, db.getConnection()))
            {
                try
                {
                    db.openConnection();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
                catch (Exception) { /* Bỏ qua lỗi để không crash ứng dụng nếu bảng Majors chưa có */ }
                finally
                {
                    db.closeConnection();
                }
            }
            return table;
        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFilteredData();
        }

        private void LoadFilteredData()
        {
            try
            {
                string selectedYear = "";
                if (cboYear.SelectedIndex > 0 && cboYear.SelectedItem != null)
                {
                    selectedYear = cboYear.SelectedItem.ToString();
                }

                string selectedMajor = "";
                if (cboMajor.SelectedIndex > 0 && cboMajor.SelectedValue != null)
                {
                    selectedMajor = cboMajor.SelectedValue.ToString();
                }

                DataTable dt = acc.GetFilteredStudentAccounts(selectedYear, selectedMajor);
                if (dt != null)
                {
                    // Xóa sạch các cột cũ nếu có và bật tính năng tự động tạo cột từ DataTable
                    student_account_display.DataSource = null;
                    student_account_display.Columns.Clear();
                    student_account_display.AutoGenerateColumns = true;

                    // Cài đặt thuộc tính cần thiết cho DataGridView
                    student_account_display.DataSource = dt;
                    student_account_display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    student_account_display.MultiSelect = false;
                    student_account_display.ReadOnly = true;
                    student_account_display.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Đổi tên các cột
                    if (student_account_display.Columns["Username"] != null)
                        student_account_display.Columns["Username"].HeaderText = "MSSV";

                    if (student_account_display.Columns["Email"] != null)
                        student_account_display.Columns["Email"].HeaderText = "Email";

                    if (student_account_display.Columns["FullName"] != null)
                        student_account_display.Columns["FullName"].HeaderText = "Họ và Tên";

                    if (student_account_display.Columns["MajorCode"] != null)
                        student_account_display.Columns["MajorCode"].HeaderText = "Mã ngành";

                    if (student_account_display.Columns["EnrollmentYear"] != null)
                        student_account_display.Columns["EnrollmentYear"].HeaderText = "Năm học";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (student_account_display.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên.");
                return;
            }

            string username =
                student_account_display.CurrentRow.Cells["Username"].Value.ToString();

            bool result = stu.MoveBackToAdmission(username);

            if (result)
            {
                MessageBox.Show("Đã xóa");

                LoadFilteredData();
            }
            else
            {
                MessageBox.Show("Thao tác thất bại.");
            }
        }
    }
}
