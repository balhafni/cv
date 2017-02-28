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
using ProductsApp.Models;

namespace ProductsApp
{
    public partial class ViewProductsForm : Form
    {
        IBusinessProducts _ibusinessProds = null;
        public ViewProductsForm()
        {
            InitializeComponent();
            _ibusinessProds = new Business() as IBusinessProducts;
        }

        private void ViewProductsForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<Category> CList = _ibusinessProds.GetAllCategories();
                cmbCategories.DataSource = CList;
                cmbCategories.DisplayMember = "CategoryName";
                cmbCategories.ValueMember = "CategoryId";
                cmbCategories.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int catId = int.Parse(cmbCategories.SelectedValue.ToString());
                List<Product> PList = _ibusinessProds.GetProductsByCat(catId);
                dg1.DataSource = PList;
                cmbCategories.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
