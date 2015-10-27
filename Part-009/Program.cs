using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_009
{
    /// <summary>
    /// Part 009: Comments in C#.
    /// </summary>
    class Program
    {
        /// <summary>
        /// There are 3 types of comments in c#.
        /// 
        /// 1. Single line comment:- This can be done by using symbol double forward slash (//).
        /// 
        /// 2. Multi line comment:- This can be done by using symbol (/* .... CODE GOES HERE IN MULTIPLE LINES .... */)
        /// 
        /// 3. XML documentation comment:- This can be done by using symbol three forward slash (///).
        /// 
        /// NOTE: Don't try to commen every line of code. Use comment for block of codes of line which is difficult to understand.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // This is single line comment.
            Console.WriteLine("Single line comment:- This can be done by using symbol double forward slash (//).");


            /* This is multi line comment 
            int a = 1;
            float b = 2;
            string s = "Anand";            
             */
            Console.WriteLine("/*This is multi line comment \nint a = 1;\nfloat b = 2;\nstring s = \"Anand\";*/\n");

            XMLComment();
        }

        /// <summary>
        /// This is example of XML documentation comment.
        /// </summary>
        public static void XMLComment()
        {
            Console.WriteLine("/// <summary>\n/// This is example of XML documentation comment.\n/// </summary>");
            Console.ReadKey();
        }
    }
}
