using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsApp.DataLayer;
using ProductsApp.Models;

namespace ProductsApp.BusinessLayer
{
    class Business : IBusinessProducts
    {
        public IRepositoryProducts _irepProds = null;
        public IRepositoryCustomerOrders _irepCustomers = null;
        public Business()
        {
            _irepCustomers = new Repository() as IRepositoryCustomerOrders;
            _irepProds = new Repository() as IRepositoryProducts;
        }
        public Business(IRepositoryProducts irepProds, IRepositoryCustomerOrders
       irepCustOrders)
        {
            _irepProds = irepProds;
            _irepCustomers = irepCustOrders;
        }
        public List<Category> GetAllCategories()
        {
            return _irepProds.GetAllCategories();
        }
        public List<Product> GetProductsByCat(int catId)
        {
            return _irepProds.GetProductsByCat(catId);
        }
        public List<Supplier> GetAllSuppliers()
        {
            return _irepProds.GetAllSuppliers();
        }
        public List<Shipper> GetAllShippers()
        {
            return _irepProds.GetAllShippers();
        }

        public int AddProduct(Product prod)
        {
            return _irepProds.AddProduct(prod);
        }
        public int GetLastProductId()
        {
            return _irepProds.GetLastProductId();
        }
    }
}
