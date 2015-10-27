using System;

namespace Part_056
{
    /// <summary>
    /// Part 056 : Generics.
    /// </summary>
    class Program
    {
        /*
         * 1. Generics are introduced in C# 2.0. Generics allow us to design classes and methods decoupled from the data types.
         * 2. We can create class, interface , methods etc as generic.
         * 3. Generic classess are extensively used by collection classes available in System.Collections.Generic namespace.(Covered in the next session) :P.
         * 
         * 4. One way of making AreEqual() method reuseable,is to use object type parameters. 
         *      Since every type in .NET directly or indirectly inherit from System.Object type.
         *      AreEqual() method works with any datatype, but the problem is performance degradation due to boxing and unboxing happening.         
         *
         * 5. Also, AreEqual() method is no longer type safe. It is now possible to pass integer for first parameter and a string for the second parameter.
         *      It doesn't really make sense to compare strings with integers.
         *      
         * 6. So, the problem with using System.Object type is that::
         *      > AreEqual() method is not type safe.
         *      > Performance degradation due to boxing and unboxing.
         *      
         * 7. To make AreEqual() method generic, we specify a type parameter using angular brackets as shown below:
         *      > public static bool AreEqual<T>(T value1, T value2);
         *      
         * 8. At the point, when the client code wants to invoke this method, they need to specify the type,
         *      they want the method to operate on. If the user wants the AreEqual() method to work with integer, 
         *      they can invoke the method specifying int as the datatype using angular brackets as shown blow::
         *          > bool genericClassEquals = CalculatorInt<int>.AreEqual(4, 4);
         *  
         */
        static void Main(string[] args)
        {
            #region 1.A Here methods are dependent on the type of parameter and tightly coupled.

            bool intEqual = Calculator.AreEqual(1, 1);
            Console.WriteLine(intEqual ? "Integer valules are equal." : "Integer valules are not equal.");

            bool strEqual = Calculator.AreEqual("A", "B");
            Console.WriteLine(strEqual ? "Strings valules are equal." : "Strings valules are not equal.");

            // This is not good practice bcoz, Here unwanted boxing int (value type) conversion to object (reference type) happens.
            bool objEqual = Calculator.AreEqual(1, "AB");
            Console.WriteLine(objEqual ? "Object valules are equal." : "Object valules are not equal.");

            #endregion

            #region 1.B This method is decoupled
            // Here any type of parameters can be passed to compare. Just you need to tell about the parameter type you want to compair.
            bool genericStrEqual = Calculator.AreEqual<String>("A", "B");
            Console.WriteLine(genericStrEqual ? "Generic string valules are equal." : "Generic string valules are not equal.");

            bool genericIntEqual = Calculator.AreEqual<int>(01, 1);
            Console.WriteLine(genericIntEqual ? "Generic int valules are equal." : "Generic int valules are not equal.");

            #endregion

            #region 2. Method of generic class.

            bool genericClassEquals = CalculatorInt<int>.AreEqual(04, 4);
            Console.WriteLine(genericClassEquals ? "Generic class values are Equals" : "Generic class values are Not-Equals");

            #endregion

            Console.ReadKey();

        }
    }

    #region 1. Non generic class having both generic and non-generic methods.

    public class Calculator
    {
        #region 1.A Non-Generic methods
        public static bool AreEqual(int valu1, int value2)
        {
            return valu1 == value2;
        }

        public static bool AreEqual(String valu1, String value2)
        {
            return valu1 == value2;
        }

        public static bool AreEqual(object valu1, object value2)
        {
            return valu1 == value2;
        }
        #endregion

        #region 1.B Generic method
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
        #endregion
    }

    #endregion

    #region 2. Even we can make a generic class, interface, struct, delegate

    public class CalculatorInt<T>
    {
        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    interface ISample<T>
    {
        T MyProperty { get; set; }
    }

    struct SampleStruct<T>
    {
        public T id;
    }

    delegate bool SampleDelegate<T>(T value1, T value2);

    #endregion


}
