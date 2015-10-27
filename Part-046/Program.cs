using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_046
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer { Name = "Mark", Gender = Gender.Male };
            customers[1] = new Customer { Name = "Mery", Gender = Gender.Female };
            customers[2] = new Customer { Name = "Sam", Gender = Gender.Unknown};

            foreach (Customer cust in customers)
            {
                Console.WriteLine("Name = {0} And Gender = {1}.", cust.Name, cust.Gender);
            }
            
            Console.ReadKey();

        }        
    }

    public class Customer
    {
        public String Name { get; set; }        
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

}
