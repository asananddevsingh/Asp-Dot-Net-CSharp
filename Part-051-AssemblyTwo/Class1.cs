using System;
using Part_051_AssemblyOne;

namespace Part_051_AssemblyTwo
{
    public class AssemblyTwoClass
    {
        public void Test()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            A1.Print();

            // This is not possible, because AssemblyOneClass2 is internal.
            //AssemblyOneClass2 A2 = new AssemblyOneClass2();
        }
    }
}
