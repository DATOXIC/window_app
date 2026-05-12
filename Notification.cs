using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace window_app
{
    internal class Notification
    {
        myDB db = new myDB();

        public int NotifId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string SentBy { get; set; }
        public DateTime SentDate { get; set; }
        public string NotifType { get; set; }
        public string TargetMSSV { get; set; }

        // Lấy thông báo chung (General)
        public DataTable GetGeneralNotifications()
        {
            string sql = "SELECT NotifId, Subject, SentBy, SentDate FROM Notification WHERE NotifType = 'General' ORDER BY SentDate DESC";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            try
            {
                db.openConnection();
                adapter.Fill(table);
            }
            finally { db.closeConnection(); }
            return table;
        }

        // Lấy thông báo cá nhân (Personal) theo MSSV
        public DataTable GetPersonalNotifications(string mssv)
        {
            string sql = "SELECT NotifId, Subject, SentBy, SentDate FROM Notification WHERE NotifType = 'Personal' AND TargetMSSV = @mssv ORDER BY SentDate DESC";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@mssv", mssv);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            try
            {
                db.openConnection();
                adapter.Fill(table);
            }
            finally { db.closeConnection(); }
            return table;
        }

        // Tìm kiếm thông báo theo từ khóa + loại
        public DataTable SearchNotifications(string keyword, string type, string mssv)
        {
            string sql;
            if (type == "Personal")
            {
                sql = "SELECT NotifId, Subject, SentBy, SentDate FROM Notification WHERE NotifType = 'Personal' AND TargetMSSV = @mssv AND (Subject LIKE @kw OR SentBy LIKE @kw) ORDER BY SentDate DESC";
            }
            else
            {
                sql = "SELECT NotifId, Subject, SentBy, SentDate FROM Notification WHERE NotifType = 'General' AND (Subject LIKE @kw OR SentBy LIKE @kw) ORDER BY SentDate DESC";
            }

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
            if (type == "Personal")
                cmd.Parameters.AddWithValue("@mssv", mssv);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            try
            {
                db.openConnection();
                adapter.Fill(table);
            }
            finally { db.closeConnection(); }
            return table;
        }

        // Lấy chi tiết 1 thông báo
        public DataTable GetNotificationDetail(int notifId)
        {
            string sql = "SELECT * FROM Notification WHERE NotifId = @id";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@id", notifId);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            try
            {
                db.openConnection();
                adapter.Fill(table);
            }
            finally { db.closeConnection(); }
            return table;
        }
    }
}
