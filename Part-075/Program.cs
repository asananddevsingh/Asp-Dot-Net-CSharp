using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_075
{
    /// <summary>
    /// Part 075 : List collection class in c# continued....
    /// </summary>
    class Program
    {
        /*
         * Functions in List.
         * 1. Contains() function: Checks if an item exists in the list. 
         *      This method returns true if item exists, else false.
         *      
         * 2. Exists() function: Checks if an item exists in the list based on a condition. 
         *      This method returns true if item exists else false.
         *      
         * 3. Find() function: Searches for an element that matches the conditions defined by the specified lambda expression
         *      and returns the first matching item from the list.
         *      
         * 4. FindLast() function: Searches for an element that matches the conditions defined by the specified lambda expression 
         *      and returns the Last matching item from the list.
         *      
         * 5. FindAll() function: Returns all the items from the list matches the conditions specified by the lambda expression.
         * 
         * 6. FindIndex() function: Returns the index of the item, that matches the condition specfied by the lambda expression. 
         *      There are 2 other overloads of this method which allows us to specify the range of the elements to search, with in the list.
         *      
         * 7. FindLastIndex() function: Returns the index of the items, that matches the condition specified by the lambda expression. 
         *      There are 2 other overloads of this method which allows us to specify the range of the elements to search, with in the list.
         *      
         * 8. ToList() function: Convert an array to a List.
         * 
         * 9. ToArray function: Convert a List to an Array.
         * 
         * 10. ToDictionary() function: Convert a List  to a Dictionary. 
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

            Console.WriteLine("Values in the list are:");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salry = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine();

            #region 1. Contains() method.
            if (listCustomers.Contains(customer3))
            {
                Console.WriteLine("List Contains() Customer 3 object.\n");
            }
            else
            {
                Console.WriteLine("List does NOT Contains() Customer 3 object.\n");
            }
            #endregion

            #region 2. Exists() method.
            if (listCustomers.Exists(cust => cust.Name.StartsWith("A")))
            {
                Console.WriteLine("Item Exists(), having Name starting with \"A\".\n");
            }
            else
            {
                Console.WriteLine("Item NOT Exists(), having Name starting with \"A\".\n");
            }
            #endregion

            #region 3. Find() method.
            Customer findCustomer = listCustomers.Find(cust => cust.Salary > 4000);
            Console.WriteLine("Find() method give us first object matching condition from list:\nID = {0}, Name = {1}, Salry = {2}", findCustomer.ID, findCustomer.Name, findCustomer.Salary);

            #endregion

            #region 4. FindLast() method.
            Customer findLastCustomer = listCustomers.FindLast(cust => cust.Salary > 4000);
            Console.WriteLine("\nFindLast() method give us last object matching condition from list:\nID = {0}, Name = {1}, Salry = {2}", findLastCustomer.ID, findLastCustomer.Name, findLastCustomer.Salary);
            #endregion

            #region 5. FindAll() method.
            Console.WriteLine("\nFindAll() method returns all the items from the list matches the conditions specified by the lambda expression.");
            List<Customer> listFindAllCustomers = listCustomers.FindAll(cust => cust.Salary > 4000);
            foreach (Customer c in listFindAllCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salry = {2}", c.ID, c.Name, c.Salary);
            }
            #endregion

            #region 6. FindIndex() method.
            int index = listCustomers.FindIndex(cust => cust.Salary > 4000);
            Console.WriteLine("\nFindIndex() method, Index = {0}", index);
            #endregion

            #region 7. FindLastIndex() method.
            int lastIndex = listCustomers.FindLastIndex(cust => cust.Salary > 4000);
            Console.WriteLine("\nFindLastIndex() method, Last Index = {0}",lastIndex);
            #endregion

            #region 8. Array to List conversion.
            Console.WriteLine("\nArray to List conversion:");
            Customer[] arrayCustomers = new Customer[3];
            arrayCustomers[0] = customer1;
            arrayCustomers[1] = customer2;
            arrayCustomers[2] = customer3;

            List<Customer> arrayToListCustomers = arrayCustomers.ToList();
            foreach (Customer c in arrayToListCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salry = {2}", c.ID, c.Name, c.Salary);
            } 
            #endregion

            #region 9. List to Array conversion
            Console.WriteLine("\nList to Array conversion:");
            Customer[] listToArray = listCustomers.ToArray();
            foreach (Customer c in listToArray)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salry = {2}", c.ID, c.Name, c.Salary);
            } 
            #endregion

            #region 10. List to Dictionary conversion.
            Console.WriteLine("\nList to Dictionary conversion:");
            Dictionary <int,Customer> listToDictonary = listCustomers.ToDictionary(cus => cus.ID);
            foreach (KeyValuePair<int, Customer> kvp in listToDictonary)
            {
                Customer c = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salry = {2}", c.ID, c.Name, c.Salary);
            }
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
}
