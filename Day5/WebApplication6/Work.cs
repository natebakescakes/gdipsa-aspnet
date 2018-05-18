using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6
{
    public class Work
    {
        Model1 model = new Model1();

        public List<Product> GetProducts()
        {
            return model.Products.ToList<Product>();
        }

        public List<int> GetProductIds()
        {
            List<int> list = new List<int>();
            foreach (Product p in GetProducts())
            {
                list.Add(p.ProductID);
            }
            return list;
        }

        public Product GetProduct(int id)
        {
            return model.Products.Where
                    (p => p.ProductID == id).ToList<Product>()[0];
        }
    }
}