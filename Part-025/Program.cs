using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_025
{
    /// <summary>
    /// Part 025: Method overloading.
    /// </summary>
    class Program
    {
        /*
         * 1. Function overloading and method overloading are terms that used interchangeably.
         * 
         * 2. Method overloading allows a class to have a multiple with the same name but with the different signature,
         * So, in C# functions can be overloaded based on the number, types (int,float,string etc.) 
         * and kind (value, ref or out) of parameter.
         * 
         * 3. The signature of method is consists of the name of the method and the type, kind(value, reference or output) 
         * and the number of its formal parameters. The signature of a method does not include the return type and the params modifiers.
         * So, it is not possible to overload a function just based on the return type or params modifier.
         *          
         */
        static void Main(string[] args)
        {
            Add(1, 2);
            int sum;
            Add(1, 4, out sum);
                       
            Console.ReadKey();
        }

        public static void Add(int fNum, int sNum)
        {
            Console.WriteLine("Sum = {0}.",  fNum + sNum);
        }

        public static void Add(float fNum, float sNum)
        {
            Console.WriteLine("Sum = {0}.", fNum + sNum);
        }

        public static void Add(int fNum, float sNum)
        {
            Console.WriteLine("Sum = {0}.", fNum + sNum);
        }

        public static void Add(float fNum, int sNum)
        {
            Console.WriteLine("Sum = {0}.", fNum + sNum);
        }

        public static void Add(int fNum, int sNum, int tNum)
        {
            Console.WriteLine("Sum = {0}.", fNum + sNum + tNum);
        }

        /*
         * We can not differ any method only by "ref" or "out" parameters (kind of parameter). It will give compile time error.
         * To see the example, uncomment the below method.
         */

        //public static void Add(int fNum, int sNum, ref int sum)
        //{
        //    sum = fNum + sNum;
        //    Console.WriteLine("Sum = {0}.", sum);
        //}

        public static void Add(int fNum, int sNum, out int sum)
        {
            sum = fNum + sNum;
            Console.WriteLine("Sum = {0}.", sum);
        }


        /*
         It is not possible to overload a function just based on the return type or params modifier. It will give compile time error.
         */
        //public static int Add(int fNum, int sNum)
        //{
        //    return fNum + sNum;
        //}

        //public static void Add(int fNum, int sNum, params int[] sum)
        //{            
        //    Console.WriteLine("Sum = {0}.", sum);
        //}

        public static void Add(int fNum, int sNum, int[] sum)
        {
            Console.WriteLine("Sum = {0}.", sum);
        }
        
    }

}
