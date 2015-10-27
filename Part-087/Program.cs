using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_087
{
    /// <summary>
    /// Part 87 : Advantages and disadvantages of multithreading
    /// </summary>
    class Program
    {
        /*
         * Advantages of multithreading:
         *      1. To maintain a responsive user interface.
         *      2. To make efficient use of processor time while waiting for I/O operations to complete.
         *      3. To split large, CPU-bound tasks to be processed simultaniously on machine that has multiple processors/cores.
         *      
         * Disadvantages of multithreading:
         *      1. On a single processor/core machine threading can affect performance affect performance negatively
         *      as there is overhead involved with context-switching.
         *      2. Have to write more lines of code to acomplish the same task.
         *      3. Multithreaded application are difficult to write, understand, debug and maintain.
         *      
         * NOTE ::
         *      Only use multithreading when the advantages of doing so outweight the disadvantage.
         *      
         */
        static void Main(string[] args)
        {
            Console.WriteLine(@"* Advantages of multithreading:
         *      1. To maintain a responsive user interface.
         *      2. To make efficient use of processor time while waiting for I/O operations to complete.
         *      3. To split large, CPU-bound tasks to be processed simultaniously on machine that has multiple processors/cores.\n");

            Console.WriteLine(@"Disadvantages of multithreading:
         *      1. On a single processor/core machine threading can affect performance affect performance negatively
         *      as there is overhead involved with context-switching.
         *      2. Have to write more lines of code to acomplish the same task.
         *      3. Multithreaded application are difficult to write, understand, debug and maintain.\n");

            Console.WriteLine(@"* NOTE ::
         *      Only use multithreading when the advantages of doing so outweight the disadvantage.");

            Console.ReadKey();
        }
    }
}
