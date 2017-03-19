using ImdbBAOdev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImdbBAOdev
{
    public partial class YonetmenDuzenle : System.Web.UI.Page
    {
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null)
            {
                id = int.Parse(Request.QueryString["ID"]);

                using (IbmdDB db = new IbmdDB())
                {
                    var bul = db.Yonetmen.Where(p => p.YonetmenID == id).FirstOrDefault();
                    txtAd.Text = bul.YonetmenIsmi;
                }
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "")
            {
                using (IbmdDB db = new IbmdDB())
                {
                    var bul = db.Yonetmen.Where(p => p.YonetmenID == id).FirstOrDefault();
                    bul.YonetmenIsmi = txtAd.Text;
                    db.SaveChanges();
                    Response.Redirect("Filmler.aspx?IDY="+bul.YonetmenID);
                }
            }
            
        }
    }
}