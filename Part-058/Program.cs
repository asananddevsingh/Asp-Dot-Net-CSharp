using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_058
{
    /// <summary>
    /// Part 058 : Why should you override Equals Method
    /// </summary>
    class Program
    {
        /*
         * 1. Equals and == both will work same for value types, but it can be different for reference types.
         * 2. If Reference equality is true then, value equality must be true, 
         *      but value equality does not gaurantee the reference equality.
         *      
         * 3. == operator will give us value equality of value types where as equals will give us reference equality.
         */
        static void Main(string[] args)
        {

            Direction dir1 = Direction.East;
            Direction dir2 = Direction.East;

            Console.WriteLine("Comaparision using == operator is :: {0}", dir1 == dir2);
            Console.WriteLine("Comaparision using Equals operator is :: {0}", dir1.Equals(dir2));

            #region 2. Comparision of reference types
            Console.WriteLine("\nComparision of reference types ::");
            Customer c1 = new Customer();
            c1.FirstName = "Anand Dev";
            c1.LastName = "Singh";

            Customer c2 = c1;

            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));

            Console.WriteLine("\nIf Reference equality is true then, value equality must be true, but value equality does not gaurantee the reference equality.");
            Customer c3 = new Customer();
            c3.FirstName = "Simon";
            c3.LastName = "Tan";

            Customer c4 = new Customer();
            c4.FirstName = "Simon";
            c4.LastName = "Tan";
            Console.WriteLine(c3 == c4);
            Console.WriteLine(c3.Equals(c4));

            #endregion

            #region 3. After overriding the equals method.
            Console.WriteLine("\nAfter overriding the equals method.");
            CustomerOverriddenEquals c5 = new CustomerOverriddenEquals();
            c5.FirstName = "Nanhi";
            c5.LastName = "Malhotra";

            CustomerOverriddenEquals c6 = new CustomerOverriddenEquals();
            c6.FirstName = "Nanhi";
            c6.LastName = "Malhotra";
            Console.WriteLine(c5 == c6);
            Console.WriteLine(c5.Equals(c6));


            #endregion


            Console.ReadKey(); ;

        }
    }

    enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }

    class Customer
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
    }

    class CustomerOverriddenEquals
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is CustomerOverriddenEquals))
            {
                return false;
            }

            return this.FirstName == ((CustomerOverriddenEquals)obj).FirstName &&
                this.LastName == ((CustomerOverriddenEquals)obj).LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}
