using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_057
{
    /// <summary>
    /// Part 057 : Why should you override ToString Method
    /// </summary>
    class Program
    {
        /*
         * The default implementation of .ToString() method provided by System.Object class 
         *      will give you the complete name of the type including the namespace. 
         */
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.FirstName = "Anand Dev";
            c1.LastName = "Singh";
            Console.WriteLine("Without override .ToString() method -> {0}",c1.ToString()); // It will print complete name of the type including the namespace.

            CustomerWithOverriddenToString c2 = new CustomerWithOverriddenToString();
            c2.FirstName = "Anand Dev";
            c2.LastName = "Singh";
            Console.WriteLine("\nAfter override .ToString() method -> {0}",c2.ToString());

            Console.ReadKey();
        }
    }

    class Customer
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }        
    }

    class CustomerWithOverriddenToString
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1}", LastName, FirstName);
        }
    }


}
