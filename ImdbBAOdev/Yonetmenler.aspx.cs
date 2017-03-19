using ImdbBAOdev.Controller;
using ImdbBAOdev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImdbBAOdev
{
    public partial class Yonetmenler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (IbmdDB db = new IbmdDB())
            {

                var result = db.Yonetmen.ToList();
                Repeater1.DataSource = result;
                Repeater1.DataBind();
            }
           
        }
    }
}