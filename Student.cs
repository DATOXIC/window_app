using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace window_app
{
    internal class Student
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime Bdate { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public MemoryStream Picture { get; set; }

        // Các phương thức nghiệp vụ theo lộ trình [cite: 67]
        public bool insertStudent() { /* Logic sẽ thêm sau */ return true; }
        public bool updateStudent() { /* Logic Tuần 04 [cite: 19] */ return true; }
        public bool deleteStudent() { /* Logic Tuần 04 [cite: 19] */ return true; }
        public DataTable getStudents() { return new DataTable(); }
    }
}
