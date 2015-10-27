using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_038
{
    class Example_1
    {        
        public void ExampleMethod()
        {
            Console.WriteLine("This is example method.\n");
        }
    }

    class Voter
    {

        public int Age { get; set; }

        public void LetsVote(Voter voterAge, IsVoteAble isVoteAble)
        {
            if (isVoteAble(voterAge))
            {
                Console.WriteLine("You can vote.\n");
            }
            else
            {
                Console.WriteLine("Please wait child.\n");
            }

        }
    }

    delegate bool IsVoteAble(Voter age);
}
