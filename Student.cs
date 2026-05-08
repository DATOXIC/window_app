using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace window_app
{
    internal class Student
    {
        public int MSSV { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // Các phương thức nghiệp vụ theo lộ trình [cite: 67]
        public bool insertStudent() { /* Logic sẽ thêm sau */ return true; }
        public bool updateStudent() { /* Logic Tuần 04 [cite: 19] */ return true; }
        public bool deleteStudent() { /* Logic Tuần 04 [cite: 19] */ return true; }
        public DataTable getStudents() { return new DataTable(); }
    }
}
