using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_007
{
    /// <summary>
    /// Part 007: Datatypes conversion.
    /// </summary>
    class Program
    {
        /// <summary>
        /// There are two types of conversions.
        /// 
        /// 1. Implicit conversion: This is done by compiler. Whene there is no loss of informtaion is possible. No possibility of throwing errors.
        /// Ex. converting from int to float.
        /// 
        /// 2. Explicit conversion: If there is possibility of losing the information, we need to do explicit conversion. 
        /// We can achieve it by using cast or convert class in C#. Cast will not through exception where as convert class can throw.
        /// Ex. converting from float to int.
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region 1. Implicit conversion.

            int num1 = 100;
            float num2;

            num2 = num1;

            Console.WriteLine("Implicit conversion done from int = {0} to float = {1}.\n", num1, num2);

            #endregion

            #region 2. Explicit conversion.

            float num3 = float.MaxValue;
            int num4;

            num4 = (int)num3; // By type casting. This will not give any exception.
            // OR 

             //num4 = Convert.ToInt32(num3); // By using convert class.. NOTE: This will give exception.

            Console.WriteLine("Explicit conversion done from float = {0} to int = {1}, Here you can see the information loss.\n ", num3, num4);
            
            #endregion

            #region 3. Parse and TryParse methods.

            String strNumber = "1234ADS";

            //int pasredNum = int.Parse(strNumber); // This will give exception.

            
            int tryParsedNum;

            bool isConverted = int.TryParse(strNumber, out tryParsedNum);
            if (isConverted)
            {
                Console.WriteLine("Conversion of string {0} was sucessfull.\n", strNumber);
            }
            else
            {
                Console.WriteLine("Conversion of string {0} was unsucessfull.\n", strNumber);
            }

            #endregion

            Console.ReadKey();
        }
    }
}
