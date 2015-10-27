using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Part_090
{
    /// <summary>
    /// Part 90 : Passing data to the Thread function in a type safe manner
    /// </summary>
    class Program
    {
        /*
         * To pass data to the Thread function in a type safe manner, encapsulate the thread function 
         *      and the data it needs in a helper class and use the ThreadStart delegate to execute the thread function.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter target number:");
            int target = Convert.ToInt32(Console.ReadLine());

            Number number = new Number(target);

            Thread T2 = new Thread(number.PrintNumbers);
            T2.Start();

            Console.ReadKey();
        }
    }

    class Number
    {
        private int _target;

        public Number(int target)
        {
            this._target = target;
        }

        public void PrintNumbers()
        {
            for (int i = 1; i <= this._target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
