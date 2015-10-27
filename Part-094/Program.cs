using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Part_094
{
    /// <summary>
    /// Part 94 : Difference between Monitor and lock in C
    /// </summary>
    class Program
    {
        /*
         * Both Monitor class and lock keyword provides a mechanism that synchronizes acess to object. 
         * Lock is the shortcut for Monitor.Enter with try and finally block. 
         * 
         * In C# 4, it is implemented slightly differently.
         *      
         */

        static int totallock = 0;
        static int totalMonitor = 0;

        static void Main(string[] args)
        {
            #region 1. Lock keyword.
            Thread T7 = new Thread(AddOneMillionByLock);
            Thread T8 = new Thread(AddOneMillionByLock);
            Thread T9 = new Thread(AddOneMillionByLock);

            T7.Start();
            T8.Start();
            T9.Start();

            T7.Join();
            T8.Join();
            T9.Join();

            Console.WriteLine("Total with lock keyword = {0}.", totallock); 

            #endregion

            #region 2. Monitor class.
            Thread TM1 = new Thread(AddOneMillionByMonitorLock);
            Thread TM2 = new Thread(AddOneMillionByMonitorLock);
            Thread TM3 = new Thread(AddOneMillionByMonitorLock);

            TM1.Start();
            TM2.Start();
            TM3.Start();

            TM1.Join();
            TM2.Join();
            TM3.Join();

            Console.WriteLine("Total with Monitor class = {0}.", totalMonitor); 
            #endregion

            Console.ReadKey();

        }

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

        static object _lockMonitor = new object();
        public static void AddOneMillionByMonitorLock()
        {
            for (int i = 0; i < 100000; i++)
            {
                Monitor.Enter(_lockMonitor);
                try
                {
                    totalMonitor++;
                }
                finally
                {
                    Monitor.Exit(_lockMonitor);
                }
            }
        }
    }
}
