Select * from [dbo].[CollegeMaster1]
Alter table [dbo].[CollegeMaster1] add Total int
Update [dbo].[CollegeMaster1] set Total = M1 + M2 + M3
select Name from [dbo].[CollegeMaster1] where Gender = 'Male' and Department = 'Btech'
Alter table [dbo].[CollegeMaster1] add Grade NvarChar(10)
Update [dbo].[CollegeMaster1] set Grade = 'First' where M1 > 60 and M2 > 60 and M3 > 60
Update [dbo].[CollegeMaster1] set Grade = 'Second' where M2 < 60 or M2 < 60 or M3 < 60 and M1 > 35 and M2 > 35 and M3 > 35
Update [dbo].[CollegeMaster1] set Grade = 'Fail' where M1 < 35 or M2 < 35 or M3 < 35
select * from [dbo].[CollegeMaster1]
select Department, Count(*) TotalStudents from [dbo].[CollegeMaster1] where Grade = 'Fail' group by Department 
select * from [dbo].[CollegeMaster1] where M2 between 95 and 99
select * from [dbo].[CollegeMaster1] where Location in ('Hyd', 'Banglore')
SELECT RoomNo from CollegeMaster1 INNER JOIN Hostel1 ON CollegeMaster1.id = Hostel1.CollegeId
where [dbo].[CollegeMaster1].Department = 'BTech'
