--Operations team wants formatted and filtered data

SELECT UPPER(c.Customber_Name) AS CustomerName, DATENAME(MONTH, o.Purchase_Date) AS OrderMonth, o.Order_ID, o.Purchase_Date
FROM [dbo].[Order_Detail] o INNER JOIN [dbo].[Customter_Master] c 
    ON c.ID = o.Customber_Id
WHERE 
    o.Purchase_Date >= '2026-01-01'
    AND o.Purchase_Date < '2026-02-01';