using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_005
{
    /// <summary>
    /// Part 005: Common Operators in C#.
    /// </summary>
    class Program
    {
        /// <summary>
        /// List of operators are:
        /// 
        // 1. Assignment operator: =
        // 2. Arithmetic operators: +, -, *, /, %
        // 3. Comparison operators: ==, !=, >, >=, <, <=
        // 4. Conditional operators: &, &&, |, ||
        // 5. Ternary operator: ?:
        // 6. Null coalescing operator: ??
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region 1. Assignment operator: =
            int num = 10;
            if (num == 10)
            {
                Console.WriteLine("Number is 10\n");
            }
            else
            {
                Console.WriteLine("Number is not 10\n");
            }
            #endregion

            #region 2. Arithmetic operators: +, -, *, /, %
            int a = 6;
            int b = 2;

            Console.WriteLine("Sum : {0}", a + b);
            Console.WriteLine("Diff : {0}", a - b);
            Console.WriteLine("Mul : {0}", a * b);
            Console.WriteLine("Div : {0}\n", a / b);

            #endregion

            #region 3. Comparison operators: ==, !=, >, >=, <, <= AND 4. Conditional operators: &, &&, |, ||
            int fNum = 10, sNum = 20;
            // Here we are using &, then it will check both conditions even if first condition is false.
            // For or conditional operator |, it will be similar.
            if (fNum == 10 & sNum == 20)
            {
                Console.WriteLine("First num = 10, Second num = 20\n");
            }
            else
            {
                Console.WriteLine("False condition !!!\n");
            }

            // Here we are using &&, then it will not check next conditions if first condition is false. Even at compile time.
            // For or conditional operator |, it will be similar.
            if (fNum == 10 && sNum == 20)
            {
                Console.WriteLine("First num = 10, Second num = 20\n");
            }
            else
            {
                Console.WriteLine("False condition !!!\n");
            }
            #endregion

            #region 5. Ternary operator: ?:

            String str = "Anand";
            bool iSName = (str == "Anand" ? true : false);
            Console.WriteLine("Bool value is: {0}\n", iSName);

            #endregion

            #region 6. Null coalescing operator: ??
            int? rate = 10;
            int price = rate * 1 ?? 0;
            Console.WriteLine("When rate is 10, Price is: {0}\n", price);

            rate = null;
            price = rate * 1 ?? 0; // It will take default value give (In our case 0) if the nulable variable is null.
            Console.WriteLine("When rate is null, Price is: {0}\n", price);
            #endregion

        }
    }
}
