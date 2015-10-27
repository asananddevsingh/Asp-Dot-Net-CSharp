using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Part_091
{
    /// <summary>
    /// Part 91 : Retrieving data from Thread function using callback method
    /// </summary>
    class Program
    {
        /*
         * Main thread retrives the target number from the user.
         * Main thread creates a child thread and pass the target number to the child thread.
         * The child thread computes the sum of numbers and then returns the sum to the main thread using callback function.
         * The callback method prints the sum of numbers.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter target number:");
            int target = Convert.ToInt32(Console.ReadLine());

            // Step 5.
            SumOfNumbersCallback callBack = new SumOfNumbersCallback(PrintSum);

            // Step 6.
            Number number = new Number(target, callBack);

            // Step 7.
            Thread T2 = new Thread(number.PrintSumOfNumbers);
            T2.Start();

            Console.ReadKey();
        }

        // Step 4.
        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum of numbers = {0}", sum); 
        }
    }

    // Step 1.
    public delegate void SumOfNumbersCallback(int sumOfNumbers);

    public class Number
    {
        int _target;
        SumOfNumbersCallback _callBackMethod;

        // Step 2.
        public Number(int target, SumOfNumbersCallback callBackMethod)
        {
            this._target = target;
            this._callBackMethod = callBackMethod;
        }

        // Step 3.
        public void PrintSumOfNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= this._target; i++)
            {
                sum += i;
            }
            if (this._callBackMethod != null)
            {
                this._callBackMethod(sum);
            }
        }
    }

}
