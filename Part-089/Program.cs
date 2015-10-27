using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Part_089
{
    /// <summary>
    /// Part 89 : ParameterizedThreadStart delegate
    /// </summary>
    class Program
    {
        /*
         * Use ParameterizedThreadStart delegate to pass data to the thread.
         * 
         * NOTE ::
         *      Using ParameterizedThreadStart delegate and Thread.Start(Object) method to pass data to the Thread function is not type safe
         *      as they operate on object datatype and any type of data can be passed.
         *      
         * If you try to change the data type of the target parameter of PrintNumbers() function from object to int, 
         *      a compiler error will be raised as the signature of PrintNumbers() function does not match with the signature of ParameterizedThreadStart
         * 
         *  
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter target number:");
            object target = Console.ReadLine();

            //With using delegate - ParameterizedThreadStart"
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(Number.PrintNumbers);
            Thread T1 = new Thread(parameterizedThreadStart);
            T1.Start(target);

            // OR
            //Without using delegate - ParameterizedThreadStart";
            Thread T2 = new Thread(Number.PrintNumbers);
            T2.Start(target);

            Console.ReadKey();
        }
    }

    class Number
    {
        // Here arameter is of object type because ParameterizedThreadStart delegate wants the same.
        public static void PrintNumbers(object target)
        {
            int t = 0;

            if (int.TryParse(target.ToString(), out t))
            {
                for (int i = 1; i <= t; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
