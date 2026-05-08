using System;

namespace window_app
{
    internal sealed class Student
    {
        public int Id { get; init; }
        public string StudentCode { get; init; }
        public string FullName { get; init; }
        public string? Email { get; init; }
        public DateTime? DateOfBirth { get; init; }
        public string? ClassName { get; init; }

        public Student(string studentCode, string fullName)
        {
            StudentCode = string.IsNullOrWhiteSpace(studentCode)
                ? throw new ArgumentException("StudentCode cannot be empty.", nameof(studentCode))
                : studentCode.Trim();

            FullName = string.IsNullOrWhiteSpace(fullName)
                ? throw new ArgumentException("FullName cannot be empty.", nameof(fullName))
                : fullName.Trim();
        }

        public override string ToString() => $"{StudentCode} - {FullName}";
    }
}

