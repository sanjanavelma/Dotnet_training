select e.Dept, e.Name, e.Salary from [dbo].[MaxSalary] e join
(select dept, Max(salary) as MaxSalary
from [dbo].[MaxSalary] 
group by Dept) m
on e.Dept = m.dept
and e.Salary = m.MaxSalary
