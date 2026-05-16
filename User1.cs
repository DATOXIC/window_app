using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace window_app
{
    public partial class User1 : UserControl
    {
        
        private readonly Account acc = new Account();
        public User1()
        {
            InitializeComponent();
        }
        public void RefreshAccountGrid()
        {
            try
            {
                DataTable dt;

                // Lọc theo vai trò nếu có chọn
                if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() != "Tất cả")
                {
                    string selectedFilter = comboBox2.SelectedItem.ToString();
                    if (TryMapRoleToPosition(selectedFilter, out int posFilter))
                    {
                        dt = acc.GetPendingAccounts(posFilter);
                    }
                    else
                    {
                        dt = acc.GetPendingAccounts();
                    }
                }
                else
                {
                    dt = acc.GetPendingAccounts();
                }

                // Gán vào DataGridView
                Display_Account_View.DataSource = dt;
                Display_Account_View.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Display_Account_View.MultiSelect = true;
                Display_Account_View.ReadOnly = true;

                // Chỉnh sửa tiêu đề cột cho chuyên nghiệp
                if (Display_Account_View.Columns["username"] != null)
                    Display_Account_View.Columns["username"].HeaderText = "Tên đăng nhập";

                if (Display_Account_View.Columns["email"] != null)
                    Display_Account_View.Columns["email"].HeaderText = "Email đăng ký";

                if (Display_Account_View.Columns["position"] != null)
                    Display_Account_View.Columns["position"].HeaderText = "Quyền hạn dự kiến";

                if (Display_Account_View.Columns["valid"] != null)
                    Display_Account_View.Columns["valid"].HeaderText = "Trạng thái";

                // Để bảng tự dãn rộng hết cỡ
                Display_Account_View.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách tài khoản: " + ex.Message);
            }
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.BringToFront();

            // Mặc định chọn "Tất cả" cho bộ lọc
            if (comboBox2.Items.Count > 0 && comboBox2.SelectedIndex == -1)
                comboBox2.SelectedIndex = 0;

            RefreshAccountGrid();
        }

        // Lọc danh sách theo vai trò
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAccountGrid();
        }

        private void sellect_all_button_Click(object sender, EventArgs e)
        {
            Display_Account_View.SelectAll();
        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem đã chọn Role chưa
            if (confirm_role_combobox.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò trước khi phê duyệt!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedRole = confirm_role_combobox.SelectedItem.ToString();
            if (!TryMapRoleToPosition(selectedRole, out int selectedPosition))
            {
                MessageBox.Show("Vai trò không hợp lệ. Vui lòng chọn lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRows = GetSelectedRows();
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần phê duyệt!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int successCount = 0;

            foreach (DataGridViewRow row in selectedRows)
            {
                if (row.Cells["username"] != null && row.Cells["username"].Value != null)
                {
                    string username = row.Cells["username"].Value.ToString();
                    if (acc.UpdateStatus(username, selectedPosition, 1))
                    {
                        successCount++;
                    }
                }
            }

            if (successCount > 0)
            {
                MessageBox.Show($"Đã phê duyệt thành công {successCount} tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshAccountGrid();
            }
            else
            {
                MessageBox.Show("Không có tài khoản nào được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Từ chối tài khoản — xóa khỏi hệ thống
        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRows = GetSelectedRows();
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần từ chối!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc muốn từ chối {selectedRows.Count} tài khoản đã chọn?\nTài khoản bị từ chối sẽ bị xóa khỏi hệ thống.",
                "Xác nhận từ chối",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            int successCount = 0;

            foreach (DataGridViewRow row in selectedRows)
            {
                if (row.Cells["username"] != null && row.Cells["username"].Value != null)
                {
                    string username = row.Cells["username"].Value.ToString();
                    if (acc.RejectAccount(username))
                    {
                        successCount++;
                    }
                }
            }

            if (successCount > 0)
            {
                MessageBox.Show($"Đã từ chối và xóa {successCount} tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshAccountGrid();
            }
            else
            {
                MessageBox.Show("Không có tài khoản nào bị xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<DataGridViewRow> GetSelectedRows()
        {
            var result = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in Display_Account_View.SelectedRows)
            {
                if (!row.IsNewRow)
                    result.Add(row);
            }

            if (result.Count > 0) return result;

            foreach (DataGridViewCell cell in Display_Account_View.SelectedCells)
            {
                if (cell?.OwningRow != null && !cell.OwningRow.IsNewRow && !result.Contains(cell.OwningRow))
                    result.Add(cell.OwningRow);
            }

            return result;
        }

        private bool TryMapRoleToPosition(string role, out int position)
        {
            switch (role?.Trim().ToLowerInvariant())
            {
                case "admin":
                    position = 0;
                    return true;
                case "teacher":
                    position = 2;
                    return true;
                case "student":
                    position = 1;
                    return true;
                case "hr":
                    position = 3;
                    return true;
                default:
                    position = -1;
                    return false;
            }
        }
    }
}
