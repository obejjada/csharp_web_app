using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using csharp_web_app.Models;

namespace csharp_web_app.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly CoffeeBeansDbContext _context;

    public HomeController(ILogger<HomeController> logger, CoffeeBeansDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult CoffeeBeans()
    {
        var allExpenses = _context.CoffeeBeans.ToList();
        return View(allExpenses);
    }
    
    public IActionResult AddEditCoffeeBean()
    {
        return View();
    }
    
    public IActionResult AddEditCoffeeBeanForm(CoffeeBeans model)
    {
        _context.CoffeeBeans.Add(model);
        _context.SaveChanges();
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