using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_069
{
    /// <summary>
    /// Part 069 : Making method parameters optional by specifying parameter defaults
    /// </summary>
    class Program
    {
        /*
        * There are 4 ways to make method parameters optional.
        * 1. Use parameters arrays, (params key word and it must be the last parameter in the parameters list.).
        * 2. By Method overloading.
        * 3. Specify parameter defaults.
        * 4. Use OptionalAttribute that is present in System.Runtime.InteropServices namespace.
        */
        static void Main(string[] args)
        {
            // Optional parameters in Print Method
            Console.WriteLine("\nWithout passing optional parameters.");
            Print(1);

            Console.WriteLine("\nPassing b as optional parameters.");
            Print(1, 200);

            Console.WriteLine("\nPassing c as optional parameters, this is called as passing named parameter.");
            Print(1,c:100);

            Console.ReadKey();
        }

        #region 3. Making method parameters optional by specifying parameter defaults

        public static void Print(int a, int b = 4, int c = 8)
        {
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("c = {0}", c);
        }

        #endregion
    }
}
