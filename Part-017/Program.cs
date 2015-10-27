using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_017
{
    /// <summary>
    /// Part 017: Different type of method parameters.
    /// </summary>
    class Program
    {
        /*
         There are 4 types of method parameters.
         * 1. Value parameter.
         * 2. Reference parameter.
         * 3. Out parameter.
         * 4. Parameter array.
         */
        static void Main(string[] args)
        {
            int i = 0;
            MethodWithValueParam(i);
            Console.WriteLine(i);

            int j = 0;
            MethodWithReferenceParam(ref j);
            Console.WriteLine(j);

            int sum;
            int prod;
            sum = CalculateUsingOutParam(2, 4, out prod);
            Console.WriteLine("Sum using return type of method = {0}, Product using 'out' parameter = {1}.\n", sum, prod);

            int[] numbers = new int[4];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;
            numbers[3] = 104;
            MethodParameters(numbers);

            // Also we can pass parameters seperated by comma.
            MethodParametersWithOtherParameters("Anand", 1, 2, 3, 4);

            Console.ReadKey();

        }

        #region 1. Value parameters
        /// <summary>
        /// Creates a copy of the parameter passed, so modification does not affect each other.
        /// i and v parameters are pointing to the different memory locations.
        /// So operation on one variable will NOT affect the other variable.
        /// </summary>
        /// <param name="v"></param>
        public static void MethodWithValueParam(int v)
        {
            v = 101;
        }
        #endregion

        #region 2. Reference parameter
        /// <summary>
        /// j and r parameters are pointing to the same memory location.
        /// So operation on one variable will affect the other variable.
        /// </summary>
        /// <param name="r"></param>
        public static void MethodWithReferenceParam(ref int r)
        {
            r = 111;
        }
        #endregion

        #region 3. Out parameter
        /// <summary>
        /// Use when you want method to return more than one value.
        /// </summary>
        /// <param name="fNum"></param>
        /// <param name="sNum"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        public static int CalculateUsingOutParam(int fNum, int sNum, out int product)
        {
            product = fNum * sNum;
            return fNum + sNum;
        }
        #endregion

        #region 4. Parameter array
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numbers"></param>
        public static void MethodParameters(params int[] numbers)
        {
            Console.WriteLine("There are {0} elements passed as parameters and those are:", numbers.Length);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// A parameter array must be the last parameter in formal parameter list.
        /// </summary>
        /// <param name="str">This is any string</param>
        /// <param name="numbers">This is param array</param>
        public static void MethodParametersWithOtherParameters(string str, params int[] numbers)
        {
            Console.WriteLine("First parameter is {0} and there are {1} elements in params array.", str, numbers.Length);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        #endregion        
    }
}
