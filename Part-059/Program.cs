using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_059
{
    /// <summary>
    /// Part 059 : Difference between Convert.ToString() and .ToString() methods.
    /// </summary>
    class Program
    {
        /*
         * 1. Convert.ToString() handles null, while .ToString() doesn't and throws a NULL Reference exception.
         * 2. Depending on type of application, architecture and what you are trying to achieve, you choose one over the other.
         */
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            String str = c1.ToString();
            Console.WriteLine(str);

            Customer c2 = null;
            String nullString = Convert.ToString(c2);
            Console.WriteLine("Return empty string if object is null = {0}",nullString);

            Console.ReadKey();


        }
    }

    class Customer
    {
        public String Name { get; set; }
    }
}
