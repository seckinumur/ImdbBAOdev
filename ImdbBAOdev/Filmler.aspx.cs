using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ImdbBAOdev.Controller;
using ImdbBAOdev.Models;

namespace ImdbBAOdev
{
    public partial class FilmListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                using (IbmdDB db = new IbmdDB())
                {
                    
                    var result = db.Film.Where(p => p.FilmID == id).ToList();
                    FilmKarti.DataSource = result;
                    FilmKarti.DataBind();
                }
            }
            else if (Request.QueryString["IDY"] != null)
            {
                int id = int.Parse(Request.QueryString["IDY"]);

                using (IbmdDB db = new IbmdDB())
                {

                    var result = db.Film.Where(p => p.YonetmenID == id).ToList();
                    FilmKarti.DataSource = result;
                    FilmKarti.DataBind();
                    
                }
                
            }
            else if (Request.QueryString["IDT"] != null)
            {
                int id = int.Parse(Request.QueryString["IDT"]);

                using (IbmdDB db = new IbmdDB())
                {

                    var result = db.Film.Where(p => p.FilmTuruID == id).ToList();
                    FilmKarti.DataSource = result;
                    FilmKarti.DataBind();
                }
            }
            else
            {
                FilmListeleme lst = new FilmListeleme();
                FilmKarti.DataSource = lst.YilaGoreSirala();
                FilmKarti.DataBind();
            }
        }
    }
}