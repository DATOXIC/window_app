using System;
using System.Collections.Generic;
using System.Text;

namespace window_app
{
    // Contact cũng là một Person
    internal class Contact : Person
    {
        // Thuộc tính riêng của Contact (Ví dụ: Nhóm người liên hệ)
        public int ContactId { get; set; }
        public string GroupName { get; set; }

        // Lớp này cũng nghiễm nhiên có Fname, Lname, Email... từ Person gửi sang
    }
}
