using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_085
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Session["BackButtonClicked"] = "YES";
            if (Session["URLStack"] != null)
            {
                Stack<string> urlStack = (Stack<string>)Session["URLStack"];
                if (urlStack.Count > 0)
                {
                    string url = urlStack.Pop();
                    Response.Redirect(url);
                }
                else
                {
                    lblMessage.Text = "There is no page in history.";
                }
            }
        }
    }
}