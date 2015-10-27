using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_073
{
    /// <summary>
    /// Part 073 : What is dictionary in c continued....
    /// </summary>
    class Program
    {
        /*
         * 1. A dictionary is a collection of (key, value) pair.
         * 2. Dictionary class is present in System.Collection.Generic namespace.
         * 3. When creating a dictionary, we need to specify the type for key and value.
         * 4. Dictionary provides fast lookups for value using keys.
         * 5. Keys in the dictionary must be unique.
         * 
         * 6. In this chapter, we will learn the fllowing methods of dictonary class.
         *      a. TryGetValue()
         *      b. Count()
         *      c. Remove()
         *      d. Clear()
         *      e. Using LINQ extension methods with Dictonary.
         *      f. Different ways to convert an Array or List into a dictonary.
         */
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { ID = 101, Name = "Anand Dev", Salry = 4000 };
            Customer customer2 = new Customer() { ID = 102, Name = "Praveen", Salry = 5000 };
            Customer customer3 = new Customer() { ID = 103, Name = "Uttam", Salry = 8000 };

            Dictionary<int, Customer> dCustomers = new Dictionary<int, Customer>();
            dCustomers.Add(customer1.ID, customer1);
            dCustomers.Add(customer2.ID, customer2);
            dCustomers.Add(customer3.ID, customer3);

            #region a. TryGetValue() method.
            Customer cust1 = new Customer();
            if (dCustomers.TryGetValue(101, out cust1))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Sal = {2}", cust1.ID, cust1.Name, cust1.Salry);
            }
            else
            {
                Console.WriteLine("Key not found");
            }
            #endregion

            #region b. Count() method.// Count is Linq extension method present in System.Linq namespace.
            int custCount = dCustomers.Count();
            Console.WriteLine("\nTotal number of items in dictionary are = {0}", custCount);

            int custCount2 = dCustomers.Count(kvp => kvp.Value.Salry > 5000);
            Console.WriteLine("\nCustomers having salary > 5000 = {0}", custCount2);

            #endregion

            #region c. Remove() method.
            dCustomers.Remove(102);
            Console.WriteLine("\nAfter removing one item");
            foreach (KeyValuePair<int, Customer> custKeyValue in dCustomers)
            {
                Customer c = custKeyValue.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Sal = {2}", c.ID, c.Name, c.Salry);
                Console.WriteLine("*******************************************************");
            }
            #endregion

            #region d. Clear() method
            dCustomers.Clear();
            Console.WriteLine("\nNo item will be found after clear() of dictionary.");
            foreach (KeyValuePair<int, Customer> custKeyValue in dCustomers)
            {
                Customer c = custKeyValue.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Sal = {2}", c.ID, c.Name, c.Salry);
                Console.WriteLine("*******************************************************");
            }
            #endregion

            #region e. Convert Array to Dictionary.
            Customer[] customers = new Customer[3];
            customers[0] = customer1;
            customers[1] = customer2;
            customers[2] = customer3;

            Dictionary<int, Customer> dicCustomers = customers.ToDictionary(c => c.ID, c => c);

            Console.WriteLine("\nConvert Array to Dictionary.");
            foreach (KeyValuePair<int, Customer> kvp in dicCustomers)
            {
                Customer c = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Sal = {2}", c.ID, c.Name, c.Salry);
                Console.WriteLine("*******************************************************");
            } 

            #endregion

            #region f. Convert List to Dictionary
            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Dictionary<int, Customer> dicListCustomers = listCustomers.ToDictionary(c => c.ID, c => c);

            Console.WriteLine("\nConvert List to Dictionary.");
            foreach (KeyValuePair<int, Customer> kvp in dicListCustomers)
            {
                Customer c = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Sal = {2}", c.ID, c.Name, c.Salry);
                Console.WriteLine("*******************************************************");
            } 
            #endregion 

            Console.ReadKey();
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Salry { get; set; }
    }
}
