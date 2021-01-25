using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PastaBar.Models;
using PastaBar.Services;

namespace PastaBar.Controllers
{
    public class InschrijvenController : Controller
    {
        private PersoonService _persoonService;

        public InschrijvenController(PersoonService persoonService)
        {
            _persoonService = persoonService;
        }

        public IActionResult Index()
        {
            return Redirect("~/Inschrijven/Toevoegen");
        }

        [HttpGet]
        public IActionResult Toevoegen()
        {
            var persoon = new Persoon();
            return View(persoon);
        }
        [HttpPost]
        public IActionResult Toevoegen(Persoon p)
        {
            if (this.ModelState.IsValid)
            {
                _persoonService.Add(p);
                return RedirectToAction("Welcom", p);
            }
            return View(p);
        }
        public IActionResult Welcom(Persoon p)
        {
            return View(p);
        }
    }
}
