CREATE PROCEDURE GetEmployeesAboveSalary
    @SalaryLimit INT
AS
BEGIN
    SELECT Name, Dept, Salary
    FROM Employees
    WHERE Salary >= @SalaryLimit;
END
