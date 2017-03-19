using ImdbBAOdev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImdbBAOdev
{
    public partial class FilmDuzenleme : System.Web.UI.Page
    {
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Request.QueryString["ID"] != null)
                {
                    id = int.Parse(Request.QueryString["ID"]);

                    using (IbmdDB db = new IbmdDB())
                    {
                        var bul = db.Film.Where(p => p.FilmID == id).FirstOrDefault();
                        txtAd.Text = bul.Adi;
                        txtSoyad.Text = bul.YapimYili;
                        txtTel.Text = bul.FilmAfisi;
                        var bul1 = db.FilmTuru.Where(p => p.FilmTuruID == bul.FilmTuruID).FirstOrDefault();
                        FilmTuru.SelectedValue = bul1.FilminTuru;
                        var bul2 = db.Yonetmen.Where(p => p.YonetmenID == bul.YonetmenID).FirstOrDefault();
                        Yonetmensec.SelectedValue = bul2.YonetmenIsmi;
                        Konu.Text = bul.Konusu;
                    }
                }
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (IbmdDB db = new IbmdDB())
            {
                id = int.Parse(Request.QueryString["ID"]);

                var bul = db.Film.Where(p => p.FilmID == id).FirstOrDefault();
                bul.Adi = txtAd.Text;
                bul.YapimYili = txtSoyad.Text;
                bul.FilmAfisi = txtTel.Text;
                var bul1 = db.FilmTuru.Where(p => p.FilminTuru == FilmTuru.SelectedValue).FirstOrDefault();
                bul.FilmTuruID = bul1.FilmTuruID;
                var bul2 = db.Yonetmen.Where(p => p.YonetmenIsmi == Yonetmensec.SelectedValue).FirstOrDefault();
                bul.YonetmenID = bul2.YonetmenID;
                bul.Konusu = Konu.Text;
                db.SaveChanges();
            }
            Response.Redirect("Filmler.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (IbmdDB db = new IbmdDB())
            {
                var bul = db.Film.Where(p => p.FilmID == id).FirstOrDefault();
                db.Film.Remove(bul);
                db.SaveChanges();
                Response.Redirect("Filmler.aspx");
            }
        }
    }
}