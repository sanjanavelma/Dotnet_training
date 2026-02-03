--customers who spent more than the average customer spending

SELECT c.Customber_Name, SUM(p.Unit_Price * o.Quantity) AS TotalSpent
FROM [dbo].[Order_Detail] o INNER JOIN [dbo].[Customter_Master] c 
    ON c.ID = o.Customber_Id
INNER JOIN [dbo].[Product_Master] p ON p.ID = o.Product_Id
GROUP BY c.Customber_Name
HAVING 
    SUM(p.Unit_Price * o.Quantity) >
    (
        SELECT 
            AVG(CustomerTotal)
        FROM
        (
            SELECT 
                SUM(p2.Unit_Price * o2.Quantity) AS CustomerTotal
            FROM  [dbo].[Order_Detail] o2 INNER JOIN [dbo].[Product_Master] p2 
                ON p2.ID = o2.Product_Id
            GROUP BY o2.Customber_Id
        ) x
    );