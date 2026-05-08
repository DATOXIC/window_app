using System;
using System.Collections.Generic;
using System.Text;

namespace window_app
{
    internal class Contact
    {
        public int ID { get; set; } // Mã liên hệ [cite: 77]
        public string Fname { get; set; }

        public string Lname { get; set; }
        public string GroupID { get; set; } // Mã nhóm liên hệ [cite: 77]
        public string Phone { get; set; }
     
        public string Email { get; set; }
        public int UserID { get; set; } // Liên kết với người dùng sở hữu danh bạ [cite: 77]
    }
}
