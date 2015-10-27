using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_051
{
    /// <summary>
    /// Part 051 : Access Modifiers for types
    /// </summary>
    class Program
    {
        /*
         * Elements defined in a namespace cannot be explicitly declared as private, protected, or protected internal.
         * by default types have internal access modifier where as type members are private.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Elements defined in a namespace cannot be explicitly declared as private, protected, or protected internal.By default types have internal access modifier where as type members are private.");
            Console.ReadKey();
        }
    }
}
