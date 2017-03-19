using ImdbBAOdev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImdbBAOdev
{
    public partial class FilmHakkinda : System.Web.UI.Page
    {
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null)
            {
                id = int.Parse(Request.QueryString["ID"]);

                using (IbmdDB db = new IbmdDB())
                {
                    var bul = db.Film.Where(p => p.FilmID == id).FirstOrDefault();
                    var bul2 = db.Film.Where(p => p.FilmID == id).ToList();
                    FilmBaslik.Text = bul.Adi;
                    Yapimyili.Text = bul.YapimYili;
                    Bilgileri.DataSource = bul2;
                    Bilgileri.DataBind();
                    Repeater1.DataSource = bul2;
                    Repeater1.DataBind();
                    var bul1 = db.FilmTuru.Where(p => p.FilmTuruID == bul.FilmTuruID).FirstOrDefault();
                    var bul4 = db.Yonetmen.Where(p => p.YonetmenID == bul.YonetmenID).FirstOrDefault();
                    Konu.Text = bul.Konusu;
                    turu.Text = bul1.FilminTuru;
                    var bul3 = db.Aktor.Where(p => p.FilmID == bul.FilmID).ToList();
                    Oyunculari.DataSource = bul3;
                    Oyunculari.DataBind();
                    Konusus.Visible = true;

                }
            }
        }
    }
}