using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsApp.Models;
using ProductsApp.DataLayer;

namespace ProductsApp.BusinessLayer
{
    class BusinessBanking : IBusinessBanking
    {
        public IRepositoryBanking _irepBank = null;
        public BusinessBanking()
        {
            _irepBank = new RepositoryBanking() as IRepositoryBanking;
        }
        public BusinessBanking(IRepositoryBanking irepbank)
        {
            _irepBank = irepbank;
        }
        public decimal GetCheckingBalance(long checkingAcctNum)
        {
            return _irepBank.GetCheckingBalance(checkingAcctNum);
        }
        public decimal GetSavingBalance(long savingAcctNum)
        {
            return _irepBank.GetSavingBalance(savingAcctNum);
        }
        public bool TransferCheckingToSaving(decimal amount, long checkingAccountNum,
       long savingAccountNum)
        {
            return _irepBank.TransferCheckingToSaving(amount, checkingAccountNum,
           savingAccountNum);
        }
    }
}
