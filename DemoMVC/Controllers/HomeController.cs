using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.HoTen = "Vũ Long";
        ViewBag.Mssv = "2221050757";
        ViewData["ChuDe"] = "Tìm hiểu về quản lý trạng thái trong ASP.NET Core MVC";
        return View();
    }

    public IActionResult Privacy() => View();

    public IActionResult ViewBagDemo()
    {
        ViewBag.TieuDe = "Ví dụ sử dụng ViewBag";
        ViewBag.HoTen = "Vũ Long";
        ViewBag.Mssv = "2221050757";
        ViewBag.Lop = "PTPMQL";
        return View();
    }

    public IActionResult ViewDataDemo()
    {
        ViewData["TieuDe"] = "Ví dụ sử dụng ViewData";
        ViewData["HoTen"] = "Vũ Long";
        ViewData["Mssv"] = "2221050757";
        ViewData["Lop"] = "PTPMQL";
        return View();
    }

    public IActionResult GuiTempData()
    {
        TempData["ThongBao"] = "TempData đã truyền dữ liệu thành công qua RedirectToAction!";
        TempData["HoTen"] = "Vũ Long";
        return RedirectToAction(nameof(NhanTempData));
    }

    public IActionResult NhanTempData() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
