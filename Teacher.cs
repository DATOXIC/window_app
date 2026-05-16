using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace window_app
{
    // Teacher.cs
    internal class Teacher : Person
    {
        private readonly myDB db = new myDB();

        // Thuộc tính riêng của giảng viên
        public string TeacherID { get; private set; }
        public string Department { get; private set; }

        /// <summary>
        /// Lấy tất cả giảng viên (JOIN với Majors để hiển thị tên ngành)
        /// </summary>
        public DataTable GetAllTeachers()
        {
            string sql = @"SELECT t.TeacherID, t.Fname + ' ' + t.Lname AS FullName, 
                           m.MajorName AS Department, t.Email, t.Phone, t.Gender, t.Dob
                           FROM Teacher t
                           LEFT JOIN Majors m ON t.Department = m.MajorCode
                           ORDER BY t.TeacherID";

            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(sql, db.getConnection()))
            {
                try
                {
                    db.openConnection();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    db.closeConnection();
                }
                catch (Exception)
                {
                    db.closeConnection();
                }
            }
            return dt;
        }

        /// <summary>
        /// Lọc giảng viên theo mã GV và/hoặc khoa
        /// </summary>
        public DataTable GetFilteredTeachers(string searchTeacherId, string departmentCode)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"SELECT t.TeacherID, t.Fname + ' ' + t.Lname AS FullName, 
                       m.MajorName AS Department, t.Email, t.Phone, t.Gender, t.Dob
                       FROM Teacher t
                       LEFT JOIN Majors m ON t.Department = m.MajorCode
                       WHERE 1=1");

            if (!string.IsNullOrEmpty(searchTeacherId))
                sb.Append(" AND t.TeacherID LIKE @search");

            if (!string.IsNullOrEmpty(departmentCode))
                sb.Append(" AND t.Department = @dept");

            sb.Append(" ORDER BY t.TeacherID");

            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(sb.ToString(), db.getConnection()))
            {
                if (!string.IsNullOrEmpty(searchTeacherId))
                    cmd.Parameters.AddWithValue("@search", "%" + searchTeacherId + "%");

                if (!string.IsNullOrEmpty(departmentCode))
                    cmd.Parameters.AddWithValue("@dept", departmentCode);

                try
                {
                    db.openConnection();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    db.closeConnection();
                }
                catch (Exception)
                {
                    db.closeConnection();
                }
            }
            return dt;
        }

        /// <summary>
        /// Xóa giảng viên (xóa khỏi bảng Teacher + tài khoản [Table])
        /// </summary>
        public bool DeleteTeacher(string teacherId)
        {
            // Lấy Account Id trước
            string sqlGetId = "SELECT Id FROM Teacher WHERE TeacherID = @tid";
            int accountId = -1;

            using (SqlCommand cmdGet = new SqlCommand(sqlGetId, db.getConnection()))
            {
                cmdGet.Parameters.AddWithValue("@tid", teacherId);
                try
                {
                    db.openConnection();
                    object result = cmdGet.ExecuteScalar();
                    db.closeConnection();
                    if (result != null)
                        accountId = Convert.ToInt32(result);
                }
                catch
                {
                    db.closeConnection();
                    return false;
                }
            }

            if (accountId == -1) return false;

            // Xóa Teacher trước, rồi xóa Account
            try
            {
                db.openConnection();
                using (SqlTransaction trans = db.getConnection().BeginTransaction())
                {
                    try
                    {
                        string sqlDelTeacher = "DELETE FROM Teacher WHERE TeacherID = @tid";
                        using (SqlCommand cmd1 = new SqlCommand(sqlDelTeacher, db.getConnection(), trans))
                        {
                            cmd1.Parameters.AddWithValue("@tid", teacherId);
                            cmd1.ExecuteNonQuery();
                        }

                        string sqlDelAccount = "DELETE FROM [Table] WHERE id = @id";
                        using (SqlCommand cmd2 = new SqlCommand(sqlDelAccount, db.getConnection(), trans))
                        {
                            cmd2.Parameters.AddWithValue("@id", accountId);
                            cmd2.ExecuteNonQuery();
                        }

                        trans.Commit();
                        return true;
                    }
                    catch
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
            finally
            {
                db.closeConnection();
            }
        }

        /// <summary>
        /// Tự động sinh mã GV tiếp theo: GV001, GV002...
        /// </summary>
        public string GenerateNextTeacherID()
        {
            string sql = "SELECT MAX(CAST(SUBSTRING(TeacherID, 3, LEN(TeacherID)-2) AS INT)) FROM Teacher WHERE TeacherID LIKE 'GV%'";
            using (SqlCommand cmd = new SqlCommand(sql, db.getConnection()))
            {
                try
                {
                    db.openConnection();
                    object result = cmd.ExecuteScalar();
                    db.closeConnection();

                    int nextNum = 1;
                    if (result != null && result != DBNull.Value)
                        nextNum = Convert.ToInt32(result) + 1;

                    return "GV" + nextNum.ToString("D3");
                }
                catch
                {
                    db.closeConnection();
                    return "GV001";
                }
            }
        }

        /// <summary>
        /// Chèn giảng viên mới vào bảng Teacher (dùng khi GV tự điền profile)
        /// </summary>
        public bool InsertTeacher(string tID, string fname, string lname, string dept, string email, string phone)
        {
            this.TeacherID = tID;
            this.Fname = fname;
            this.Lname = lname;
            this.Department = dept;
            this.Email = email;
            this.Phone = phone;

            string sql = "INSERT INTO Teacher (TeacherID, Fname, Lname, Department, Email, Phone) " +
                         "VALUES (@id, @fn, @ln, @dept, @email, @phone)";

            using (SqlCommand command = new SqlCommand(sql, db.getConnection()))
            {
                command.Parameters.AddWithValue("@id", this.TeacherID);
                command.Parameters.AddWithValue("@fn", this.Fname);
                command.Parameters.AddWithValue("@ln", this.Lname);
                command.Parameters.AddWithValue("@dept", this.Department);
                command.Parameters.AddWithValue("@email", this.Email);
                command.Parameters.AddWithValue("@phone", this.Phone);

                db.openConnection();
                bool result = command.ExecuteNonQuery() == 1;
                db.closeConnection();
                return result;
            }
        }

        /// <summary>
        /// Chèn giảng viên với đầy đủ thông tin (bao gồm Id liên kết Account, Dob, Gender)
        /// </summary>
        public bool InsertFullTeacher(int accountId, string teacherId, string fname, string lname,
                                      string dept, string email, string phone, DateTime? dob, string gender)
        {
            string sql = @"INSERT INTO Teacher (Id, TeacherID, Fname, Lname, Department, Email, Phone, Dob, Gender) 
                           VALUES (@id, @tid, @fn, @ln, @dept, @email, @phone, @dob, @gdr)";

            using (SqlCommand cmd = new SqlCommand(sql, db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@id", accountId);
                cmd.Parameters.AddWithValue("@tid", teacherId);
                cmd.Parameters.AddWithValue("@fn", fname);
                cmd.Parameters.AddWithValue("@ln", lname);
                cmd.Parameters.AddWithValue("@dept", dept);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", (object)phone ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@dob", dob.HasValue ? (object)dob.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@gdr", (object)gender ?? DBNull.Value);

                try
                {
                    db.openConnection();
                    bool result = cmd.ExecuteNonQuery() == 1;
                    db.closeConnection();
                    return result;
                }
                catch
                {
                    db.closeConnection();
                    return false;
                }
            }
        }

        /// <summary>
        /// Kiểm tra xem một Account Id đã có profile Teacher chưa
        /// </summary>
        public bool HasTeacherProfile(int accountId)
        {
            string sql = "SELECT COUNT(*) FROM Teacher WHERE Id = @id";
            using (SqlCommand cmd = new SqlCommand(sql, db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@id", accountId);
                try
                {
                    db.openConnection();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    db.closeConnection();
                    return count > 0;
                }
                catch
                {
                    db.closeConnection();
                    return false;
                }
            }
        }
    }
}
