using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_072
{
    /// <summary>
    /// Part 072 : What is dictionary in c#.
    /// </summary>
    class Program
    {
        /*
         * 1. A dictionary is a collection of (key, value) pair.
         * 2. Dictionary class is present in System.Collection.Generic namespace.
         * 3. When creating a dictionary, we need to specify the type for key and value.
         * 4. Dictionary provides fast lookups for value using keys.
         * 5. Keys in the dictionary must be unique.
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

            foreach (KeyValuePair<int, Customer> custKeyValue in dCustomers)
            {
                Customer c = custKeyValue.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Sal = {2}", c.ID, c.Name, c.Salry);
                Console.WriteLine("*******************************************************");
            }

            Console.WriteLine("\nOnly values from dictonary....\n");
            foreach (Customer custValue in dCustomers.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Sal = {2}", custValue.ID, custValue.Name, custValue.Salry);
                Console.WriteLine("*******************************************************");
            }

            // Check if key exists in dictonary before adding new item in dictionary.
            Customer customer4 = new Customer() { ID = 104, Name = "Nanhi Dostu", Salry = 5000 };
            if (dCustomers.ContainsKey(customer4.ID))
            {
                dCustomers.Add(customer4.ID, customer4);
            }

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
