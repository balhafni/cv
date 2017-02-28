using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsApp.BusinessLayer;
namespace ProductsApp
{
    public partial class BankingForm : Form
    {
        IBusinessBanking _ibusinessBanking = null;
        public BankingForm()
        {
            InitializeComponent();
            _ibusinessBanking = new BusinessBanking() as IBusinessBanking;
        }

        private void btnGetBalances_Click(object sender, EventArgs e)
        {
            try
            {
                long checkingAccountNum = long.Parse(txtCheckingNum.Text);
                long savingAccountNum = long.Parse(txtSavingNum.Text);
                decimal checkingBalance = _ibusinessBanking.GetCheckingBalance(checkingAccountNum);
                decimal savingBalance = _ibusinessBanking.GetSavingBalance(savingAccountNum);

                lblCheckingBalance.Text = checkingBalance.ToString();
                lblSavingBalance.Text = savingBalance.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTransferChecking_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = decimal.Parse(txtamount.Text);
                long checkingAccountNum = long.Parse(txtCheckingNum.Text);
                long savingAccountNum = long.Parse(txtSavingNum.Text);
                bool ret = _ibusinessBanking.TransferCheckingToSaving(amount, checkingAccountNum, savingAccountNum);
                if (ret == true)
                    btnGetBalances.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
