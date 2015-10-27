using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_030
{
    /// <summary>
    /// Part 030: Interface
    /// </summary>
    class Program
    {
        /*
         * 1. We create interface by using  interface keyword. Just like classes interfaces also contains properties, methods, deligates or events. But only declaration and no implementation.
         * 2. It will a compile time error to provide implementaion for any interface members.
         * 3. Interface members are public by default. and they don't allow expilixit access modifiers.
         * 4. Interfaces can not contains fields. Ex, Int, String etc.
         * 5. A class or struct inherits from interface, It must provide implementation for all interface members, Otherwise we get a compiler error.
         * 6. A class or strcut can inherit from more than one interface at the same time. Where as a class can not inherit from more that one class at the same time.
         * 7. Interface can inherit from more other interfaces. A class that inherits this interface must provide implementation for all the members on the entire inheritance chain.
         * 8. We can't create instance of interface but an interface reference variable can point to derived class object. 
         */
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.Print1();
            c.Print2();

            ICustomer1 ic1 = new Customer();
            ic1.Print1();

            Console.ReadKey();
        }
    }

    interface ICustomer1
    {
        // Error : interface members cannot have a definition
        //void Print()
        //{
        //}

        void Print1();
    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();        
    }

    interface ICustomer3
    {
        void Print2();
    }


    public class Customer : ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Interface 1 Print method");
        }

        public void Print2()
        {
            Console.WriteLine("Interface 2 Print method");
        }
    }

    class Sample
    {

    }
}
