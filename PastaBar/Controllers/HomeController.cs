using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PastaBar.Models;
using PastaBar.Services;

namespace PastaBar.Controllers
{
    public class HomeController : Controller
    {
        private BestellingService _bestellingService;
        public HomeController(BestellingService bestellingService)
        {
            _bestellingService = bestellingService;
        }
        public IActionResult Index()
        {
            var pasta = new Pasta();
            return View(pasta);
        }

        [HttpPost]
        public IActionResult Toevoegen(Pasta pasta)
        {

            this.TempData["pasta"] = JsonConvert.SerializeObject(pasta);
            _bestellingService.Add(pasta);
            this.TempData["pastas"] = JsonConvert.SerializeObject(_bestellingService.FindAll());
            return Redirect("~/Home/Toevoegd");
        }

        public IActionResult Toevoegd()
        {
            var pasta = JsonConvert.DeserializeObject<Pasta>((string)this.TempData["pasta"]);
            return View(pasta);
        }

        public IActionResult overzichts()
        {
            var bestelling = new List<Pasta>();
            if (this.TempData.Keys.Contains("pastas"))
                bestelling = JsonConvert.DeserializeObject<List<Pasta>>((string)this.TempData["pastas"]);

            return View(bestelling);
        }

        public IActionResult naarpastashop()
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
