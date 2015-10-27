using System;
using System.Threading;

namespace Part_088
{
    /// <summary>
    /// Part 88 : ThreadStart delegate
    /// </summary>
    class Program
    {
        /*
         * 1. To create a Thread, Create an instance of Thread class and to it's constructor pass the name of the function that we want the thread to execute.
         * 2. Why a delegate need to be passed as a parameter to the thread class constructor?
         *      The purpose of creating a thread is to execute a function.
         *      A delegate is a type safe function pointer, meaning it points to a function that the thread has to execute.
         *      In short, all the threads require an entry point to start execution. 
         *      Any thread you create will need an explicit defined entry point i.e a pointer to the function where they should begin execution.
         *      So threads always require a delegate.
         *      
         *  Thread function need not be a static function always. It can also be called using instance of class.
         */
        static void Main(string[] args)
        {
            // Using ThreadStart delegate.
            // Its working without using delegate because framework is doing it automatically.
            Thread T1 = new Thread(new ThreadStart(Number.PrintNumbers));
            T1.Start();

            // Using delegate keyword.
            Number n = new Number();            
            Thread T2 = new Thread(delegate() { n.InvokeMyThread(); });
            T2.Start();

            // Using lamda expression.
            Thread T3 = new Thread(() => Number.PrintNumbers());
            T3.Start();
        }
    }

    class Number
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void InvokeMyThread()
        {
            Console.WriteLine("Thread invoked....");
        }
    }
}
