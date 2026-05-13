using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace window_app
{
    public class ChangePasswordForm : Form
    {
        private Label lblTitle;
        private Label lblOldPass, lblNewPass, lblConfirmPass;
        private TextBox txtOldPass, txtNewPass, txtConfirmPass;
        private Button btnSave, btnCancel;
        private Panel pnlHeader;

        public ChangePasswordForm()
        {
            InitUI();
        }

        private void InitUI()
        {
            // ── Form ──
            Text            = "Change Password";
            Size            = new Size(420, 340);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox     = false;
            MinimizeBox     = false;
            StartPosition   = FormStartPosition.CenterParent;
            BackColor       = Color.FromArgb(245, 248, 252);
            Font            = new Font("Segoe UI", 10F);

            // ── Header panel ──
            pnlHeader = new Panel
            {
                Dock      = DockStyle.Top,
                Height    = 56,
                BackColor = Color.FromArgb(55, 90, 130)
            };
            Controls.Add(pnlHeader);

            lblTitle = new Label
            {
                Text      = "🔒  Change Password",
                Dock      = DockStyle.Fill,
                Font      = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlHeader.Controls.Add(lblTitle);

            // ── Old Password ──
            lblOldPass = new Label
            {
                Text     = "Current Password",
                Location = new Point(30, 74),
                AutoSize = true,
                Font     = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(50, 70, 100)
            };
            Controls.Add(lblOldPass);

            txtOldPass = CreatePasswordBox(new Point(30, 97), 340);
            Controls.Add(txtOldPass);

            // ── New Password ──
            lblNewPass = new Label
            {
                Text     = "New Password",
                Location = new Point(30, 135),
                AutoSize = true,
                Font     = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(50, 70, 100)
            };
            Controls.Add(lblNewPass);

            txtNewPass = CreatePasswordBox(new Point(30, 158), 340);
            Controls.Add(txtNewPass);

            // ── Confirm Password ──
            lblConfirmPass = new Label
            {
                Text     = "Confirm New Password",
                Location = new Point(30, 196),
                AutoSize = true,
                Font     = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(50, 70, 100)
            };
            Controls.Add(lblConfirmPass);

            txtConfirmPass = CreatePasswordBox(new Point(30, 219), 340);
            Controls.Add(txtConfirmPass);

            // ── Buttons ──
            btnCancel = new Button
            {
                Text      = "Cancel",
                Size      = new Size(100, 36),
                Location  = new Point(160, 262),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(200, 210, 222),
                ForeColor = Color.FromArgb(50, 60, 80),
                Font      = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                Cursor    = Cursors.Hand
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click += (s, e) => Close();
            Controls.Add(btnCancel);

            btnSave = new Button
            {
                Text      = "Save",
                Size      = new Size(100, 36),
                Location  = new Point(270, 262),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(55, 90, 130),
                ForeColor = Color.White,
                Font      = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                Cursor    = Cursors.Hand
            };
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Click += BtnSave_Click;
            Controls.Add(btnSave);
        }

        private TextBox CreatePasswordBox(Point location, int width)
        {
            return new TextBox
            {
                Location      = location,
                Size          = new Size(width, 30),
                Font          = new Font("Segoe UI", 10.5F),
                UseSystemPasswordChar = true,
                BorderStyle   = BorderStyle.FixedSingle,
                BackColor     = Color.White
            };
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string oldPass     = txtOldPass.Text;
            string newPass     = txtNewPass.Text;
            string confirmPass = txtConfirmPass.Text;

            // Validation
            if (string.IsNullOrWhiteSpace(oldPass) || string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(confirmPass))
            {
                MessageBox.Show("Please fill in all fields.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("New password and confirmation do not match.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPass.Focus();
                return;
            }

            if (newPass.Length < 6)
            {
                MessageBox.Show("New password must be at least 6 characters.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPass.Focus();
                return;
            }

            if (oldPass == newPass)
            {
                MessageBox.Show("New password must be different from the current password.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPass.Focus();
                return;
            }

            try
            {
                var acc = new Account();
                string username = Globals.GlobalUsername;

                // Verify old password
                var loginResult = acc.LoginWithStatus(username, oldPass);
                if (loginResult != Account.LoginResult.Success)
                {
                    MessageBox.Show("Current password is incorrect.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPass.Focus();
                    return;
                }

                // Update password
                bool updated = acc.ResetPassword(username, newPass);
                if (updated)
                {
                    MessageBox.Show("Password changed successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to update password. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "System Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
