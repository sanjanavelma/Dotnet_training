
create procedure dbo.uspGetStudentNamesofHostel
as
begin
	select c.Name from [dbo].[CollegeMaster] c inner join [dbo].[Hostel] h
	on c.id = h.CollegeId
end;
---------------------------------------------------
exec dbo.uspGetStudentNamesofHostel