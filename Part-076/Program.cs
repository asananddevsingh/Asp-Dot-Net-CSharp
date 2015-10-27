using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_076
{
    /// <summary>
    /// Part 076 : Working with generic list class and ranges.
    /// </summary>
    class Program
    {
        /*
         * 1. AddRange(): Add() method allows you to add one item at a time to the end of the list.
         *      where as AddRange() allows you to add another list of items, to the end of the list.
         *      
         * 2. GetRange(): Using an item index, we can retrieve only one item at a time from the list, if you want to get a list of items from the list.
         *      Then use GetRange() function. This function expects 2 parameters, i.e the start index in the list and the number of elements to return.
         *      
         * 3. InsertRange(): Insert() method allows you to insert a single item into the list at a specified index. 
         *      Where as InsertRange() allows you to, insert another list of items to your llist at the specified index.
         *      
         * 4. RemoveRange(): Remove() function removes only the first matching item from the list. 
         *      RemoveAt() function, removes the items at specified index in list.
         *      RemoveAll() function, removes all the items that matches the specified condition.
         *      RemoveRange() function, removes a range of elements from the list. This function expects 2 parameters. 
         *      i.e the start index in the list and the number of elements to remove. 
         *      If you want to remove all the elements from the list without specifying any condition, then use Clear() function.
         *      
         */
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { ID = 101, Name = "Anand Dev", Salary=4000, Type = "Corporate" };
            Customer customer2 = new Customer() { ID = 102, Name = "Nanhi", Salary = 6000, Type = "Corporate" };
            Customer customer3 = new Customer() { ID = 103, Name = "Praveen", Salary = 7000, Type = "Retail" };
            Customer customer4 = new Customer() { ID = 104, Name = "Uttam", Salary = 8000, Type = "Retail" };
            Customer customer5 = new Customer() { ID = 105, Name = "Anoop", Salary = 9000, Type = "Retail" };

            List<Customer> listCorporateCustomer = new List<Customer>();
            listCorporateCustomer.Add(customer1);
            listCorporateCustomer.Add(customer2);

            List<Customer> listRetailCustomer = new List<Customer>();
            listRetailCustomer.Add(customer3);
            listRetailCustomer.Add(customer4);
            listRetailCustomer.Add(customer5);

            #region 1. AddRange() method.
            List<Customer> listCustomers = new List<Customer>();
            listCustomers.AddRange(listCorporateCustomer);
            listCustomers.AddRange(listRetailCustomer);

            Console.WriteLine("AddRane() method.");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            } 
            #endregion

            #region 2. GetRange() method.
            List<Customer> listGetCustomers = listCustomers.GetRange(0, 2);
            Console.WriteLine("\nGetRange() method, to get only corporate customers");
            foreach (Customer c in listGetCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            } 
            #endregion 

            #region 3. InsertRange() method.
            listCorporateCustomer.InsertRange(0, listRetailCustomer);
            Console.WriteLine("\nInsertRange() method, to insert retail customers from zero index.");
            foreach (Customer c in listCorporateCustomer)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            } 
            #endregion

            #region 4. Remove() method.
            listCustomers.Remove(customer1);
            Console.WriteLine("\nRemove() method.");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            } 
            #endregion

            #region 5. RemoveAt() method.
            listCustomers.RemoveAt(3);
            Console.WriteLine("\nRemoveAt() method.");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            }
            #endregion

            #region 6. RemoveAll() method.
            listCustomers.RemoveAll(R => R.Type == "Corporate");
            Console.WriteLine("\nRemoveAll() method.");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            } 
            #endregion

            #region 7. RemoveRange() method.
            listCustomers.RemoveRange(0, 1);
            Console.WriteLine("\nRemoveRange() method.");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
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
        public String Type { get; set; }
    }
}
