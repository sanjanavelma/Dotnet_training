-- write the stored proc to insert the new hostel record if hostel students is less than 5
create proc dbo.uspInsertHostelRecord
as
begin
declare @studentcount int
select @studentcount = count(*) from [dbo].[Hostel]
if @studentcount < 5
begin
insert into [dbo].[Hostel]
values('656', 4)
end;
end;

exec dbo.uspInsertHostelRecord
