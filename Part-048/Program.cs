using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_048
{
    /// <summary>
    /// Part 048 : types and type members.
    /// </summary>
    class Program
    {
        /*
         * 1. In this example Customer is the Type and fields, Properties and method are type members.
         * 2. So, in general classes, structs, enums, interfaces, delegates are called as types and 
         *      fields, properties, constructors, methods etc, that normally reside in a type ar called as type members.
         * 3. In C# there are 5 different access modifiers:
         *  > Private
         *  > Protected
         *  > Internal
         *  > Protected Internal
         *  > Public
         * 
         * 4. Type members can have all the access modifiers, where as types can have only 2 (internal, public).
         * 
         * NOTE :: Using regions you can expand and collapse sections of code either manually or by Edit > Outlining > Toggle All Outlining.
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("In general classes, structs, enums, interfaces, delegates are called as types and fields, properties, constructors, methods etc, that normally reside in a type ar called as type members.");
            Console.WriteLine("\nType members can have all the access modifiers, where as types can have only 2 (internal, public).");

            Console.ReadKey();
        }
    }

    class Customer
    {
        #region Fields
        private int _id;
        private string _firstName;
        private string _lastName;

        #endregion

        #region Properties
        public int Id { get { return _id; } set { _id = value; } }
        public String FirstName { get { return _firstName; } set { _firstName = value; } }
        public String LastName { get { return _lastName; } set { _lastName = value; } }

        #endregion

        #region Methods
        public String GetFullName()
        {
            return String.Format("{0} {1}", this._firstName, this._lastName);
        }
        #endregion

    }
}
