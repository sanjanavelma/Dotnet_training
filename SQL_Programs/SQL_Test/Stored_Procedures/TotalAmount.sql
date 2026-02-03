create proc [dbo].[aspDataRange]
@StartDate date,
@EndDate date,
@AccountID int
as 
begin
select Sum(case when TransactionType = 'Deposit' then Amount else 0 end) as DepositTotal, 
Sum(case when TransactionType = 'Withdraw' then Amount else 0 end) as WithdrawTotal
from [dbo].[Transactions] 
where AccountID = @AccountID and TransactionDate between @StartDate and @EndDate
end
exec [dbo].[aspDataRange] 
@StartDate = '2024-01-01',
@EndDate = '2024-01-20',
@AccountID = 1;