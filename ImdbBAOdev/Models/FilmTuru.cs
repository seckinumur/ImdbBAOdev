using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImdbBAOdev.Models
{
    public class FilmTuru
    {
        public int FilmTuruID { get; set; }
        public string FilminTuru { get; set; }

        public virtual ICollection<Film> Filmler { get; set; }
    }
}