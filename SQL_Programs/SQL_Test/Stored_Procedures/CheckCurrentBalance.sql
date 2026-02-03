create proc [dbo].[uspCheckCurrentBalance]
as
begin
select c.CustomerName, a.AccountNumber, 
a.OpeningBalance + ISNULL(Sum(case when t.TransactionType = 'Deposit' then t.Amount end), 0)
-ISNULL(sum(case when t.TransactionType = 'Withdraw' then t.Amount end), 0)
+ Isnull(sum(b.BonusAmount),0) as CurrentBalance
from [dbo].[Customers] c
join [dbo].[Accounts] a
on c.CustomerID = a.CustomerID
left join [dbo].[Transactions] t 
on a.AccountID = t.AccountID
left join [dbo].[Bonus] b
on t.AccountID = b.AccountID
group by
c.CustomerName,
a.AccountNumber,
a.OpeningBalance
end;


exec [dbo].[uspCheckCurrentBalance]