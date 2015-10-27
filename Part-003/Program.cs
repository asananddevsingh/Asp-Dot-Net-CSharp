using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_003
{
    /// <summary>
    /// Part 003: Built in types.
    /// </summary>
    class Program
    {
        /// <summary>
        /// These are the built in types and we can get its Min and Max value by using its property.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool b = true;
            sbyte sbMin = sbyte.MinValue;
            sbyte sbMax = sbyte.MaxValue;

            byte byMin = byte.MinValue;
            byte byMax = byte.MaxValue;

            short shMin = short.MinValue;
            short shMax = short.MaxValue;

            ushort us;
            int i;
            uint ui;
            long l;
            ulong ul;
            double d;

            Console.WriteLine("sbyte: Min value = {0}, Max value = {1}", sbMin, sbMax);
            Console.Read();


        }
    }
}
