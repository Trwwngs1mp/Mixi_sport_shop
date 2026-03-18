using Microsoft.AspNetCore.Mvc;
using BackEnd.Models;
using BackEnd.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace BackEnd.Controllers
{
    public class CartController : Controller
    {
        private readonly Database _db;

        public CartController(Database db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var cart = GetCart();
            return View(cart);
        }

        // ===============================
        // THÊM SẢN PHẨM
        // ===============================
        public IActionResult Add(int id, int qty = 1)
        {
            var product = _db.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            var cart = GetCart();

            var item = cart.FirstOrDefault(x => x.Product.Id == id);

            if (item != null)
                item.Quantity += qty;
            else
                cart.Add(new CartItem { Product = product, Quantity = qty });

            SaveCart(cart);

            return Ok(); // AJAX
        }

        // ===============================
        // TĂNG SỐ LƯỢNG
        // ===============================
        public IActionResult Increase(int id)
        {
            var cart = GetCart();

            var item = cart.FirstOrDefault(x => x.Product.Id == id);

            if (item != null)
                item.Quantity++;

            SaveCart(cart);

            return RedirectToAction("Index");
        }

        // ===============================
        // GIẢM SỐ LƯỢNG
        // ===============================
        public IActionResult Decrease(int id)
        {
            var cart = GetCart();

            var item = cart.FirstOrDefault(x => x.Product.Id == id);

            if (item != null)
            {
                item.Quantity--;

                if (item.Quantity <= 0)
                    cart.Remove(item);
            }

            SaveCart(cart);

            return RedirectToAction("Index");
        }

        // ===============================
        // XOÁ SẢN PHẨM
        // ===============================
        public IActionResult Remove(int id)
        {
            var cart = GetCart();

            cart.RemoveAll(x => x.Product.Id == id);

            SaveCart(cart);

            return RedirectToAction("Index");
        }

        // ===============================
        // SESSION
        // ===============================
        private List<CartItem> GetCart()
        {
            var cart = HttpContext.Session.GetString("CART");

            if (string.IsNullOrEmpty(cart))
                return new List<CartItem>();

            return JsonSerializer.Deserialize<List<CartItem>>(cart) ?? new List<CartItem>();
        }

        private void SaveCart(List<CartItem> cart)
        {
            HttpContext.Session.SetString("CART", JsonSerializer.Serialize(cart));
        }
    }
}