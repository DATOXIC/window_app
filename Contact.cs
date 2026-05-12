using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace window_app
{
    // Contact cũng là một Person
    internal class Contact : Person, MutualFunc
    {
        // Thuộc tính riêng của Contact (Đóng gói)
        myDB db = new myDB();
        public int Id { get; set; }
        public int GroupId { get; set; } // Liên kết với bảng nhóm (Groups)
        public int UserId { get; set; }  // ID của người dùng sở hữu danh bạ này


        public bool Insert()
        {
            // Logic SQL INSERT INTO Course...
            return true;
        }
        public Contact(string fname, string lname, string phone, string address, string email, int groupId, int userId, byte[] picture)
            : base(fname, lname, DateTime.MinValue, "", phone, address, email, picture) // DOB và Gender có thể để mặc định nếu bảng Contact không yêu cầu
        {
            this.GroupId = groupId;
            this.UserId = userId;
        }
        public Contact() : base() { }

        public bool Update() { /* Logic SQL UPDATE... */ return true; }
        public bool Delete(int id) { /* Logic SQL DELETE... */ return true; }
        public DataTable GetData(SqlCommand command) { /* Logic nạp data... */ return new DataTable(); }

        private bool ExecuteNonQuery(string sql)
        {
            SqlCommand command = new SqlCommand(sql, db.getConnection());

            // Nếu là Update thì cần ID
            command.Parameters.AddWithValue("@id", this.Id);

            command.Parameters.AddWithValue("@fn", this.Fname);
            command.Parameters.AddWithValue("@ln", this.Lname);
            command.Parameters.AddWithValue("@gid", this.GroupId);
            command.Parameters.AddWithValue("@phn", this.Phone);
            command.Parameters.AddWithValue("@mail", this.Email);
            command.Parameters.AddWithValue("@adrs", this.Address);
            command.Parameters.AddWithValue("@uid", this.UserId);
            command.Parameters.AddWithValue("@pic", (this.Picture != null) ? this.Picture : (object)DBNull.Value);

            db.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            db.closeConnection();
            return result;
        }
    }
}
