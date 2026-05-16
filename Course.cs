using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace window_app
{
    // Course: Thực thi Interface IBaseEntity (Tính trừu tượng)
    internal class Course : MutualFunc
    {
        myDB db = new myDB();

        // Thuộc tính (Đóng gói)
        public int Id { get; set; }
        public string Label { get; set; }
        public int Period { get; set; }
        public string Description { get; set; }

        // 1. HÀM KHỞI TẠO (Constructor)
        public Course(int id, string label, int period, string description)
        {
            this.Id = id;
            this.Label = label;
            this.Period = period;
            this.Description = description;
        }

        // Constructor rỗng dùng khi chỉ cần gọi hàm GetData hoặc Delete
        public Course() { }

        

        // Thêm khóa học mới
        public bool Insert()
        {
            string sql = "INSERT INTO Course (CourseId, CourseName, Period, description) VALUES (@id, @lbl, @per, @desc)";
            return ExecuteNonQuery(sql, true);
        }

        // Cập nhật khóa học
        public bool Update()
        {
            string sql = "UPDATE Course SET CourseName = @lbl, Period = @per, description = @desc WHERE CourseId = @id";
            return ExecuteNonQuery(sql, false);
        }

        // Xóa khóa học
        public bool Delete(int courseId)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Course WHERE CourseId = @id", db.getConnection()))
            {
                command.Parameters.AddWithValue("@id", courseId);

                db.openConnection();
                bool result = (command.ExecuteNonQuery() == 1);
                db.closeConnection();
                return result;
            }
        }

        // Lấy dữ liệu (Tính đa hình)
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

        // 3. CÁC HÀM HỖ TRỢ VÀ NGHIỆP VỤ RIÊNG

        // Hàm phụ dùng chung để thực thi lệnh SQL (Tính đóng gói logic)
        private bool ExecuteNonQuery(string sql, bool isInsert)
        {
            using (SqlCommand command = new SqlCommand(sql, db.getConnection()))
            {
                command.Parameters.AddWithValue("@id", this.Id);
                command.Parameters.AddWithValue("@lbl", this.Label);
                command.Parameters.AddWithValue("@per", this.Period);
                command.Parameters.AddWithValue("@desc", this.Description);

                db.openConnection();
                bool result = (command.ExecuteNonQuery() == 1);
                db.closeConnection();
                return result;
            }
        }

        // Hàm kiểm tra tên khóa học đã tồn tại chưa (Nghiệp vụ riêng)
        public bool CheckCourseName(string courseName, int courseId = 0)
        {
            // Nếu courseId = 0 là kiểm tra cho Insert, nếu khác 0 là cho Update (trừ chính nó)
            string sql = (courseId == 0)
                ? "SELECT * FROM Course WHERE CourseName = @name"
                : "SELECT * FROM Course WHERE CourseName = @name AND CourseId <> @id";

            using (SqlCommand command = new SqlCommand(sql, db.getConnection()))
            {
                command.Parameters.AddWithValue("@name", courseName);
                command.Parameters.AddWithValue("@id", courseId);

                DataTable table = GetData(command);
                return table.Rows.Count > 0;
            }
        }

        // Nạp chồng (Overloading) hàm lấy danh sách khóa học
        public DataTable GetAllCourses()
        {
            return GetData(new SqlCommand("SELECT * FROM Course"));
        }

        public int GetCount() 
        {
            string sql = "SELECT count(*) FROM Course";
            using (SqlCommand command = new SqlCommand(sql, db.getConnection()))
            {
                db.openConnection();
                int count = (int)command.ExecuteScalar();
                db.closeConnection();
                return count;
            }
        }
    }
}