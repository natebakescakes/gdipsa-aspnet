using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication7.Models;

namespace WebApplication7
{
    public class BusinessLogic
    {
        Model1 m = new Model1();

        public int Count
        {
            get
            {
                return GetCustomers.Count;
            }
        }

        public List<String> GetCustomerIDs
        {
            get
            {
                return m.Customers.Select<Customer, String>
                                     (c => c.CustomerID).ToList<String>();
            }
        }

        public List<Customer> GetCustomers
        {
            get
            {
                return m.Customers.ToList<Customer>();
            }
        }

        public Customer GetCustomer(string id)
        {
            List<Customer> result = m.Customers.Where
                              (c => c.CustomerID.Equals(id)).ToList<Customer>();
            if (result.Count > 0)
                return result[0];
            else
                return null;
        }

        public List<Product> GetProductsOrderedBy(string custid)
        {
            var list = new List<Product>();
            Customer c = GetCustomer(custid);
            List<Order> orders = m.Orders
                .Where(o => o.CustomerID.Equals(c.CustomerID))
                .ToList<Order>();

            foreach (Order o in orders)
            {
                List<int> ids = m.Order_Details
                    .Where(d => d.OrderID == o.OrderID)
                    .Select(de => de.ProductID)
                    .ToList<int>();

                foreach (int id in ids)
                {
                    Product prod = m.Products
                        .Where(p => p.ProductID.Equals(id))
                        .ToList<Product>()[0];

                    list.Add(prod);
                }
            }

            return list;
        }
    }
}