using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_004
{
    /// <summary>
    /// Part 004: Built in type "Sting"
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            String str = "Anand Dev Singh\n";
            Console.WriteLine(str);
            
            // \t used to give one tab space, \n used for new line, \" used to show " in output window.
            String escapeSequences = "Anand \tDev \nSingh \"Sahil\"";
            Console.WriteLine("Example of escape sequences: {0}\n", escapeSequences);

            // Path below is not very much readable, to make it readable we can use symbol @ at begning and remove extra slash from path.
            String pathWithoutVerbatimLiteral = "F:\\Development\\IntroductionToCSharp";
            Console.WriteLine("Path without verbatim literal: {0}\n", pathWithoutVerbatimLiteral);

            // Symbol @ is called as verbatim literal.
            String pathWithVerbatimLiteral = @"F:\Development\IntroductionToCSharp";
            Console.WriteLine("Path with verbatim literal \"@\": {0}\n", pathWithVerbatimLiteral);

            Console.ReadKey();
        }
    }
}
