using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OrderedBy(string id)
        {
            BusinessLogic b = new BusinessLogic();
            ViewBag.customer = b.GetCustomer(id);
            ViewBag.products = b.GetProductsOrderedBy(id);
            return View();
        }
    }
}