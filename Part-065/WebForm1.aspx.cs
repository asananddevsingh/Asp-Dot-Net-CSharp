using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_065
{
    /// <summary>
    /// Part 064 : Indexer in c#. 
    /// </summary>
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();

            #region Getting details by using indexer.

            Response.Write("Name of Employee with ID 2 = " + company[2]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with ID 1 = " + company[1]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with ID 4 = " + company[4]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with ID 3 = " + company[3]);
            Response.Write("<br/>");
            #endregion

            #region Setting detail by using indexer.

            Response.Write("Changing name of employee with iD = 2, 4");
            Response.Write("<br/>");
            company[2] = "2nd employee name changed";
            company[4] = "4nd employee name changed";

            #endregion

            #region Again getting details after changing the names.
            Response.Write("Name of Employee with ID 2 = " + company[2]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with ID 1 = " + company[1]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with ID 4 = " + company[4]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with ID 3 = " + company[3]);
            Response.Write("<br/>"); 
            #endregion
        }
    }
}