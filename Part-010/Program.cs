using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_010
{
    /// <summary>
    /// Part 010: if-else statement.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number :");
            int num;
            bool isNumber = int.TryParse(Console.ReadLine(), out num);
            if (isNumber)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("{0} is even number.\n", num);
                }
                else
                {
                    Console.WriteLine("{0} is odd number.\n", num);
                }
            }
            else
            {
                Console.WriteLine("Please enter valid number.\n", num);
            }
            
            

            Console.ReadKey();
        }
    }
}
