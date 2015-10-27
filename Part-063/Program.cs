using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_063
{
    /// <summary>
    /// Part 063 : Partial methods in c#
    /// </summary>
    class Program
    {
        /*
         * 1. A partial class or struct can contains partial methods.
         * 2. Apartial method is created usign the partial keyword.
         * 3. A partial method declaration consists of two parts.
         *      a. The defination (only the methods signature).
         *      b. The implementation.
         *    These are be in separate parts of the partial class, or in the same part.
         *    
         * 4. The implementation for a partial methods is optional. IIf we don't provide the implementation, 
         *      the compiler removes the signature and all calls to the method.
         *      
         * 5. Partial methods are private by default, and it is a compile time error to include any access modifiers, ncluding private.
         * 6. It is a compile time error, to include declaration and implementation at the same time for partial methods.
         * 7. A partial method return type must be void. Including any other return type is a compile time error.
         * 8. Signature of the partial method declaration, must match with the signature of the implementation.
         * 9. A partial method must be declared within a partial class or partial struct (not in interface). A non-partial class or struct can't include partial methods.
         * 10. A partial method can be implemented only once. Triying to implement a partial method more than once, raise a compile time error.
         */
        static void Main(string[] args)
        {
            SamplePartialClass spc = new SamplePartialClass();
            spc.PublicMethod();

            Console.ReadKey();
        }
    }
}
