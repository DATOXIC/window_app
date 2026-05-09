using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace window_app
{
    internal class Account
    {
        myDB db = new myDB();
        // --- Các thuộc tính khớp với bảng [Table] ---
        public int Id { get; set; }           // Tự động tăng (Identity)
        public string Username { get; set; }  // NVARCHAR(MAX)
        public string Password { get; set; }  // NVARCHAR(MAX)
        public int Valid { get; set; }        // 0 hoặc 1
        public string StudentID { get; set; } // NCHAR(10) - Lưu MSSV kết nối
        public int Position { get; set; }     // 0: Admin, 1: Student, 2: HR
        public string Email { get; set; }
        public enum LoginResult
        {
            Success = 0,
            InvalidCredentials = 1,
            NotApproved = 2,
        }
        public bool Register(string user, string pass, string email)
        {
            string hashedPass = db.HashPassword(pass);

            string query = "INSERT INTO [Table] (username, password, valid, position, email) " +
                           "VALUES (@user, @pass, 1, 1, @mail)";

            using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", hashedPass);
                cmd.Parameters.AddWithValue("@mail", email); // Truyền giá trị email từ tham số

                db.openConnection();
                bool result = cmd.ExecuteNonQuery() > 0;
                db.closeConnection();
                return result;
            }
        }
        public bool Login(string user, string pass)
        {
            return LoginWithStatus(user, pass) == LoginResult.Success;
        }


        public LoginResult LoginWithStatus(string user, string pass)
        {
            string query = "SELECT password, valid FROM [Table] WHERE username = @user";
            using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@user", user);

                db.openConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        db.closeConnection();
                        return LoginResult.InvalidCredentials;
                    }

                    string storedPass = reader["password"]?.ToString() ?? "";
                    int valid = reader["valid"] != DBNull.Value ? Convert.ToInt32(reader["valid"]) : 0;
                    db.closeConnection();

                    string hashedPass = db.HashPassword(pass);

                    bool matchesHash = string.Equals(storedPass, hashedPass, StringComparison.OrdinalIgnoreCase);
                    bool matchesPlain = string.Equals(storedPass, pass, StringComparison.Ordinal);

                    if (!matchesHash && !matchesPlain)
                        return LoginResult.InvalidCredentials;

                    // If legacy DB stored plain text password, migrate to hash on successful login.
                    if (matchesPlain && !matchesHash)
                    {
                        string update = "UPDATE [Table] SET password = @pass WHERE username = @user";
                        using (SqlCommand upd = new SqlCommand(update, db.getConnection()))
                        {
                            upd.Parameters.AddWithValue("@user", user);
                            upd.Parameters.AddWithValue("@pass", hashedPass);
                            db.openConnection();
                            upd.ExecuteNonQuery();
                            db.closeConnection();
                        }
                    }

                    return valid == 1 ? LoginResult.Success : LoginResult.NotApproved;
                }
            }
        }
        public int GetUserPosition(string user)
        {
            string query = "SELECT position FROM [Table] WHERE username = @user";
            using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@user", user);
                db.openConnection();
                object result = cmd.ExecuteScalar();
                db.closeConnection();

                // Trả về position hoặc -1 nếu không tìm thấy.
                // Nếu DB đang có dữ liệu test bị NULL, mặc định Student (1) để app không crash.
                if (result is null || result == DBNull.Value) return 1;
                return Convert.ToInt32(result);
            }
        }
        public string GetStudentID(string user)
        {
            string query = "SELECT studentID FROM [Table] WHERE username = @user";
            using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@user", user);
                db.openConnection();
                object result = cmd.ExecuteScalar();
                db.closeConnection();
                // Trả về studentID hoặc null nếu không tìm thấy.
                if (result is null || result == DBNull.Value) return null;
                return result.ToString();
            }
        }
        public bool ApproveAndLinkStudent(string user, string studentID, int pos)
        {
            // Cập nhật trạng thái valid, quyền hạn và nối với bảng Student qua studentID
            string query = "UPDATE [Table] SET valid = 1, studentID = @sID, position = @pos WHERE username = @user";

            using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@sID", studentID);
                cmd.Parameters.AddWithValue("@pos", pos);

                db.openConnection();
                bool result = cmd.ExecuteNonQuery() > 0;
                db.closeConnection();
                return result;
            }
        }
    }
}
