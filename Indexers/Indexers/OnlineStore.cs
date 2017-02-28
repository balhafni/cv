using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class OnlineStore
    {
        Product[] Prods;

        public Product this[int idToSearch]
        {
            get
            {
                Product productFound = null;
                foreach (Product prod in Prods)
                {
                    if (prod.ProductId == idToSearch)
                    {
                        productFound = prod;
                        break;
                    }
                }
                return productFound;
            }
        }

        public Product this[string nameToSearch]
        {
            get
            {
                Product prodFound = null;
                foreach (Product prod in Prods)
                {
                    if (prod.ProductName == nameToSearch)
                    {
                        prodFound = prod;
                        break;
                    }
                }
                return prodFound;
            }
        }

        public ArrayList this[string partialDescription, SearchType searchBy]
        {
            get
            {
                ArrayList prodList = new ArrayList();
                foreach (Product prod in Prods)
                {
                    if (searchBy == SearchType.DESCRIPTION)
                    {
                        if (prod.Description.Contains(partialDescription))
                        {
                            prodList.Add(prod);
                        }
                    }
                }
                return prodList;
            }
        }

        public ArrayList this[Category category]
        {
            get
            {
                ArrayList prodList = new ArrayList();
                foreach (Product prod in Prods)
                {
                    if (prod.Category == category)
                    {
                        prodList.Add(prod);
                    }
                }
                return prodList;
            }
        }



        public Product[] Products
        {
            get { return Prods; }
            set { Prods = value; }
        }

        public OnlineStore()
        {
          Prods = new Product[9];
            for(int i =0; i  < Prods.Length; i++)
            {
                Prods[i] = new Product();
            }
         
            Prods[0].ProductId = 1212;
            Prods[0].ProductName = "MacBook Pro";
            Prods[0].Price = 800.50;
            Prods[0].Category = Category.ELECTRONICS;
            Prods[0].Description = "Laptop";

           
            Prods[1].ProductId = 1313;
            Prods[1].ProductName = "Galaxy S6";
            Prods[1].Price = 705.30;
            Prods[1].Category = Category.ELECTRONICS;
            Prods[1].Description = "Samsung Smart Phone";

            
            Prods[2].ProductId = 1212;
            Prods[2].ProductName = "Apple Watch";
            Prods[2].Price = 570.20;
            Prods[2].Category = Category.ELECTRONICS;
            Prods[2].Description = "Smart Watch";


           
            Prods[3].ProductId = 1414;
            Prods[3].ProductName = "Cracking the coding Interview";
            Prods[3].Price = 31.25;
            Prods[3].Category = Category.BOOKS;
            Prods[3].Description = "Coding Book";

           
            Prods[4].ProductId = 1515;
            Prods[4].ProductName = "Essential Calculus";
            Prods[4].Price = 200.60;
            Prods[4].Category = Category.BOOKS;
            Prods[4].Description = "Calculus Book";

          
            Prods[5].ProductId = 1616;
            Prods[5].ProductName = "GRE Prep Book";
            Prods[5].Price = 125.89;
            Prods[5].Category = Category.BOOKS;
            Prods[5].Description = "GRE Book";

           
            Prods[6].ProductId = 1717;
            Prods[6].ProductName = "Messi Special Cleats";
            Prods[6].Price = 70.20;
            Prods[6].Category = Category.SPORTS;
            Prods[6].Description = "Soccer Shoes";

           
            Prods[7].ProductId = 1818;
            Prods[7].ProductName = "Air Jordan";
            Prods[7].Price = 120.24;
            Prods[7].Category = Category.SPORTS;
            Prods[7].Description = "BasketBall shoes";

            Prods[8].ProductId = 1919;
            Prods[8].ProductName = "Adidas ball";
            Prods[8].Price = 80.87;
            Prods[8].Category = Category.SPORTS;
            Prods[8].Description = "Soccer Ball";


        }

        
       
    }
}
