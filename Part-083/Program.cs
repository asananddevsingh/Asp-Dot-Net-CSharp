using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_083
{
    /// <summary>
    /// Part 83 : Generic stack collection class
    /// </summary>
    class Program
    {
        /*
         * 1. Stack is a generic LIFO (Last In First Out) collection class that is present in System.Collections.Generic namespace. 
         *      The Stack collection class is analogous to a stack of plates. If you want to add a new plate to the stack of plates, 
         *      you place it on top of all the already existing plates.If you want to remove a plate from the stack, 
         *      you will first remove the one that you have last added. The stack collection class also operates in a similar fashion. 
         *      The last item to be added (pushed) to the stack, will be the first item to be removed (popped) from the stack. 
         *      
         * 2. To insert an item at the top of the stack, use Push() method.
         * 
         * 3. To remove and return the item that is present at the top of the stack, use Pop() method.
         * 
         * 4. A foreach loop iterates thru the items in the stack, but will not remove them from the stack. 
         *      The items from the stack are retrieved in LIFO (Last In First Out), order. The last element added to the Stack is the first one to be removed.
         *      
         * 5. To check if an item exists in the stack, use Contains() method.
         * 
         * 6. What is the difference between Pop() and Peek() methods? 
         *      Pop() method removes and returns the item at the top of the stack, 
         *      where as Peek() returns the item at the top of the stack, without removing it.
         */
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { ID = 101, Name = "Anand Dev", Gender = "Male" };
            Customer customer2 = new Customer() { ID = 102, Name = "Praveen", Gender = "Male" };
            Customer customer3 = new Customer() { ID = 103, Name = "Sandhya", Gender = "Female" };
            Customer customer4 = new Customer() { ID = 104, Name = "Nanhi", Gender = "Female" };
            Customer customer5 = new Customer() { ID = 105, Name = "Uttam", Gender = "Male" };

            #region 1. Push() method.
            Stack<Customer> stackCustomers = new Stack<Customer>();
            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);

            foreach (Customer c in stackCustomers)
            {
                Console.WriteLine("Pushed item in stack, ID = {0}, Name = {1}", c.ID, c.Name);
                Console.WriteLine("Items count. = {0}", stackCustomers.Count);
            }
            #endregion

            #region 2. Pop() method.
            Customer c1 =  stackCustomers.Pop();            
            Console.WriteLine("\nOne item is poped, " + c1.ID + " - " + c1.Name);
            Console.WriteLine("Items left in the stack after Pop() method = {0}", stackCustomers.Count);
            #endregion

            #region 3. Peek() method.
            Customer c2 = stackCustomers.Peek();
            Console.WriteLine("\nPeek method gives us, " + c2.ID + " - " + c2.Name);
            Console.WriteLine("Items left in the stack after Peek() method= {0}", stackCustomers.Count); 
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
