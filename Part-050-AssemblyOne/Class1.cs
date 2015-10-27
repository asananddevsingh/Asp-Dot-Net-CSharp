using System;


namespace Part_50_AssemblyOne
{
    public class AssemblyOneClass1
    {
        internal int id = 101;
        protected internal String Name = "Anand Dev";
    }

    public class AssemblyOneClass2
    {
        public void SampleMethod()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            Console.WriteLine("Internal member is accessable in the different class of the same assembly :" + A1.id);
        }
    }
}
