CREATE TABLE Employees (
    EmpID INT PRIMARY KEY,
    Name VARCHAR(50),
    Dept VARCHAR(50),
    Salary INT
);

INSERT INTO Employees VALUES
(1, 'Amit', 'IT', 50000),
(2, 'Riya', 'HR', 40000),
(3, 'John', 'Finance', 60000);

CREATE TABLE Employees_Deleted_Log (
    EmpID INT,
    Name VARCHAR(50),
    Dept VARCHAR(50),
    Salary INT,
    DeletedDate DATETIME
);


CREATE TRIGGER trg_AfterDelete_Employees
ON Employees
AFTER DELETE
AS
BEGIN
    INSERT INTO Employees_Deleted_Log
    SELECT EmpID, Name, Dept, Salary, GETDATE()
    FROM deleted;
END;

DELETE FROM Employees WHERE EmpID = 2;

SELECT * FROM Employees_Deleted_Log;
select * from Employees