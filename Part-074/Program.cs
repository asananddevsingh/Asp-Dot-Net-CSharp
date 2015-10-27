using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_074
{
    /// <summary>
    /// Part 074 : List collection class in c#
    /// </summary>
    class Program
    {
        /*
         * 1. List is one of the generic collection classes present in System.Collections.Generic namespace.
         * 2. There are several generic collection classess are:
         *      a. Dictionary.
         *      b. List.
         *      c. Stack.
         *      d. Queue etc.
         *      
         * 3. A list class can be used to create a collection of any type.
         *      Ex. we can create a list of integers, strings and even complex types such as class.
         * 4. The objects stored in the list can be accessed by index.
         * 5. Unlike arrays, lists can grow in size automatically.
         * 6. This class also provides methods to search, sort and manipulate lists.
         * 
         */
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { ID = 101, Name = "Anand Dev", Salary = 4000 };
            Customer customer2 = new Customer() { ID = 102, Name = "Praveen", Salary = 5000 };
            Customer customer3 = new Customer() { ID = 103, Name = "Uttam", Salary = 8000 };

            List<Customer> listCustomers = new List<Customer>(2);
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);            

            #region 1. Fetch values from list using index.
            Console.WriteLine("Fetch values from list using index:");
            Customer cust = listCustomers[0];
            Console.WriteLine("ID = {0}, Name = {1}, Salry = {2}", cust.ID, cust.Name, cust.Salary);

            #endregion

            #region 2. Fetch values from list using foreach loop.
            Console.WriteLine("\nFetch values from list using foreach loop:");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salry = {2}", c.ID, c.Name, c.Salary);
            } 
            #endregion

            #region 3. Lists are stronly typed, it can add object of defined list type or type derived from defined types. Ex. "SavingsCustomer"            
            SavingsCustomer sc = new SavingsCustomer() { ID= 104, Name =  "Nanhi", Salary = 6000 };
            listCustomers.Add(sc);
            Console.WriteLine("\nWe can add derived type of object of defined type of list:");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salry = {2}", c.ID, c.Name, c.Salary);
            }            

            #endregion

            #region 4. Insert method in List
            listCustomers.Insert(1,sc);
            Console.WriteLine("\nWe have inserted ID = 104 at 1st index as well:");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salry = {2}", c.ID, c.Name, c.Salary);
            } 
            #endregion

            #region 5. IndexOf() method, There are several overloaded versions
            Console.WriteLine("\nIndex of any item from List:");
            int defaultindex = listCustomers.IndexOf(sc);
            Console.WriteLine("Default index searched object = {0}, for ID = 104, it will give the first index where it will be found.", defaultindex);

            int specificIndex = listCustomers.IndexOf(sc,2);
            Console.WriteLine("Specific index of object = {0}, for ID = 104.", specificIndex);
            
            #endregion
 
            Console.ReadKey();
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }
    }

    public class SavingsCustomer : Customer
    {

    }
}
