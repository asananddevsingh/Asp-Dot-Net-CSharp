using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_052
{
    /// <summary>
    /// Part 052 : Attributes.
    /// </summary>
    class Program
    {
        /*
         * 1. Attributes allow you to add declarative nformation to your program. This information can then be retrieved at runtime using reflection.
         * 2. There are several pre-defined attributes provided by .NET. t is also possible to create your own CustomAttributes.
         * 3. A few pre-defined attributes are:
         *  > Obselete      : Markes types and type members outdated.
         *  > WebMethods    : To expose a method as an XML web servce method.
         *  > Serializable  : Indicates that a class can be serialized.
         *  
         * 4. It is possible to customize the attribute using parameters.
         * 5. An attribute is a class that inherits from System.Attribute base class.
         */
        static void Main(string[] args)
        {
            int sumNumbers = Calculator.Add(10, 4);
            Console.WriteLine("Result using obsolete method = {0}", sumNumbers);

            int sumList = Calculator.Add(new List<int>() { 10, 20, 30 });
            Console.WriteLine("Result using new method = {0}", sumList);

            int sumParams = Calculator.Add(10, 20, 30, 40);
            Console.WriteLine("Result using params as parameter kind in method = {0}", sumParams);



            Console.ReadKey();
        }
    }

    public class Calculator
    {
        #region Old method for which we want to show warrning or error along with name of method to be used in the message.
        // It can add only two numbers. By Using Obsolete attribute we can show warning for old methods.
        [Obsolete("Use Add(List<int> numbers) method OR Add(params int[] numbers) insted.")]
        public static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        // This method will give error if we use this because, this is obbsolete and marked as error.
        [Obsolete("Use Add(List<int> numbers) method insted.", true)]
        public static int Add(int firstNum, int secondNum, int thirdNum)
        {
            return firstNum + secondNum + thirdNum;
        }

        #endregion

        #region New method that can be used by users over the old one.
        // This method is capible to add list of numbers.
        public static int Add(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        // This method is capible to add list of numbers.
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        #endregion
    }
}
