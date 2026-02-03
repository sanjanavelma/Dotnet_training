--Management wants to identify salespersons who generated high revenue

SELECT s.Id AS SalesPerson_ID, s.SalesPerson_Name, SUM(p.Unit_Price * o.Quantity) AS TotalSales
FROM [dbo].[SalesPerson_Master] s INNER JOIN [dbo].[Order_Detail] o ON o.SalesPerson_Id = s.Id
INNER JOIN [dbo].[Product_Master] p ON o.Product_Id = p.Id
GROUP BY 
    s.Id,
    s.SalesPerson_Name
HAVING 
    SUM(p.Unit_Price * o.Quantity) < 60000;