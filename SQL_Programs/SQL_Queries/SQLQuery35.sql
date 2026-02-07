create or alter proc uspGetGenderCount
@gender nvarchar(50),
@count int output
as
begin
select @count = count(Gender) from [dbo].[CollegeMaster1]
where Gender = @gender;
end

