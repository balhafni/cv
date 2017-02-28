using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
   public class Product
    {
        int proudctID;
        public int ProductId
        {
            set { proudctID = value; }
            get { return proudctID; }
        }

        string productName;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }

        }
        double price;
        public double Price
        {
            set { price = value;  }
            get { return price; }
        }
        string description;
        public string Description
        {
            set { description = value; }
            get { return description; }
        }
        Category category;
        public Category Category
        {
            set { category = value; }
            get { return category; }
        }
    }
}
