using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;

namespace window_app
{
    internal class myDB
    {
        private const string EnvVarName = "WINDOW_APP_SQL_CONNECTION";

        private static string BuildConnectionString()
        {
            string? raw = Environment.GetEnvironmentVariable(EnvVarName);
            if (string.IsNullOrWhiteSpace(raw))
            {
                throw new InvalidOperationException(
                    $"Chưa cấu hình connection string. Hãy set biến môi trường {EnvVarName}.\n\n" +
                    "Ví dụ:\n" +
                    $"Server=<IP_or_HOST>\\\\SQLEXPRESS;Database=window_app;User Id=window_app_user;Password=...;TrustServerCertificate=True;");
            }

            // Normalize to avoid common TLS/trust errors on dev servers.
            var builder = new SqlConnectionStringBuilder(raw)
            {
                ConnectTimeout = 30,
                Pooling = true,
            };

            if (!builder.ContainsKey("TrustServerCertificate") && !builder.ContainsKey("Encrypt"))
            {
                builder.TrustServerCertificate = true;
            }

            return builder.ConnectionString;
        }

        private readonly string connectionString = BuildConnectionString();
        private SqlConnection? _connection;

        public SqlConnection getConnection()
        {
            _connection ??= new SqlConnection(connectionString);
            return _connection;
        }

        public void openConnection()
        {
            var conn = getConnection();
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                conn.Open();
        }

        public void closeConnection()
        {
            if (_connection is null) return;
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
        }

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
        public string GetHashedPassword(string username)
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
                    return result?.ToString();
                }
            } // Kết nối tự động đóng tại đây
        }

        
    }
}
