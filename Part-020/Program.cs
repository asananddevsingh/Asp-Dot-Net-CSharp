using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_020
{
    /// <summary>
    /// Part 020: Static and instance class members.
    /// </summary>
    class Program
    {
        /// <summary>
        /// When a class member includes a static modifier, the members is called as static members.
        /// When NO static modifier, then members is called as non-static or instance members.
        /// Static members can be invoked usign class name where as instance members are invoked using instance of the class.
        /// 
        /// An instance member belongs to specific instance of a class. If i create 3 instance(object) of a class i will have 3 set of instance member in memory.
        /// Where as there will be only one copy of static member. no matter how many times instance of class is created.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*
             Since here when we call c1.CalculateArea() or c2.CalculateArea() every time the value of pi is going to be constant. 
             * And with every object created it will take memory since it is instance member. 
             */
            Circel c1 = new Circel(4);
            float area1 = c1.CalculateArea();
            Console.WriteLine("Area of circle is {0}.", area1);

            Circel c2 = new Circel(6);
            float area2 = c2.CalculateArea();
            Console.WriteLine("Area of circle is {0}.", area2);

            /*
             Now below codes are similar to above but this will less consume memory because its pi value is created as static member.
             */
            Circel2 c3 = new Circel2(4);
            float area3 = c3.CalculateArea2();
            Console.WriteLine("Area of circle is {0}.", area3);

            Circel2 c4 = new Circel2(6);
            float area4 = c4.CalculateArea2();
            Console.WriteLine("Area of circle is {0}.", area4);
             

            Console.ReadKey();
        }
    }

    class Circel
    {
        float _pi = 3.141f; // If you debug the program, debugger will come here for every instance of calss where as it will go only once in static constructor.
        int _radius;

        public Circel(int radius)
        {
            this._radius = radius;
        }

        public float CalculateArea()
        {
            return this._pi * this._radius * this._radius;
        }
    }

    class Circel2
    {
        static float _pi2;
        int _radius2;

        // Access modifiers cant't be used for static constuctors.
        // We use static constructor to initialize static fields.
        // Static constructors called before instances constructors and even before you refer to any static field.
        // If you debug the program, debugger will come here only once when first time class is instanced.
        static Circel2()
        {
            Console.WriteLine("Static constructor called.");
            Circel2._pi2 = 3.141f;
        }

        public Circel2(int radius)
        {
            Console.WriteLine("Instance constructor called.");
            this._radius2 = radius;
        }

        public float CalculateArea2()
        {
            // Now we can't use this keyword for _pi2 because it is static member. Now we can use class name insted this keyword.
            return Circel2._pi2 * this._radius2 * this._radius2;
        }        

    }
}
