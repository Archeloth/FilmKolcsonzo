using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _20190927.Models;

namespace _20190927.ViewModels
{
    public class RandomFilmViewModel
    {
        //Adott filmet kikölcsönző emberek listája
        public Film Film { get; set; }
        public List<Kolcsonzo> Kolcsonzok { get; set; }

    }
}