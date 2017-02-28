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
    public partial class AddProductForm : Form
    {
        IBusinessProducts _ibusinessProds = null;
        public AddProductForm()
        {
            InitializeComponent();
            _ibusinessProds = new Business() as IBusinessProducts;
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

            List<Category> CList = _ibusinessProds.GetAllCategories();
            cbCategories.DataSource = CList;
            cbCategories.DisplayMember = "CategoryName";
            cbCategories.ValueMember = "CategoryId";
            cbCategories.Refresh();

            List<Supplier> SList = _ibusinessProds.GetAllSuppliers();
            cbSuppliers.DataSource = SList;
            cbSuppliers.DisplayMember = "CompanyName";
            cbSuppliers.ValueMember = "SupplierID";
            cbSuppliers.Refresh();

            foreach (var item in Enum.GetValues(typeof(Discounted)))
            {
                cbDiscontinued.Items.Add(item);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.ProductID = _ibusinessProds.GetLastProductId() + 1;
                p.ProductName = txtProdName.Text;
                p.SupplierID = (int)cbSuppliers.SelectedValue;
                p.CategoryID = (int)cbCategories.SelectedValue;
                p.QuantityPerUnit = txtQuanPerUnit.Text;
                p.UnitPrice = decimal.Parse(txtPrice.Text);
                p.UnitsInStock = Int16.Parse(txtUnitsInStock.Text);
                p.UnitsOnOrder = Int16.Parse(txtUnitsOnOrder.Text);
                p.ReorderLevel = Int16.Parse(txtReorderLevel.Text);
                p.Discontinued = Convert.ToBoolean(cbDiscontinued.SelectedItem.ToString());
                int added = _ibusinessProds.AddProduct(p);
                if (added > 0)
                {
                    MessageBox.Show("New Product has been added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

       
    }
}
