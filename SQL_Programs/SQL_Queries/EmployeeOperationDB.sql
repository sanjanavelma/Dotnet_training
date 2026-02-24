CREATE PROCEDURE sp_GetEmployeesByDepartment
    @Department NVARCHAR(50)
AS
BEGIN
    SELECT EmpId, Name, Department, Phone, Email
    FROM Employees
    WHERE Department = @Department
END

CREATE PROCEDURE sp_GetDepartmentEmployeeCount
    @Department NVARCHAR(50),
    @TotalEmployees INT OUTPUT
AS
BEGIN
    SELECT @TotalEmployees = COUNT(*)
    FROM Employees
    WHERE Department = @Department
END

CREATE PROCEDURE sp_GetEmployeeOrders
AS
BEGIN
    SELECT 
        E.Name,
        E.Department,
        O.OrderId,
        O.OrderAmount,
        O.OrderDate
    FROM Employees E
    INNER JOIN Orders O
        ON E.EmpId = O.EmpId
END

CREATE PROCEDURE sp_GetDuplicateEmployees
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE Phone IN (
        SELECT Phone
        FROM Employees
        GROUP BY Phone
        HAVING COUNT(*) > 1
    )
    OR Email IN (
        SELECT Email
        FROM Employees
        GROUP BY Email
        HAVING COUNT(*) > 1
    )
END

select * from Employees
select * from [dbo].[Orders]