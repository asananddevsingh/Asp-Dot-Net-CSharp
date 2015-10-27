using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroductionToCSharp
{
    class Program
    {
        /// <summary>
        /// Main method is the entry point of your program and there can be only one entry point, 
        /// meaning there can be only one Main method with in one project.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#.");
            Console.ReadKey();
        }

        /// <summary>
        /// This will give warning: This has wrong signature to be an entry point.
        /// </summary>
        /// <param name="args"></param>
        static void Main(int[] args)
        {
            Console.WriteLine("This has wrong signature to be an entry point.");
            Console.ReadKey();
        }

        /// <summary>
        /// We can not do this, it will give compile time error.
        /// </summary>
        /// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("We can not do this.");
        //}
    }
}
