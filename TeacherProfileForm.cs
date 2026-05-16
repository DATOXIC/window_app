using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace window_app
{
    /// <summary>
    /// Form hiện ra khi giáo viên đăng nhập lần đầu và chưa có profile.
    /// Giáo viên điền đầy đủ thông tin → InsertFullTeacher() → DialogResult.OK → Teacher_Main mở.
    /// Nếu giáo viên chọn thoát mà chưa điền → cảnh báo → chọn "Ở lại" hoặc "Thoát" (DialogResult.Cancel).
    /// </summary>
    public partial class TeacherProfileForm : Form
    {
        private readonly int _accountId;
        private readonly Teacher _teacher  = new Teacher();
        private readonly myDB   _db        = new myDB();

        // Cờ theo dõi: giáo viên đã bấm "Hoàn thành" thành công chưa
        private bool _profileSaved = false;

        public TeacherProfileForm(int accountId)
        {
            _accountId = accountId;
            InitializeComponent();
            // 1. Đăng ký sự kiện cho Form (Quan trọng nhất để sinh ID và Load dữ liệu)
            this.Load += new System.EventHandler(this.TeacherProfileForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherProfileForm_FormClosing);

            // 2. Đăng ký sự kiện cho các nút bấm (Nếu bạn chưa làm ở bước trước)
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        }

        // ── Load ──────────────────────────────────────────────────────
        private void TeacherProfileForm_Load(object sender, EventArgs e)
        {
            // Sinh mã GV tự động
            txtTeacherId.Text = _teacher.GenerateNextTeacherID();

            // Tải danh sách Khoa/Ngành
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            string sql = "SELECT MajorCode, MajorName FROM Majors ORDER BY MajorName";
            DataTable dt = new DataTable();
            dt.Columns.Add("MajorCode", typeof(string));
            dt.Columns.Add("MajorName", typeof(string));

            using (SqlCommand cmd = new SqlCommand(sql, _db.getConnection()))
            {
                try
                {
                    _db.openConnection();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                        adp.Fill(dt);
                    _db.closeConnection();
                }
                catch { _db.closeConnection(); }
            }

            cboDept.DataSource    = dt;
            cboDept.DisplayMember = "MajorName";
            cboDept.ValueMember   = "MajorCode";
            if (cboDept.Items.Count > 0) cboDept.SelectedIndex = 0;
        }

        // ── Hoàn thành ────────────────────────────────────────────────
        private void btnComplete_Click(object sender, EventArgs e)
        {
            // 1. Validate
            if (!ValidateFields()) return;

            string teacherId = txtTeacherId.Text.Trim();
            string fname     = txtFname.Text.Trim();
            string lname     = txtLname.Text.Trim();
            string dept      = cboDept.SelectedValue?.ToString() ?? "";
            string email     = txtEmail.Text.Trim();
            string phone     = txtPhone.Text.Trim();
            DateTime dob     = dtpDob.Value.Date;
            string gender    = cboGender.SelectedItem?.ToString() ?? "Nam";

            // 2. Lưu vào DB
            bool ok = _teacher.InsertFullTeacher(
                _accountId, teacherId, fname, lname, dept, email, phone, dob, gender);

            if (ok)
            {
                _profileSaved = true;
                MessageBox.Show(
                    $"Hồ sơ đã được lưu thành công!\nMã giảng viên của bạn: {teacherId}",
                    "Hoàn thành",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Lưu hồ sơ thất bại. Vui lòng thử lại hoặc liên hệ Admin.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ── Validate ──────────────────────────────────────────────────
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtFname.Text))
            {
                ShowWarning("Vui lòng nhập Họ.", txtFname);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLname.Text))
            {
                ShowWarning("Vui lòng nhập Tên.", txtLname);
                return false;
            }
            if (cboDept.SelectedIndex < 0)
            {
                ShowWarning("Vui lòng chọn Khoa/Bộ môn.", cboDept);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ShowWarning("Vui lòng nhập Email.", txtEmail);
                return false;
            }

            // Validate email đơn giản
            try
            {
                var addr = new System.Net.Mail.MailAddress(txtEmail.Text.Trim());
                if (addr.Address != txtEmail.Text.Trim())
                {
                    ShowWarning("Email không hợp lệ.", txtEmail);
                    return false;
                }
            }
            catch
            {
                ShowWarning("Email không hợp lệ.", txtEmail);
                return false;
            }

            // Validate SĐT (tùy chọn, nhưng nếu có thì phải đúng định dạng)
            string phone = txtPhone.Text.Trim();
            if (!string.IsNullOrEmpty(phone))
            {
                System.Text.RegularExpressions.Regex rgx =
                    new System.Text.RegularExpressions.Regex(@"^0\d{9}$");
                if (!rgx.IsMatch(phone))
                {
                    ShowWarning("Số điện thoại không hợp lệ (phải bắt đầu bằng 0, đủ 10 chữ số).", txtPhone);
                    return false;
                }
            }

            return true;
        }

        private void ShowWarning(string message, Control focusControl)
        {
            MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focusControl?.Focus();
        }

        // ── Thoát ─────────────────────────────────────────────────────
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Kích hoạt FormClosing → sẽ hiện cảnh báo nếu chưa lưu
            this.Close();
        }

        // ── Chặn đóng nếu chưa lưu ───────────────────────────────────
        private void TeacherProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu đã lưu thành công → cho phép đóng bình thường
            if (_profileSaved) return;

            // Hiện cảnh báo
            DialogResult choice = MessageBox.Show(
                "Bạn chưa hoàn thành hồ sơ giảng viên.\n\n" +
                "• Chọn \"Ở lại\" để tiếp tục điền thông tin.\n" +
                "• Chọn \"Thoát\" để quay về màn hình đăng nhập.",
                "Chưa hoàn thành hồ sơ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);

            // Button1 = Yes = "Ở lại"
            if (choice == DialogResult.Yes)
            {
                // Hủy đóng → giáo viên ở lại form
                e.Cancel = true;
            }
            else
            {
                // Thoát → DialogResult.Cancel để login_form biết cần show lại
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
