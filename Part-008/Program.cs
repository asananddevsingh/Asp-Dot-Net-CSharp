using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_008
{
    /// <summary>
    /// Part 008: Arrays
    /// </summary>
    class Program
    {
        /// <summary>
        /// An array is a collection of similar data types. 
        /// 
        /// Advantages: Arrays are strongly typed. We can't store value of other type than of array.
        /// 
        /// Disadvantage: Arrays can not grow in size once initialized. Have to rely on integer indices to store or retrieve items from array.
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] evenNumbers = new int[3];

            evenNumbers[0] = 04;
            evenNumbers[1] = 14;
            evenNumbers[2] = 24;

            Console.WriteLine("Item in array at 1 index is {0}.\n", evenNumbers[1]);

            Console.ReadKey();

        }
    }
}
