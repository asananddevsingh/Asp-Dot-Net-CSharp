using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Part_021
{
    /// <summary>
    /// Part 021: Inheritance.
    /// </summary>
    class Program
    {        
        /*
         * 1. Derived class "FullTimeEmployee" and "PartTimeEmployee" inherits Base class "Employee".
         * 2. C# supports only single class inheritance.
         * 3. C# supports multiple interface inheritance.
         * 4. Child OR derived class is specilization of parent OR base class.
         * 5. Base class are automatically instantiated defore derived class.
         * 6. Parent class constructor executes before child class constructor.
         */
        /// <summary>
        /// Why inheritance : 
        /// Inheritance is one of the primary pillars of OOPs.
        /// It allows code reuse. Which can reduce time and errors.
        /// 
        /// NOTE:: You will specify all the common fields, methods and properties in the base class, which allows reuseability.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            #region Basic Example
            FullTimeEmployee ft = new FullTimeEmployee();
            ft.firstName = "Anand Dev";
            ft.lastName = "Singh";
            ft.yearlyRate = 1000;
            ft.PrintFullName();

            PartTimeEmployee pt = new PartTimeEmployee();
            pt.firstName = "Uttam";
            pt.lastName = "Mishra";
            pt.hourlyRate = 500;
            pt.PrintFullName();
            #endregion

            #region Single Inheritance

            Console.WriteLine("\n");
            SingleParent sp = new SingleParent();
            sp.Print();
            sp.Parent();

            Console.WriteLine("\n");
            SingleParent sp2 = new SingleChild();
            sp2.Print();
            sp2.Parent();

            Console.WriteLine("\n");
            SingleChild sc = new SingleChild();
            sc.Print();
            sc.Child();
            sc.Parent();

            /* This will give error. We can not */
            //SingleChild sc2 = new SingleParent();


            #endregion

            #region Multilevel Inheritance

            Console.WriteLine("\n");
            MultiLevelGrandParent mgp = new MultiLevelGrandParent();
            mgp.Print();
            mgp.GrandParent();

            Console.WriteLine("\n");
            MultiLevelGrandParent mgp2 = new MultiLevelParent();
            mgp2.Print();
            mgp2.GrandParent();

            Console.WriteLine("\n");
            MultiLevelGrandParent mgp3 = new MultiLevelChild();
            mgp3.Print();
            mgp3.GrandParent();


            Console.WriteLine("\n");
            // This is not possible.
            // MultiLevelParent mp = new MultiLevelGrandParent() 

            MultiLevelParent mp = new MultiLevelParent();
            mp.Print();
            mp.Parent();
            mp.GrandParent();

            Console.WriteLine("\n");
            MultiLevelParent mp2 = new MultiLevelChild();
            mp2.Print();
            mp2.Parent();
            mp2.GrandParent();

            Console.WriteLine("\n");
            // This is not possible.
            // MultiLevelChild mc = new MultiLevelParent();
            MultiLevelChild mc = new MultiLevelChild();
            mc.Print();
            mc.Child();
            mc.Parent();
            mc.GrandParent();

            Console.WriteLine("\n");



            #endregion

            #region Hierarchical Interface

            Console.WriteLine("\n");
            HierarchicalParent hp = new HierarchicalParent();
            hp.Print();
            hp.Parent();

            Console.WriteLine("\n");
            HierarchicalParent hp1 = new HierarchicalChild_1();
            hp1.Print();
            hp1.Parent();

            Console.WriteLine("\n");
            HierarchicalParent hp2 = new HierarchicalChild_2();
            hp2.Print();
            hp2.Parent();

            Console.WriteLine("\n");
            HierarchicalChild_1 hc1 = new HierarchicalChild_1();
            hc1.Print();
            hc1.Child_1();
            hc1.Parent();

            Console.WriteLine("\n");
            HierarchicalChild_2 hc2 = new HierarchicalChild_2();
            hc2.Print();
            hc2.Child_2();
            hc2.Parent();

            #endregion

            Baseclass b = new Baseclass();
            Derived d = new Derived();
            // d = b; This will give compile time error.
            // d = (Derived)b; This will give run time error.

            b = d;
            d = (Derived)b; // This is possible.

            Console.ReadKey();
        }
    }

    #region 1. Basic Example of why we need inheritance
    public class Employee
    {
        public String firstName;
        public String lastName;
        public String email;

        static Employee()
        {
            Console.WriteLine("Base class constructor called");
        }

        public void PrintFullName()
        {
            Console.WriteLine("{0} {1}", firstName, lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float yearlyRate;

        internal FullTimeEmployee()
        {
            Console.WriteLine("Derived class 'FullTimeEmployee' constructor called");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public float hourlyRate;

        internal PartTimeEmployee()
        {
            Console.WriteLine("Derived class 'PartTimeEmployee' constructor called");
        }
    }
    #endregion

    #region 2. Types of Inheritance

    #region A. Single Inheritance

    public class SingleParent
    {
        internal void Print()
        {
            Console.WriteLine("Parent class print method.");
        }

        internal void Parent()
        {
            Console.WriteLine("Parent class method.");
        }
    }

    public class SingleChild : SingleParent
    {
        internal void Print()
        {
            Console.WriteLine("Child class print method.");
        }

        internal void Child()
        {
            Console.WriteLine("Child class method.");
        }
    }

    #endregion

    #region B. Multilevel Inheritance

    public class MultiLevelGrandParent
    {
        internal void Print()
        {
            Console.WriteLine("Grand parent print method.");
        }

        internal void GrandParent()
        {
            Console.WriteLine("Grand parent method.");
        }
    }

    public class MultiLevelParent : MultiLevelGrandParent
    {
        internal void Print()
        {
            Console.WriteLine("Parent print method.");
        }

        internal void Parent()
        {
            Console.WriteLine("Parent method.");
        }
    }

    public class MultiLevelChild : MultiLevelParent
    {
        internal void Print()
        {
            Console.WriteLine("Child print method.");
        }

        internal void Child()
        {
            Console.WriteLine("Child method.");
        }
    }

    #endregion

    #region C. Multiple Inheritance

    /*
     Multiple inheritance of classes are not possible where as it can be achived by interfaces. 
     */

    #endregion

    #region D. Hierarchical Inherface

    // One parent class derived by multiple child classes.

    public class HierarchicalParent
    {
        internal void Print()
        {
            Console.WriteLine("Hierarchical parent print method.");
        }

        internal void Parent()
        {
            Console.WriteLine("Parent method.");
        }
    }

    public class HierarchicalChild_1 : HierarchicalParent
    {
        internal void Print()
        {
            Console.WriteLine("HierarchicalChild_1 print method.");
        }

        internal void Child_1()
        {
            Console.WriteLine("HierarchicalChild_1 method.");
        }
    }

    public class HierarchicalChild_2 : HierarchicalParent
    {
        internal void Print()
        {
            Console.WriteLine("HierarchicalChild_2 print method.");
        }

        internal void Child_2()
        {
            Console.WriteLine("HierarchicalChild_2 method.");
        }
    }

    #endregion

    #endregion

    public class Baseclass
    {
        private int a = 1; // Private members can't be inherited.
        public int i;
        internal void B()
        {
            Console.WriteLine("This is base class method");
        }
    }

    public class Derived : Baseclass
    {
        internal void D()
        {
            i = 1;
            Console.WriteLine("This is derived class method");
        }
    }
}
