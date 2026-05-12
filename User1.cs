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
                // Lấy danh sách từ database
                DataTable dt = acc.GetPendingAccounts();

                // Gán vào DataGridView của bạn
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
                    Display_Account_View.Columns["valid"].HeaderText = "Chờ phê duyệt";

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
            RefreshAccountGrid();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("Vui lòng chọn vai trò (Role) trước khi duyệt!");
                return;
            }
            string selectedRole = confirm_role_combobox.SelectedItem.ToString();
            if (!TryMapRoleToPosition(selectedRole, out int selectedPosition))
            {
                MessageBox.Show("Vai trò không hợp lệ. Vui lòng chọn lại.");
                return;
            }

            var selectedRows = GetSelectedRows();
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng bôi đen dòng cần duyệt!");
                return;
            }

            int successCount = 0;

            foreach (DataGridViewRow row in selectedRows)
            {
                // 3. SỬA TÊN CỘT: Dùng "username" (khớp với Designer của bạn)
                if (row.Cells["username"] != null && row.Cells["username"].Value != null)
                {
                    string username = row.Cells["username"].Value.ToString();

                    // 4. CẬP NHẬT & TĂNG BIẾN ĐẾM
                    if (acc.UpdateStatus(username, selectedPosition, 1))
                    {
                        successCount++; // QUAN TRỌNG: Phải tăng biến này lên
                    }
                }
            }

            // 5. Thông báo kết quả
            if (successCount > 0)
            {
                MessageBox.Show($"Đã phê duyệt thành công {successCount} tài khoản.");
                RefreshAccountGrid(); // Nạp lại bảng để danh sách tự biến mất người đã duyệt
            }
            else
            {
                MessageBox.Show("Không có tài khoản nào được cập nhật. Hãy thử chọn lại các dòng cần duyệt.");
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
                default:
                    position = -1;
                    return false;
            }
        }
    }
}
