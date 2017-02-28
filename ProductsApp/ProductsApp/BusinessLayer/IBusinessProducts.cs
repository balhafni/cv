using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsApp.Models;

namespace ProductsApp.BusinessLayer
{
    interface IBusinessProducts
    {
        List<Category> GetAllCategories();
        List<Product> GetProductsByCat(int catId);

        List<Supplier> GetAllSuppliers();

        List<Shipper> GetAllShippers();

        int AddProduct(Product prod);
        int GetLastProductId();
    }
}
