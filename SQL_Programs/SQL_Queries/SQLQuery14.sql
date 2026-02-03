select * from [dbo].[CollegeMaster1]
--Print the Student name Who has taken the Java book from the Library
select C.Name from [dbo].[CollegeMaster1] C inner Join [dbo].[Library3] L
	on C.id = L.TakenBy
	Where L.BId = 3

-- How many books taken by the person who scored 100 in any one Subject
select Count(L.BId) as 'TotalCount', C.Name from [dbo].[CollegeMaster1] C inner Join [dbo].[Library3] L
	on C.id = L.TakenBy
	where C.M1 = 100 or C.M2 = 100 or C.M3 = 100
	group by C.Name

-- How many Students in Room no 1 have taken the book from library
select Count(H.CollegeId) As 'NoofStudents' from [dbo].[GHostel] H inner join Library3 L on 
	H.CollegeId = L.TakenBy
	where H.RoomNo = 101

-- Which deparment students have taken the python book
select C.Department from [dbo].[CollegeMaster1] C inner join [dbo].[Library3] L
on C.id = L.TakenBy
where L.BId = 2

-- Print the phone number of the student who took the jave book
select C.PhoneNo from [dbo].[CollegeMaster1] C inner join [dbo].[Library3] L
on C.id = L.TakenBy
where L.BId = 3



truncate table [dbo].[LaptopPurchase]