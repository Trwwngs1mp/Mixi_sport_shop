using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BackEnd.Data;
using BackEnd.Models;
using System.Linq;

public class AccountController : Controller
{
    private readonly Database _db;

    public AccountController(Database db)
    {
        _db = db;
    }

    // ================= LOGIN =================
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        var user = _db.Users.FirstOrDefault(u => u.Username == username);

        // ❌ Sai tài khoản hoặc mật khẩu
        if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
        {
            ViewBag.Error = "Sai tài khoản hoặc mật khẩu";
            return View();
        }

        // ✅ Lưu session
        HttpContext.Session.SetString("Username", user.Username);
        HttpContext.Session.SetString("Role", user.Role);

        return RedirectToAction("Index", "Home");
    }

    // ================= REGISTER =================
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(string username, string password, string confirmPassword)
    {
        // ❌ Check trùng tài khoản
        if (_db.Users.Any(u => u.Username == username))
        {
            ViewBag.Error = "Tài khoản đã tồn tại";
            return View();
        }

        // ❌ Check mật khẩu
        if (password != confirmPassword)
        {
            ViewBag.Error = "Mật khẩu không khớp";
            return View();
        }

        if (password.Length < 8 || !password.Any(char.IsDigit) || !password.Any(char.IsLetter))
        {
            ViewBag.Error = "Mật khẩu phải ≥ 8 ký tự, gồm chữ và số";
            return View();
        }

        // ✅ Tạo user mới
        var user = new User
        {
            Username = username,
            Password = BCrypt.Net.BCrypt.HashPassword(password),
            Role = "User"
        };

        _db.Users.Add(user);
        _db.SaveChanges();

        return RedirectToAction("Login");
    }

    // ================= LOGOUT =================
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Home");
    }
}