alter function HighestMarks()
returns int
as
begin
declare @Hm2 int
select @Hm2 = max(M2) from [dbo].[CollegeMaster1];
return @Hm2;
end;

SELECT dbo.HighestMarks() AS Highest_M2;