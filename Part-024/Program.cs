using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_024
{
    /// <summary>
    /// Part 024 : Difference between method overriding and method hiding.
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            /* 
             * 
             * In method overriding a base class reference variable pointing to a derived class object, 
             * will invoke the overriden method in the derived class.
             *          
             */
            MehodOverridingBaseClass mo = new MehodOverridingDerivedClass();
            mo.Print();

            /* 
            * 
            * In method hiding a base class reference variable pointing to a derived class object,
            * will invoke the hidden method in the base class.
            * 
            */
            MethodHidingBaseClass mh = new MethodHidingDerivedClass();
            mh.Print();

            Console.ReadKey();
        }
    }

    #region 1. Method Overriding

    public class MehodOverridingBaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Mehod Overriding Base class print method.");
        }
    }

    public class MehodOverridingDerivedClass : MehodOverridingBaseClass
    {
        public override void Print()
        {
            Console.WriteLine("Mehod Overriding Derived class print method.");
        }
    }

    #endregion

    #region 1. Method Hiding

    public class MethodHidingBaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Method Hiding Base class print method.");
        }
    }

    public class MethodHidingDerivedClass : MethodHidingBaseClass
    {
        public new void Print()
        {
            Console.WriteLine("Method Hiding Derived class print method.");
        }
    }

    #endregion

}
