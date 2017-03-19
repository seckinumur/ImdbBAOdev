using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImdbBAOdev.Models;

namespace ImdbBAOdev.Controller
{
    public class AktorIslemleri
    {
        public List<Aktor> EnGencAktor()
        {
            using (IbmdDB db = new IbmdDB())
            {
                var sirala = db.Aktor.OrderBy(p=> p.AktorDogumTarihi).ToList();
                return sirala;
            }
        }
        public void AktorKaydet(Aktor Kaydet)
        {
            using (IbmdDB db = new IbmdDB())
            {
                db.Aktor.Add(Kaydet);
                db.SaveChanges();
            }
        }
        public void AktorSil(Aktor Sil)
        {
            using (IbmdDB db = new IbmdDB())
            {
                db.Aktor.Remove(Sil);
                db.SaveChanges();
            }
        }
        public Aktor AktorBul(int ID)
        {
            using (IbmdDB db = new IbmdDB())
            {
               var bul=  db.Aktor.Where(p => p.AktorID == ID).FirstOrDefault();
                return bul;
            }
        }

    }
}