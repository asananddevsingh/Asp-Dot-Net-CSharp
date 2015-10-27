using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_045
{
    /// <summary>
    /// Part 045 : Why Enums
    /// </summary>
    class Program
    {
        /*
         * 1. Enums are storngly typed constants.
         * 2. If a program uses set of integral numbers, consider replacing them with Enums. Otherwise program become less Readable and Maintainable.
         */
        static void Main(string[] args)
        {

            Customer[] customers = new Customer[3];

            customers[0] = new Customer { Name = "Mark", Gender = 1 };
            customers[1] = new Customer { Name = "Mery", Gender = 2 };
            customers[2] = new Customer { Name = "Sam", Gender = 0 };

            #region Way 1 :: Print customers normally
            Console.WriteLine("Print customers normally:\n");
            foreach (Customer cust in customers)
            {
                Console.WriteLine("Name = {0} And Gender = {1}.", cust.Name, cust.Gender);
            }
            #endregion

            #region Way 2 :: Print customers with using function to convert gender value to words
            Console.WriteLine("\nPrint customers with using function to convert gender value to words:\n");
            foreach (Customer cust in customers)
            {
                Console.WriteLine("Name = {0} And Gender = {1}.", cust.Name, GetGender(cust.Gender));
            }
            #endregion
            Console.ReadKey();
        }

        private static String GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";                    
                case 1:
                    return "Male";                    
                case 2:
                    return "Female";                    
                default:
                    return "Invalid data detected.";
            }            
        }
    }

    public class Customer
    {
        public String Name { get; set; }

        // GENDER
        // 0 = Unknown
        // 1 = Male
        // 2 = Female
        public int Gender { get; set; }
    }
}
