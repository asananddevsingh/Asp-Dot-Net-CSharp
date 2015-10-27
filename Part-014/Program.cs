using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_014
{
    /// <summary>
    /// Part 014: do while loop.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // A do loop checks its condition at the end of loop. 
            // This means that the loop is gauranteed to execute at least once.
            // do loops are used to present a menu to the user.
            String userChoice = String.Empty;
            do
            {
                Console.Write("Enter your target > 0 : ");
                int userTarget = int.Parse(Console.ReadLine());

                int start = 0;

                while (start <= userTarget)
                {
                    Console.Write("{0} ", start);
                    start = start + 2;
                }

                do
                {
                    Console.Write("\nDo you want to continue ? Y/N: ");
                    userChoice = Console.ReadLine().ToUpper();

                    if (userChoice != "Y" && userChoice != "N")
                    {
                        Console.Write("Please enter a valid choice.");
                    }

                } while (userChoice != "Y" && userChoice != "N");
            }
            while (userChoice == "Y");
        }
    }
}
