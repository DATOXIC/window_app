using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
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
        public string BaseSalary { get; private set; }
        // Hàm Insert riêng cho Teacher (Lưu vào bảng Teacher trong DB)
        public bool InsertTeacher(string tID, string fname, string lname, string dept, string email, string phone)
        {
            // Gán giá trị cho thuộc tính của đối tượng
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
    }
}
