using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Heads
{
    class Bald : Head
    {
        //Properties
        public int ShineLevel { get; set; }
        public bool HasToupe { get; set; }

        //Fields
        //Constructor
        //Methods
        public void Cut(HairLength newLength) //do void when you dont want to return anything
        {
            HairLength = newLength;
        }

        public string Talk()
        {
            return "I pity the foo'!";
        }


    }

    internal enum HairLength
    {
        CompletelyBald,
        Stubble,
        Short,
        Medium,
        Long
    }


}
