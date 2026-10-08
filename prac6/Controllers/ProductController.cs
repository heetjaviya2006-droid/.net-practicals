
using ProductCatalog.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace prac6.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    Category = "Electronics",
                    Price = 55000,
                    Quantity = 10,
                    Description = "High performance laptop"
                },

                new Product
                {
                    ProductId = 2,
                    ProductName = "Mobile Phone",
                    Category = "Electronics",
                    Price = 25000,
                    Quantity = 20,
                    Description = "Smartphone"
                }
            };

            return View(products);
        }
    }
}