using KlubPrátelTaborovychOhnu.Models;
using KlubPrátelTaborovychOhnu.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KlubPrátelTaborovychOhnu.Controllers
{
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

        public IActionResult Privacy()
        {
            return View();
        }       
        // GET Metoda násobení 5
        public IActionResult Ahoj() 
        {
            AhojViewModel a1 = new AhojViewModel();
            a1.Jmeno = "hokup pokus";
            return View(a1);
        }
        // POST Metoda násobení 5
        [HttpPost]
        public IActionResult Ahoj(AhojViewModel a) 
        {
            a.Vstup *= 5;
            return View(a);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public int scitej(int a,int b) 
        {
            return a + b;
        }
    }
}
