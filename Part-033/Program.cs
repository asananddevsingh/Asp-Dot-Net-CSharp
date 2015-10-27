using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_033
{
    /// <summary>
    /// Part 33: Abstract class Vs interface.
    /// </summary>
    class Program : A1
    {
        /*
         * Differences ::        
         * ----------------------------------------------------------------------
         * 1. Abstract class can have implementation for Some of it memmers. But Interface can't have implementation for any of its member.
         * 2. Abstract can have fields (int, bool, etc.) whereas Interface can't have.
         * 3. Abstract class inherit from other abstract class or interface. But Interface can inherit from other interfce only and can't from bastract class.
         * 4. A class can inherit from multiple interface at the same time, where as a class cannot inherit from multiple classes at the same time.
         * 5. Abstract class members can have access modifires where as interface members can not have.
         * 6. Abstract class can't be instanciated.
         * 7. An abstract class cannot be inherited by structures.
         */
        static void Main(string[] args)
        {

            A1 a = new Program();
            a.Print();

            S6 s = new S6();
            s.Interface();
            I6 i = new S6();
            i.Interface();

            Console.ReadKey();
        }      
    }

    #region 1. Abstract class can have implementation for Some of it memmers. But Interface can't have implementation for any of its member.
    abstract class A1
    {
        public void Print()
        {
            Console.WriteLine("abstract class Print method.");            
        }

        public A1()
        {
            Console.WriteLine("This is abstract class constructor.");
        }

        public A1(int str)
        {
            Console.WriteLine("You wrote :" + str );
        }

        ~A1()
        {
            Console.WriteLine("Distructor");
        }
    }

    interface IA1
    {
        // We can do this.
        void Print();

        /// <summary>
        /// We can't implement any method in interface.
        /// </summary>
        //void Print()
        //{

        //}

    }
    #endregion  

    #region 2. Abstract can have fields (int, bool, etc.) whereas Interface can't have.
    abstract class A2
    {
        int x = 4;
        public abstract int MyProperty { get; set; }

        private void Sample()
        {
            this.MyProperty = x;
        }

    }
    interface IA2
    {
        // This is not possibe.
        //int x = 4;
    }
    #endregion

    #region 3. Abstract class inherit from other abstract class or interface. But Interface can inherit from other interfce only and can't from bastract class.
    abstract class A3
    {
        internal abstract void Test();
    }

    // This is possible.
    abstract class B3 : A3, IA3
    {
        
    }

    interface IA3
    {

    }

    interface IB3 : IA3 // We cant inherit from A3 or any other class.
    {

    }
    #endregion

    #region 4. A class can inherit from multiple interface at the same time, where as a class cannot inherit from multiple classes at the same time.
    abstract class A4
    {

    }
    
    abstract class B4 
    {

    }

    abstract class C4 : A4, IA4, IA3  // It can not inherit from B4 class at the same time with A4.
    {

    }

    interface IA4
    {

    }

    interface IB4 : IA4, IA3, IA2// We cant inherit from any number of interface
    {

    }
    #endregion    

    #region 5. Abstract class members can have access modifires where as interface members can not have.
    abstract class A5
    {
        public abstract void Method1();
        
        private void Method2()
        {

        }

        protected void Method3()
        {

        }
    }
    interface IA5
    {
        
        // public void IMethod1(); // This is not possible.
        void IMethod1();
        
    }
    #endregion

    #region 6. An abstract class or class cannot be inherited by structures. But interface can be.
    class C6
    {

    }
    abstract class A6
    {

    }
    interface I6
    {
        void Interface();
    }
    struct S6 : I6
    {
        public void Interface()
        {
            Console.WriteLine("struct inherits interface but can't inherit class.");
        }

        void I6.Interface()
        {
            Console.WriteLine("struct calling interface method.");
        }
    }
    #endregion
}
