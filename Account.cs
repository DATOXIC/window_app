using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
                           "VALUES (@user, @pass, 0, 1, @mail)";

            using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", hashedPass);
                cmd.Parameters.AddWithValue("@mail", email); 

                db.openConnection();
                bool result = cmd.ExecuteNonQuery() > 0;
                db.closeConnection();
                return result;
            }
        }

        // Hàm Trả về trạng thái của Login 
        public LoginResult LoginWithStatus(string user, string pass)
        {

            string query = "SELECT password, valid FROM [Table] WHERE username = @user";
            using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@user", user);

                db.openConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read()) // Nếu SQL kh tìm thấy
                    {
                        db.closeConnection();
                        return LoginResult.InvalidCredentials;
                    }

                    string storedPass = reader["password"] ?. ToString() ?? "";
                    int valid = reader["valid"] != DBNull.Value ? Convert.ToInt32(reader["valid"]) : 0;
                    db.closeConnection();

                    // So sánh MK trong DTB và người dùng nhập
                    string hashedPass = db.HashPassword(pass);
                    bool matchesHash = string.Equals(storedPass, hashedPass, StringComparison.OrdinalIgnoreCase);

                    if (!matchesHash) // Sai MK
                        return LoginResult.InvalidCredentials;

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
        
        // Lấy email theo username (dùng cho Forgot Password)
        public string GetEmailByUsername(string username)
        {
            string query = "SELECT email FROM [Table] WHERE username = @user";
            using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@user", username);
                db.openConnection();
                object result = cmd.ExecuteScalar();
                db.closeConnection();
                if (result is null || result == DBNull.Value) return null;
                return result.ToString();
            }
        }

        // Đặt lại mật khẩu (hash SHA-256 trước khi lưu)
        public bool ResetPassword(string username, string newPassword)
        {
            string hashedPass = db.HashPassword(newPassword);
            string query = "UPDATE [Table] SET password = @pass WHERE username = @user";
            using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", hashedPass);
                db.openConnection();
                bool result = cmd.ExecuteNonQuery() > 0;
                db.closeConnection();
                return result;
            }
        }

        // Chức năng của HR ==> Chỉnh sửa ID - Valid - POS
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
        public bool UpdateStatus(string username, int role, int status)
        {
            string query = "UPDATE [Table] SET position = @role, valid = @status WHERE username = @user";

            using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@user", username);

                try
                {
                    db.openConnection();
                    int result = cmd.ExecuteNonQuery();
                    db.closeConnection();

                    return result > 0;
                }
                catch (Exception ex)
                {
                    db.closeConnection();
                    return false;
                }
            }
        }

        public DataTable GetPendingAccounts()
        {
            string query = "SELECT username, email, position, valid FROM [Table] WHERE valid = 0";

            using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
            {
                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.closeConnection();
                return table;
            }
        }

    public DataTable GetFilteredStudentAccounts(string year, string department)
    {
        // Trích xuất Năm học (EnrollmentYear) và Mã ngành (MajorCode) từ MSSV
        string query = @"
            SELECT 
                acc.username AS Username, 
                acc.email AS Email, 
                LTRIM(RTRIM(ISNULL(stu.Fname, '') + ' ' + ISNULL(stu.Lname, ''))) AS FullName,
                SUBSTRING(ISNULL(NULLIF(LTRIM(RTRIM(acc.studentID)), ''), acc.username), 3, 3) AS MajorCode,
                CASE WHEN LEFT(ISNULL(NULLIF(LTRIM(RTRIM(acc.studentID)), ''), acc.username), 2) LIKE '[0-9][0-9]' 
                     THEN CAST('20' + LEFT(ISNULL(NULLIF(LTRIM(RTRIM(acc.studentID)), ''), acc.username), 2) AS INT) 
                     ELSE 0 END AS EnrollmentYear
            FROM [Table] acc
            LEFT JOIN Student stu ON (LTRIM(RTRIM(acc.studentID)) = LTRIM(RTRIM(CAST(stu.MSSV AS NVARCHAR(MAX)))) 
                                  OR LTRIM(RTRIM(acc.username)) = LTRIM(RTRIM(CAST(stu.MSSV AS NVARCHAR(MAX)))))
            WHERE acc.position = 1"; // position = 1 dành riêng cho sinh viên

        if (!string.IsNullOrEmpty(year))
        {
            query += " AND LEFT(ISNULL(NULLIF(LTRIM(RTRIM(acc.studentID)), ''), acc.username), 2) = RIGHT(@year, 2)";
        }
        
        if (!string.IsNullOrEmpty(department))
        {
            query += " AND SUBSTRING(ISNULL(NULLIF(LTRIM(RTRIM(acc.studentID)), ''), acc.username), 3, 3) = @department";
        }

        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
        {
            if (!string.IsNullOrEmpty(year))
                cmd.Parameters.AddWithValue("@year", year);
                
            if (!string.IsNullOrEmpty(department))
                cmd.Parameters.AddWithValue("@department", department);

            DataTable table = new DataTable();
            try
            {
                db.openConnection();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                    
                    // --- BƯỚC 2: Debug dữ liệu ra Console (Output) của Visual Studio ---
                    if (table.Columns.Contains("FullName"))
                    {
                        System.Diagnostics.Debug.WriteLine("DEBUG: Đã tìm thấy cột FullName trong DataTable.");
                        if (table.Rows.Count > 0)
                        {
                            System.Diagnostics.Debug.WriteLine("DEBUG: Giá trị FullName dòng đầu tiên là: '" + table.Rows[0]["FullName"].ToString() + "'");
                        }
                        else
                        {
                            System.Diagnostics.Debug.WriteLine("DEBUG: Bảng không có dữ liệu (0 rows).");
                        }
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("DEBUG - CẢNH BÁO: Không có cột FullName trong DataTable!");
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiện thông báo lỗi SQL (VD: Thiếu cột Fname, Lname) để xử lý thay vì bị ẩn đi
                System.Windows.Forms.MessageBox.Show("Lỗi truy vấn SQL: " + ex.Message, "Debug SQL", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
            return table;
        }
    }
    }
}
