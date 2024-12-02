using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using csharp_web_app.Models;

namespace csharp_web_app.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult CoffeeBeans()
    {
        return View();
    }
    
    public IActionResult AddEditCoffeeBean()
    {
        return View();
    }
    
    public IActionResult AddEditCoffeeBeanForm(CoffeeBeans model)
    {
        return RedirectToAction("CoffeeBeans");
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}