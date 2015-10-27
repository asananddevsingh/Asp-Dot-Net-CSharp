using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_036
{
    /// <summary>
    /// Part 036 : Delegates
    /// </summary>
    class Program
    {
        /*
         * 1. A delegate is a type safe function pointer. i.e, it holds a reference(pointer) to a function.
         * 2. It is of reference type.
         * 3. The signature of the delegate must match the signature of the function the delegate points to, otherwise you will get a compiler error. 
         * this is why delegate is called as type safe function pointers.
         * 4. It is similar to class, you can create an instance of it, and when you do so. You pass in the function name as paramerter to delegate constructor.
         * and it is to this function the delegate will point to.
         * 
         * TIPS :: To remember delegate syntax: 
         * It looks very similar to function syntax with delegate keyword with it.
         */
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from delegate");

            SampleFunctionDelegate del2 = new SampleFunctionDelegate(Sample);
            string s = del2(1, "Sample from delegate ");
            Console.WriteLine(s);

            Console.ReadKey();
        }

        public static void Hello(String strMessage)
        {
            Console.WriteLine(strMessage);
        }

        public static String Sample(int msgNum, String strMessage)
        {
            return msgNum + "-"+ strMessage;
        }
    }

    /// <summary>
    /// Delegate should have same signature as of function.
    /// </summary>
    /// <param name="message"></param>
    public delegate void HelloFunctionDelegate(String message);
    public delegate String SampleFunctionDelegate(int msgNum, String message); 
}
