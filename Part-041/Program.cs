using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;


namespace Part_041
{
    /// <summary>
    /// Part 041 : Inner exception
    /// </summary>
    class Program
    {
        /*
         * 1. The inner exception property returns the excepion instance that caused the current exception.
         * 2. To retain the original exception pass it as a parameter to the constructor of the current exception.
         * 3. Always check if the inner exception is not null before accessing any property of the inner exception object, else you may get NullReferenceException.
         * 4. To get the type of inner exception use GetType() method.
         */
        static void Main(string[] args)
        {
            /* TO GET THE EXCEPTIONS
             * 1. Enter any not numeric value. (Format exception)
             * 2. Enter very long number for int (Overflow Exception)
             * 3. Enter second num  = 0;
             */
            try
            {
                try
                {
                    Console.Write("Enter first number :");
                    int firstNum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Second number :");
                    int secondNum = Convert.ToInt32(Console.ReadLine());

                    int result = firstNum / secondNum;

                    Console.WriteLine("Result = {0}", result);
                }
                catch (Exception ex)
                {
                    // To get exception here, rename the file, it will throw new exception and previous exception will act as inner exception.
                    String logFilePath = @"F:\Development\My Programs\CSharpByVenkatPragim\IntroductionToCSharp\Part-041\ExceptionLog1.txt";
                    if (File.Exists(logFilePath))
                    {
                        StreamWriter sw = new StreamWriter(logFilePath);
                        String exName = ex.GetType().Name;
                        String exMessage = ex.Message;
                        sw.Write("{0} :: {1}", exName, exMessage);
                        sw.Close();
                        Console.WriteLine("Oops !!! There is some problem, please try again later.");
                    }
                    else
                    {
                        throw new Exception(logFilePath + "is not present", ex);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("\nCurrent exception = {0}", exception.GetType().Name);
                if (exception.InnerException != null)
                {
                    Console.WriteLine("\nInner exception = {0}", exception.InnerException.GetType().Name);
                }
                
            }
        }
    }
}
