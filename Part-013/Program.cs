using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_013
{
    /// <summary>
    /// Part 013: While loops.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // While loop checks condition first, if statement is true then statement in the loop will be executed.
            #region 1. While loop
            Console.Write("Enter your target > 0 : ");
            int userTarget = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= userTarget)
            {
                Console.Write("{0} ",start);
                start = start + 2;
            }
            #endregion
            Console.ReadKey();
        }
    }
}
