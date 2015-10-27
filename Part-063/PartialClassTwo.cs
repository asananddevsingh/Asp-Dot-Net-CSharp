using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_063
{
    public partial class SamplePartialClass
    {
        // Partial methods are private by default.
        partial void SamplePartialMethod()
        {
            Console.WriteLine("SamplePartialMethod() invoked.");
        }
    }
}
