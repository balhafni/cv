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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void btnViewProds_Click(object sender, EventArgs e)
        {
            ViewProductsForm form = new ViewProductsForm();
            form.ShowDialog();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();
            form.ShowDialog();
        }
    }
}
