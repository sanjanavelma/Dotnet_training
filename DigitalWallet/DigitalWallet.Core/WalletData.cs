using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalWallet.Core
{
    public class WalletData
{
    //Value Types
    public int UserId;
    public decimal Balance;
    public bool IsActive;

    //Reference Type
    public string UserName;
    public decimal[] RecentTransactions;
}
}