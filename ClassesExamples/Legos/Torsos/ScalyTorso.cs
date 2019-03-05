using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Torsos
{
    class ScalyTorso : Torso
    {
        public ScalyTorso() 
            : base (4,Sex.Other,Colors.Red,"Hard as a rock")
        {
        }

        public override void Wave()
        {
            Console.WriteLine(@"Fragile waving \0/"); //@ allows for multiline strings
        }

    }
}
