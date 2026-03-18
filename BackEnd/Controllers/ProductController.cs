using Microsoft.AspNetCore.Mvc;
using BackEnd.Data;
using BackEnd.Models;
using System.Linq;
using System.Collections.Generic;

namespace BackEnd.Controllers
{
    public class ProductController : Controller
    {
        private readonly Database _db;

        public ProductController(Database db)
        {
            _db = db;
        }

        // Trang tổng sản phẩm
        public IActionResult Index()
        {
            var products = _db.Products.ToList();
            return View(products);
        }

        // ===============================
        // QUẦN ÁO (1 - 25)
        // ===============================
        public IActionResult QuanAo()
        {
            var products = _db.Products
                .Where(p => p.Id >= 1 && p.Id <= 25)
                .ToList();

            return View("Index", products);
        }

        // ===============================
        // GIÀY (26 - 50)
        // ===============================
        public IActionResult Giay()
        {
            var products = _db.Products
                .Where(p => p.Id >= 26 && p.Id <= 50)
                .ToList();

            return View("Index", products);
        }

        // ===============================
        // DỤNG CỤ (51 - 75)
        // ===============================
        public IActionResult DungCu()
        {
            var products = _db.Products
                .Where(p => p.Id >= 51 && p.Id <= 75)
                .ToList();

            return View("Index", products);
        }

        // ===============================
        // THỰC PHẨM (76 - 100)
        // ===============================
        public IActionResult ThucPham()
        {
            var products = _db.Products
                .Where(p => p.Id >= 76 && p.Id <= 100)
                .ToList();

            return View("Index", products);
        }
    }
}