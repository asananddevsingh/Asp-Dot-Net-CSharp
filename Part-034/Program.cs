using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_034
{
    /// <summary>
    /// Part 034: Problems with multiple class inheritance.
    /// </summary>
    class Program
    {
        /*
         * The ambiguity in a class inheriting different class methods having same name is called "Diamond" problem.
         */
        static void Main(string[] args)
        {
            // Example of method over riding.
            A a1 = new B();
            a1.Print();

            // Example of method hiding.
            A a2 = new C();
            a2.Print();

            Console.ReadKey();
        }
    }

    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A class implementation");
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B class implementation");
        }
    }

    class C : A
    {
        public new void Print()
        {
            Console.WriteLine("C class implementation");
        }
    }

    class D : B // If this class inhert both B and C class. Then there will be ambiguity between overriden Print() methods of B and C class.
    {
        //public new void Print()
        //{
        //    Console.WriteLine("C class implementation");
        //}
    }
}
