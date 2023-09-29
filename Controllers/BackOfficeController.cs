using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projet_Tovo.Models;

namespace Projet_Tovo.Controllers
{
    [Route("[controller]")]
    public class BackOfficeController : Controller
    {
        private readonly ILogger<BackOfficeController> _logger;

        public BackOfficeController(ILogger<BackOfficeController> logger)
        {
            _logger = logger;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Detail")]
        public IActionResult Detail()
        {
            // Chargez les données depuis votre base de données ou une autre source
            var Detail = new PageViewModel
            {
                Title = "Détails par l'admin"
            };
            return View(Detail);
        }

        [Route("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}