﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO; // Thêm dòng này để dùng MemoryStream

namespace window_app
{
    public class studentModel
    {
        public int Id { get; private set; }
        public int MSSV { get; private set; }
        public string Fname { get; private set; }
        public string Lname { get; private set; }
        public DateTime Dob { get; private set; }
        public string Gder { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }
        public byte[] Picture { get; private set; }
    }
    public class PendingStudentDTO
    {
        public string CandidateID { get; set; }
        public string FullName { get; set; }
        public string MajorCode { get; set; }
        public string Email { get; set; }
        public int EnrollmentYear { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
    }
    internal class Student
    {
        private readonly myDB db = new myDB();

        // 1. Hàm Thêm sinh viên (Dành cho Admin nhập tay)

        public bool Insert(studentModel student)
        {
            string sql = "INSERT INTO Student (MSSV, Fname, Lname, Dob, Gder, Phone, Address, Email, Pture) " +
                         "VALUES (@mssv, @fn, @ln, @dob, @gdr, @phn, @adrs, @email, @pic)";
            using (SqlCommand command = new SqlCommand(sql, db.getConnection()))
            {
                command.Parameters.AddWithValue("@mssv", student.MSSV);
                command.Parameters.AddWithValue("@fn", student.Fname);
                command.Parameters.AddWithValue("@ln", student.Lname);
                command.Parameters.AddWithValue("@dob", student.Dob);
                command.Parameters.AddWithValue("@gdr", student.Gder);
                command.Parameters.AddWithValue("@phn", student.Phone);
                command.Parameters.AddWithValue("@adrs", student.Address);
                command.Parameters.AddWithValue("@email", student.Email);
                command.Parameters.AddWithValue("@pic", (student.Picture != null) ? student.Picture : (object)DBNull.Value);

                db.openConnection();
                bool result = (command.ExecuteNonQuery() == 1);
                db.closeConnection();
                return result;
            }
        }


        // 2. Hàm Cập nhật sinh viên (Đã sửa lại khớp với cấu trúc mới)
        public bool Update(studentModel student)
        {
            string sql = "UPDATE Student SET Fname=@fn, Lname=@ln, Dob=@dob, Gder=@gdr, Phone=@phn, Address=@adrs, Email=@email, Pture=@pic WHERE MSSV=@mssv";

            using (SqlCommand command = new SqlCommand(sql, db.getConnection()))
            {
                command.Parameters.AddWithValue("@mssv", student.MSSV);
                command.Parameters.AddWithValue("@fn", student.Fname);
                command.Parameters.AddWithValue("@ln", student.Lname);
                command.Parameters.AddWithValue("@dob", student.Dob);
                command.Parameters.AddWithValue("@gdr", student.Gder);
                command.Parameters.AddWithValue("@phn", student.Phone);
                command.Parameters.AddWithValue("@adrs", student.Address);
                command.Parameters.AddWithValue("@email", student.Email);
                command.Parameters.AddWithValue("@pic", (student.Picture != null) ? student.Picture : (object)DBNull.Value);

                db.openConnection();
                bool result = (command.ExecuteNonQuery() == 1);
                db.closeConnection();
                return result;
            }
        }

        // 3. Hàm Xóa sinh viên --> THÊM LẠI VÀO ADMISSION REVIEW
        public bool Delete(int mssv)
        {
            try
            {
                db.openConnection();

                // 1. Lấy thông tin sinh viên từ bảng Student
                string selectQuery = "SELECT * FROM Student WHERE MSSV = @mssv";

                SqlCommand selectCmd = new SqlCommand(selectQuery, db.getConnection());
                selectCmd.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;

                SqlDataReader reader = selectCmd.ExecuteReader();

                if (!reader.Read())
                {
                    reader.Close();
                    db.closeConnection();
                    return false;
                }

                // Lưu dữ liệu student
                string fullname = reader["Fname"].ToString() + " " + reader["Lname"].ToString();
                string email = reader["Email"].ToString();
                string phone = reader["Phone"].ToString();
                string address = reader["Address"].ToString();
                string gender = reader["Gder"].ToString();

                DateTime dob = Convert.ToDateTime(reader["Dob"]);

                // MSSV: 23110003
                // MajorCode: 110
                string majorCode = mssv.ToString().Substring(2, 3);

                // EnrollmentYear: 2023
                int enrollmentYear = Convert.ToInt32("20" + mssv.ToString().Substring(0, 2));

                reader.Close();

                string clearOldQuery = "DELETE FROM AdmissionList WHERE Email = @email OR CandidateID = @cid";
                SqlCommand clearCmd = new SqlCommand(clearOldQuery, db.getConnection());
                clearCmd.Parameters.AddWithValue("@email", email);
                clearCmd.Parameters.AddWithValue("@cid", "TS" + mssv.ToString());
                clearCmd.ExecuteNonQuery();

                // 2. Insert lại vào AdmissionList
                string insertQuery =
                    "INSERT INTO AdmissionList " +
                    "(CandidateID, FullName, Email, MajorCode, EnrollmentYear, IsAccountCreated, Dob, Gender, Phone, Address) " +
                    "VALUES " +
                    "(@cid, @fullname, @email, @major, @year, 0, @dob, @gender, @phone, @address)";

                SqlCommand insertCmd = new SqlCommand(insertQuery, db.getConnection());

                insertCmd.Parameters.AddWithValue("@cid", "TS" + mssv.ToString());
                insertCmd.Parameters.AddWithValue("@fullname", fullname);
                insertCmd.Parameters.AddWithValue("@email", email);
                insertCmd.Parameters.AddWithValue("@major", majorCode);
                insertCmd.Parameters.AddWithValue("@year", enrollmentYear);
                insertCmd.Parameters.AddWithValue("@dob", dob);
                insertCmd.Parameters.AddWithValue("@gender", gender);
                insertCmd.Parameters.AddWithValue("@phone", phone);
                insertCmd.Parameters.AddWithValue("@address", address);

                insertCmd.ExecuteNonQuery();

                // 3. Xóa khỏi Student
                string deleteQuery = "DELETE FROM Student WHERE MSSV = @mssv";

                SqlCommand deleteCmd = new SqlCommand(deleteQuery, db.getConnection());

                deleteCmd.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;

                bool result = deleteCmd.ExecuteNonQuery() == 1;

                // 4. Xóa khỏi table ssms
                // XÓA ACCOUNT TRONG TABLE
                string deleteAccount =
                    "DELETE FROM [Table] WHERE username = @user";

                SqlCommand deleteAccCmd =
                new SqlCommand(deleteAccount, db.getConnection());

                deleteAccCmd.Parameters.AddWithValue("@user", mssv.ToString());

                deleteAccCmd.ExecuteNonQuery();

                db.closeConnection();

                return result;
            }
            catch (Exception ex)
            {
                db.closeConnection();
                MessageBox.Show("Lỗi");
                return false;
            }
        }

        // 4. Hàm lấy danh sách sinh viên
        public DataTable GetData(SqlCommand command)
        {
            command.Connection = db.getConnection();
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        /// <summary>
        /// Tự động ghi danh sinh viên từ danh sách trúng tuyển (AdmissionList).
        /// Hàm sẽ cấp tài khoản đăng nhập (mật khẩu mặc định bằng MSSV), 
        /// lưu hồ sơ chi tiết và đánh dấu thí sinh đã được duyệt thành công.
        /// </summary>
        /// <param name="candidateId">Mã hồ sơ thí sinh</param>
        /// <param name="fullName">Họ và tên đầy đủ</param>
        /// <param name="majorCode">Mã ngành (ví dụ: 110, 120)</param>
        /// <param name="year">Năm nhập học (để sinh tiền tố MSSV)</param>
        /// <returns>Trả về <c>true</c> nếu toàn bộ luồng tạo tài khoản và hồ sơ thành công 100%.</returns>
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
            // Bắt đầu Transaction để tránh sinh ra dữ liệu mồ côi (ví dụ: có account nhưng mất student profile nếu lỗi giữa chừng)
            using (SqlTransaction trans = db.getConnection().BeginTransaction())
            {
                try
                {
                    // BƯỚC A: Tạo tài khoản đăng nhập.
                    string sqlAcc = "INSERT INTO [Table] (username, password, valid, studentID, position, email) " +
                                    "VALUES (@user, @user, 1, @sid, 1, @email); SELECT SCOPE_IDENTITY();";

                    int accountId;
                    using (SqlCommand cmdAcc = new SqlCommand(sqlAcc, db.getConnection(), trans))
                    {
                        cmdAcc.Parameters.AddWithValue("@user", mssvString);
                        cmdAcc.Parameters.AddWithValue("@sid", mssvString); // Cột studentID trong [Table]
                        cmdAcc.Parameters.AddWithValue("@email", email);
                        // SCOPE_IDENTITY() giúp lấy ngay ID vừa được Identity tự sinh trong [Table]
                        accountId = Convert.ToInt32(cmdAcc.ExecuteScalar());
                    }

                    // BƯỚC B: Tạo hồ sơ Student liên kết với ID tài khoản phía trên
                    string sqlStu = "INSERT INTO Student (Id, MSSV, Name, Phone, Email, Fname, Lname, Dob, Gder, Address) " +
                                    "VALUES (@id, @mssv, @name, @phn, @email, @fn, @ln, @dob, @gdr, @adrs)";

                    using (SqlCommand cmdStu = new SqlCommand(sqlStu, db.getConnection(), trans))
                    {
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
                    }

                    // BƯỚC C: Đánh dấu đã cấp tài khoản để ngăn ngừa việc xử lý trùng lặp
                    string sqlAdm = "UPDATE AdmissionList SET IsAccountCreated = 1 WHERE CandidateID = @cid";
                    using (SqlCommand cmdAdm = new SqlCommand(sqlAdm, db.getConnection(), trans))
                    {
                        cmdAdm.Parameters.AddWithValue("@cid", candidateId);
                        cmdAdm.ExecuteNonQuery();
                    }

                    // Hoàn tất và lưu vĩnh viễn các thay đổi vào CSDL
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
        }
        // 6. Hàm Sinh MSSV tự động
        private string GenerateNewMSSV(string year, string majorCode)
        {
            string yearPrefix = year.Substring(year.Length - 2);
            string prefix = yearPrefix + majorCode;
            string query = "SELECT MAX(MSSV) FROM Student WHERE CAST(MSSV AS VARCHAR) LIKE @pattern";

            using (SqlCommand command = new SqlCommand(query, db.getConnection()))
            {
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

            DataTable table = new DataTable();

            try
            {
                using (SqlCommand command = new SqlCommand(sql, db.getConnection()))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    db.openConnection();
                    adapter.Fill(table);
                }
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
                using (SqlCommand cmd = new SqlCommand(sql, db.getConnection()))
                {
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

        /// <summary>
        /// Từ chối thí sinh — xóa khỏi AdmissionList (chỉ xóa thí sinh chưa được cấp tài khoản).
        /// </summary>
        public bool RejectCandidate(string candidateId)
        {
            string sql = "DELETE FROM AdmissionList WHERE CandidateID = @cid AND IsAccountCreated = 0";

            using (SqlCommand cmd = new SqlCommand(sql, db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@cid", candidateId);
                try
                {
                    db.openConnection();
                    int result = cmd.ExecuteNonQuery();
                    db.closeConnection();
                    return result > 0;
                }
                catch
                {
                    db.closeConnection();
                    return false;
                }
            }
        }

        // --- PHẦN 2: LOGIC PHÊ DUYỆT VÀ CẤP MSSV (Từ nhánh master) ---
        /// <summary>
        /// Tính toán số thứ tự (rank) để cấp MSSV cho một sinh viên trong đợt phê duyệt hiện tại.
        /// Việc cấp số được nối tiếp từ số thứ tự lớn nhất đã có trong DB, cộng thêm 
        /// vị trí xếp hạng theo bảng chữ cái của sinh viên đó trong danh sách đang chờ duyệt.
        /// </summary>
        /// <param name="majorCode">Mã ngành học (Ví dụ: 110, 120)</param>
        /// <param name="year">Năm nhập học (Ví dụ: 2024)</param>
        /// <param name="fullName">Họ và tên đầy đủ của thí sinh</param>
        /// <param name="candidateId">Mã hồ sơ thí sinh (dùng để xử lý trùng tên)</param>
        /// <param name="trans">SqlTransaction đảm bảo đồng bộ dữ liệu</param>
        /// <returns>Số thứ tự cuối cùng (int) dùng để ráp thành MSSV hoàn chỉnh</returns>
        private int GetAlphabeticalRank(string majorCode, int year, string fullName, string candidateId, SqlTransaction trans)
        {
            // Lấy số thứ tự lớn nhất của sinh viên thuộc khóa/ngành này đã nằm sẵn trong DB
            int currentMaxRank = GetCurrentStudentCount(majorCode, year.ToString(), trans);

            // Đếm số lượng sinh viên trong đợt chờ duyệt (IsAccountCreated = 0) có thứ tự alphabet đứng trước sinh viên này.
            // Cụm (FullName = @name AND CandidateID <= @cid) hoạt động như 'tie-breaker' để phân định những người trùng y hệt họ tên, đảm bảo rank luôn tăng tuần tự.
            string sql = @"
        SELECT COUNT(*) + 1 
        FROM AdmissionList 
        WHERE MajorCode = @major 
        AND EnrollmentYear = @year 
        AND IsAccountCreated = 0
        AND (FullName < @name OR (FullName = @name AND CandidateID <= @cid))";

            using (SqlCommand cmd = new SqlCommand(sql, db.getConnection(), trans))
            {
                cmd.Parameters.AddWithValue("@major", majorCode);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@name", fullName);
                cmd.Parameters.AddWithValue("@cid", candidateId);

                // Rank cuối cùng = (STT lớn nhất đã có trong DB) + (Vị trí của sinh viên trong đợt duyệt hiện tại)
                // Ví dụ: DB đã có 10 người, bạn đứng thứ 3 trong đợt duyệt hiện tại => Rank = 10 + 3 = 13
                return currentMaxRank + (int)cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// Phê duyệt hàng loạt sinh viên trúng tuyển. 
        /// Hàm này tự động tạo tài khoản, cấp mã số sinh viên (MSSV) dựa trên thứ tự bảng chữ cái, 
        /// và lưu thông tin hồ sơ sinh viên vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="selectedStudents">Danh sách các sinh viên đang chờ duyệt.</param>
        /// <param name="picture">Luồng dữ liệu ảnh đại diện mặc định sẽ được gán cho các sinh viên này.</param>
        /// <returns>Trả về <c>true</c> nếu toàn bộ quá trình phê duyệt thành công.</returns>
        public bool ApproveBatchStudents(List<PendingStudentDTO> selectedStudents, MemoryStream picture = null)
        {
            // Sắp xếp danh sách sinh viên theo tên để đảm bảo việc cấp MSSV (STT) đi theo đúng thứ tự bảng chữ cái
            var sortedStudents = selectedStudents.OrderBy(s => s.FullName).ToList();

            db.openConnection();
            // Sử dụng Transaction: Nếu xảy ra lỗi ở bất kỳ thao tác Insert/Update nào của bất kỳ sinh viên nào, 
            // toàn bộ quá trình sẽ được hoàn tác (Rollback), tránh tình trạng sinh ra dữ liệu rác (VD: Có Account nhưng mất Student)
            using (SqlTransaction trans = db.getConnection().BeginTransaction())
            {
                try
                {
                    foreach (var student in sortedStudents)
                    {
                        string cid = student.CandidateID;
                        string fullName = student.FullName;
                        string majorCode = student.MajorCode;
                        string email = student.Email;
                        int year = student.EnrollmentYear;
                        string phone = student.Phone;
                        string address = student.Address;
                        string gender = student.Gender;
                        DateTime dob = student.Dob;

                        // Tính toán MSSV theo Format: [2 số cuối của năm nhập học] + [Mã ngành] + [STT 3 chữ số]
                        int rank = GetAlphabeticalRank(majorCode, year, fullName, cid, trans);
                        string yearPrefix = year.ToString().Substring(year.ToString().Length - 2);
                        string mssvString = yearPrefix + majorCode + rank.ToString("D3");

                        // 3.1.5: Tách tên (Fname, Lname) từ FullName
                        string[] names = fullName.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        string lastName = "";
                        string firstName = "";
                        if (names.Length == 0)
                        {
                            lastName = "Unknown";
                            firstName = "Unknown";
                        }
                        else if (names.Length == 1)
                        {
                            // Nếu tên chỉ có 1 chữ, gán cả họ và tên để tránh lỗi DB
                            lastName = names[0];
                            firstName = names[0]; 
                        }
                        else
                        {
                            lastName = names[names.Length - 1];
                            firstName = string.Join(" ", names, 0, names.Length - 1);
                        }

                        // Kiểm tra bảo mật lần cuối trước khi chèn vào DB
                        if (string.IsNullOrWhiteSpace(firstName)) firstName = "Unknown";
                        if (string.IsNullOrWhiteSpace(lastName)) lastName = "Unknown";
                        // 3.1: Chèn vào bảng [Table]
                        string sqlAccount = "INSERT INTO [Table] (username, password, valid, position, email) " +
                                            "VALUES (@user, @pass, 1, 1, @email); SELECT SCOPE_IDENTITY();"; // Dùng SCOPE_IDENTITY() để lấy ngay ID của tài khoản vừa tạo

                        int newAccountId;
                        using (SqlCommand cmdAccount = new SqlCommand(sqlAccount, db.getConnection(), trans))
                        {
                            cmdAccount.Parameters.AddWithValue("@user", mssvString);
                            cmdAccount.Parameters.AddWithValue("@pass", db.HashPassword(mssvString));
                            cmdAccount.Parameters.AddWithValue("@email", email);
                            newAccountId = Convert.ToInt32(cmdAccount.ExecuteScalar());
                        }

                        // 3.2: Chèn vào bảng Student
                        string sqlStudent = "INSERT INTO Student (Id, MSSV, Name, Phone, Email, Dob, Gder, Address, Pture, Fname, Lname) " +
                            "VALUES (@id, @mssv, @name, @phone, @email, @dob, @gdr, @adrs, @pic, @fn, @ln)";

                        using (SqlCommand cmdStudent = new SqlCommand(sqlStudent, db.getConnection(), trans))
                        {
                            cmdStudent.Parameters.AddWithValue("@id", newAccountId);
                            cmdStudent.Parameters.AddWithValue("@mssv", mssvString);
                            cmdStudent.Parameters.AddWithValue("@name", fullName);
                            cmdStudent.Parameters.AddWithValue("@phone", phone);
                            cmdStudent.Parameters.AddWithValue("@email", email);
                            cmdStudent.Parameters.AddWithValue("@dob", dob);
                            cmdStudent.Parameters.AddWithValue("@gdr", gender);
                            cmdStudent.Parameters.AddWithValue("@adrs", address);
                            // cmdStudent.Parameters.AddWithValue("@pic", picture != null ? (object)picture.ToArray() : DBNull.Value);
                            cmdStudent.Parameters.AddWithValue("@fn", firstName);
                            cmdStudent.Parameters.AddWithValue("@ln", lastName);
                            
                            // Khai báo rõ ràng kiểu dữ liệu là Image cho SQL Server hiểu
                            SqlParameter picParam = new SqlParameter("@pic", SqlDbType.Image);
                            if (picture != null)
                            {
                                picParam.Value = picture.ToArray();
                            }
                            else
                            {
                                picParam.Value = DBNull.Value;
                            }
                            cmdStudent.Parameters.Add(picParam);

                            cmdStudent.ExecuteNonQuery();
                        }

                        // 3.3: Cập nhật studentID cho Account
                        string sqlUpdateAcc = "UPDATE [Table] SET studentID = @sid WHERE id = @aid";
                        using (SqlCommand cmdUpdateAcc = new SqlCommand(sqlUpdateAcc, db.getConnection(), trans))
                        {
                            cmdUpdateAcc.Parameters.AddWithValue("@sid", mssvString);
                            cmdUpdateAcc.Parameters.AddWithValue("@aid", newAccountId);
                            cmdUpdateAcc.ExecuteNonQuery();
                        }

                        // 3.4: Đánh dấu đã phê duyệt trong AdmissionList
                        string sqlUpdateAdm = "UPDATE AdmissionList SET IsAccountCreated = 1 WHERE CandidateID = @cid";
                        using (SqlCommand cmdUpdateAdm = new SqlCommand(sqlUpdateAdm, db.getConnection(), trans))
                        {
                            cmdUpdateAdm.Parameters.AddWithValue("@cid", cid);
                            cmdUpdateAdm.ExecuteNonQuery();
                        }
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
        }

        /// <summary>
/// Truy vấn số thứ tự (3 số cuối) lớn nhất của sinh viên dựa trên mã ngành và năm nhập học.
/// Hàm này sử dụng SQL Transaction để đảm bảo tính nhất quán dữ liệu khi chạy hàng loạt.
/// </summary>
/// <param name="major">Mã ngành học (ví dụ: 110, 120).</param>
/// <param name="year">Năm nhập học (ví dụ: 2024 hoặc 24).</param>
/// <param name="trans">Đối tượng <see cref="SqlTransaction"/> để thực thi lệnh trong một phiên làm việc an toàn.</param>
/// <returns>Trả về số thứ tự lớn nhất hiện có (kiểu int). Nếu chưa có sinh viên nào thì trả về 0.</returns>
private int GetCurrentStudentCount(string major, string year, SqlTransaction trans)
{
    // Bước 1: Xử lý chuỗi để lấy 2 số cuối của năm (ví dụ: 2024 -> 24)
    string yearPrefix = year.Length > 2 ? year.Substring(year.Length - 2) : year;
    
    // Bước 2: Tạo tiền tố (prefix) tìm kiếm. Ví dụ: 24 (năm) + 110 (ngành) = 24110
    string prefix = yearPrefix + major; 

    // Bước 3: Dùng hàm MAX() trong SQL để tìm MSSV lớn nhất có tiền tố này.
    // Việc dùng MAX giúp tránh lỗi trùng lặp mã nếu trước đó có sinh viên bị xóa.
    string sql = "SELECT MAX(MSSV) FROM Student WHERE CAST(MSSV AS VARCHAR) LIKE @prefix";

    // Khởi tạo command kèm theo Transaction để đảm bảo tính an toàn dữ liệu (Atomicity)
    using (SqlCommand cmd = new SqlCommand(sql, db.getConnection(), trans))
    {
        // Dùng toán tử LIKE với ký tự đại diện % để tìm các MSSV "bắt đầu với" tiền tố trên
        cmd.Parameters.AddWithValue("@prefix", prefix + "%");

        // ExecuteScalar lấy về giá trị duy nhất ở ô đầu tiên (MAX MSSV)
        object result = cmd.ExecuteScalar();

        // Nếu DB chưa có sinh viên nào thuộc ngành/năm này, kết quả sẽ là NULL
        if (result == DBNull.Value || result == null)
        {
            return 0; // Trả về 0 để sinh viên đầu tiên sẽ có STT là 1 (0 + 1)
        }

        // Bước 4: "Bóc tách" lấy 3 ký tự cuối cùng của MSSV lớn nhất tìm được
        // Ví dụ: MSSV '24110003' -> lấy được chuỗi '003'
        string maxMssvStr = result.ToString();
        string suffix = maxMssvStr.Substring(maxMssvStr.Length - 3);
        
        // Ép kiểu về int để trả về số 3 cho hàm xử lý tiếp theo
        return int.Parse(suffix);
    }
}
    }
}