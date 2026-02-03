--Id + 3letters
select Cast(id as Varchar) + upper(left(name, 3)) as op
from [dbo].[punjabSports];

--Till R
select left(name, CHARINDEX('r', name)) as stringtillR
from [dbo].[punjabSports]

--From R
SELECT RIGHT(name, LEN(name) - CHARINDEX('r', name) + 1) AS stringFromR
FROM [dbo].[punjabSports]
