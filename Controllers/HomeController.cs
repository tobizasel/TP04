using Microsoft.AspNetCore.Mvc;

namespace TP_Zaselsky.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
