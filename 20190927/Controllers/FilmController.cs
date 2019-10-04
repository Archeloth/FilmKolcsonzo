using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _20190927.Models;
using _20190927.ViewModels;

namespace _20190927.Controllers
{
    public class FilmController : Controller
    {
        public ActionResult Index()
        {
            var vrf = GetData();
            return View(vrf);
        }

        // GET: Filmek/Random
        public ViewResult Random()
        {
            var film = new Film()
            { Cim = "Star Wars" };

            var kolcsonzok = new List<Kolcsonzo>()
            {
                new Kolcsonzo(){ Nev = "Géza"},
                new Kolcsonzo(){ Nev = "Lacika"},
                new Kolcsonzo(){ Nev = "Zsuzsanna"},
                new Kolcsonzo(){ Nev = "Peti"},
                new Kolcsonzo(){ Nev = "Lacika"},
                new Kolcsonzo(){ Nev = "Lacika"},
            };

            var rfvm = new RandomFilmViewModel()
            {
                Film = film,
                Kolcsonzok = kolcsonzok
            };

            return View(rfvm);

            //Adat átdobásra:
            //-View-ban () a modell dolgokat
            //-ViewData dictionary-ban
            //-viewbag

            //return View(film);
            //ViewData["Film"] = film;
            //ViewBag.Film = film;


            //return Content("");
            //return HTTPNotFound();
            //return new EmptyResult();
            //return RedirectToAction();



        }
        public ActionResult Szerkesztes(int id)
        {
            return Content($"ID: {id}");
        }

        //GET /Filmek/oldal/rendezes
        //GET /Filmek/2/cim
        //GET /Filmek -> 1 oldal és cím szerint
        
        //public ActionResult Index(int oldal = 1, string rendezes = "cim")
        //{
        //    /*if (!oldal.HasValue) oldal = 1;
        //    if (string.IsNullOrWhiteSpace()) rendezes = "cim";*/
        //    return Content($"Oldal = {oldal}/rendezés = {rendezes}");
        //}
        
        //GET https://localhost:44316/Filmek/megjelenes/2002/12
        [Route("Filmek/Megjelenes/{ev:regex(\\d{4})}/{honap:regex(\\d{2}):range(1,12)}")]//Új mvc route-olás
        public ActionResult Megjelenes(int ev = 2000, int honap = 10)
        {
            return Content($"Év: {ev} Hónap: {honap}");
        }

        private IEnumerable<Film> GetData()
        {
            return new List<Film>
            {
                new Film() { Id = 1, Cim = "A remény rabjai", Kiadas = 1994 },
                new Film() { Id = 2, Cim = "A keresztapa", Kiadas = 1972 },
                new Film() { Id = 3, Cim = "A keresztapa II", Kiadas = 1974 },
                new Film() { Id = 4, Cim = "A sötét lovag", Kiadas = 2008 },
                new Film() { Id = 5, Cim = "Tizenkét dühös ember", Kiadas = 1957 },
                new Film() { Id = 6, Cim = "Schindler listája", Kiadas = 1993 },
                new Film() { Id = 7, Cim = "A Gyűrűk Ura: A király visszatér", Kiadas = 2003 },
                new Film() { Id = 8, Cim = "Ponyvaregény", Kiadas = 1994  }
            };
        }
    }
}