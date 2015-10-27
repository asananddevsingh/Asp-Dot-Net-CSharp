using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part_085
{
    /// <summary>
    /// Part 85 : Real time example of stack collection class in c
    /// </summary>
    public class BasePage : System.Web.UI.Page
    {
        protected override void OnLoad(EventArgs e)
        {
            if (Session["URLStack"] == null)
            {
                Stack<string> urlStack = new Stack<string>();
                Session["URLStack"] = urlStack;
            }
            if (Request.UrlReferrer != null && !this.Page.IsPostBack && Session["BackButtonClicked"] == null)
            {
                Stack<string> urlStack = (Stack<string>)Session["URLStack"];
                urlStack.Push(Request.UrlReferrer.AbsoluteUri);
            }

            if (Session["BackButtonClicked"] != null)
            {
                Session["BackButtonClicked"] = null;
            }

        }
    }
}