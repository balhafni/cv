using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsApp.Models;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ProductsApp.DataLayer
{
    class Repository : IRepositoryCustomerOrders, IRepositoryProducts
    {
        IDataAccess _idac = null;
        public Repository()
        {
            string CONNSTR =
           ConfigurationManager.ConnectionStrings["ProductsApp.Properties.Settings.NORTHWNDConnectionString"].ConnectionString;
           
            _idac = new DataAccess(CONNSTR);
        }
        public Repository(IDataAccess idac) { _idac = idac; }

        public List<Category> GetAllCategories()
        {
            List<Category> CList = null;
            try
            {
                string sql = "select * from Categories";
                DataTable dt = _idac.GetManyRowsCols(sql, null);
                CList = DBList.ToList<Category>(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return CList;
            }



        public List<Product> GetProductsByCat(int catId)
        {
            try
            {
                List<Product> PList = null;
                try
                {
                    string sql = "select * from Products where CategoryId = @CategoryId";
                List<DbParameter> ParamList = new List<DbParameter>();
                    SqlParameter p1 = new SqlParameter("@CategoryId", SqlDbType.Int);
                    p1.Value = catId;
                    ParamList.Add(p1);
                    DataTable dt = _idac.GetManyRowsCols(sql, ParamList);
                    PList = DBList.ToList<Product>(dt);
                }
                catch (Exception)
                {
                    throw;
                }
                return PList;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> SList = null;
            try
            {
                string sql = "select * from Suppliers";
                DataTable dt = _idac.GetManyRowsCols(sql, null);
                SList = DBList.ToList<Supplier>(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return SList;
        }
        public List<Shipper> GetAllShippers()
        {
            List<Shipper> SList = null;
            try
            {
                string sql = "select * from Shippers";
                DataTable dt = _idac.GetManyRowsCols(sql, null);
                SList = DBList.ToList<Shipper>(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return SList;
        }

        public int GetLastProductId()
        {
            int prodid = 0;
            try
            {
                string sql = "SELECT TOP 1 * FROM products ORDER BY productid DESC";
                prodid = (int)_idac.GetSingleAnswer(sql,null);

            }
            catch(Exception)
            {
                throw;
            }
            return prodid;
        }
        public int AddProduct(Product prod)
        {
            int rows = 0;
            try
            {
                
                string sql = "SET IDENTITY_INSERT Products ON " +
                            "insert into Products(productid, productname, supplierid, categoryid," +
                            "quantityperunit, unitprice, unitsinstock, unitsonorder, reorderlevel, discontinued)"+"\n"
                            +"values('"+prod.ProductID+"','"+prod.ProductName+"','"+prod.SupplierID+"','"+
                            prod.CategoryID+"', '"+prod.QuantityPerUnit+"', '"+prod.UnitPrice+"','"+prod.UnitsInStock+"', '"+
                            prod.UnitsOnOrder+"', '"+prod.ReorderLevel+"', '"+prod.Discontinued+"')";

                

                rows = _idac.InsertUpdateDelete(sql, null);
            }
            catch(Exception)
            {
                throw;
            }
            return rows;
        }
    }
   }

