using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_043
{
    /// <summary>
    /// Part 043 : Exception handling abuse.
    /// </summary>
    class Program
    {
        /*
         * Using exception handling to implement program logical flow is bad and is called as exception handling abuse.
         */
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter numerator :");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter denominator :");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / denominator;
                Console.WriteLine("Result is = {0}", result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number only.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter a number between {0} to {1}.", Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator can't be zero.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
