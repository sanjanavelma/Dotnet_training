create proc dbo.aspGetMonth
@months datetime
as
begin
select * from [dbo].[CollegeMaster1] where  month(DOB) = @months
end;

exec dbo.aspGetMonth
@months = 11