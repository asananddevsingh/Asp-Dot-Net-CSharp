using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_032
{
    /// <summary>
    /// Part 032: Abstract Classes. 
    /// </summary>
    abstract class Program
    {
        /*
         * 1. abstract keyword is used to create abstract classes.
         * 2. An abstract class is incomplete and hence can not be instanciated.
         * 3. We use abstract class as a base class only.
         * 4. An abstract class can not be sealed. because "astract means class can be inherited" and "sealed means class can not be inherited".
         * 5. Abstract class may contain abstract members(methods, properties, indexers, and events). But not mandatory.
         * A non-abstract class derived from an abstract class must provide implementations for all inherited abstract members. 
         * 
         * NOTE :: If a class inherits an abstract class, there are 2 options available for that class.
         * Option 1: Provide implimentation for all the abstract members inherited from the base abstract class.
         * Option 2: If the class does not wish to provide implementation for all the members inherited from the abstract class 
         * then class has to be masrked as abstract class. But in that case you can not create the instance of abstract class.
         */
        static void Main(string[] args)
        {
            Customer c = new Dealer();
            c.Print();
            c.Print2();
            c.Hello();
            Console.WriteLine(c.MyProperty);
            Console.WriteLine(c.MyProperty2 = 2);
            c.MyProperty3 = 3;
            Console.WriteLine(c.MyProperty3);
            //c.SampleMethod();
            //c.SampleAbstractMethod();

            Console.WriteLine("\n");
            Dealer p = new Dealer();
            p.Print();
            p.Print2();
            p.Hello();
            Console.WriteLine(p.MyProperty);
            Console.WriteLine(p.MyProperty2 = 0);
            p.MyProperty3 = 4;
            Console.WriteLine(p.MyProperty3);
            //p.SampleMethod();
            //p.SampleAbstractMethod();

            Console.ReadKey();
        }


    }

    abstract class Customer //: Sample
    {
        // Error "Customer.PrintMethod()' cannot declare a body because it is marked abstract.
        /*
         public abstract void PrintMethod()
        {

        }
         */
        public abstract int MyProperty { get; }
        public abstract int MyProperty2 { set; }
        public abstract int MyProperty3 { get; set; }
        public abstract void Print();

        public abstract void Print2();

        public void Hello()
        {
            Console.WriteLine("Hello....");
        }

        //public abstract override void SampleAbstractMethod();        
    }

    class Dealer : Customer
    {
        #region Abstract class methods and properties.
        public override void Print()
        {
            Console.WriteLine("abstract method overridden.");
        }

        public override void Print2()
        {
            Console.WriteLine("Print 2.");
        }

        public override int MyProperty
        {
            get { return 1; }
        }

        int a;
        public override int MyProperty2
        {
            set { a = value; }
        }

        int b;
        public override int MyProperty3
        {
            set { b = value; }
            get { return b; }
        }

        //public override void SampleAbstractMethod()
        //{
        //    Console.WriteLine("Sample abstract method.");
        //}
        #endregion
    }

    //abstract class Sample
    //{
    //    public abstract void SampleAbstractMethod();

    //    public void SampleMethod()
    //    {
    //        Console.WriteLine("Sample method.");
    //    }
    //}
}
