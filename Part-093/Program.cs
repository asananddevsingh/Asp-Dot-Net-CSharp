using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Diagnostics;

namespace Part_093
{
    /// <summary>
    /// Part 93 : Protecting shared resources from concurrent access in multithreading
    /// </summary>
    class Program
    {
        /*
         * What happens if shared resources are not protected from concurrent access in multithreaded program.
         *      The output or behaviour of the program can become inconsistent. Let us understand this with an example.  
         *      
         * Every time we run the above program, we get a different output. The inconsistent output is because the 
         * Total field which is a shared resource is not protected from concurrent access by multiple threads. 
         * The operator ++ is not thread safe. There are several ways to fix this. Let's explore 2 of the options.
         *      
         *      1. Using Interlocked.Increment() method: Modify AddOneMillion() method as shown below. 
         *              The Interlocked.Increment() Method, increments a specified variable and stores the result, as an atomic operation
         *              
         *      2. Using lock keyword, which lock the shared resoure untill it is released by one thread.
         *      
         * Which option is better?
         *      From a performance perspective using Interlocked class is better over using locking. 
         *      Locking locks out all the other threads except a single thread to read and increment the Total variable. 
         *      This will ensure that the Total variable is updated safely. 
         *      The downside is that since all the other threads are locked out, there is a performance hit.
         *      
         *      The Interlocked class can be used with addition/subtraction (increment, decrement, add, etc.) on and int or long field. 
         *      The Interlocked class has methods for incrementing, decrementing, adding, and reading variables atomically.
         */

        #region Shared resources.

        static int total = 0;
        static int totalThread = 0;
        static int totalInterlock = 0;
        static int totallock = 0;

        #endregion

        static void Main(string[] args)
        {
            #region 1. Usign shared resource without threading.

            Stopwatch s1 = Stopwatch.StartNew();

            AddOneMillion();
            AddOneMillion();
            AddOneMillion();

            s1.Stop();

            Console.WriteLine("Total without Threading = {0} and elasped time = {1}", total, s1.ElapsedTicks);

            #endregion

            #region 2. Using shared resource with threading but without locking the shared resource.

            Stopwatch s2 = Stopwatch.StartNew();

            Thread T1 = new Thread(AddOneMillionByThread);
            Thread T2 = new Thread(AddOneMillionByThread);
            Thread T3 = new Thread(AddOneMillionByThread);

            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join();
            T2.Join();
            T3.Join();

            s2.Stop();

            Console.WriteLine("Total with Threading  = {0} and elasped time = {1}", totalThread, s2.ElapsedTicks);
            #endregion

            #region 3. Using shared resource with threading and Interlock class.

            Stopwatch s3 = Stopwatch.StartNew();

            Thread T4 = new Thread(AddOneMillionByInterlock);
            Thread T5 = new Thread(AddOneMillionByInterlock);
            Thread T6 = new Thread(AddOneMillionByInterlock);

            T4.Start();
            T5.Start();
            T6.Start();

            T4.Join();
            T5.Join();
            T6.Join();

            s3.Stop();

            Console.WriteLine("Total with Interlock Class  = {0} and elasped time = {1}", totalInterlock, s3.ElapsedTicks);
            #endregion

            #region 4. Using shared resource with lock key word.

            Stopwatch s4 = Stopwatch.StartNew();

            Thread T7 = new Thread(AddOneMillionByLock);
            Thread T8 = new Thread(AddOneMillionByLock);
            Thread T9 = new Thread(AddOneMillionByLock);

            T7.Start();
            T8.Start();
            T9.Start();

            T7.Join();
            T8.Join();
            T9.Join();

            s4.Stop();

            Console.WriteLine("Total with lock keyword = {0} and elasped time = {1}", totallock, s4.ElapsedTicks);

            #endregion

            Console.ReadKey();
        }

        // 1.
        public static void AddOneMillion()
        {
            for (int i = 0; i < 100000; i++)
            {
                total++;
            }
        }

        // 2.
        public static void AddOneMillionByThread()
        {
            for (int i = 0; i < 100000; i++)
            {
                totalThread++;
            }
        }

        // 3.
        public static void AddOneMillionByInterlock()
        {
            for (int i = 0; i < 100000; i++)
            {
                Interlocked.Increment(ref totalInterlock);
            }
        }

        // 4.
        static object _lockTotal = new object();
        public static void AddOneMillionByLock()
        {
            for (int i = 0; i < 100000; i++)
            {
                lock (_lockTotal)
                {
                    totallock++;
                }
            }
        }
    }
}
