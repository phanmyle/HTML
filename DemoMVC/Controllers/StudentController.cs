using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers;
public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Index(string fullName)
    {
        return View();
    }
    public IActionResult Demo()
{
    return View();
}
}
