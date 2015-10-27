using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_051_AssemblyOne
{
    public class AssemblyOneClass1
    {
        public void Print()
        {
            Console.WriteLine("Hello public class method.");
        }
    }

    internal class AssemblyOneClass2
    {
        public void Print()
        {
            Console.WriteLine("Hello internal class method.");
        }
    }
}
