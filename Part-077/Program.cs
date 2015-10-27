using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_077
{
    /// <summary>
    /// Part 077 : Sort a list of simple types in c.
    /// </summary>
    class Program
    {
        /*
         * Q. What are the simple types in the C#
         * A. int, string, char, decimal, double etc are simple types in c#.
         * 
         * 1. Sorting a list of simple type like int, string, char etc is straight forward. 
         *      Just invoke the sort() method on the list instance and the data will be automatically sorted in the  ascending order.
         *      
         * 2. If you want the data to be retrived in descending order, use Reverse() method on the list instance.
         * 
         * 3. However, when you do the same thing on a complex type like Customer, we get a invalid operation exception - Failed to compare 2 elements in the array at runtime.
         * This is because .NET runtime doesnot know to sort complex types. 
         *      We have to tell the way we want the data to be sorted in the list by implementing ICompareable interface.
         *      
         * 4. How is the sort functionality working for siple types like int, string char etc. ?
         *      That is because these types (int, string, char etc) have implemented IComparable interface already.
         */

        static void Main(string[] args)
        {
            #region 1. Sorting at int type.
            List<int> numbers = new List<int>() { 1, 9, 8, 2, 4, 3, 5, 6, 7 };

            Console.WriteLine("Numbers before soting:");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            numbers.Sort(); ;

            Console.WriteLine("\nNumbers after soting:");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            numbers.Reverse();

            Console.WriteLine("\nNumbers reversed:");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            } 
            #endregion

            #region 2. Sorting at String type.
            List<String> alphabets = new List<String>() { "D", "S", "N", "A", "G", "R" };

            Console.WriteLine("Alphabets before soting:");
            foreach (String n in alphabets)
            {
                Console.WriteLine(n);
            }

            alphabets.Sort(); ;

            Console.WriteLine("\nAlphabets after soting:");
            foreach (String n in alphabets)
            {
                Console.WriteLine(n);
            }

            alphabets.Reverse();

            Console.WriteLine("\nAlphabets reversed:");
            foreach (String n in alphabets)
            {
                Console.WriteLine(n);
            } 
            #endregion

            Console.ReadKey();
        }
    }
}
