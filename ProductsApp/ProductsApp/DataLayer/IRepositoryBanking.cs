using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApp.DataLayer
{
    interface IRepositoryBanking
    {
        decimal GetCheckingBalance(long checkingAcctNum);
        decimal GetSavingBalance(long savingAcctNum);
        bool TransferCheckingToSaving(decimal amount, long checkingAccountNum, long
       savingAccountNum);
    }
}
