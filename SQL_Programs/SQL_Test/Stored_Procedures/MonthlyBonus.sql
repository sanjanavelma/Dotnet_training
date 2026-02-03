create proc [dbo].[uspMontlyBouns]
as
begin
insert into [dbo].[Bonus](AccountID, BonusMonth, BonusYear, BonusAmount, CreatedDate)
select
t.AccountID,
Month(t.TransactionDate) as BonusMonth,
Year(t.TransactionDate) as BounsYear,
1000 as BounsAmount,
GETDATE() as CreatedDate
from [dbo].[Transactions] t
where t.TransactionType = 'Deposit'
group by t.AccountID, MONTH(t.TransactionDate), Year(t.TransactionDate)
having sum(t.Amount) > 50000
       AND NOT EXISTS
       (
           SELECT 1
           FROM Bonus b
           WHERE b.AccountID = t.AccountID
             AND b.BonusMonth = MONTH(t.TransactionDate)
             AND b.BonusYear  = YEAR(t.TransactionDate)
       );
END;


exec [dbo].[uspMontlyBouns]

