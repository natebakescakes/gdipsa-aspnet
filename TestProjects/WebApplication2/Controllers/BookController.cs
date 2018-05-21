using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class BookController : Controller
    {
        BookshopEntities context = new BookshopEntities();
        
        // GET: Book
        public ActionResult Index()
        {
            ViewBag.books = context.Books.ToList<Book>();
            return View();
        }
    }
}