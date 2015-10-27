using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_049
{
    /// <summary>
    /// Part 049 : Access modifiers.
    /// </summary>
    class Program
    {
        /*
         * 1. There are 5 types of access modifiers.
         *  1> Private
         *  2> protected
         *  3> Internal
         *  4> Protected Internal
         *  5> Public
         *  
         * We will learn about only 3 in this lession.
         * private :: Accessable only within the containing class.
         * public :: Accessable any where; No restrictions;
         * protected :: Accessable within the containing type and the types derived from the containing type.
         * internal :: Accessable anywhere with in the containing assembly.
         * protected internal :: Accessable anywhere with in the containing assembly and  from within a derived class in any another assembly.
         * 
         */
        static void Main(string[] args)
        {
            Customer c1 = new Customer();

            //c1._id; This will be inaccessable due to protection level.
            
            
            c1.Id = 101; // This is possible because ID property is public.            
        }
    }

    class Customer
    {
        private int _id;
        protected String Name;
        public int Id { get { return _id; } set { _id = value; } }
    }

    class CorporateCustomer : Customer
    {
        void PrintName()
        {
            CorporateCustomer cc = new CorporateCustomer();
            cc.Name = "Anand";
            
            // OR
            base.Name = "Dev";
            this.Name = "Singh";
        }
    }
}
