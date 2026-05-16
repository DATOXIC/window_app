using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace window_app
{
    public partial class User6 : UserControl
    {
        private readonly Teacher teacher = new Teacher();
        private readonly Account acc = new Account();
        private readonly myDB db = new myDB();

        public User6()
        {
            InitializeComponent();
        }

        private void User6_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            // Tải danh sách Khoa/Ngành từ bảng Majors
            DataTable dtMajors = GetAllMajors();
            if (dtMajors != null)
            {
                DataRow allRow = dtMajors.NewRow();
                allRow["MajorCode"] = "";
                allRow["MajorName"] = "Tất cả";
                dtMajors.Rows.InsertAt(allRow, 0);

                cboDepartment.DataSource = dtMajors;
                cboDepartment.DisplayMember = "MajorName";
                cboDepartment.ValueMember = "MajorCode";
                cboDepartment.SelectedIndex = 0;
            }

            // Đăng ký sự kiện lọc
            cboDepartment.SelectedIndexChanged += Filter_SelectedIndexChanged;

            // Tải dữ liệu ban đầu
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
                    db.closeConnection();
                }
                catch (Exception) { db.closeConnection(); }
            }
            return table;
        }

        private void LoadFilteredData()
        {
            string searchText = txtSearch.Text.Trim();
            string deptCode = cboDepartment.SelectedValue?.ToString() ?? "";

            DataTable dt = teacher.GetFilteredTeachers(
                string.IsNullOrEmpty(searchText) ? null : searchText,
                string.IsNullOrEmpty(deptCode) ? null : deptCode
            );

            teacher_display.DataSource = dt;

            // Đổi header tiếng Việt
            if (teacher_display.Columns["TeacherID"] != null)
            {
                teacher_display.Columns["TeacherID"].HeaderText = "Mã GV";
                teacher_display.Columns["TeacherID"].DefaultCellStyle.ForeColor = Color.FromArgb(41, 107, 191);
                teacher_display.Columns["TeacherID"].DefaultCellStyle.Font = new Font(teacher_display.Font, FontStyle.Bold);
            }
            if (teacher_display.Columns["FullName"] != null)
                teacher_display.Columns["FullName"].HeaderText = "Họ và Tên";

            if (teacher_display.Columns["Department"] != null)
                teacher_display.Columns["Department"].HeaderText = "Khoa";

            if (teacher_display.Columns["Email"] != null)
                teacher_display.Columns["Email"].HeaderText = "Email";

            if (teacher_display.Columns["Phone"] != null)
                teacher_display.Columns["Phone"].HeaderText = "SĐT";

            if (teacher_display.Columns["Gender"] != null)
                teacher_display.Columns["Gender"].HeaderText = "Giới tính";

            if (teacher_display.Columns["Dob"] != null)
                teacher_display.Columns["Dob"].HeaderText = "Ngày sinh";
        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFilteredData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadFilteredData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (teacher_display.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string teacherId = teacher_display.CurrentRow.Cells["TeacherID"].Value?.ToString();
            string fullName = teacher_display.CurrentRow.Cells["FullName"].Value?.ToString() ?? "";

            if (string.IsNullOrEmpty(teacherId))
            {
                MessageBox.Show("Không tìm thấy mã giảng viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa giảng viên:\n\n{fullName} ({teacherId})\n\nThao tác này sẽ xóa cả tài khoản đăng nhập.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                if (teacher.DeleteTeacher(teacherId))
                {
                    MessageBox.Show($"Đã xóa giảng viên {teacherId}.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFilteredData();
                }
                else
                {
                    MessageBox.Show("Thao tác thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (teacher_display.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần reset mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string teacherId = teacher_display.CurrentRow.Cells["TeacherID"].Value?.ToString();
            string fullName = teacher_display.CurrentRow.Cells["FullName"].Value?.ToString() ?? "";

            if (string.IsNullOrEmpty(teacherId))
            {
                MessageBox.Show("Không tìm thấy mã giảng viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm username từ bảng [Table] thông qua Teacher.Id
            string username = GetUsernameByTeacherId(teacherId);
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Không tìm thấy tài khoản của giảng viên này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc muốn reset mật khẩu cho:\n\n{fullName} ({teacherId})\n\nMật khẩu mới sẽ được đặt về = Username ({username}).",
                "Xác nhận Reset mật khẩu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                if (acc.ResetPassword(username, username))
                {
                    MessageBox.Show(
                        $"Đã reset mật khẩu cho {fullName}.\n\nMật khẩu mới: {username}",
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tìm username trong bảng [Table] thông qua Teacher.Id → [Table].id
        /// </summary>
        private string GetUsernameByTeacherId(string teacherId)
        {
            string sql = @"SELECT t2.username FROM Teacher t1 
                           INNER JOIN [Table] t2 ON t1.Id = t2.id 
                           WHERE t1.TeacherID = @tid";

            using (SqlCommand cmd = new SqlCommand(sql, db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@tid", teacherId);
                try
                {
                    db.openConnection();
                    object result = cmd.ExecuteScalar();
                    db.closeConnection();
                    return result?.ToString();
                }
                catch
                {
                    db.closeConnection();
                    return null;
                }
            }
        }
    }
}
