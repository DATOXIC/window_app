using System;
using System.Collections.Generic;
using System.Text;

namespace window_app
{
    internal class Course
    {
        public string Mamh { get; set; } // Mã môn học [cite: 69]
        public string Tenmh { get; set; } // Tên môn học [cite: 69]
        public int Sotc { get; set; } // Số tín chỉ [cite: 69]
        public int Tuan { get; set; } // Số tuần học [cite: 69]
        public int Hocky { get; set; } // Học kỳ [cite: 69]
        public string Decription { get; set; } // Mô tả [cite: 69]

        public bool addCourse() { return true; }
        public bool editCourse() { return true; }
        public bool delCourse() { return true; }
    }
}
