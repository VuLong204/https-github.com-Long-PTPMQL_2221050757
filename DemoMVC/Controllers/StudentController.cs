using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;

namespace DemoMvc.Controllers; // Đã sửa thành DemoMvc và thêm dấu phân cách ;

public class StudentController : Controller // Đổi tên class trùng với tên file StudentController
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string fullName, string address, string university)
    {
        ViewBag.ThongBao = "Xin chào: " + fullName + " - Địa chỉ: " + address + " - Trường: " + university;
        return View();
    }
}
