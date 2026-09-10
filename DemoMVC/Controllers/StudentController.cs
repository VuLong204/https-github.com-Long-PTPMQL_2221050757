using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers;

public class StudentController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(string fullName, string address, string university)
    {
        ViewBag.ThongBao = $"Xin chào {fullName}! Địa chỉ: {address} - Trường: {university}";
        return View();
    }
}
