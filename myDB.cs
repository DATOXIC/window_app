using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;

namespace window_app
{
    internal class myDB
    {
        // Sử dụng |DataDirectory| để máy nào cũng tìm thấy file database
        private readonly string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtb_login.mdf;Integrated Security=True;Connect Timeout=30;Pooling=False";

        // Hàm băm mật khẩu SHA256 sẵn có của C#
        public string HashPassword(string rawPassword)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawPassword));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("x2"));
                return builder.ToString();
            }
        }

        // Truy vấn dùng Parameter để chống SQL Injection
        public string? GetHashedPassword(string username)
        {
            // Cấu trúc này đảm bảo kết nối luôn được đóng tự động
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT password FROM [Table] WHERE username = @user";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    object result = cmd.ExecuteScalar();
                    if (result is null || result is DBNull) return null;
                    return Convert.ToString(result);
                }
            } // Kết nối tự động đóng tại đây
        }

        public bool AddUser(string username, string password, string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO [Table] (username, password, email) VALUES (@user, @pass, @mail)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.Parameters.AddWithValue("@mail", email);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
