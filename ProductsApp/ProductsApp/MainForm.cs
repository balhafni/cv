using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm form = new ProductsForm();
            form.ShowDialog();
        }

        private void btnBanking_Click(object sender, EventArgs e)
        {
            BankingForm form = new BankingForm();
            form.ShowDialog();
        }
    }
}
