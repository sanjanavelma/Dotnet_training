Alter proc [dbo].[usp_BonusCalculation]
as
begin
create table #bounscalculator(Name nvarchar(50), total int, bonus int);
insert into #bounscalculator(Name, total) select name, total from [dbo].[CollegeMaster1]
update #bounscalculator set bonus = 500 where total > 290
select * from #bounscalculator
end
exec [dbo].[usp_BonusCalculation]