using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using ServiceReference1;

    class Program
    {
        static void Main(string[] args)
        {
            WebServiceSoapClient c = new WebServiceSoapClient();
            foreach (var productId in c.GetProductIds())
            {
                Console.WriteLine(productId);
            }
        }
    }
}
