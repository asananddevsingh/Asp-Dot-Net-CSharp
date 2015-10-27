using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_067
{
    /// <summary>
    /// Part 067 : Optional parameters in c#.
    /// </summary>
    class Program
    {
        /*
         * There are 4 ways to make method parameters optional.
         * 1. Use parameters arrays, (params key word and it must be the last parameter in the parameters list.).
         * 2. Method overloading.
         * 3. Specify parameter defaults.
         * 4. Use OptionalAttribute that is present in System.Runtime.InteropServices namespace.
         */
        static void Main(string[] args)
        {            
            Console.WriteLine("Without passing optional parameters.");
            AddNumbers(4, 5);
            
            Console.WriteLine("\nPassing optional parameters.");
            AddNumbers(4, 5, 2);
            AddNumbers(4, 5, 2, 6);
            Console.ReadKey();
        }

        #region 1. Use parameters arrays, (params key word). 
        public static void AddNumbers(int firstNum, int secondNum, params int[] restOfNums)
        {
            int result = firstNum + secondNum;
            if (restOfNums != null)
            {
                foreach (int i in restOfNums)
                {
                    result += i;
                }
            }

            Console.WriteLine("Sum = {0}", result);
        } 
        #endregion
    }
}
