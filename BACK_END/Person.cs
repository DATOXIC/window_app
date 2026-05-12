using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace window_app
{
    internal class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime Dob { get; set; }
        public string Gder { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public byte[] Picture { get; set; }

        public Person() { }
        public Person(string fname, string lname, DateTime dob, string gder, string phone, string address, string email, byte[] picture)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Dob = dob;
            this.Gder = gder;
            this.Phone = phone;
            this.Address = address;
            this.Email = email;
            this.Picture = picture;
        }
        public bool IsValidEmail()
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(this.Email);
                return addr.Address == this.Email;
            }
            catch
            {
                return false;
            }
        }
        public bool IsValidPhone()
        {
            // Nếu số điện thoại trống
            if (string.IsNullOrEmpty(this.Phone))
                return false;

            // Quy tắc: 
            // ^0: Bắt đầu bằng số 0
            // \d{9}: Theo sau là đúng 9 chữ số
            // $: Kết thúc chuỗi
            string pattern = @"^0\d{9}$";

            return Regex.IsMatch(this.Phone, pattern);
        }

        // Phương thức ảo (Virtual) - cho phép lớp con ghi đè nếu cần (Tính đa hình)
        public virtual string GetFullName()
        {
            return Fname + " " + Lname;
        }
    }
}
