using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImdbBAOdev.Models
{
    public class Aktor
    {
        public int AktorID { get; set; }
        public string AktorDogumTarihi  { get; set; }
        public string AktorAdi { get; set; }
        public int FilmID { get; set; }

        public virtual Film Film { get; set; }
    }
}