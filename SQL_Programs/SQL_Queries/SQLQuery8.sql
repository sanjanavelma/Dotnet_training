select c.Name, h.RoomNo from [dbo].[CollegeMaster] c left join [dbo].[Hostel] h
on c.id = h.CollegeId
Select c.Name, h.RoomNo from [dbo].[CollegeMaster] c inner join [dbo].[Hostel] h
on c.id = h.CollegeId
select d.DeptName,  c.Name from [dbo].[CollegeMaster] c right join [dbo].[DepartmentMaster] d
on c.Department = d.DeptId
