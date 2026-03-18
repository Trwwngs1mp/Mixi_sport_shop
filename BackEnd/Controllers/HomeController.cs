using Microsoft.AspNetCore.Mvc;
using BackEnd.Data;
using BackEnd.Models;
using System.Linq;
using System.Collections.Generic;

namespace BackEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly Database _db;

        public HomeController(Database db)
        {
            _db = db;
        }

        private static List<Product> randomProducts;

        public IActionResult Index()
        {
            if (randomProducts == null)
            {
                Random rd = new Random();

                randomProducts = _db.Products
                    .OrderBy(x => Guid.NewGuid())
                    .Take(66)
                    .ToList();
            }

            return View(randomProducts);
        }

        public IActionResult Search(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return RedirectToAction("Index");
            }

            var result = _db.Products
                .Where(p => p.Name.ToLower().Contains(keyword.ToLower()))
                .ToList();

            return View("Index", result);
        }
    }
}