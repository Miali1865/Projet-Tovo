using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projet_Tovo.Models;

namespace Projet_Tovo.Controllers;

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

    public IActionResult Detail()
    {
        // Chargez les données depuis votre base de données ou une autre source
        var DetailPoste = new PageViewModel
        {
            Title = "Remplir plus de détails",
            Content = "Veuillez remplir les champs suivant"
        };
        return View(DetailPoste);
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
