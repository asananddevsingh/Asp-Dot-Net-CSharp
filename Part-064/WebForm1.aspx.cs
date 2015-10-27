using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_064
{
    /// <summary>
    /// Part 064 : How and where are indexers used in .Net framework.
    /// </summary>
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* 
             * 1. Session is using two indexers.
             * 2. Go to defintaion of Session, Then go to defination of HttpSessionState, there you will get two indexers.
             *      A. public object this[int index] { get; set; }
             *      B. public object this[string name] { get; set; }
             */
            Session["Session1"] = "Session 1 data";
            Session["Session2"] = "Session 2 data";

            // Retrieve value using session index.
            Response.Write("Session one = " + Session[0] + "<br/>");

            // Retrieve value using session key.
            Response.Write("Session two = " + Session["Session2"]);


        }
    }
}