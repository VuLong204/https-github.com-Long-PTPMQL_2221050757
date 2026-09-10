using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers;

public class DemoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ThongBao = "DemoController - quản lý trạng thái MVC";
        return View("~/Views/Home/Index.cshtml");
    }
}
