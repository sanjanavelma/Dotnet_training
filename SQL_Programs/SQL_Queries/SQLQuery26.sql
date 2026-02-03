create function GetDepartmentByName(@name Nvarchar(20))
returns table
as
return
(
	select * from CollegeMaster where Name = @name
);

select * from GetDepartmentByName('Sanjana')
