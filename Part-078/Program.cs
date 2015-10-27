using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_078
{
    /// <summary>
    /// Part 078 : Sort a list of complex types in c#.
    /// </summary>
    class Program
    {
        /*
         * To sort a list of complex types without using LINQ, the complex types has to implement IComparable interface annd provide implementation for CompareTo() method.
         * CompareTo() method returns an integer, and the meaning of the return value is shown below. 
         * :: Return values are ::
         *      a. Greater than ZERO ( > 0 ): The current instance is greater than the object being compared with.
         *      b. Less than ZERO ( < 0 )   : The current instance is less than the object being compared with.
         *      c. ZERO ( = 0 )             : The current instance is equals than the object being compared with.
         *      
         * Alternatively you can also invoke Compareto() method: 
         *      Salary property of the Customer object is int. CompareTo() method is already implemented on integer type, so we can invoke this method and return it's value.
         *      
         * If you prefer not to use the sort functionality provided by the class, then you can provide your ouw,
         *      by implementing IComarer interface.
         *      Ex. if i want the customers to sorted by name insted of salary.
         *          Step 1: Implement IComparer interface.
         *          Step 2: Pass an instance of the class that implements IComparer nterface, as an argument to the Sort() method.
         */
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { ID = 101, Name = "Anand Dev", Salary = 4000 };
            Customer customer2 = new Customer() { ID = 102, Name = "Nanhi", Salary = 8000 };
            Customer customer3 = new Customer() { ID = 103, Name = "Praveen", Salary = 6000 };
            Customer customer4 = new Customer() { ID = 104, Name = "Uttam", Salary = 5000 };
            Customer customer5 = new Customer() { ID = 105, Name = "Anoop", Salary = 3000 };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);
            listCustomers.Add(customer4);
            listCustomers.Add(customer5);

            Console.WriteLine("Before sorting.");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("Name = {0}, Salary = {1}.", c.Name, c.Salary);
            }

            #region 1. By default Sort() the list by Salary.
            listCustomers.Sort();
            // listCustomers.Reverse(); // This will reverse the elements.
            Console.WriteLine("\nAfter sorting by salary ASC.");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("Name = {0}, Salary = {1}.", c.Name, c.Salary);
            } 
            #endregion

            #region 2. Sort the list by Name by implementing Compare method of IComparer class.
            SortByName sortByName = new SortByName();

            listCustomers.Sort(sortByName);
            Console.WriteLine("\nAfter sorting by Name ASC.");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("Name = {0}, Salary = {1}.", c.Name, c.Salary);
            } 
            #endregion            
        }
    }

    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }

        // Sort by salary will be the default for this class, so if we want to sort it by name then we need to change the code for name. 
        // Or good to use IComparer over iComparable.
        public int CompareTo(Customer otherObject)
        {
            // We are commenting this code because salary is of int type and int has already implemented CompareTo method
            /*if (this.Salary > otherObject.Salary)
                return 1;
            else if (this.Salary < otherObject.Salary)
                return -1;
            else
                return 0;
            */

            // Salary property of the Customer object is int. CompareTo() method is already implemented on integer type, so we can invoke this method and return it's value.
            return this.Salary.CompareTo(otherObject.Salary);            
        }
    }

    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
