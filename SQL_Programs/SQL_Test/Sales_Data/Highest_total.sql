--Third Highest Total Sales 

SELECT * FROM [dbo].[Order_Detail] o Inner join [dbo].[Product_Master] p 
    on p.Id=o.Product_Id 
order by 
    p.Unit_Price*o.Quantity desc
offset 1 rows fetch next 1 row only;