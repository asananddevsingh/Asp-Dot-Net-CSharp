using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_016
{
    /// <summary>
    /// Part 016: Methods.
    /// </summary>
    class Program
    {
        /*
         Why we need methods.
         * Methods are extreamly useful because they allow to define your logic once and use it at many places.
         * It makes maintainace easy. Basic sturcture of methods are as below.
         * 
         * [attributes]
         * access-modifier return-type method-name (parameters)
         * {
         *      method body;
         * }
         */
        static void Main(string[] args)
        {
            Console.WriteLine("\nEven numbers with instanciated method:");
            Program p = new Program();
            p.EvenNumbers(20);

            Console.WriteLine("\nOdd numbers with static method:");
            Program.OddNumbers(21);

            Console.ReadKey();
        }

        #region 1. Instance method
        /// <summary>
        /// 1. When no static modifier is present, the method is said to be an instance method.
        /// 2. Instance methods can be called only by object of its class.
        /// </summary>
        /// <param name="target"></param>
        public void EvenNumbers(int target)
        {
            int start = 0;

            while (start <= target)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
        #endregion

        #region 2. Static method
        /// <summary>
        /// 1. When a method declaration includes a static modifier, that method is said to be static method.
        /// 2. Static methods can be called directly using the class name or directly by method name if it is in the same class.
        /// </summary>
        /// <param name="target"></param>
        public static void OddNumbers(int target)
        {
            int start = 1;

            while (start <= target)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
        #endregion
    }
}
