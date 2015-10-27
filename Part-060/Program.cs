using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_060
{
    /// <summary>
    /// Part 060 : Difference between String and StringBuilder.
    /// </summary>
    class Program
    {
        /*
         * 1. System.String is immutable.
         * 2. StringBuilder is mutable.
         */
        static void Main(string[] args)
        {
            // This immutableString variable will create 5 instance in heap memory and reference to the last one in stack.
            // All unused instance will be cleared from memory when garbage collector run.
            String immutableString = "C#";
            immutableString += " Video";
            immutableString += " Tuorial";
            immutableString += " For";
            immutableString += " Beginners";

            // This mutableString variable will create only one instance in heap memory and reference that in stack.           
            StringBuilder mutableString = new StringBuilder("C#");                
            mutableString.Append(" Video");
            mutableString.Append(" Tutorial");
            mutableString.Append(" For");
            mutableString.Append(" Beginners");
            

        }
    }
}
