using ImdbBAOdev.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImdbBAOdev
{
    public partial class Turler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            turler ak = new turler();
            Repeater1.DataSource = ak.Hepsi();
            Repeater1.DataBind();
        }
    }
}