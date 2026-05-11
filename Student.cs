using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO; // Thêm dòng này để dùng MemoryStream

namespace window_app
{
    internal class Student
    {
        myDB db = new myDB();

        // Cập nhật Properties để khớp với Week 02
        public int Id { get; set; }
        public int MSSV { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime Dob { get; set; }
        public string Gder { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public byte[] Picture { get; set; }

        // 1. Hàm Thêm sinh viên (Dành cho Admin nhập tay)
        public bool insertStudent(int mssv, string fname, string lname, DateTime dob, string gder, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Student (MSSV, Fname, Lname, Dob, Gder, Phone, Address, Pture) " +
                "VALUES (@mssv, @fn, @ln, @dob, @gdr, @phn, @adrs, @pic)", db.getConnection());

            command.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@dob", SqlDbType.DateTime).Value = dob;
            command.Parameters.Add("@gdr", SqlDbType.NVarChar).Value = gder;
            command.Parameters.Add("@phn", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            db.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            db.closeConnection();
            return result;
        }

        // 2. Hàm Cập nhật sinh viên (Đã sửa lại khớp với cấu trúc mới)
        public bool updateStudent(int mssv, string fname, string lname, DateTime dob, string gder, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE Student SET Fname=@fn, Lname=@ln, Dob=@dob, Gder=@gdr, Phone=@phn, Address=@adrs, Pture=@pic WHERE MSSV=@mssv", db.getConnection());

            command.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@dob", SqlDbType.DateTime).Value = dob;
            command.Parameters.Add("@gdr", SqlDbType.NVarChar).Value = gder;
            command.Parameters.Add("@phn", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            db.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            db.closeConnection();
            return result;
        }

        // 3. Hàm Xóa sinh viên
        public bool deleteStudent(int mssv)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Student WHERE MSSV=@mssv", db.getConnection());
            command.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;

            db.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            db.closeConnection();
            return result;
        }

        // 4. Hàm lấy danh sách sinh viên
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = db.getConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // 5. Hàm Tự động cấp tài khoản từ AdmissionList
        public bool AutoEnrollStudent(string candidateId, string fullName, string email, string majorCode, int year,
                             DateTime dob, string gender, string phone, string address)
        {
            // 1. Tách tên theo yêu cầu Week 02 
            string[] names = fullName.Trim().Split(' ');
            string lastName = names[names.Length - 1];
            string firstName = string.Join(" ", names, 0, names.Length - 1);

            // 2. Sinh MSSV tự động (Kiểu INT theo image_8a070d.png) 
            string mssvString = GenerateNewMSSV(year.ToString(), majorCode);
            int newMSSV = int.Parse(mssvString);

            db.openConnection();
            SqlTransaction trans = db.getConnection().BeginTransaction();

            try
            {
                // BƯỚC A: Tạo tài khoản trong bảng [Table] (image_8a072b.png)
                // Lưu ý: position = 1 (Student), valid = 1 
                string sqlAcc = "INSERT INTO [Table] (username, password, valid, studentID, position, email) " +
                                "VALUES (@user, @user, 1, @sid, 1, @email); SELECT SCOPE_IDENTITY();";

                SqlCommand cmdAcc = new SqlCommand(sqlAcc, db.getConnection(), trans);
                cmdAcc.Parameters.AddWithValue("@user", mssvString);
                cmdAcc.Parameters.AddWithValue("@sid", mssvString); // Cột studentID trong [Table]
                cmdAcc.Parameters.AddWithValue("@email", email);
                int accountId = Convert.ToInt32(cmdAcc.ExecuteScalar());

                // BƯỚC B: Tạo hồ sơ Student (image_8a070d.png)
                // Điền đầy đủ các cột bạn đã thiết lập
                string sqlStu = "INSERT INTO Student (Id, MSSV, Name, Phone, Email, Fname, Lname, Dob, Gder, Address) " +
                                "VALUES (@id, @mssv, @name, @phn, @email, @fn, @ln, @dob, @gdr, @adrs)";

                SqlCommand cmdStu = new SqlCommand(sqlStu, db.getConnection(), trans);
                cmdStu.Parameters.AddWithValue("@id", accountId);
                cmdStu.Parameters.AddWithValue("@mssv", newMSSV);
                cmdStu.Parameters.AddWithValue("@name", fullName);
                cmdStu.Parameters.AddWithValue("@phn", phone);
                cmdStu.Parameters.AddWithValue("@email", email);
                cmdStu.Parameters.AddWithValue("@fn", firstName);
                cmdStu.Parameters.AddWithValue("@ln", lastName);
                cmdStu.Parameters.AddWithValue("@dob", dob); // Kiểu datetime [cite: 20]
                cmdStu.Parameters.AddWithValue("@gdr", gender);
                cmdStu.Parameters.AddWithValue("@adrs", address);
                cmdStu.ExecuteNonQuery();

                // BƯỚC C: Cập nhật AdmissionList (image_8a06e8.png)
                string sqlAdm = "UPDATE AdmissionList SET IsAccountCreated = 1 WHERE CandidateID = @cid";
                SqlCommand cmdAdm = new SqlCommand(sqlAdm, db.getConnection(), trans);
                cmdAdm.Parameters.AddWithValue("@cid", candidateId);
                cmdAdm.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw new Exception("Lỗi chi tiết: " + ex.Message);
            }
            finally { db.closeConnection(); }
        }
        // 6. Hàm Sinh MSSV tự động
        public string GenerateNewMSSV(string year, string majorCode)
        {
            string yearPrefix = year.Substring(year.Length - 2);
            string prefix = yearPrefix + majorCode;
            string query = "SELECT MAX(MSSV) FROM Student WHERE CAST(MSSV AS VARCHAR) LIKE @pattern";

            SqlCommand command = new SqlCommand(query, db.getConnection());
            command.Parameters.AddWithValue("@pattern", prefix + "%");

            db.openConnection();
            object result = command.ExecuteScalar();
            db.closeConnection();

            if (result == DBNull.Value || result == null) return prefix + "001";
            else
            {
                int maxMSSV = Convert.ToInt32(result);
                return (maxMSSV + 1).ToString();
            }
        }
        // Thêm vào lớp Student.cs
        public DataTable GetPendingAdmissions()
        {
            SqlCommand command = new SqlCommand("SELECT CandidateID, FullName, Email, MajorCode, EnrollmentYear, Dob, Gender, Phone, Address FROM AdmissionList WHERE IsAccountCreated = 0", db.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        public bool AddCandidateToAdmission(string name, string major, int year, string email, string phone, DateTime dob, string gender, string address)
        {
            // Tự sinh CandidateID duy nhất: TS + 10 số cuối của Ticks (thời gian hệ thống)
            string candidateId = "TS" + DateTime.Now.Ticks.ToString().Substring(10);

            string sql = @"INSERT INTO AdmissionList 
                   (CandidateID, FullName, MajorCode, EnrollmentYear, Email, Phone, Dob, Gender, Address, IsAccountCreated)
                   VALUES (@cid, @name, @major, @year, @email, @phone, @dob, @gender, @address, 0)";

            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand(sql, db.getConnection());

                cmd.Parameters.AddWithValue("@cid", candidateId);
                cmd.Parameters.AddWithValue("@name", name.Trim());
                cmd.Parameters.AddWithValue("@major", major);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@email", email.Trim());
                cmd.Parameters.AddWithValue("@phone", phone.Trim());
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address.Trim());

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm thí sinh: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}