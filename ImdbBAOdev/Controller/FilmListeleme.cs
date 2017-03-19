using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImdbBAOdev.Models;
using ImdbBAOdev.Controller;

namespace ImdbBAOdev
{
    public class FilmListeleme
    {
        public List<Film>TureGoreSirala(int TurID)
        {
            using (IbmdDB db = new IbmdDB())
            {
                var sirala = db.Film.Where(p => p.FilmTuruID == TurID).ToList();
                return sirala;
            }
        }
        public List<Film> YilaGoreSirala()
        {
           
            using (IbmdDB db = new IbmdDB())
            {
                var sirala = db.Film.OrderBy(p => p.YapimYili).ToList();
                return sirala;

            }
        }

        public void FilmKaydet(Film Kaydet)
        {
            using (IbmdDB db = new IbmdDB())
            {
                db.Film.Add(Kaydet);
                db.SaveChanges();
            }
        }
        public void FilmSilme(Film sil)
        {
            using (IbmdDB db = new IbmdDB())
            {
                db.Film.Remove(sil);
                db.SaveChanges();
            }
        }
        
    }
}