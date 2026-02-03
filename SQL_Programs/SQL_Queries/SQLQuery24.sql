Create view v1 as select * from [dbo].[CollegeMaster1] where gender = 'Female'

select location from v1

create view v2 as select c.Name from [dbo].[CollegeMaster1] c inner join [dbo].[Library3] l
on c.id = l.TakenBy

select * from v2
