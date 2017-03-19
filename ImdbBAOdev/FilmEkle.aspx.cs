using ImdbBAOdev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImdbBAOdev
{
    public partial class FilmEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (IbmdDB db = new IbmdDB())
            {
                try
                {
                    var bul = db.Film.Where(p => p.Adi == txtAd.Text).FirstOrDefault();
                    if (bul.Adi == txtAd.Text)
                    {
                        Response.Redirect("Filmler.aspx?ID=" + bul.FilmID);
                    }
                }
                catch
                {
                    Film Ekle = new Film();
                    Ekle.Adi = txtAd.Text;
                    Ekle.FilmAfisi = txtTel.Text;
                    var bul1 = db.FilmTuru.Where(p => p.FilminTuru == FilmTuru.SelectedValue).FirstOrDefault();

                    Ekle.FilmTuruID = bul1.FilmTuruID;
                    Ekle.Konusu = Konu.Text;
                    Ekle.YapimYili = txtSoyad.Text;
                    try
                    {
                        var bul2 = db.Yonetmen.Where(p => p.YonetmenIsmi == Yonetmensecim.Text).FirstOrDefault();
                        if (bul2.YonetmenIsmi == Yonetmensecim.Text)
                        {
                            Ekle.YonetmenID = bul2.YonetmenID;
                        }
                    }
                    catch
                    {
                        using (IbmdDB db2 = new IbmdDB())
                        {
                            Yonetmen yeni = new Yonetmen();
                            yeni.YonetmenIsmi = Yonetmensecim.Text;
                            db2.Yonetmen.Add(yeni);
                            db2.SaveChanges();
                        }
                        var bul3 = db.Yonetmen.Where(p => p.YonetmenIsmi == Yonetmensecim.Text).FirstOrDefault();
                        Ekle.YonetmenID = bul3.YonetmenID;
                    }
                    db.Film.Add(Ekle);
                    db.SaveChanges();
                    using (IbmdDB db3 = new IbmdDB())
                    {
                        var bul4 = db.Film.Where(p => p.Adi == txtAd.Text).FirstOrDefault();
                        Aktor yeni = new Aktor();
                        yeni.AktorAdi = Oyuncu1ri.Text;
                        yeni.AktorDogumTarihi = Odo.Text;
                        yeni.FilmID = bul4.FilmID;
                        db3.Aktor.Add(yeni);
                        db3.SaveChanges();
                    }
                    using (IbmdDB db4 = new IbmdDB())
                    {
                        var bul4 = db.Film.Where(p => p.Adi == txtAd.Text).FirstOrDefault();
                        Aktor yeni = new Aktor();
                        yeni.AktorAdi = Oyuncu2ri.Text;
                        yeni.AktorDogumTarihi = odo2.Text;
                        yeni.FilmID = bul4.FilmID;
                        db4.Aktor.Add(yeni);
                        db4.SaveChanges();
                    }
                    
                    Response.Redirect("Filmler.aspx");
                }
            }    
        }
    }
}