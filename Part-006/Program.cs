using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_006
{
    /// <summary>
    /// Part 006: Nullable types and null coalescing variable.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // string is referance type and it can store null.
            String name = null;

            Console.WriteLine("String value have null value: {0}", name);

            // Value type can be divided in two types:
            // 1. Nullable.
            // 2. Non Nullable.
            //int i = null; We can't assign null to int type without making it nullable.

            #region 1. Nullable type
            Console.Write("Enter first name: ");
            String firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            String lastName = Console.ReadLine();

            Console.Write("Are you major ? Y/N: ");
            String major = Console.ReadLine();

            bool? isMajor = null;
            isMajor = major.ToLower() == "y" ? true : false;

            if (isMajor.Value == true)
            {
                Console.WriteLine("Welcome, {0} {1}. You are major.\n", firstName, lastName);
            }
            else if (!isMajor.Value == false)
            {
                Console.WriteLine("Welcome, {0} {1}. You are Not major.\n", firstName, lastName);
            }
            else
            {
                Console.WriteLine("Welcome, {0} {1}. You have not answerd about question.\n", firstName, lastName);
            }
            
            #endregion

            #region 2. Null coalescing operator
            
            int? tktOnSale = null;

            int availableTkt = tktOnSale ?? 0; // Since tkt on sale is null, it will assign available tkt value = 0;

            Console.WriteLine("Available tickets : {0}\n", availableTkt);
            Console.ReadKey();
            #endregion




        }
    }
}
