CREATE DATABASE EmployeeDB;
GO
USE EmployeeDB;
GO

CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY(1,1),

    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,

    Email NVARCHAR(100) NOT NULL UNIQUE,
    PhoneNumber NVARCHAR(15) NOT NULL,

    Gender NVARCHAR(10) NOT NULL,

    DateOfBirth DATE NOT NULL,
    Age INT NOT NULL CHECK (Age BETWEEN 18 AND 60),

    Department NVARCHAR(50) NOT NULL,
    Designation NVARCHAR(50) NOT NULL,

    Salary DECIMAL(10,2) NOT NULL CHECK (Salary > 0),

    State NVARCHAR(50) NOT NULL,
    City NVARCHAR(50) NOT NULL,

    JoiningDate DATE NOT NULL,

    IsActive BIT NOT NULL DEFAULT 1,

    CreatedAt DATETIME DEFAULT GETDATE()
);

ALTER TABLE Employees
ADD 
    AddressLine1 NVARCHAR(150) NOT NULL,
    AddressLine2 NVARCHAR(150) NULL,
    Pincode NVARCHAR(10) NOT NULL,
    AadhaarNumber NVARCHAR(12) NOT NULL UNIQUE;

select * from [dbo].[Employees]

ALTER TABLE Employees
ADD CONSTRAINT UQ_Phone UNIQUE (PhoneNumber);