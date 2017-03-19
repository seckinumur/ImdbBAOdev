using ImdbBAOdev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImdbBAOdev.Controller
{
    public class turler
    {
        public List<FilmTuru> Hepsi()
        {
            using (IbmdDB db = new IbmdDB())
            {
                var sirala = db.FilmTuru.ToList();
                return sirala;
            }
        }
    }
}