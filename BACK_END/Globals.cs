using System;
using System.Collections.Generic;
using System.Text;

namespace window_app
{
    public enum UserRole
    {
        Admin = 0,
        Student = 1,
        HR = 2
    }
    internal class Globals
    {
        public static int GlobalUserId { get; private set; }
        public static string GlobalUsername { get; private set; }
        public static UserRole GlobalRole { get; private set; }
        public static string GlobalStudentID { get; private set; }

        // Hàm thiết lập thông tin khi đăng nhập thành công
        public static void SetLoginSession(int userId, string username, int role, string studentID)
        {
            GlobalUserId = userId;
            GlobalUsername = username;
            GlobalRole = (UserRole)role; // Ép kiểu từ int trong DB sang Enum
            GlobalStudentID = studentID;
        }

        // Hàm xóa thông tin khi đăng xuất
        public static void Logout()
        {
            GlobalUserId = 0;
            GlobalUsername = null;
            GlobalStudentID = null;
        }
    }
}
