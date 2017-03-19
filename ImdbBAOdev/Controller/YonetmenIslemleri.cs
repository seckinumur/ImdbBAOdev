using ImdbBAOdev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImdbBAOdev.Controller
{
    public class YonetmenIslemleri
    {
        public List<Yonetmen> Yonetmenlerinhepsi()
        {
            using (IbmdDB db = new IbmdDB())
            {
                var bul = db.Yonetmen.ToList();
                return bul;
            }
        }
        public void YonetmenKaydet(Yonetmen Kaydet)
        {
            using (IbmdDB db = new IbmdDB())
            {
                db.Yonetmen.Add(Kaydet);
                db.SaveChanges();
            }
        }
        public void YonetmenSil(Yonetmen Sil)
        {
            using (IbmdDB db = new IbmdDB())
            {
                db.Yonetmen.Remove(Sil);
                db.SaveChanges();
            }
        }
    }
}