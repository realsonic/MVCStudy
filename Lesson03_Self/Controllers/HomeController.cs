using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Lesson03_Self.Models;

namespace Lesson03_Self.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<Product> products = new List<Product>
            {
                new Product {Id = 1, Name = "Pencil", Price = 10m, CreatedDate = DateTime.Now},
                new Product {Id = 2, Name = "Pen", Price = 110m, CreatedDate = DateTime.Now.AddDays(-10)},
                new Product {Id = 3, Name = "Paper", Price = 210m, CreatedDate = DateTime.Now.AddHours(-100)},
                new Product {Id = 4, Name = "Apple", Price = 40m, CreatedDate = DateTime.Now.AddYears(-2)}
            };

            return View(products);
        }

        public ActionResult ProductsList(IEnumerable<Product> products)
        {
            return PartialView("_ProductsList", products);
        }

        public ActionResult ProductsTable(IEnumerable<Product> products)
        {
            return PartialView("_ProductsTable", products);
        }
    }
}