using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_031
{
    /// <summary>
    /// Part 031 : Explicit interface implementation.
    /// </summary>
    class Program : I1, I2
    {        
        /*
         * Question:: A class inherits from 2 interfaces and both the interfaces have the same method name. 
         * How should the class implement the method for both interface.
         * 
         * Answer:: We arae using explicit interface implementation technique to solve this problem.
         * 
         * NOTE:: When a class explicitly implements, an interface member. The interface member can no longer be accessed thru
         * class reference variable, but only thru interface reference variable.
         * Access modifiers are not allowed on explicitly implemented interface members.
         */
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Print();

            //
            Program p1 = new Program();
            ((I1)p1).InterfaceMethod();
            ((I2)p1).InterfaceMethod();

            // When the methods are exlicitly implemented, then we can call methods by using the interface reference variable only.
            // We can't do like 
            // Program p = new Program();
            // p.InterfaceMethod();

            I1 i1 = new Program();
            i1.InterfaceMethod();

            I2 i2 = new Program();
            i2.InterfaceMethod();

            // Calling default "InterfaceMethod()" from both interface methods.
            Program p2 = new Program();
            p2.InterfaceMethod();

            Console.ReadKey();
        }

        public void Print()
        {
            Console.WriteLine("This method will work for both interface, since the method name is same and it is not explicitily defined.\n");
        }

        // This will act as default method between both "InterfaceMethod()" because it is not implemented explicitly. And we can call it by object of derived class.
        public void InterfaceMethod()
        {
            Console.WriteLine("Interface 1 method");
        }

        #region Explicit implimentation of interface.
        // Public access modifier is not allowed at the time of explicit implementation of interface.        
        void I2.InterfaceMethod()
        {
            Console.WriteLine("Interface 2 method.\n");
        }
        #endregion
    }

    interface I1
    {
        void Print();
        void InterfaceMethod();        
    }

    interface I2
    {
        void Print();
        void InterfaceMethod();
    }
}
