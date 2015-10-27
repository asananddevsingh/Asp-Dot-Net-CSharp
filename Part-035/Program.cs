using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_035
{
    /// <summary>
    /// Part 035: Multiple class inheritance using interface.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();

            Console.ReadKey();
        }
    }

    interface IA
    {
        void AMethod();        
    }

    class A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("A");
        }
    }

    interface IB
    {
        void BMethod();
    }

    class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void AMethod()
        {
            a.AMethod();
        }

        public void BMethod()
        {
            b.BMethod();
        }
    }
}
