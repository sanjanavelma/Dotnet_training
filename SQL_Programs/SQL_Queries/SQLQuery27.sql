Alter proc [dbo].[usp_PassingCalculation]
as
begin
create table #Passingtable(Name nvarchar(50), M1 int, Grade Nvarchar(10));
insert into #Passingtable(Name, M1) select name, M1 from [dbo].[CollegeMaster1] 
update #Passingtable set M1 = M1 + 5
Update #Passingtable set Grade = 'Pass' where  M1 >= 35 
Update #Passingtable set Grade = 'Fail' where M1 < 35 
select * from #Passingtable
end
select Name, M1, Grade from [dbo].[CollegeMaster1]
exec [dbo].[usp_PassingCalculation]
