using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_029
{
    /// <summary>
    /// Part 029 : Difference between struct and class.
    /// </summary>
    class Program
    {
        /*
         * :: Differences :: 
         * 1. A struct is a value type where as class is a referance type.
         * 2. All the differences apply to value type and reference type are applicable here also.
         * 3. Structs are stored in stack and classes in heap.
         * 4. Value types holds there value in the memory where they created whereas reference type hold a reference to an object in memory.
         * 5. Value types are distroyed immediately after the scope is lost, whereas for reference types only 
         * the reference variable is distroyed after the scope is lost. The object is later distroyed by garbage collector.
         * 6. When you copy a struct into another struct, a new copy of struct created and modification at one struct will not affect value contained by other.
         * 7. structs can't have destructors where as class can have.
         * 8. structs can't have explicit parameter less constructor where as a class can. 
         * 9. structs can't inherit from another class where as a class can. Both structs and classes can inherit from an interface.
         * 10. A class or struct cannot inherit from another struct. Structs are sealed types. 
         * 11. Since struct does not support inheritance, access modifier of a member of a struct cannot be protected or protected internal.

         */
        static void Main(string[] args)
        {
            #region Value types holds there value in the memory where they created whereas reference type hold a reference to an object in memory.
            // Value types are distroyed immediately after the scope is lost, whereas for reference types only 
            // the reference variable is distroyed after the scope is lost. The object is later distroyed by garbage collector.
            int i = 1;

            if (i == 1)
            {
                int j = 10;
                Customer c = new Customer();
                c.ID = 101;
                c.Name = "Anand";
            }
            #endregion

            #region When you copy a struct into another struct, a new copy of struct created and modification at one struct will NOT affect value contained by other.

            int a = 10;
            int b = a;
            b = b + 1;
            a = a + 4; // This operation on a will not be reflected at b.
            Console.WriteLine("a = {0}, b = {1}", a, b);

            #endregion

            #region When you copy a class into another class, a only get a copy of reference variable, Both the variables point to the same onject on the heap and modification at one reference variable will affect value contained by other.

            Customer c1 = new Customer();
            c1.ID = 100;
            c1.Name = "Anand";
            Console.WriteLine("c1.ID = {0}, c1.Name = {1}", c1.ID, c1.Name);

            Customer c2 = c1;
            c2.Name = "Sahil"; // This operation on c2.Name will be reflected at c1.Name.
            Console.WriteLine("c1.ID = {0}, c1.Name = {1}", c1.ID, c1.Name);

            #endregion

            //Struct_1 s = new Struct_1();
            //s.Equals(s);

            #region Example
            StructurePerson strX = new StructurePerson();
            strX.LastName = "Bejaoui";
            strX.FirstName = "Bechir";
            StructurePerson strY = new StructurePerson();
            strY.LastName = "Bejaoui";
            strY.FirstName = "Bechir";

            if (strX.Equals(strY))
            {
                Console.WriteLine("strX = strY");
            }
            else
            {
                Console.WriteLine("strX != strY");
            }//This code displays strX = strY
            ClassPerson clsX = new ClassPerson();
            clsX.LastName = "Bejaoui";
            clsX.FirstName = "Bechir";
            ClassPerson clsY = new ClassPerson();
            clsY.LastName = "Bejaoui";
            clsY.FirstName = "Bechir";
            if (clsX.Equals(clsY))
            {
                Console.WriteLine("clsX = clsY");
            }
            else
            {
                Console.WriteLine("clsX != clsY");
            }//This code displays clsX != clsY
            #endregion


            Console.ReadKey();
        }
    }

    #region Structs can't have destructors where as class can have.
    public class ClassEmployee
    {
        public int ID { get; set; }
        public String Name { get; set; }

        /// Creating a destrctor for class is possible.
        ~ClassEmployee()
        {
            Console.WriteLine("Destructor called.");
        }
    }
    public struct StructEmployee
    {
        public int ID { get; set; }
        public String Name { get; set; }

        /// Creating a destrctor for struct will give error.
        //~StructEmployee()
        //{
        //    Console.WriteLine("Destructor called.");
        //}
    }
    #endregion

    #region Structs can't have explicit parameter less constructor where as a class can.

    public class MyClass
    {
        public MyClass()
        {
            // This is parameter less constructor.
        }
    }

    public struct MyStruct
    {
        /// <summary>
        ///  Structs cannot contain explicit parameterless constructors.
        /// </summary>
        //public MyStruct()
        //{
        //    // This is parameter less constructor.
        //}

        /// <summary>
        /// Parameterized explicit constructor is possible.
        /// </summary>
        /// <param name="a"></param>
        public MyStruct(int a)
        {
            // This is Parameterized constructor.
        }
    }

    #endregion

    #region A class or struct cannot inherit from another struct. Structs are sealed types.

    /// <summary>
    /// static keyword is not supported.
    /// 
    /// Since struct does not support inheritance, access modifier of a member of a struct cannot be protected or protected internal.
    /// </summary>
    struct Struct_1
    {
        // public String s = null; // Error.
        // public int s = 10; // Error: cannot have instance field initializers in structs.
        public void Print()
        {
            Console.WriteLine("Struct 1");
        }
    }

    public struct Struct_2 : IInterface_1// It can inherit only interfaces. Neither struct nor class.
    {
        public void Print()
        {
            Console.WriteLine("Struct 2");
        }

        int IInterface_1.MyProperty
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    public class Class_1
    {
        public void Print()
        {
            Console.WriteLine("Class 1");
        }
    }

    public class Class_2 : Class_1, IInterface_1
    {
        public void Print()
        {
            Console.WriteLine("Class 2");
        }

        int IInterface_1.MyProperty
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    interface IInterface_1
    {
        int MyProperty { get; set; }
    }

    #endregion

    #region Example
    struct StructurePerson
    {
        public string FirstName;
        public string LastName;
    }
    class ClassPerson
    {
        public string FirstName;
        public string LastName;
    }
    #endregion

    public class Customer
    {
        public int ID { get; set; }
        public String Name { get; set; }
    }
}
