using System;
using Part_50_AssemblyOne;
using Part_50_AssemblyTwo;

namespace Part_050
{
    /// <summary>
    /// Part 050 : Internal and Protected Internal Access Modifiers in C
    /// </summary>
    class Program
    {
        /*
         * 1. A member with internal access modifier is available any where within the containing assembly. 
         *  Its a compile time error to access an internal member from outside the containing assembly.
         *  
         * 2. Protected internal members can be accessed by any code in the assembly in ehich it is declared
         *  or from within a derived class in another assembly. It is a combination of protected and internal
         *  If you have understood protected and internal, this should be very easy to follow.
         * 
         * Note :: In .NET assemblies are of two types ".dll" & ".exe". Assembly contains intermediate language of projects...
        */
        static void Main(string[] args)
        {
            AssemblyOneClass2 A1C2 = new AssemblyOneClass2();
            A1C2.SampleMethod();

            Console.WriteLine();

            AssemblyTwoClass1 A2C1 = new AssemblyTwoClass1();
            A2C1.Print1();

            Console.WriteLine();

            AssemblyTwoClass2 A2C2 = new AssemblyTwoClass2();
            A2C2.Print2();

            Console.ReadKey();
            
        }
    }
}
