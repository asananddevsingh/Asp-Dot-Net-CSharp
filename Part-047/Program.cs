using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_047
{
    /// <summary>
    /// Part 047 : Enums in C#.
    /// </summary>
    class Program
    {
        /*
         * 1. If program set of integral numbers, consider replacing them with enum, which will make program more readable and maintainable.
         * 2. Enums are enumerations.
         * 3. Enums are strongly typed constants. Hence, an explicit cast is needed to convert from enum type to an integral type and vice versa. 
         *      Also, am enum of one type cannot be implicitly assigned to an enum of even though the underlying value of their members are same.
         * 4. The default underlying type of an enum is int.
         * 5. The default value of first value is ZERO (0) and it get incremented by one.
         * 6. It is possible to customize the underlying type and value.
         * 7. Enums are value type. 
         * 8. enum keyword (all small letters) is used to create enumerations, where as Enum class contains static GetValue() and GetNames() 
         *      which can be used to list Enum underlying type values and Names.
         */
        static void Main(string[] args)
        {
            
            #region 1. Defautl underlying type of enum is int.
            int[] values = (int[])Enum.GetValues(typeof(Gender));
            Console.WriteLine("Values of enum Gender:");
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("\nNames of enum Gender:");
            String[] names = (String[])Enum.GetNames(typeof(Gender));
            foreach (String name in names)
            {
                Console.WriteLine(name);
            }
            #endregion

            #region 2. Changing underlying type of enum from int to short.

            short [] sessions = (short[])Enum.GetValues(typeof(Season));
            Console.WriteLine("\nValues of enum Season:");
            foreach (short session in sessions)
            {
                Console.WriteLine(session);
            }

            Console.WriteLine("\nNames of enum Season:");
            String[] sessionsName = (String[])Enum.GetNames(typeof(Season));
            foreach (String sName in sessionsName)
            {
                Console.WriteLine(sName);
            }
            #endregion

            #region 3. Proof of third point written above (Explicit conversion needed).
            Gender g = (Gender)3;
            int num = (int)Gender.Male;

            // This is not possible even the underlying type is same.
            // Gender gender = Season.Winter;

            Gender gender = (Gender)Season.Winter;

            #endregion

            Console.ReadKey();
        }
    }

    #region 1. Defautl underlying type of enum is int.
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    #endregion

    #region 2. Changing underlying type of enum from int to short
    public enum Season : short
    {
        Rain,
        Summer,
        Winter = -2,
        Spring = 6,
        Autom,
    }
    #endregion
}
