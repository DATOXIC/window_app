using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;

namespace window_app
{
    internal class Student
    {
        myDB db = new myDB();
        public int Id { get; set; }
        public int MSSV { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool insertStudent(int id, int mssv, string name, string phone, string email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Student (Id, MSSV, Name, Phone, Email) VALUES (@id, @mssv, @name, @phone, @email)", db.getConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

            db.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            db.closeConnection();
            return result;
        }

        public bool updateStudent(int id, int mssv, string name, string phone, string email)
        {
            SqlCommand command = new SqlCommand("UPDATE Student SET MSSV=@mssv, Name=@name, Phone=@phone, Email=@email WHERE Id=@id", db.getConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

            db.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            db.closeConnection();

            return result;
        }

        public bool deleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Student WHERE Id=@id", db.getConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            db.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            db.closeConnection();

            return result;
        }

        public DataTable getStudents()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Student", db.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table); // Đổ dữ liệu vào DataTable 

            return table;
        }

        
    }
}
