using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_011
{
    /// <summary>
    /// Part 011: Switch and break statement.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number :");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 10:
                    Console.WriteLine("Your number is 10");
                    break;
                case 20:
                    Console.WriteLine("Your number is 20");
                    break;
                case 30:
                case 40:
                     Console.WriteLine("Your number is 30 OR 40");
                    break;
                case 50:
                    Console.WriteLine("Your number is 30");
                    break;

                default:
                    Console.WriteLine("Your number is NOT 10, 20, 30, 40 or 50.\n");
                    break;
            }
            Console.ReadKey();
        }
    }
}
