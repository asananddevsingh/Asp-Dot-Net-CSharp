using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_063
{
    public partial class SamplePartialClass
    {
        // Defination of this method is at other file.
        // Partial method can have only void return type.
        partial void SamplePartialMethod();

        // This method does not have implementation even then it will not give error at caling, becuase it will be ignored by compiler.
        partial void SamplePartialMethodTwo();

        public void PublicMethod()
        {
            Console.WriteLine("Public method invoked.");
            SamplePartialMethod();
            SamplePartialMethodTwo();
        }
    }

    // We can't do this.
    //public partial interface ISample
    //{
    //    partial void InterfacePrint();
    //}

    public partial struct SampleStruct
    {
        partial void StructPrint();
    }
}
