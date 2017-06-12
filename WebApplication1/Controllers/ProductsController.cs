using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Product
        public ActionResult List()
        {
            var products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Ручка",
                    Price = 10m,
                    Description = "Авторучка"
                },
                new Product
                {
                    Id = 2,
                    Name = "Ложка",
                    Price = 40m,
                    Description = "Для еды"
                },
                new Product
                {
                    Id = 3,
                    Name = "Вилка",
                    Price = 10.45m,
                    Description = "Для макарон"
                },
                new Product
                {
                    Id = 3,
                    Name = "Вилка",
                    Price = 10.45m,
                    Description = "Для макарон"
                },
                new Product
                {
                    Id = 3,
                    Name = "Вилка",
                    Price = 10.45m,
                    Description = "Для макарон"
                },
            };

            return View(products);
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}