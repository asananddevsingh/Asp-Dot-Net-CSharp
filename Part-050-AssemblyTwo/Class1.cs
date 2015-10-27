using System;
using Part_50_AssemblyOne;

namespace Part_50_AssemblyTwo
{
    public class AssemblyTwoClass1
    {
        public void Print1()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            // We can not access internal member (id) of different assembly.
            // Console.WriteLine(A1.id);
            Console.WriteLine("Internal member of the different asembly is not accessable here.");
        }
    }

    public class AssemblyTwoClass2 : AssemblyOneClass1
    {
        public void Print2()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            // We can not access protected internal member (Name) by instance of AssemblyOneClass1 class.
            //Console.WriteLine(A1.Name);

            // But by 
            Console.WriteLine("Protected internal member of different assembly is accessable in different assembly but in derived class using base keyword : " + base.Name);
            
            // OR
            Console.WriteLine();

            AssemblyTwoClass2 A2 = new AssemblyTwoClass2();
            Console.WriteLine("Protected internal member of different assembly is accessable in different assembly but in derived class usign instance of child class only : "+ A2.Name);
        }
    }



}
