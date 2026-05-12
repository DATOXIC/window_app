using System;
using System.Collections.Generic;
using System.Text;

namespace window_app
{

    // Admin.cs
    internal class Admin : Person
    {
        myDB db = new myDB();

        public int AdminLevel { get; set; } // Ví dụ: 1 là SuperAdmin, 2 là Mod

        public bool UpdateAdminProfile(string email, string phone, string address)
        {
            this.Email = email;
            this.Phone = phone;
            this.Address = address;

            // Logic UPDATE vào bảng [Table] hoặc bảng Admin riêng tùy DB của bạn
            string sql = "UPDATE [Table] SET email = @email WHERE username = @user";
            // ... thực thi lệnh SQL
            return true;
        }
    }
}
