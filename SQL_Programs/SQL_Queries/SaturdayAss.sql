
-- 2 use ALTER TABLE to add a column called BonusPoints to the Employee table. Set default value as 0.

alter table Employee add BonusPoints int default 0;

--3 Add a CHECK constraint on BonusPoints. Ensure invalid values cannot be inserted or updated.

alter table [dbo].[Employee] 
add constraint bonuscheck check (BonusPoints between 0 and 100);
select * from [dbo].[Employee]


--4 Only include employees who have made at least one sale.

select e.EmpName, d.DepartmentName, Month(s.SaleDate) as SaleMonth, Year(s.SaleDate) as SaleYear, s.SaleAmount
from [dbo].[Department] d inner join [dbo].[Employee] e
on d.ID = e.Department
inner join [dbo].[Sales] s
on e.EmpID = s.EmpId


-- 5 Write a query to calculate total sales for each employee for the current year.

select e.EmpName, Sum(s.SaleAmount) as TotalSales from [dbo].[Employee] e
inner join [dbo].[Sales] s
on e.EmpID = s.EmpId
where Year(s.SaleDate) = Year(GetDate())
group by e.EmpName


-- 6 Generate the username using SUBSTRING and LEFT.


SELECT e.EmpName, 
    SUBSTRING(e.EmpName, 1, 3)
    + LEFT(d.DepartmentName, 2)
    + CAST(e.EmpID AS VARCHAR(10)) AS Username
FROM Employee e inner join [dbo].[Department] d
on e.Department = d.ID

-- Write a query to find employees whose total sales amount is greater than the average sales amount of all employees.

SELECT EmpName FROM Employee
WHERE EmpID IN ( SELECT EmpID FROM Sales GROUP BY EmpID
HAVING SUM(SaleAmount) > ( SELECT AVG(TotalSales)
FROM (SELECT SUM(SaleAmount) AS TotalSales FROM Sales GROUP BY EmpID) AS AvgSales));


-- Display: Employee Name, Sale Amount, Category (High / Low)*/

SELECT e.EmpName, s.SaleAmount, 'High' AS Category
FROM Employee e INNER JOIN Sales s 
ON e.EmpID = s.EmpID
WHERE s.SaleAmount > 3500
UNION
SELECT e.EmpName, s.SaleAmount, 'Low' AS Category
FROM Employee e INNER JOIN Sales s 
ON e.EmpID = s.EmpID
WHERE s.SaleAmount < 3000;


-- Create an AFTER INSERT trigger on Sales table.

CREATE or alter TRIGGER trg_UpdateBonusPoints ON Sales
AFTER INSERT
AS
BEGIN
    UPDATE e SET e.BonusPoints = e.BonusPoints +
        CASE
            WHEN i.SaleAmount >= 50000 THEN 10
            WHEN i.SaleAmount >= 2000 THEN 5
            ELSE 0
        END
    FROM Employee e INNER JOIN inserted i ON e.EmpID = i.EmpID;
END;

--Question 10 – Integrated Validation Query (Final)
SELECT e.EmpName AS EmployeeName, d.DepartmentName AS Department, SUM(s.SaleAmount) AS TotalSales, e.BonusPoints,
    CASE
        WHEN e.BonusPoints >= 50 THEN 'A'
        WHEN e.BonusPoints BETWEEN 20 AND 49 THEN 'B'
        ELSE 'C'
    END AS PerformanceGrade
FROM Employee e INNER JOIN Department d ON e.Department = d.ID
INNER JOIN Sales s ON e.EmpID = s.EmpID
GROUP BY 
    e.EmpName,
    d.DepartmentName,
    e.BonusPoints;

