using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_079
{
    /// <summary>
    /// Part 79 : Sort a list of complex types using Comparison delegate.
    /// </summary>
    class Program
    {
        /*
         * 1. One of the overload of the sort() method in list class expects Comparision delegate to be passes as an argument.
         * 
         * 2. Approach 1.
         *      Step 1: Create a fnction whose signature mathches the signature of System.Comparison delegate. 
         *          Comparison() is the method we need to write logic to compare 2 customer objects.
         *      Step 2: Create an instance of System.Comparision delegate and then pass the name of the function created in Step 1 as the argument.
         *          So, at this point "Comparison" delegate is pointing to our function that contains the logic to compare 2 customer objects.
         *      Step 3: Pass the delegate instance as an argument, to Sort() function.
         *      
         * 3. Approach 2.
         *      All the steps in approach 1 can be replaced by simply writing delegate keyword and logic in Sort() function.
         *      
         * 4. Approach 3.
         *      By using lamda expression.
         */
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { ID = 101, Name = "Anand Dev", Salary = 4000 };
            Customer customer2 = new Customer() { ID = 102, Name = "Nanhi", Salary = 8000 };
            Customer customer3 = new Customer() { ID = 103, Name = "Praveen", Salary = 6000 };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer3);
            listCustomers.Add(customer2);

            Console.WriteLine("Before sorting.");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}.", c.ID, c.Name);
            }

            #region 1. Approach 1 - Step 2 and 3.
            // Step 2.
            Comparison<Customer> customerComparer = new Comparison<Customer>(Comparison);

            // Step 3.
            listCustomers.Sort(customerComparer);

            Console.WriteLine("\nAfter sorting by ID ASC using Comparison delegate - Approach 1");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}.", c.ID, c.Name);
            }
            #endregion

            #region 2. Approach 2 - By implemention delegate directly in Sort() function.

            Customer customer4 = new Customer() { ID = 104, Name = "Jam", Salary = 4000 };
            Customer customer5 = new Customer() { ID = 105, Name = "Mark", Salary = 8000 };
            Customer customer6 = new Customer() { ID = 106, Name = "Odi", Salary = 6000 };

            List<Customer> listCustomers2 = new List<Customer>();
            listCustomers2.Add(customer6);
            listCustomers2.Add(customer4);
            listCustomers2.Add(customer5);

            Console.WriteLine("\nBefore sorting.");
            foreach (Customer c in listCustomers2)
            {
                Console.WriteLine("ID = {0}, Name = {1}.", c.ID, c.Name);
            }

            Console.WriteLine("Second way.");
            listCustomers2.Sort(delegate(Customer c1, Customer c2) { return c1.ID.CompareTo(c2.ID); });
            Console.WriteLine("\nAfter sorting by ID ASC using Comparison delegate - Approach 2");
            foreach (Customer c in listCustomers2)
            {
                Console.WriteLine("ID = {0}, Name = {1}.", c.ID, c.Name);
            }
            #endregion

            #region 3. Approach 3 - By using lamda expression.
            List<Customer> listAllCustomers = new List<Customer>();
            listAllCustomers.AddRange(listCustomers);
            listAllCustomers.AddRange(listCustomers2);

            Console.WriteLine("\nBefore sorting.");
            foreach (Customer c in listAllCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}.", c.ID, c.Name);
            }

            listAllCustomers.Sort((x, y) => x.ID.CompareTo(y.ID));

            Console.WriteLine("\nAfter sorting using lamda expression - Approach 3.");
            foreach (Customer c in listAllCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}.", c.ID, c.Name);
            }
            #endregion

            Console.ReadKey();
        }

        #region 1. Approach 1 - Step 1 - Providing implementation to Comparision method.
        // Step 1.
        private static int Comparison(Customer x, Customer y)
        {
            return x.ID.CompareTo(y.ID);
        }
        #endregion
    }

    public class Customer
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }
    }
}
