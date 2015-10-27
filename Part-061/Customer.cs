using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part_061
{
    public class Customer
    {
        private String _firstName;
        private String _lastName;

        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public String LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public String GetFullName()
        {
            return _firstName + ", " + _lastName;
        }

    }
}