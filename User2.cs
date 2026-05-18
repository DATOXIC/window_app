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
        private readonly Student stu = new Student();
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

                // Gán vào DataGridView
                admission_data_display.DataSource = dt;
                admission_data_display.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                admission_data_display.MultiSelect = true;
                admission_data_display.ReadOnly = true;

                if (admission_data_display.Columns["ProvisionalMSSV"] != null)
                {
                    admission_data_display.Columns["ProvisionalMSSV"].HeaderText = "MSSV Dự Kiến";
                    admission_data_display.Columns["ProvisionalMSSV"].DefaultCellStyle.ForeColor = Color.FromArgb(41, 107, 191);
                    admission_data_display.Columns["ProvisionalMSSV"].DefaultCellStyle.Font = new Font(admission_data_display.Font, FontStyle.Bold);
                }

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

                admission_data_display.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Cập nhật thống kê
                UpdateStats(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cập nhật panel thống kê nhanh từ DataTable đã load
        /// </summary>
        private void UpdateStats(DataTable dt)
        {
            // Tổng số thí sinh
            int total = dt.Rows.Count;
            lblTotalCount.Text = total.ToString();

            // Xóa các label cũ trong statsDetails
            statsDetails.Controls.Clear();

            if (total == 0)
            {
                Label emptyLabel = new Label
                {
                    Text = "Không có thí sinh nào.",
                    Font = new Font("Segoe UI", 8.5F, FontStyle.Italic),
                    ForeColor = Color.FromArgb(150, 160, 175),
                    AutoSize = true,
                    Dock = DockStyle.Top,
                    Padding = new Padding(0, 5, 0, 0)
                };
                statsDetails.Controls.Add(emptyLabel);
                return;
            }

            // Đếm theo ngành (MajorCode)
            var majorGroups = new Dictionary<string, int>();
            foreach (DataRow row in dt.Rows)
            {
                string major = row["MajorCode"]?.ToString() ?? "N/A";
                if (majorGroups.ContainsKey(major))
                    majorGroups[major]++;
                else
                    majorGroups[major] = 1;
            }

            // Tạo label cho từng ngành (thêm từ dưới lên vì Dock.Top ngược)
            var sorted = new List<KeyValuePair<string, int>>(majorGroups);
            sorted.Sort((a, b) => b.Value.CompareTo(a.Value)); // Sắp giảm dần

            for (int i = sorted.Count - 1; i >= 0; i--)
            {
                var kvp = sorted[i];
                Panel row = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 24,
                    BackColor = Color.White
                };

                Label lblMajor = new Label
                {
                    Text = $"Ngành {kvp.Key}",
                    Font = new Font("Segoe UI", 8.5F),
                    ForeColor = Color.FromArgb(70, 80, 100),
                    AutoSize = true,
                    Dock = DockStyle.Left,
                    Padding = new Padding(0, 3, 0, 0)
                };

                Label lblCount = new Label
                {
                    Text = kvp.Value.ToString(),
                    Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(41, 107, 191),
                    AutoSize = true,
                    Dock = DockStyle.Right,
                    Padding = new Padding(0, 3, 0, 0)
                };

                row.Controls.Add(lblCount);
                row.Controls.Add(lblMajor);
                statsDetails.Controls.Add(row);
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

        private async void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có sinh viên nào được chọn không
                if (admission_data_display.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một sinh viên trong danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<PendingStudentDTO> pendingStudents = new List<PendingStudentDTO>();
                foreach (DataGridViewRow row in admission_data_display.SelectedRows)
                {
                    if (row.Cells["CandidateID"].Value != null)
                    {
                        pendingStudents.Add(new PendingStudentDTO
                        {
                            CandidateID = row.Cells["CandidateID"].Value.ToString().Trim(),
                            FullName = row.Cells["FullName"].Value.ToString().Trim(),
                            MajorCode = row.Cells["MajorCode"].Value.ToString().Trim(),
                            Email = row.Cells["Email"].Value.ToString().Trim(),
                            EnrollmentYear = Convert.ToInt32(row.Cells["EnrollmentYear"].Value),
                            Phone = row.Cells["Phone"].Value?.ToString() ?? "",
                            Address = row.Cells["Address"].Value?.ToString() ?? "",
                            Gender = row.Cells["Gender"].Value?.ToString() ?? "",
                            Dob = Convert.ToDateTime(row.Cells["Dob"].Value)
                        });
                    }
                }

                if (pendingStudents.Count > 0)
                {
                    DialogResult confirm = MessageBox.Show(
                        $"Bạn có chắc muốn phê duyệt {pendingStudents.Count} thí sinh?",
                        "Xác nhận phê duyệt",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirm != DialogResult.Yes) return;

                    Student stu = new Student();
                    if (await stu.ApproveBatchStudents(pendingStudents, null))
                    {
                        MessageBox.Show($"Phê duyệt thành công {pendingStudents.Count} thí sinh!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshAdmissionGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Từ chối thí sinh — xóa khỏi AdmissionList
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (admission_data_display.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một thí sinh cần từ chối!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int count = admission_data_display.SelectedRows.Count;
                DialogResult confirm = MessageBox.Show(
                    $"Bạn có chắc muốn từ chối {count} thí sinh?\nThí sinh bị từ chối sẽ bị xóa khỏi danh sách tuyển sinh.",
                    "Xác nhận từ chối",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                int successCount = 0;
                Student stuReject = new Student();

                foreach (DataGridViewRow row in admission_data_display.SelectedRows)
                {
                    if (row.Cells["CandidateID"].Value != null)
                    {
                        string candidateId = row.Cells["CandidateID"].Value.ToString().Trim();
                        if (stuReject.RejectCandidate(candidateId))
                        {
                            successCount++;
                        }
                    }
                }

                if (successCount > 0)
                {
                    MessageBox.Show($"Đã từ chối {successCount} thí sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshAdmissionGrid();
                }
                else
                {
                    MessageBox.Show("Không có thí sinh nào bị xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
