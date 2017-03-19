using ImdbBAOdev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImdbBAOdev
{
    public partial class AktorDuzenle : System.Web.UI.Page
    {
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null)
            {
                id = int.Parse(Request.QueryString["ID"]);

                using (IbmdDB db = new IbmdDB())
                {
                    var bul = db.Aktor.Where(p => p.AktorID == id).FirstOrDefault();
                    txtAd.Text = bul.AktorAdi;
                    txtSoyad.Text = bul.AktorDogumTarihi;
                }
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(txtAd.Text!="" && txtSoyad.Text != "")
            {
                using (IbmdDB db = new IbmdDB())
                {
                    var bul = db.Aktor.Where(p => p.AktorID == id).FirstOrDefault();
                    bul.AktorAdi = txtAd.Text;
                    bul.AktorDogumTarihi = txtSoyad.Text;
                    db.SaveChanges();
                    Response.Redirect("Filmler.aspx?ID=" + bul.AktorID);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (IbmdDB db = new IbmdDB())
            {
                var bul = db.Aktor.Where(p => p.AktorID == id).FirstOrDefault();
                db.Aktor.Remove(bul);
                db.SaveChanges();
                Response.Redirect("Filmler.aspx");
            }
        }
    }
}