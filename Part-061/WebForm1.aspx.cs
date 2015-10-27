using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_061
{
    /// <summary>
    /// Part 061 : Partial classes in c#.
    /// </summary>
    public partial class WebForm1 : System.Web.UI.Page
    {
        /*
         * 1. Partial class allow us to split a class into 2 or more files. 
         *      All parts are then combined into a single class, when apllication is compiled.
         * 2. The partial keyword can also be used to aplit a struct or an interface over two or more files.
         * 
         * 3. Advantages of partial classess ::
         * 
         *  > The main advantage is that, visual studio uses partial classess to separate automatically generated code from developers code.
         *      For Example :: when you add a webfoem, two .cs files are generated
         *          A. WebForm1.aspx.cs - Containes the developer code.
         *          B. WebForm1.aspx.designer.cs - Contains the system enerated code. 
         *          Example: declarations for the controls that you drag and drop on the webform.
         *          
         *   > When working on large projects, Spreding a class over separate files allows multiple programmers to work on it simultaniously.
         *   Though microsoft claims this as an advantage. I haven't really seen anywhere, people using partial classes, just to work on them simultaniously.
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            #region 1. Code from single file, Customer.cs.
            
            Customer c1 = new Customer();
            c1.FirstName = "Anand Dev";
            c1.LastName = "Singh";
            String fullName = c1.GetFullName();
            Response.Write(String.Format("{0}<br/>", fullName));

            #endregion

            #region 2. Code from PartialClassOne.cs and PartialClassTwo.cs, two seperate files.
            
            PartialCustomer pc = new PartialCustomer();
            pc.FirstName = "Nanhi";
            pc.LastName = "Malhotra";

            String dostuName = pc.GetFullName();
            Response.Write(String.Format("{0}<br/>", dostuName));

            #endregion            

        }
    }
}