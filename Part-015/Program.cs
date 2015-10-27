using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_015
{
    /// <summary>
    /// Part 015: for and foreach loops.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. for loop
            int[] numbres = new int[3];
            numbres[0] = 101;
            numbres[1] = 102;
            numbres[2] = 103;

            /* 
             In for loo we do variable initialization, condition check and variable modification at one place. 
             */
            Console.WriteLine("Example of for loop:");
            for (int i = 0; i < numbres.Length; i++)
            {
                Console.WriteLine(numbres[i]);
            }

            /*
             We can use break and continue keyword in for loop.
             */
            Console.WriteLine("\nPrint numbers only upto 10 using break keyword.");
            for (int i = 0; i <= 20; i++)
            {
                if (i >= 10)
                    break;
                Console.Write(" {0}", i);
            }

            Console.WriteLine("\nPrint only even number using continue keyword.");
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 1)
                    continue;
                Console.WriteLine(i);
            }
            #endregion

            #region 2. foreach loop
            /*
             foreach loop is used to iterate through the items in a collection. For example it can be used with array, hastable etc.
             * There is no possibility of index out of range excepton.
             */
            Console.WriteLine("\nExample of foreach loop:");
            foreach (int n in numbres)
            {
                Console.WriteLine(n);
            }
            #endregion            

            Console.ReadKey();
        }
    }
}
