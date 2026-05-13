using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace window_app
{
    internal class Account
    {
        private readonly myDB db = new myDB();

        // --- Các thuộc tính khớp với bảng [Table] ---
        public int Id { get; private set; }           // Tự động tăng (Identity)
        public string Username { get; private set; }  // NVARCHAR(MAX)
        public string Password { get; private set; }  // NVARCHAR(MAX)
        public int Valid { get; private set; }        // 0 hoặc 1
        public string StudentID { get; private set; } // NCHAR(10) - Lưu MSSV kết nối
        public int Position { get; private set; }     // 0: Admin, 1: Student, 2: HR
        public string Email { get; private set; }

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

        //Nhấn nút delete sinh viên thì đưa sinh viên đó từ list sinh viên -> admission list
        public bool MoveBackToAdmission(string username)
        {
            string query =
                "UPDATE [Table] " +
                "SET valid = 0 " +
                "WHERE username = @user";

            using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@user", username);

                db.openConnection();

                bool result = cmd.ExecuteNonQuery() > 0;

                db.closeConnection();

                return result;
            }
        }



        /// <summary>
        /// Hàm này đóng vai trò 'active' tài khoản và link nó với mã số sinh viên (MSSV).
        /// Thực hiện cập nhật trạng thái Valid = 1, gán ID sinh viên và set quyền hạn (Position).
        /// </summary>
        /// <param name="user">Tên đăng nhập của tài khoản cần duyệt.</param>
        /// <param name="studentID">Mã số sinh viên dùng để map với bảng Student.</param>
        /// <param name="pos">Quyền hạn trong hệ thống (thường 1 là Student).</param>
        /// <returns>Trả về <c>true</c> nếu 'phá đảo' thành công, ngược lại là <c>false</c>.</returns>
        public bool ApproveAndLinkStudent(string user, string studentID, int pos)
{
    // Bước 1: Build câu Query. 
    // Dùng @ tham số để tránh bị 'ăn đòn' bởi SQL Injection - cực kỳ quan trọng để bảo mật nhé!
    string query = "UPDATE [Table] SET valid = 1, studentID = @sID, position = @pos WHERE username = @user";

    // Bước 2: Khởi tạo SqlCommand trong khối 'using'. 
    // 'using' giúp tự động dọn rác (Dispose) sau khi chạy xong, đỡ lo vụ tràn RAM.
    using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
    {
        // Bước 3: Bơm dữ liệu vào các tham số. Phải khớp 100% tên @ đã định nghĩa ở trên.
        cmd.Parameters.AddWithValue("@user", user);
        cmd.Parameters.AddWithValue("@sID", studentID);
        cmd.Parameters.AddWithValue("@pos", pos);

        db.openConnection(); // Mở cổng kết nối vào Database

        // Bước 4: Thực thi lệnh. 
        // ExecuteNonQuery() dùng cho UPDATE/INSERT/DELETE, nó trả về số dòng bị tác động.
        // Nếu kết quả > 0 tức là đã cập nhật thành công ít nhất một bản ghi.
        bool result = cmd.ExecuteNonQuery() > 0;

        db.closeConnection(); // 'Làm xong thì đóng cổng' - quy tắc vàng để tiết kiệm tài nguyên hệ thống.
        
        return result; // Hứng kết quả cuối cùng để báo về cho UI
    }
}

        /// <summary>
        /// Cập nhật quyền hạn (position) và trạng thái kích hoạt (valid) cho một tài khoản dựa trên tên đăng nhập.
        /// </summary>
        /// <param name="username">Tên đăng nhập (username) của tài khoản cần cập nhật.</param>
        /// <param name="role">Giá trị số đại diện cho quyền hạn mới (ví dụ: 0: Admin, 1: Student, 2: HR).</param>
        /// <param name="status">Trạng thái kích hoạt (0: Chưa duyệt/Khóa, 1: Đã duyệt/Kích hoạt).</param>
        /// <returns>
        /// Trả về <c>true</c> nếu cập nhật thành công ít nhất một bản ghi; ngược lại trả về <c>false</c>.
        /// </returns>
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

        /// <summary>
        /// Truy vấn danh sách các tài khoản người dùng đang ở trạng thái chờ phê duyệt (valid = 0).
        /// </summary>
        /// <returns>
        /// Trả về một <see cref="DataTable"/> chứa thông tin: Tên đăng nhập, Email, Quyền hạn và Trạng thái của các tài khoản chưa kích hoạt.
        /// </returns>
        public DataTable GetPendingAccounts()
        {
            // Chỉ định rõ 4 cột dữ liệu cần lấy
            string query = "SELECT username, email, position, valid FROM [Table] WHERE valid = 0";
            

            // Thực thi lệnh SQL
            using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
            {
                db.openConnection();
                // Lấy dữ liệu bảng sau khi Execute SQL --> Đổ vào Datatable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.closeConnection();
                return table;
            }
        }

    /// <summary>
    /// Hàm lọc sinh viên theo tiêu chí Year và Major
    /// </summary>
    /// <param name="year">Năm nhập học</param>
    /// <param name="department">Khoa</param>
    /// <returns>Trả về kết quả là một kiểu dữ Liệu Bảng (DataTable)</returns>
    public DataTable GetFilteredStudentAccounts(string year, string department)
    {
        // Kết nối nhiều bảng với nhau bằng Query để ra thông tin cần thiết
        string query = @"
            SELECT 
                acc.username AS Username, 
                acc.email AS Email, 
                COALESCE(NULLIF(stu.Name, ''), LTRIM(RTRIM(ISNULL(stu.Fname, '') + ' ' + ISNULL(stu.Lname, '')))) AS FullName,
                SUBSTRING(ISNULL(NULLIF(LTRIM(RTRIM(acc.studentID)), ''), acc.username), 3, 3) AS MajorCode,
                CASE WHEN LEFT(ISNULL(NULLIF(LTRIM(RTRIM(acc.studentID)), ''), acc.username), 2) LIKE '[0-9][0-9]' 
                     THEN CAST('20' + LEFT(ISNULL(NULLIF(LTRIM(RTRIM(acc.studentID)), ''), acc.username), 2) AS INT) 
                     ELSE 0 END AS EnrollmentYear
            FROM [Table] acc
            LEFT JOIN Student stu ON (LTRIM(RTRIM(acc.studentID)) = LTRIM(RTRIM(CAST(stu.MSSV AS NVARCHAR(MAX)))) 
                                  OR LTRIM(RTRIM(acc.username)) = LTRIM(RTRIM(CAST(stu.MSSV AS NVARCHAR(MAX)))))
            WHERE acc.position = 1 and acc.valid = 1"; // position = 1 dành riêng cho sinh viên

        // Nếu Admin chọn lọc bằng Year/ Major --> sẽ thêm các lệnh SQL vào query ban đầu
        if (!string.IsNullOrEmpty(year))
        {
            query += " AND LEFT(ISNULL(NULLIF(LTRIM(RTRIM(acc.studentID)), ''), acc.username), 2) = RIGHT(@year, 2)";
        }
        if (!string.IsNullOrEmpty(department))
        {
            query += " AND SUBSTRING(ISNULL(NULLIF(LTRIM(RTRIM(acc.studentID)), ''), acc.username), 3, 3) = @department";
        }
        

        // Nơi thực thi lệnh SQL
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
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) // Lấy kết quả bảng thông qua SqlDataAdapter
                {
                    adapter.Fill(table); // Đổ dữ liệu từ Database vào Table
                }
            }
            catch (Exception ex)
            {
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
