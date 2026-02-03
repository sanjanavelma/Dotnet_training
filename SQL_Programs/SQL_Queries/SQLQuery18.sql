--Name
alter table [dbo].[CollegeMaster1] add constraint n2 check (Name NOT LIKE '%[^A-Za-z ]%')

--Phone
alter table [dbo].[CollegeMaster1] add constraint p1 check (PhoneNo NOT LIKE '%[^0-9]%');

alter table [dbo].[CollegeMaster1] add constraint p2 check (LEN(PhoneNo) BETWEEN 2 AND 10);

alter table [dbo].[CollegeMaster1] add constraint uq_phone unique (PhoneNo);

--Gender
alter table [dbo].[CollegeMaster1] add constraint g1 check (Gender IN ('Male','Female'));

--Marks
alter table [dbo].[CollegeMaster1] add constraint m1_range check (M1 BETWEEN 0 AND 100);

alter table [dbo].[CollegeMaster1] add constraint m2_range check (M2 BETWEEN 0 AND 100);

alter table [dbo].[CollegeMaster1] add constraint m3_range check (M3 BETWEEN 0 AND 100);

alter table [dbo].[CollegeMaster1] add constraint t1 check (Total = (M1 + M2 + M3));

select DATEADD(year, 1, getdate()) as warrantydate

SELECT DATEDIFF(day, '2004-11-27', GETDATE()) AS DayDiff;

ALTER TABLE [dbo].[CollegeMaster1]
ADD DOB DATE;
select * from [dbo].[CollegeMaster1]


