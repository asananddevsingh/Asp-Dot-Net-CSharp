using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_012
{
    /// <summary>
    /// Part 012: Switch, break and goto statement.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int totalCost = 0;
            Start: // This is called as label.
            Console.WriteLine("Choose your coffee: 1-Small, 2-Medium, 3-Large.");

            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    totalCost += 1;
                    break;
                case 2:
                    totalCost += 2;
                    break;
                case 3:
                    totalCost += 3;
                    break;
                case 4:
                    goto default; // We can goto any case as well.
                default:
                    Console.WriteLine("Please correct you choice, {0}", userChoice);
                    goto Start;
            }

            Decide:
            Console.WriteLine("You want more ? Y/N");
            String userDecision = Console.ReadLine().ToLower();

            switch (userDecision)
            {
                case "y":
                    goto Start;
                case "n":
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice again");
                    goto Decide;                    
            }

            Console.WriteLine("Thanks for shopping, Your bill amount is {0}", totalCost);
            Console.ReadKey(); ;
        }
    }
}
