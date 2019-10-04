using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _20190927.Models;

namespace _20190927.Controllers
{
    public class UgyfelekController : Controller
    {
        private IEnumerable<Kolcsonzo> GetData()
        {
            return new List<Kolcsonzo>
            {
                new Kolcsonzo() { Id = 1, Nev = "Petike" },
                new Kolcsonzo() { Id = 2, Nev = "Adrienn" },
                new Kolcsonzo() { Id = 3, Nev = "Jani" },
                new Kolcsonzo() { Id = 4, Nev = "István" },
                new Kolcsonzo() { Id = 5, Nev = "Anna" },
                new Kolcsonzo() { Id = 6, Nev = "Bella" },
                new Kolcsonzo() { Id = 7, Nev = "Zsuzsanna" },
                new Kolcsonzo() { Id = 8, Nev = "Róbert" }
            };
        }

        // GET: Ugyfelek
        public ViewResult Index()
        {
            var vrf = GetData();
           return View(vrf);
        }

        public ActionResult Reszletek(int id)
        {
            var uf = GetData().SingleOrDefault(c => c.Id == id);

            if (uf is null) return HttpNotFound();
            else return View(uf);
        }
    }
}