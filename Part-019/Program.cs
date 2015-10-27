using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_019
{
    /// <summary>
    /// Part 019: Classes.
    /// </summary>
    class Program
    {
        /*
         So Far we have seen data types such as int, string , double etc. 
         * If you want to make complex custom type then we create class.
         * A class consists of data (fields) and behaviour (methods). 
         */
        static void Main(string[] args)
        {
            // When user create default constructure.
            Customer c1 = new Customer();
            c1.PrintFullName();

            Customer c = new Customer("Anand Dev", "Singh");
            c.PrintFullName();

            Console.ReadKey();
        }
    }

    class Customer
    {
        String _firstName;
        String _lastName;

        /*
         The purpose of a class constructor is to initialize class fields. 
         * 1. A class constructor is automatically called when an instance of class is created.
         * 2. Constructor have the same name as of class and do not have any return type.
         * 3. Constructor are not mandatory. If we not provide, a default parameter less constructor automatically created.
         * 4. Constructor can be overloaded.
         */
        public Customer()
            : this("No first name", "No last name")
        {

        }

        public Customer(String firstName, String lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full name = {0} {1}", this._firstName, this._lastName);
        }

        // This is destructor.  
        ~Customer()
        {
            
        }
    }
}
