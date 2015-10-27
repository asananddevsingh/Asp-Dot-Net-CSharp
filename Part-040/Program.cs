using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Part_040
{
    /// <summary>
    /// Part 040 : Exception handling.
    /// </summary>
    class Program
    {
        /*
         * 1. An exception is an unforeseen error that occurs when a program is running.
         * 2. Example :
         *      A. Trying to read from file that does not exist -> FileNotFoundException.
         *      B. Trying to read from DataBase table that does not exist -> SqlException.
         * 3. Showing actual unhandled exceptions to the end user is bad for two reasons:
         *      A. Users will be annoyed as they are cryptic and dones not make uch sense to the end user.
         *      B. Exceptions contain information, that can be used for hacking into your application.
         * 4. An exception is actually a class that derives from System.Exception class. The Syatem.Exception class has
         *  several useful properties, that provide valuable information about the exception.
         *      Message: Gets a message that describes the current exception.
         *      StackTrace: Provides the call stack to the line number in the method where the exception occurred.
         *      
         * 5. Why we use try, catch and finally blocks for exception handling:
         *      A. try :: The code that can possibly cause an exception will be in the try block.
         *      B. catch :: Handles the exception.
         *      C. finally :: Clean and free resources that the class was holding onto during the program execution. Finally block is optional.
         *      
         * NOTE :: It is a good practice to always release resources in the finally block, because finally block is gauranteed to execute, irrespective 
         * of wether there is an exception or not.
         * 
         * Specific exception will caught before the base general exception, so specific exception block should always be on the top of the base eception block.
         * Otherwise, you will encounter a compiler error.
         */
        static void Main(string[] args)
        {
            StreamReader sReader = null;
            try
            {
                sReader = new StreamReader(@"F:\Development\My Programs\CSharpByVenkatPragim\IntroductionToCSharp\Part-040\Excep tionLog.txt");
                Console.WriteLine(sReader.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                // To get this exception, rename the file.
                Console.WriteLine("Please check, file {0} exist.", ex.FileName);
            }
            catch (DirectoryNotFoundException ex)
            {
                // To get this exception, rename the folder path.
                Console.WriteLine("Please check directory of file exist.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\n");
                Console.WriteLine(ex.StackTrace);
            }
            // Even if error occour in cath block, finally block will execute.
            finally
            {
                if (sReader != null)
                {
                    sReader.Close();
                }
                Console.WriteLine("Finally block executed.");
            }

            Console.ReadKey();

        }
    }
}
