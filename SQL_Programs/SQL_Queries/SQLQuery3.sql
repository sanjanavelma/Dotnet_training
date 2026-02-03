select B.BookName from [dbo].[BookMaster1] B inner join [dbo].[Library3] L
	on B.BookId = L.BId
	inner join [dbo].[CollegeMaster1] C on C.id = L.TakenBy
	where C.Name = 'Sanjana'

select B.ISBN from [dbo].[BookMaster1] B inner join [dbo].[Library3] L
	on B.BookId = L.BId
	inner join [dbo].[CollegeMaster1] C on C.id = L.TakenBy
	where C.Name = 'Sanjana'