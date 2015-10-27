using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Part_062
{
    /// <summary>
    /// Part 062 : Creating partial classess in c#.
    /// </summary>
    public partial class WebForm1 : System.Web.UI.Page
    {
        /*
         * 1. All the parts spread across different files, must use the "Partial Keyword".
         * 2. All the parts spread across different files, must have the "Same Access Modifiers".
         * 3. If any of the parts are declared abstract, then "the entire type is considered abstract".
         * 4. If any of the parts are declared sealed, then "the entire type is considered sealed".
         * 5. If any of the parts inherits a class, then "the entire type inherits that class".
         * 6. C# does not support multiple class inheritance. Different parts of the partial class, must not specify "Different base classess".
         * 7. Different parts of the partial class can specify defferent base interface, and the 
         *      "final type implements all of the interface listed by all of the partial declarations".
         * 8. Any members that are declared in a partial defination are "available to all of the other parts of the partial class".
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder pointOfPartialClass = new StringBuilder();
            pointOfPartialClass.Append("* 1. All the parts spread across different files, must use the 'Partial Keyword'.<br/>");
            pointOfPartialClass.Append("* 2. All the parts spread across different files, must have the 'Same Access Modifiers'.<br/>");
            pointOfPartialClass.Append("* 3. If any of the parts are declared abstract, then 'the entire type is considered abstract'.<br/>");
            pointOfPartialClass.Append("* 4. If any of the parts are declared sealed, then 'the entire type is considered sealed'.<br/>");
            pointOfPartialClass.Append("* 5. If any of the parts inherits a class, then 'the entire type inherits that class'.<br/>");
            pointOfPartialClass.Append("* 6. C# does not support multiple class inheritance. Different parts of the partial class, must not specify 'Different base classes'.<br/>");
            pointOfPartialClass.Append("* 7. Different parts of the partial class can specify defferent base interface, and the 'final type implements all of the interface listed by all of the partial declarations'.<br/>");
            pointOfPartialClass.Append("* 8. Any members that are declared in a partial defination are 'available to all of the other parts of the partial class'.<br/>");
            Response.Write(pointOfPartialClass);

        }
    }
}