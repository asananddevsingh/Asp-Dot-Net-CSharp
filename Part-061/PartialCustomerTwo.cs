using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part_061
{
    public partial class PartialCustomer
    {        
        public String GetFullName()
        {
            return _firstName + ", " + _lastName;
        }
    }
}