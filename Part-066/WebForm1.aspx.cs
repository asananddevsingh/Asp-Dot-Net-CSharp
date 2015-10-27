using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_066
{
    /// <summary>
    /// Part 065 : Overloading indexers in C#.
    /// </summary>
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();

            Response.Write("Before update <br/>");
            Response.Write("Total male employee = " + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Female employee = " + company["Female"]);

            company["Male"] = "Female";

            Response.Write("<br/><br/>Aftre update <br/>");
            Response.Write("Total male employee = " + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Female employee = " + company["Female"]);
        }
    }
}