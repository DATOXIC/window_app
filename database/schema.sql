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

