create proc usp_getstudentName
as
begin
select * from collegemaster 
end

Exec usp_getstudentName