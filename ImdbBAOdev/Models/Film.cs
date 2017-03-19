using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImdbBAOdev.Models
{
    public class Film
    {
        public int FilmID { get; set; }
        public string Adi { get; set; }
        public string YapimYili { get; set; }
        public int FilmTuruID { get; set; }
        public int YonetmenID { get; set; }
        public string FilmAfisi { get; set; }
        public string Konusu { get; set; }

        public virtual Yonetmen Yonetmen { get; set; }
        public virtual FilmTuru Filmturu { get; set; }
    }
}