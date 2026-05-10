using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace window_app
{
    internal class EmailService
    {
        private const string SmtpEmailEnv = "WINDOW_APP_SMTP_EMAIL";
        private const string SmtpPasswordEnv = "WINDOW_APP_SMTP_PASSWORD";

        private readonly string _senderEmail;
        private readonly string _senderPassword;

        public EmailService()
        {
            _senderEmail = Environment.GetEnvironmentVariable(SmtpEmailEnv)
                ?? throw new InvalidOperationException(
                    $"Chưa cấu hình biến môi trường {SmtpEmailEnv}.\n" +
                    "Hãy set email Gmail dùng gửi OTP.");

            _senderPassword = Environment.GetEnvironmentVariable(SmtpPasswordEnv)
                ?? throw new InvalidOperationException(
                    $"Chưa cấu hình biến môi trường {SmtpPasswordEnv}.\n" +
                    "Hãy set App Password của Gmail.");
        }

        public async Task SendOtpAsync(string toEmail, string otpCode)
        {
            var message = new MailMessage
            {
                From = new MailAddress(_senderEmail, "Window App"),
                Subject = "Mã OTP đặt lại mật khẩu",
                Body = $"Mã OTP của bạn là: {otpCode}\n\n" +
                       "Mã này có hiệu lực trong 5 phút.\n" +
                       "Nếu bạn không yêu cầu đặt lại mật khẩu, hãy bỏ qua email này.",
                IsBodyHtml = false
            };
            message.To.Add(toEmail);

            using var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(_senderEmail, _senderPassword),
                EnableSsl = true,
                Timeout = 30000
            };

            await client.SendMailAsync(message);
        }
    }
}
