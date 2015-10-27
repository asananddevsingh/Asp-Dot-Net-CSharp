using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Part_092
{
    /// <summary>
    /// Part 92 : Significance of Thread Join and Thread IsAlive functions
    /// </summary>
    class Program
    {
        /*
         * Join blocks the current thread and makes it wait until the thread on which join method is invoked completes.
         * Join method also has a overload where we can specify the timeout. If we don't specify the timeout the calling thread waits indefinitly,
         * until the thread on which join() is invoked completes. This overloaded join(int milisecondsTimeOut) method returns boolean.
         * True if the thread has termitated otherwise false.
         * 
         * Join is particularly useful when we need to wait and collect result from a thread execution 
         * or if we need to do some clean-up after thread has completed.
         * 
         * IsAlive returns boolean. True if the thread is still executing otherwise false.
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Main started");

            Thread T1 = new Thread(Program.Thread1);
            T1.Start();

            Thread T2 = new Thread(Program.Thread2);
            T2.Start();

            if (T1.Join(1000))
            {
                Console.WriteLine("Thread 1 function completed.");
            }
            else
            {
                Console.WriteLine("Thread 1 function has not completed in 1 sec.");
            }
            
            T2.Join();
            Console.WriteLine("Thread 2 function completed");

            for (int i = 1; i <= 10; i++)
            {
                if (T1.IsAlive)
                {
                    Console.WriteLine("Thread 1 function still alive.");
                }
                else
                {
                    Console.WriteLine("Thread 1 function not alive any more.");
                    break;
                }
            }            

            Console.WriteLine("Main completed");
        }

        public static void Thread1()
        {
            Console.WriteLine("Thread 1 function started.");
            Thread.Sleep(5000);
            Console.WriteLine("Thread 1 function is about to return.");
        }

        public static void Thread2()
        {
            Console.WriteLine("Thread 2 function started.");
        }
    }
}
