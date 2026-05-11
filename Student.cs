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
        private int GetAlphabeticalRank(string majorCode, int year, string fullName, string candidateId, SqlTransaction trans)
        {
            // Chúng ta đếm số người có tên "nhỏ hơn" tên hiện tại
            // Nếu trùng tên, ta dùng CandidateID làm tiêu chí phụ để đảm bảo thứ tự không đổi
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

            return (int)cmd.ExecuteScalar();
        }
        public bool ApproveBatchStudents(List<DataGridViewRow> selectedRows)
        {
            // 1. SẮP XẾP LẠI theo tên để đảm bảo tính nhất quán của STT
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
                    // 2. Tính toán MSSV (Rank Alphabet)
                    int rank = GetAlphabeticalRank(majorCode, year, fullName, cid, trans);
                    string yearPrefix = year.ToString().Substring(year.ToString().Length - 2);
                    string mssvString = yearPrefix + majorCode + rank.ToString("D3");

                    // 3. Tiến hành chèn (Sửa lỗi thứ tự và ép kiểu)

                    // Bước 3.1: Chèn Account trước (để lấy Id tự tăng)
                    // Lưu ý: Tạm thời chưa điền studentID nếu nó là Khóa ngoại
                    string sqlAccount = "INSERT INTO [Table] (username, password, valid, position, email) " +
                                        "VALUES (@user, @pass, 1, 1, @email); SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdAccount = new SqlCommand(sqlAccount, db.getConnection(), trans);
                    cmdAccount.Parameters.AddWithValue("@user", mssvString);
                    cmdAccount.Parameters.AddWithValue("@pass", db.HashPassword(mssvString));
                    cmdAccount.Parameters.AddWithValue("@email", email);

                    // Ép kiểu decimal để tránh lỗi InvalidCastException
                    int newAccountId = Convert.ToInt32(cmdAccount.ExecuteScalar());

                    // Bước 3.2: Chèn vào bảng Student (Dùng Id vừa lấy)
                    string sqlStudent = "INSERT INTO Student (Id, MSSV, Name, Phone, Email, Dob, Gder, Address) " +
                        "VALUES (@id, @mssv, @name, @phone, @email, @dob, @gdr, @adrs)";

                    SqlCommand cmdStudent = new SqlCommand(sqlStudent, db.getConnection(), trans);
                    cmdStudent.Parameters.AddWithValue("@id", newAccountId);
                    cmdStudent.Parameters.AddWithValue("@mssv", mssvString);
                    cmdStudent.Parameters.AddWithValue("@name", fullName);
                    cmdStudent.Parameters.AddWithValue("@phone", phone); // ĐÃ THÊM PHONE
                    cmdStudent.Parameters.AddWithValue("@email", email);
                    cmdStudent.Parameters.AddWithValue("@dob", dob);     // ĐÃ THÊM DOB
                    cmdStudent.Parameters.AddWithValue("@gdr", gender);  // ĐÃ THÊM GENDER
                    cmdStudent.Parameters.AddWithValue("@adrs", address); // ĐÃ THÊM ADDRESS
                    cmdStudent.ExecuteNonQuery();

                    // Bước 3.3: Quay lại cập nhật studentID cho bảng [Table] (Nếu cần)
                    string sqlUpdateAcc = "UPDATE [Table] SET studentID = @sid WHERE id = @aid";
                    SqlCommand cmdUpdateAcc = new SqlCommand(sqlUpdateAcc, db.getConnection(), trans);
                    cmdUpdateAcc.Parameters.AddWithValue("@sid", mssvString);
                    cmdUpdateAcc.Parameters.AddWithValue("@aid", newAccountId);
                    cmdUpdateAcc.ExecuteNonQuery();

                    // Bước 3.4: Chốt hạ - Xóa khỏi danh sách chờ
                    string sqlUpdateAdm = "UPDATE AdmissionList SET IsAccountCreated = 1 WHERE CandidateID = @cid";
                    SqlCommand cmdUpdateAdm = new SqlCommand(sqlUpdateAdm, db.getConnection(), trans);
                    cmdUpdateAdm.Parameters.AddWithValue("@cid", cid);
                    cmdUpdateAdm.ExecuteNonQuery();
                }

                // Nếu mọi thứ suôn sẻ, chốt giao dịch
                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                // Nếu có bất kỳ lỗi nào, hủy bỏ toàn bộ để tránh dữ liệu rác
                trans.Rollback();
                throw new Exception("Lỗi phê duyệt hệ thống: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }
        public bool ApproveStandardSystem(List<DataGridViewRow> selectedRows)
        {
            // 1. SẮP XẾP TUYỆT ĐỐI: Dù Admin chọn thế nào, code vẫn nắn lại theo quy tắc chuẩn
            // Sắp xếp theo Ngành -> Tên -> Họ đệm (Đảm bảo thứ tự định danh luôn cố định)
            var sortedList = selectedRows.Select(r => new {
                Row = r,
                CandidateID = r.Cells["CandidateID"].Value.ToString(),
                Major = r.Cells["MajorCode"].Value.ToString(),
                Year = r.Cells["EnrollmentYear"].Value.ToString()
            }).OrderBy(x => x.Major).ThenBy(x => x.CandidateID).ToList();

            db.openConnection();
            SqlTransaction trans = db.getConnection().BeginTransaction();

            try
            {
                foreach (var item in sortedList)
                {
                    // 2. TÍNH TOÁN MSSV TỰ ĐỘNG
                    // Lấy số lượng sinh viên ĐÃ TỒN TẠI của ngành đó trong bảng Student
                    int currentCount = GetCurrentStudentCount(item.Major, item.Year, trans);

                    // MSSV = Năm(2) + Ngành(3) + (Số lượng + 1)
                    string mssvString = item.Year.Substring(2) + item.Major + (currentCount + 1).ToString("D3");
                    int newMSSV = int.Parse(mssvString);

                    // 3. ỦY QUYỀN (AUTHORIZATION)
                    // Tạo tài khoản với trạng thái valid = 1 để cho phép đăng nhập
                    string sqlAcc = "INSERT INTO [Table] (username, password, valid, studentID, position, email) " +
                                    "VALUES (@user, @user, 1, @sid, 1, @email); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdAcc = new SqlCommand(sqlAcc, db.getConnection(), trans);
                    cmdAcc.Parameters.AddWithValue("@user", mssvString);
                    cmdAcc.Parameters.AddWithValue("@sid", mssvString);
                    cmdAcc.Parameters.AddWithValue("@email", item.Row.Cells["Email"].Value.ToString());
                    int accountId = Convert.ToInt32(cmdAcc.ExecuteScalar());

                    // 4. LƯU HỒ SƠ SINH VIÊN
                    string sqlStu = "INSERT INTO Student (Id, MSSV, Name, Phone, Email, Dob, Gder, Address) " +
                                    "VALUES (@id, @mssv, @name, @phn, @email, @dob, @gdr, @adrs)";
                    SqlCommand cmdStu = new SqlCommand(sqlStu, db.getConnection(), trans);
                    cmdStu.Parameters.AddWithValue("@id", accountId);
                    cmdStu.Parameters.AddWithValue("@mssv", newMSSV);
                    cmdStu.Parameters.AddWithValue("@name", item.Row.Cells["FullName"].Value.ToString());
                    // ... (các tham số khác từ item.Row) ...
                    cmdStu.ExecuteNonQuery();

                    // 5. CẬP NHẬT TRẠNG THÁI ADMISSION
                    string sqlAdm = "UPDATE AdmissionList SET IsAccountCreated = 1 WHERE CandidateID = @cid";
                    SqlCommand cmdAdm = new SqlCommand(sqlAdm, db.getConnection(), trans);
                    cmdAdm.Parameters.AddWithValue("@cid", item.CandidateID);
                    cmdAdm.ExecuteNonQuery();
                }
                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw ex;
            }
            finally { db.closeConnection(); }
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