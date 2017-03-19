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
    public partial class Aktorler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                AktorIslemleri ak = new AktorIslemleri();
                Repeater1.DataSource = ak.EnGencAktor();
                Repeater1.DataBind();
           
        }
    }
}