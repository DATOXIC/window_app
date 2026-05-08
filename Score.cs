using System;
using System.Collections.Generic;
using System.Text;

namespace window_app
{
    internal class Score
    {
        public string Mssv { get; set; } // Mã sinh viên [cite: 71]
        public string Mamh { get; set; } // Mã môn học [cite: 71]
        public decimal Diemqt { get; set; } // Điểm quá trình [cite: 71]
        public decimal Diemck { get; set; } // Điểm cuối kỳ [cite: 71]
        public decimal Diemtk { get; set; } // Điểm tổng kết [cite: 71]
        public string Mota { get; set; } // Ghi chú [cite: 71]

        // Phương thức tính điểm TK theo công thức: QT*0.4 + CK*0.6 [cite: 61]
        public decimal CalculateAverage() => (Diemqt * 0.4m) + (Diemck * 0.6m);
    }
}
