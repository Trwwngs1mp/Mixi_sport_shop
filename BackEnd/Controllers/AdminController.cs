using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BackEnd.Data;
using BackEnd.Models;
using System.Linq;

public class AdminController : Controller
{
    private readonly Database _db;

    public AdminController(Database db)
    {
        _db = db;
    }

    // 🔒 CHECK ADMIN
    private bool IsAdmin()
    {
        return HttpContext.Session.GetString("Role") == "Admin";
    }

    // ================= DANH SÁCH + SEARCH =================
    public IActionResult Index(string keyword)
    {
        if (!IsAdmin())
            return RedirectToAction("Login", "Account");

        var products = _db.Products.AsQueryable();

        // 🔍 SEARCH
        if (!string.IsNullOrEmpty(keyword))
        {
            products = products.Where(p => p.Name.Contains(keyword));
        }

        return View(products.ToList());
    }

    // ================= THÊM =================
    public IActionResult Create()
    {
        if (!IsAdmin())
            return RedirectToAction("Login", "Account");

        return View();
    }

    [HttpPost]
    public IActionResult Create(Product p)
    {
        if (!IsAdmin())
            return RedirectToAction("Login", "Account");

        if (ModelState.IsValid)
        {
            _db.Products.Add(p);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        return View(p);
    }

    // ================= SỬA =================
    public IActionResult Edit(int id)
    {
        if (!IsAdmin())
            return RedirectToAction("Login", "Account");

        var product = _db.Products.Find(id);
        if (product == null) return NotFound();

        return View(product);
    }

    [HttpPost]
    public IActionResult Edit(Product p)
    {
        if (!IsAdmin())
            return RedirectToAction("Login", "Account");

        if (ModelState.IsValid)
        {
            _db.Products.Update(p);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        return View(p);
    }

    // ================= XOÁ =================
    public IActionResult Delete(int id)
    {
        if (!IsAdmin())
            return RedirectToAction("Login", "Account");

        var product = _db.Products.Find(id);
        if (product == null) return NotFound();

        return View(product);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        if (!IsAdmin())
            return RedirectToAction("Login", "Account");

        var product = _db.Products.Find(id);

        if (product != null)
        {
            _db.Products.Remove(product);
            _db.SaveChanges();
        }

        return RedirectToAction("Index");
    }

    // ================= CHI TIẾT =================
    public IActionResult Details(int id)
    {
        if (!IsAdmin())
            return RedirectToAction("Login", "Account");

        var product = _db.Products.Find(id);
        if (product == null) return NotFound();

        return View(product);
    }
}