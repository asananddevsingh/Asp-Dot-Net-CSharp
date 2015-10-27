using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_068
{
    /// <summary>
    /// Part 068 : Making method parameters optional using method overloading
    /// </summary>
    class Program
    {
        /*
        * There are 4 ways to make method parameters optional.
        * 1. Use parameters arrays, (params key word and it must be the last parameter in the parameters list.).
        * 2. By Method overloading.
        * 3. Specify parameter defaults.
        * 4. Use OptionalAttribute that is present in System.Runtime.InteropServices namespace.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Without passing optional parameters.");
            AddNumbers(4, 5);

            Console.WriteLine("\nPassing optional parameters.");
            AddNumbers(4, 5, null);
            AddNumbers(4, 5, new int[] { 2 });
            AddNumbers(4, 5, new int[] { 2, 6 });

            Console.ReadKey();
        }

        #region 2. Making method parameters optional using method overloading

        public static void AddNumbers(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            Console.WriteLine("Sum = {0}", result);
        }

        public static void AddNumbers(int firstNum, int secondNum, int[] restOfNums)
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
