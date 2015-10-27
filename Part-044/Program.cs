using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_044
{
    /// <summary>
    /// Part 044 : Preventing exception abuse.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter numerator :");
                int numerator;
                bool isNumeratorConversionSuccess = int.TryParse(Console.ReadLine(), out numerator);
                if (isNumeratorConversionSuccess)
                {

                    Console.Write("Enter denominator :");
                    int denominator;
                    bool isDenominatorConversionSuccess = int.TryParse(Console.ReadLine(), out denominator);
                    if (isDenominatorConversionSuccess)
                    {
                        if (denominator != 0)
                        {
                            int result = numerator / denominator;
                            Console.WriteLine("Result is = {0}", result);
                        }
                        else
                        {
                            Console.WriteLine("Denominator can't be zero.");
                        }                           
                    }
                    else
                    {
                        Console.WriteLine("Denominator should be a valid number between {0} to {1}", int.MinValue, int.MaxValue);
                    }
                }
                else
                {
                    Console.WriteLine("Numerator should be a valid number between {0} to {1}", int.MinValue, int.MaxValue);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
