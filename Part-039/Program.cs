using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_039
{
    /// <summary>
    /// Part 039 : Multicast delegate.
    /// </summary>
    class Program
    {
        /*
         * 1. A multicast delegate is a delegate that has reference to more than one function.
         * When you invoke a multicast delegate,all the functions the delegate is pointign to are invoked.
         * 
         * 2. There are 2 approaches to create a multicast delegate. Depending on the approach you use.
         * + or += to register a method with the delegate.
         * - or -= to un-register a method with the delegate.
         * 
         * 3. Note :: A multicast delegate, invokes the methods in the invocation list, in the same order in which the are added.
         * 
         * 4. If the delegate has a return type other than void and if the delegate is a multicast delegate.
         * Only the value of the last invoked method will be returned. Along the same lines.
         * If the delegate has an out parameter, the value of the output parameter, will be the value assigned by the last method.
         * 
         * 5. Common interview question - where do we use multicast delegate. ?
         * Multicast delegate makes implementation of observe design pattern very simple. Observe design pattern is also called as publish/subscribe design pattern.
         */
        static void Main(string[] args)
        {
            #region 1. Methods with void return type 
            #region Way One
            Console.WriteLine("Invoked by way one:\n");
            SampleDelegateVoid del1, del2, del3, del4;
            del1 = new SampleDelegateVoid(SampleMethodOneVoid);
            del2 = new SampleDelegateVoid(SampleMethodTwoVoid);
            del3 = new SampleDelegateVoid(SampleMethodThreeVoid);

            del4 = del1 + del2 + del3;
            del4();

            Console.WriteLine("\n");
            del4 = del1 + del2 - del3;
            del4();

            #endregion

            #region Way Two
            Console.WriteLine("\nInvoked by way two:\n");
            SampleDelegateVoid sDel = new SampleDelegateVoid(SampleMethodOneVoid);
            sDel += SampleMethodTwoVoid;
            sDel += SampleMethodThreeVoid;
            sDel();
            Console.WriteLine("\n");
            sDel -= SampleMethodThreeVoid;
            sDel();
            #endregion            
            #endregion

            // A multicast delegate, invokes the methods in the invocation list, in the same order in which the are added.
            // If the delegate has a return type other than void and if the delegate is a multicast delegate. Only the value of the last invoked method will be returned. Along the same lines.
            #region 2. Methods with any return type, example int.
            Console.WriteLine("Delegate with int return type.\n");
            SampleDelegateInt sDelInt = new SampleDelegateInt(SampleMethodOneInt);
            sDelInt += SampleMethodTwoInt;
            sDelInt += SampleMethodThreeInt;
            
            int delegateReturnedValue = sDelInt();
            Console.WriteLine("\nDelegate returned value (Third method invoked at last) = {0}.\n", delegateReturnedValue);

            sDelInt -= SampleMethodThreeInt;
            delegateReturnedValue = sDelInt();
            Console.WriteLine("\nDelegate returned value (Third method deleted from invokation list) = {0}.\n", delegateReturnedValue);

              
            #endregion

            //A multicast delegate, invokes the methods in the invocation list, in the same order in which the are added.
            // If the delegate has an out parameter, the value of the output parameter, will be the value assigned by the last method.
            #region 3. Methods having out parameter
            Console.WriteLine("Delegate with output parameter.\n");
            SampleDelegateOut sDelOut = new SampleDelegateOut(SampleMethodOneOut);
            sDelOut += SampleMethodTwoOut;
            sDelOut += SampleMethodThreeOut;

            int delegateOutputParam = -1;
            sDelOut(out delegateOutputParam);
            Console.WriteLine("\nDelegate returned ouput value (Third method invoked at last) = {0}.\n", delegateOutputParam);

            sDelOut -= SampleMethodThreeOut;
            sDelOut(out delegateOutputParam);
            Console.WriteLine("\nDelegate returned ouput value (Third method deleted from invocation list) = {0}.\n", delegateOutputParam);

            #endregion
            Console.ReadKey();
        }

        #region 1. Methods with void return type
        public static void SampleMethodOneVoid()
        {
            Console.WriteLine("SampleMethod One void invoked.");
        }

        public static void SampleMethodTwoVoid()
        {
            Console.WriteLine("SampleMethod Two void invoked.");
        }

        public static void SampleMethodThreeVoid()
        {
            Console.WriteLine("SampleMethod Three void invoked.");
        }
        #endregion

        /// <summary>
        /// If the delegate has a return type other than void and if the delegate is a multicast delegate.
        /// Only the value of the last invoked method will be returned. Along the same lines.
        /// </summary>
        /// <returns></returns>
        #region 2. Methods with any return type, example int.
        public static int SampleMethodOneInt()
        {
            return 1;
        }
        public static int SampleMethodTwoInt()
        {
            return 2;
        }
        public static int SampleMethodThreeInt()
        {
            return 3;
        }
        #endregion

        /// <summary>
        /// If the delegate has an out parameter, the value of the output parameter, will be the value assigned by the last method.
        /// </summary>
        /// <param name="num"></param>
        #region 3. Methods having out parameter
        public static void SampleMethodOneOut(out int num)
        {
            num = 1;
        }
        public static void SampleMethodTwoOut(out int num)
        {
            num = 2;
        }
        public static void SampleMethodThreeOut(out int num)
        {
            num = 3;
        }
        #endregion

    }

    // 1st
    public delegate void SampleDelegateVoid();
    // 2nd
    public delegate int SampleDelegateInt();
    // 3rd
    public delegate void SampleDelegateOut(out int intNum);
}
