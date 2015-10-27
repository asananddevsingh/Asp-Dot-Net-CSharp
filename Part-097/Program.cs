using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Part_097
{
    /// <summary>
    /// Part 97 : Performance of a multithreaded program
    /// </summary>
    class Program
    {
        /*
         * 1. How to find out how many processors you have on your machine.
         * 
         *      1. Using task manager. > Go to Performance tab > The number of boxes you get under CPU Usage history is number of processors.
         *      2. Using Environment.ProcessorCount.
         *      3. On window command prompt, type following command > echo %NUMBER_OF_PROCESSORS%
         * 
         * 2. On a machine that has multiple processors, multiple threads can execute application code in parallel on different cores. 
         *      For example, if there are two threads and two cores, then each thread would run on an individual core.
         *      This means, performance is better.
         *      
         *          If two threads take 10 milli-seconds each to complete, then on a machine with 2 processors, the total time taken is 10 milli-seconds.
         *          
         * 3. On a machine that has a single processor, multiple threads execute, one after the other or wait until one thread finishes. 
         *      It is not possible for a single processor system to execute multiple threads in parallel. 
         *      Since the operating system switches between the threads so fast, it just gives us the illusion that the threads run in parallel. 
         *      On a single core/processor machine multiple threads can affect performance negatively as there is overhead involved with context-switching.
         * 
         *          If two threads take 10 milli-seconds each to complete, then on a machine with 1 processor, the total time taken is 20 milli-seconds + (Thread context switching time, if any)
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Number of processors = {0}\n", Environment.ProcessorCount);

            #region 1. Using single thread - Default.

            Stopwatch stopWatch = Stopwatch.StartNew();

            EvenNumbersSum();
            OddNumbersSum();

            stopWatch.Stop();

            Console.WriteLine("Total miliseconds without multiple threads = {0}\n", stopWatch.ElapsedMilliseconds);

            #endregion

            #region 2. Using multiple threading.

            stopWatch = Stopwatch.StartNew();
            Thread T1 = new Thread(EvenNumbersSum);
            Thread T2 = new Thread(OddNumbersSum);

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();
            stopWatch.Stop();
            Console.WriteLine("Total miliseconds with 2 threads = {0}\n", stopWatch.ElapsedMilliseconds);

            #endregion

            Console.ReadKey();
        }

        public static void EvenNumbersSum()
        {
            double sum = 0;
            for (int i = 0; i <= 50000000; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of even numbers = {0}\n", sum);
        }

        public static void OddNumbersSum()
        {
            double sum = 0;
            for (int i = 0; i <= 50000000; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of odd numbers = {0}\n", sum);
        }
    }
}
