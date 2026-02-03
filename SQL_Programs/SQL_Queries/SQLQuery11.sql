create procedure dbo.uspGetNameOfRoom1
	@room nvarchar(50)
as
begin
	select c.Name from [dbo].[CollegeMaster] c inner join [dbo].[Hostel] h
	on c.id = h.CollegeId
	where h.RoomNo = @room
end;


-------------------------------------------------

exec dbo.uspGetNameOfRoom1
@room = '666'
