using System;
using System.Collections.Generic;
using System.Text;

namespace window_app
{
    internal class Account
    {
        public string Mgv { get; set; } // Mã giảng viên/ID người dùng [cite: 75]
        public string Username { get; set; } // Tên đăng nhập [cite: 75]
        public string Password { get; set; } // Mật khẩu (đã băm) [cite: 75]
        public int Position { get; set; } // 0=Admin, 1=SV, 2=HR [cite: 53]
        public int Valid { get; set; } // 0=Chờ duyệt, 1=Đã duyệt [cite: 57]

        public void AcceptAccount() { /* UC-04 [cite: 55] */ }
    }
}
