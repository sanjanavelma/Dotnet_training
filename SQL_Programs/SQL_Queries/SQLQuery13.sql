create procedure dbo.uspGetStudentByDept
	@dept int,
	@StudentCount int output
as
begin
	select @StudentCount = count(*) from [dbo].[CollegeMaster] where [Department] = @dept
end;
declare @scount int
exec dbo.uspGetStudentByDept
@dept = 2,
@StudentCount = @scount output
select @scount
--

