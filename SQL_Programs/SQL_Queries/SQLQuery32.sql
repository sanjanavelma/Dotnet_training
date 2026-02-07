create trigger prevent_tabel_creation
on database
for drop_table
as
begin
print 'You can not drop the table in this'
rollback
end;

drop table 

Alter trigger prevent_update
on [dbo].[Customter_Master]
for update
as
begin
raiserror ('You can not update in this table', 16, 1);
Rollback
end;

update [dbo].[Customter_Master] set City = 'Banglore' 
CREATE TABLE Employees (
    EmpID INT IDENTITY(1,1) PRIMARY KEY,
    EmpName VARCHAR(100),
    EmpSal DECIMAL(10,2)
);
GO
CREATE TABLE Employee_Audit (
    EmpID INT,
    EmpName VARCHAR(100),
    EmpSal DECIMAL(10,2),
    Audit_Action VARCHAR(100),
    Audit_Timestamp DATETIME
);
GO

CREATE TRIGGER trgAfterInsertEmployee
ON [dbo].[SalesPerson_Master]
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Employee_Audit
        (EmpID, EmpName, EmpSal, Audit_Action, Audit_Timestamp)
    SELECT
        i.EmpID,
        i.EmpName,
        i.EmpSal,
        'Inserted Record',
        GETDATE()
    FROM inserted i;
END;
GO

INSERT INTO Employees (EmpName, EmpSal)
VALUES ('Aryan', 45000.00);

SELECT * FROM Employee_Audit;