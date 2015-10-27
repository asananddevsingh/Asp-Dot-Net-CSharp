using System;

using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

namespace Part_018
{
    /// <summary>
    /// Part 018: Namespaces.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Namespace are used to organize the code and it can contains:
        /// 1. Namespace.
        /// 2. Class.
        /// 3. Interface.
        /// 4. Deligates.
        /// 5. Enums.
        /// 6. Struct.
        /// etc....
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            PATA.Class1.Print();
            // we can call method my fully qualified name.
            // ProjectA.TeamB.Class1.Print(); 

            // Also we can create namespace alias to remove ambiguity.
            PATB.Class1.Print();


            /*
             * Also we can write codes in separate class library or class files.
             */
            ProjectB.TeamA.Class1.Print();
            ProjectB.TeamB.Class1.Print();

            Console.ReadKey();
        }
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class Class1
        {
            public static void Print()
            {
                Console.WriteLine("Project A Team A print method.");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class Class1
        {
            public static void Print()
            {
                Console.WriteLine("Project A Team B print method.");
            }
        }
    }
}