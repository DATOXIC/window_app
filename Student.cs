using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO; // Thêm dòng này để dùng MemoryStream

namespace window_app
{
    internal class Student : Person, MutualFunc
    {
        myDB db = new myDB();

        // Cập nhật Properties để khớp với Week 02
        public int Id { get; set; }
        public int MSSV { get; set; }

        // Constructor của Student gọi Constructor của Person
        public Student(int mssv, string fname, string lname, DateTime dob, string gder, string phone, string address, string email, byte[] picture)
            : base(fname, lname, dob, gder, phone, address, email, picture) // Đẩy dữ liệu lên lớp cha
        {
            this.MSSV = mssv; // Chỉ cần gán những gì riêng biệt của Student
        }
        public Student() : base() { }
        public override string GetFullName()
        {
            return base.GetFullName().ToUpper(); // Trả về tên in hoa
        }

        // 1. Hàm Thêm sinh viên (Dành cho Admin nhập tay)
        public bool Insert()
        {
            string sql = "INSERT INTO Student (MSSV, Fname, Lname, Dob, Gder, Phone, Address, Email, Pture) " +
                         "VALUES (@mssv, @fn, @ln, @dob, @gdr, @phn, @adrs, @email, @pic)";

            SqlCommand command = new SqlCommand(sql, db.getConnection());
            command.Parameters.AddWithValue("@mssv", this.MSSV);
            command.Parameters.AddWithValue("@fn", this.Fname);
            command.Parameters.AddWithValue("@ln", this.Lname);
            command.Parameters.AddWithValue("@dob", this.Dob);
            command.Parameters.AddWithValue("@gdr", this.Gder);
            command.Parameters.AddWithValue("@phn", this.Phone);
            command.Parameters.AddWithValue("@adrs", this.Address);
            command.Parameters.AddWithValue("@email", this.Email);
            command.Parameters.AddWithValue("@pic", (this.Picture != null) ? this.Picture : (object)DBNull.Value);

            db.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            db.closeConnection();
            return result;
        }

        // 2. Hàm Cập nhật sinh viên (Đã sửa lại khớp với cấu trúc mới)
        public bool Update()
        {
            string sql = "UPDATE Student SET Fname=@fn, Lname=@ln, Dob=@dob, Gder=@gdr, Phone=@phn, Address=@adrs, Email=@email, Pture=@pic WHERE MSSV=@mssv";

            SqlCommand command = new SqlCommand(sql, db.getConnection());
            command.Parameters.AddWithValue("@mssv", this.MSSV);
            command.Parameters.AddWithValue("@fn", this.Fname);
            command.Parameters.AddWithValue("@ln", this.Lname);
            command.Parameters.AddWithValue("@dob", this.Dob);
            command.Parameters.AddWithValue("@gdr", this.Gder);
            command.Parameters.AddWithValue("@phn", this.Phone);
            command.Parameters.AddWithValue("@adrs", this.Address);
            command.Parameters.AddWithValue("@email", this.Email);
            command.Parameters.AddWithValue("@pic", (this.Picture != null) ? this.Picture : (object)DBNull.Value);

            db.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            db.closeConnection();
            return result;
        }

        // 3. Hàm Xóa sinh viên
        public bool Delete(int mssv)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Student WHERE MSSV=@mssv", db.getConnection());
            command.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;

            db.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            db.closeConnection();
            return result;
        }

        // 4. Hàm lấy danh sách sinh viên
        public DataTable GetData(SqlCommand command)
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
            // Logic: 
            // 1. Lấy 2 số cuối của năm nhập học (ví dụ 2024 -> 24).
            // 2. Dùng ROW_NUMBER() để đánh số thứ tự (Rank) theo bảng chữ cái (FullName).
            // 3. Nếu trùng tên, CandidateID sẽ là tiêu chí phụ để đảm bảo thứ tự luôn cố định.
            // 4. Kết hợp lại thành MSSV dự kiến (ProvisionalMSSV).

            string sql = @"
        SELECT 
            CandidateID, 
            FullName, 
            Email, 
            Phone, 
            MajorCode, 
            EnrollmentYear,
            Dob,
            Gender,
            Address,
            (CAST(RIGHT(CAST(EnrollmentYear AS VARCHAR), 2) AS VARCHAR) + 
             MajorCode + 
             RIGHT('000' + CAST(ROW_NUMBER() OVER(
                PARTITION BY MajorCode, EnrollmentYear 
                ORDER BY 
                    REVERSE(LEFT(REVERSE(FullName), CHARINDEX(' ', REVERSE(FullName) + ' ') - 1)) ASC,
                    FullName ASC,
                    CandidateID ASC
             ) AS VARCHAR), 3)) AS ProvisionalMSSV
        FROM AdmissionList 
        WHERE IsAccountCreated = 0";

            SqlCommand command = new SqlCommand(sql, db.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            try
            {
                db.openConnection();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách trúng tuyển: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }

            return table;
        }
// --- PHẦN 1: THÊM THÍ SINH VÀO DANH SÁCH CHỜ (Từ nhánh admin_form) ---
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

        // --- PHẦN 2: LOGIC PHÊ DUYỆT VÀ CẤP MSSV (Từ nhánh master) ---
        private int GetAlphabeticalRank(string majorCode, int year, string fullName, string candidateId, SqlTransaction trans)
        {
            string sql = @"
                SELECT COUNT(*) + 1 
                FROM AdmissionList 
                WHERE MajorCode = @major 
                AND EnrollmentYear = @year 
                AND (FullName < @name OR (FullName = @name AND CandidateID <= @cid))";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection(), trans);
            cmd.Parameters.AddWithValue("@major", majorCode);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@name", fullName);
            cmd.Parameters.AddWithValue("@cid", candidateId);

            int currentCount = GetCurrentStudentCount(majorCode, year.ToString(), trans);
            return currentCount + (int)cmd.ExecuteScalar();
        }

        public bool ApproveBatchStudents(List<DataGridViewRow> selectedRows, MemoryStream picture)
        {
            var sortedRows = selectedRows.OrderBy(r => r.Cells["FullName"].Value.ToString()).ToList();

            db.openConnection();
            SqlTransaction trans = db.getConnection().BeginTransaction();

            try
            {
                foreach (var row in sortedRows)
                {
                    string cid = row.Cells["CandidateID"].Value.ToString().Trim();
                    string fullName = row.Cells["FullName"].Value.ToString().Trim();
                    string majorCode = row.Cells["MajorCode"].Value.ToString().Trim();
                    string email = row.Cells["Email"].Value.ToString().Trim();
                    int year = Convert.ToInt32(row.Cells["EnrollmentYear"].Value);
                    string phone = row.Cells["Phone"].Value?.ToString() ?? "";
                    string address = row.Cells["Address"].Value?.ToString() ?? "";
                    string gender = row.Cells["Gender"].Value?.ToString() ?? "";
                    DateTime dob = Convert.ToDateTime(row.Cells["Dob"].Value);

                    int rank = GetAlphabeticalRank(majorCode, year, fullName, cid, trans);
                    string yearPrefix = year.ToString().Substring(year.ToString().Length - 2);
                    string mssvString = yearPrefix + majorCode + rank.ToString("D3");

                    // 3.1: Chèn vào bảng [Table]
                    string sqlAccount = "INSERT INTO [Table] (username, password, valid, position, email) " +
                                        "VALUES (@user, @pass, 1, 1, @email); SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdAccount = new SqlCommand(sqlAccount, db.getConnection(), trans);
                    cmdAccount.Parameters.AddWithValue("@user", mssvString);
                    cmdAccount.Parameters.AddWithValue("@pass", db.HashPassword(mssvString));
                    cmdAccount.Parameters.AddWithValue("@email", email);

                    int newAccountId = Convert.ToInt32(cmdAccount.ExecuteScalar());

                    // 3.2: Chèn vào bảng Student
                    string sqlStudent = "INSERT INTO Student (Id, MSSV, Name, Phone, Email, Dob, Gder, Address, Pture) " +
                        "VALUES (@id, @mssv, @name, @phone, @email, @dob, @gdr, @adrs, @pic)";

                    SqlCommand cmdStudent = new SqlCommand(sqlStudent, db.getConnection(), trans);
                    cmdStudent.Parameters.AddWithValue("@id", newAccountId);
                    cmdStudent.Parameters.AddWithValue("@mssv", mssvString);
                    cmdStudent.Parameters.AddWithValue("@name", fullName);
                    cmdStudent.Parameters.AddWithValue("@phone", phone);
                    cmdStudent.Parameters.AddWithValue("@email", email);
                    cmdStudent.Parameters.AddWithValue("@dob", dob);
                    cmdStudent.Parameters.AddWithValue("@gdr", gender);
                    cmdStudent.Parameters.AddWithValue("@adrs", address);
                    cmdStudent.Parameters.AddWithValue("@pic", picture.ToArray());
                    cmdStudent.ExecuteNonQuery();

                    // 3.3: Cập nhật studentID cho Account
                    string sqlUpdateAcc = "UPDATE [Table] SET studentID = @sid WHERE id = @aid";
                    SqlCommand cmdUpdateAcc = new SqlCommand(sqlUpdateAcc, db.getConnection(), trans);
                    cmdUpdateAcc.Parameters.AddWithValue("@sid", mssvString);
                    cmdUpdateAcc.Parameters.AddWithValue("@aid", newAccountId);
                    cmdUpdateAcc.ExecuteNonQuery();

                    // 3.4: Đánh dấu đã phê duyệt trong AdmissionList
                    string sqlUpdateAdm = "UPDATE AdmissionList SET IsAccountCreated = 1 WHERE CandidateID = @cid";
                    SqlCommand cmdUpdateAdm = new SqlCommand(sqlUpdateAdm, db.getConnection(), trans);
                    cmdUpdateAdm.Parameters.AddWithValue("@cid", cid);
                    cmdUpdateAdm.ExecuteNonQuery();
                }

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw new Exception("Lỗi phê duyệt hệ thống: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private int GetCurrentStudentCount(string major, string year, SqlTransaction trans)
        {
            string yearPrefix = year.Substring(2);
            string sql = "SELECT COUNT(*) FROM Student WHERE MSSV LIKE @prefix";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection(), trans);
            cmd.Parameters.AddWithValue("@prefix", yearPrefix + major + "%");
            return (int)cmd.ExecuteScalar();
        }
    }
}