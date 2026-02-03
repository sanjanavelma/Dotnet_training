select * from [dbo].[Canteen]
select * from [dbo].[EmployeeMaster]
Update [dbo].[EmployeeMaster] Set PF = Salary * 0.12
Where Age > 21;

--Total 
select e.Name, Sum(c.Price) as TotalPrice from [dbo].[EmployeeMaster] e inner join [dbo].[Canteen] c
on e.Id = c.TakenBy
where c.TakenBy = 1
group by e.Name

--List on 23 Jan

select * from [dbo].[Canteen] c inner join [dbo].[EmployeeMaster] e 
on c.TakenBy = e.Id
where c.Date = '2026-01-23 00:00:00.000' and TakenBy = 1

--Top Most 
select Top 1 e.Name, Sum(c.Price) As TopCustomer from [dbo].[Canteen] c inner join [dbo].[EmployeeMaster] e 
on c.TakenBy = e.Id
group by e.Name
Order By Sum(c.Price) Desc

--One
SELECT MAX(TotalSpent) AS TopCustomerAmount
FROM (
    SELECT SUM(c.Price) AS TotalSpent FROM [dbo].[Canteen] c Inner Join [dbo].[EmployeeMaster] e 
        ON c.TakenBy = e.Id
    Group by e.Name
) AS T;
