using System;
using System.Collections.Generic;

namespace Part_082
{
    /// <summary>
    /// Part 82 : Generic queue collection class.
    /// </summary>
    class Program
    {
        /*
         * 1. Queue is a generic FIFO (First In First Out) collection class that is present in System.Collections.Generic namespace.
         *      The Queue collection class is analogous to Queue at an ATM machine to withdraw money. 
         *      The order in which people Queue up, will be the order in which they will be able to get out of the Queue and withdraw money.
         *      The Queue collection class operates in a similar fashion. The first item to be added (enqueued) to the Queue, 
         *      will be the first item to be removed (dequeueued) from the Queue.
         *      
         * 2. To add items to the end of the Queue, use Enqueue() method.
         * 
         * 3. To remove an item that is present at the beginning of the Queue, use Dequeue() method.
         * 
         * 4. A foreach loop iterates thru the item in the Queue, but will not remove them from the Queue.
         * 
         * 5. To check if an item in the Queue, use Contains() method.
         * 
         * 6. What is the difference between Dequeue() and Peek() methods?
         *      Dequeue() method removes and returns the item at the beginning of the Queue, 
         *      where as Peek() returns the item at the beginning of the Queue without removing it. 
         */
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { ID = 101, Name = "Anand Dev", Gender = "Male" };
            Customer customer2 = new Customer() { ID = 102, Name = "Praveen", Gender = "Male" };
            Customer customer3 = new Customer() { ID = 103, Name = "Sandhya", Gender = "Female" };
            Customer customer4 = new Customer() { ID = 104, Name = "Nanhi", Gender = "Female" };
            Customer customer5 = new Customer() { ID = 105, Name = "Uttam", Gender = "Male" };

            #region 1. Enqueue() method.
            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            foreach (Customer c in queueCustomers)
            {
                Console.WriteLine("Item in Queue, ID = {0}, Name = {1}", c.ID, c.Name);
                Console.WriteLine("Items after one item dequeued. = {0}", queueCustomers.Count);
            }
            #endregion

            #region 2. Dequeue() method.
            Console.WriteLine("\nAfter dequeueing one item.");
            Customer c1 = queueCustomers.Dequeue();
            Console.WriteLine("Dequeued item, ID = {0}, Name = {1}", c1.ID, c1.Name);
            Console.WriteLine("Items after one item dequeued. = {0}", queueCustomers.Count);
            #endregion

            #region 3. Peek() method.
            Customer p = queueCustomers.Peek();
            Console.WriteLine("\nPeek item is, ID = {0}, Name = {1}", p.ID, p.Name);
            Console.WriteLine("Items after getting peek item. = {0}", queueCustomers.Count);
            #endregion

            #region 4. Contains() method.
            Console.WriteLine("Customer1 i.e 'Anand Dev' exists ? = {0}", queueCustomers.Contains(customer1));
            #endregion
        }
    }

    class Customer
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
    }
}
