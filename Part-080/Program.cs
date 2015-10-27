using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections.ObjectModel;

namespace Part_080
{
    /// <summary>
    /// Part 80 : Some useful methods of List collection class
    /// </summary>
    class Program
    {
        /*
         * 1. TrueForAll() - Returns true or false depending on whether if every element in the list matches the condition defined by the specified predicate.
         * 
         * 2. AsReadOnly() - Returns a read only wrapper for the current collection. Use this method, if you don't want the client to modify the collection.
         *      i.e add or remove any element from the collection. The ReadOnlyCollection will not have methods to add or remove items from the collection.
         *      You can only read items from the collection.
         *      
         * 3. TrimExcess() - Sets the capacity to the actual number of elements in the list, if that number is less than a threshold value.
         * 
         * According to MSDN:
         *      This method can be used to minimize a collection's memory overhead if no new wlement will be added to the collection. 
         *      The cost of reallocation and copying a large List<T> can be considrable. 
         *      So the TrimExcess() method does nothing if the list is at more than 90% of capacity.
         *      This avoids incurring a large reallocation cost for a relatively small gain. The current threshold s 90%, but this could change in the future.
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

            #region 1. TrueForAll() method.
            bool trueForAll = listCustomers.TrueForAll(x => x.Salary > 4000);
            Console.WriteLine("Are all salaries greater than 4000 = {0}", trueForAll);
            #endregion

            #region 2. AsReadOnly() method.
            ReadOnlyCollection<Customer> listReadOnlyCustomers = listCustomers.AsReadOnly();
            Console.WriteLine("Number of items = " + listReadOnlyCustomers.Count);
            #endregion

            #region 3. TrimExcess() method.
            List<Customer> listTrimCstomers = new List<Customer>(100);
            listTrimCstomers.AddRange(listCustomers);
            Console.WriteLine("\nCapacity before trim = " + listTrimCstomers.Capacity);

            listTrimCstomers.TrimExcess();
            Console.WriteLine("Capacity after trim = " + listTrimCstomers.Capacity); 
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
