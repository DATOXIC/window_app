-- window_app shared database schema (SQL Server)
-- Run this on the shared SQL Server database (e.g., window_app).

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;

IF OBJECT_ID(N'dbo.[Table]', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.[Table] (
        id INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Table PRIMARY KEY,
        username NVARCHAR(255) NOT NULL,
        password NVARCHAR(255) NOT NULL,
        valid INT NOT NULL CONSTRAINT DF_Table_valid DEFAULT (0),
        studentID NCHAR(10) NULL,
        position INT NULL,
        email NVARCHAR(255) NULL
    );
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = N'UX_Table_username' AND object_id = OBJECT_ID(N'dbo.[Table]')
)
BEGIN
    CREATE UNIQUE INDEX UX_Table_username ON dbo.[Table](username);
END;

IF OBJECT_ID(N'dbo.Student', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Student (
        Id INT NOT NULL CONSTRAINT PK_Student PRIMARY KEY,
        MSSV INT NOT NULL,
        Name NVARCHAR(255) NOT NULL,
        Phone NVARCHAR(50) NOT NULL,
        Email NVARCHAR(255) NOT NULL
    );
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = N'UX_Student_MSSV' AND object_id = OBJECT_ID(N'dbo.Student')
)
BEGIN
    CREATE UNIQUE INDEX UX_Student_MSSV ON dbo.Student(MSSV);
END;

-- =============================================
-- Bảng Notification (Thông báo)
-- =============================================
IF OBJECT_ID(N'dbo.Notification', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Notification (
        NotifId    INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Notification PRIMARY KEY,
        Subject    NVARCHAR(500) NOT NULL,
        Body       NVARCHAR(MAX) NULL,
        SentBy     NVARCHAR(255) NOT NULL,
        SentDate   DATETIME NOT NULL CONSTRAINT DF_Notification_SentDate DEFAULT GETDATE(),
        NotifType  NVARCHAR(20) NOT NULL CONSTRAINT DF_Notification_NotifType DEFAULT 'General',
        TargetMSSV NVARCHAR(20) NULL
    );
END;

-- Dữ liệu mẫu
IF NOT EXISTS (SELECT 1 FROM dbo.Notification)
BEGIN
    INSERT INTO dbo.Notification (Subject, Body, SentBy, SentDate, NotifType, TargetMSSV) VALUES
    (N'Thông báo lịch thi cuối kỳ HK2 2025-2026', N'Sinh viên xem lịch thi tại cổng thông tin.', N'Phòng Đào tạo', '2026-05-10 08:00:00', 'General', NULL),
    (N'Thông báo đóng học phí HK2 2025-2026', N'Hạn chót: 30/05/2026.', N'Phòng Tài chính', '2026-05-08 09:30:00', 'General', NULL),
    (N'Lịch nghỉ lễ 30/4 - 1/5', N'Nghỉ từ 30/04 đến 01/05/2026.', N'Phòng Hành chính', '2026-04-25 14:00:00', 'General', NULL),
    (N'Thông báo tuyển sinh Thạc sĩ 2026', N'Tuyển sinh đợt 1 năm 2026.', N'Phòng Đào tạo SĐH', '2026-05-05 10:00:00', 'General', NULL),
    (N'Hội thảo CNTT lần thứ 5', N'Ngày 20/05/2026 tại Hội trường A.', N'Khoa CNTT', '2026-05-03 11:00:00', 'General', NULL),
    (N'Cảnh báo học vụ HK1 2025-2026', N'Điểm TB dưới 5.0, liên hệ cố vấn.', N'Phòng Đào tạo', '2026-05-01 08:00:00', 'Personal', '24110147'),
    (N'Xác nhận đăng ký môn học thành công', N'Đã đăng ký 6 môn cho HK2.', N'Hệ thống', '2026-04-28 16:00:00', 'Personal', '24110147'),
    (N'Kết quả học bổng HK1 2025-2026', N'Chúc mừng đạt học bổng loại B.', N'Phòng CTSV', '2026-04-20 09:00:00', 'Personal', '24110147');
END;

-- =============================================
-- Bảng Teacher (Giảng viên)
-- =============================================
IF OBJECT_ID(N'dbo.Teacher', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Teacher (
        Id          INT NOT NULL CONSTRAINT PK_Teacher PRIMARY KEY,  -- FK → [Table].id
        TeacherID   NVARCHAR(20) NOT NULL,
        Fname       NVARCHAR(100) NOT NULL,
        Lname       NVARCHAR(50) NOT NULL,
        Department  NVARCHAR(100) NOT NULL,  -- MajorCode từ bảng Majors
        Email       NVARCHAR(255) NOT NULL,
        Phone       NVARCHAR(20) NULL,
        Dob         DATE NULL,
        Gender      NVARCHAR(10) NULL
    );
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = N'UX_Teacher_TeacherID' AND object_id = OBJECT_ID(N'dbo.Teacher')
)
BEGIN
    CREATE UNIQUE INDEX UX_Teacher_TeacherID ON dbo.Teacher(TeacherID);
END;
