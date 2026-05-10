using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace window_app
{
    public partial class ForgotPassForm : Form
    {
        private readonly Account _account = new Account();
        private EmailService _emailService;

        private string _currentOtp;
        private DateTime _otpCreatedAt;
        private string _currentUsername;
        private int _otpAttempts;
        private const int MaxOtpAttempts = 3;
        private const int OtpExpiryMinutes = 5;

        private System.Windows.Forms.Timer _countdownTimer;
        private int _remainingSeconds;

        public ForgotPassForm()
        {
            InitializeComponent();
        }

        private void ForgotPassForm_Load(object sender, EventArgs e)
        {
            ShowStep(1);
        }

        // ============ ĐIỀU HƯỚNG BƯỚC ============

        private void ShowStep(int step)
        {
            pnlStep1.Visible = step == 1;
            pnlStep2.Visible = step == 2;
            pnlStep3.Visible = step == 3;

            switch (step)
            {
                case 1:
                    lblSubtitle.Text = "Enter your username to receive OTP";
                    txtUsername.Focus();
                    break;
                case 2:
                    lblSubtitle.Text = "Enter the OTP code sent to your email";
                    txtOtp.Clear();
                    txtOtp.Focus();
                    break;
                case 3:
                    lblSubtitle.Text = "Create your new password";
                    txtNewPass.Clear();
                    txtConfirmPass.Clear();
                    txtNewPass.Focus();
                    break;
            }
        }

        // ============ SINH MÃ OTP ============

        private string GenerateOtp()
        {
            using var rng = RandomNumberGenerator.Create();
            byte[] bytes = new byte[4];
            rng.GetBytes(bytes);
            int num = Math.Abs(BitConverter.ToInt32(bytes, 0)) % 1000000;
            return num.ToString("D6");
        }

        private string MaskEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return "";
            int atIndex = email.IndexOf('@');
            if (atIndex <= 1) return email;
            string name = email[..atIndex];
            string domain = email[atIndex..];
            if (name.Length <= 2)
                return name[0] + "***" + domain;
            return name[0] + new string('*', name.Length - 2) + name[^1] + domain;
        }

        // ============ BƯỚC 1: GỬI OTP ============

        private async void btnSendOtp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập Username!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm email trong DB
            string email;
            try
            {
                email = _account.GetEmailByUsername(username);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối DB: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Không tìm thấy tài khoản với username này!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Khởi tạo EmailService (lazy – chỉ tạo khi thật sự cần gửi)
            try
            {
                _emailService ??= new EmailService();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Thiếu cấu hình SMTP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _currentUsername = username;
            _currentOtp = GenerateOtp();
            _otpCreatedAt = DateTime.Now;
            _otpAttempts = 0;

            btnSendOtp.Enabled = false;
            btnSendOtp.Text = "Đang gửi...";

            try
            {
                await _emailService.SendOtpAsync(email, _currentOtp);
                lblEmailHint.Text = $"OTP đã gửi tới {MaskEmail(email)}";
                StartCountdown();
                ShowStep(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể gửi email: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSendOtp.Enabled = true;
                btnSendOtp.Text = "Gửi mã OTP";
            }
        }

        // ============ BƯỚC 2: XÁC THỰC OTP ============

        private void StartCountdown()
        {
            _remainingSeconds = OtpExpiryMinutes * 60;
            _countdownTimer?.Stop();
            _countdownTimer?.Dispose();
            _countdownTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            _countdownTimer.Tick += CountdownTimer_Tick;
            lblTimer.Text = $"Mã OTP hết hạn sau: {OtpExpiryMinutes:D2}:00";
            lblTimer.ForeColor = Color.Gray;
            lnkResend.Visible = false;
            _countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            _remainingSeconds--;
            if (_remainingSeconds <= 0)
            {
                _countdownTimer.Stop();
                lblTimer.Text = "Mã OTP đã hết hạn!";
                lblTimer.ForeColor = Color.Red;
                lnkResend.Visible = true;
            }
            else
            {
                int min = _remainingSeconds / 60;
                int sec = _remainingSeconds % 60;
                lblTimer.Text = $"Mã OTP hết hạn sau: {min:D2}:{sec:D2}";
                lblTimer.ForeColor = _remainingSeconds <= 60 ? Color.OrangeRed : Color.Gray;
            }
        }

        private void btnVerifyOtp_Click(object sender, EventArgs e)
        {
            string inputOtp = txtOtp.Text.Trim();
            if (string.IsNullOrEmpty(inputOtp))
            {
                MessageBox.Show("Vui lòng nhập mã OTP!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra hết hạn
            if ((DateTime.Now - _otpCreatedAt).TotalMinutes > OtpExpiryMinutes)
            {
                MessageBox.Show("Mã OTP đã hết hạn! Vui lòng gửi lại.", "Hết hạn",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lnkResend.Visible = true;
                return;
            }

            // So sánh OTP
            if (inputOtp != _currentOtp)
            {
                _otpAttempts++;
                int remaining = MaxOtpAttempts - _otpAttempts;
                if (remaining <= 0)
                {
                    MessageBox.Show("Bạn đã nhập sai quá 3 lần!\nVui lòng gửi lại mã OTP.",
                        "Quá số lần cho phép", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _countdownTimer?.Stop();
                    ShowStep(1);
                    return;
                }
                MessageBox.Show($"Mã OTP không đúng! Còn {remaining} lần thử.",
                    "Sai mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // OTP đúng → sang bước 3
            _countdownTimer?.Stop();
            ShowStep(3);
        }

        private async void lnkResend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = _account.GetEmailByUsername(_currentUsername);
            _currentOtp = GenerateOtp();
            _otpCreatedAt = DateTime.Now;
            _otpAttempts = 0;

            try
            {
                await _emailService.SendOtpAsync(email, _currentOtp);
                MessageBox.Show("Đã gửi lại mã OTP!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                StartCountdown();
                txtOtp.Clear();
                txtOtp.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể gửi email: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ BƯỚC 3: ĐỔI MẬT KHẨU ============

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string newPass = txtNewPass.Text.Trim();
            string confirmPass = txtConfirmPass.Text.Trim();

            if (string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_account.ResetPassword(_currentUsername, newPass))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ NÚT QUAY LẠI ============

        private void returnPB_Click(object sender, EventArgs e)
        {
            _countdownTimer?.Stop();
            _countdownTimer?.Dispose();
            this.Close();
        }
    }
}
