using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_002
{
    /// <summary>
    /// Part 002: Reading and writing to console.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            String yourName = Console.ReadLine();

            // String.Format("{0}") syntax is called as placeholder syntaX.
            Console.WriteLine(String.Format("\nWelcome, {0}.", yourName)); // \n is used to break the line.
            Console.ReadKey();
        }
    }
}
