using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PostTutorialNET.Models;
using PostTutorialNET.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PostTutorialNET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private RepositorySweetAlert repo;

        public HomeController(ILogger<HomeController> logger,RepositorySweetAlert repo)
        {
            _logger = logger;
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Juego> juegos = this.repo.GetJuegos();
            return View(juegos);
        }

        public IActionResult DeleteJuego(int idjuego)
        {
            Juego juego = this.repo.FindJuego(idjuego);
            this.repo.DeleteJuego(idjuego);
            return RedirectToAction("Index", "Home");
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
}
