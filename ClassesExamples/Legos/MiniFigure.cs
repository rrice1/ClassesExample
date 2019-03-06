using ClassesExamples.Legos.Heads;
using ClassesExamples.Legos.Legs;
using ClassesExamples.Legos.Torsos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos
{
    class MiniFigure
    {
        private string name;

        public Head Head { get; set; }
        public Torso Body { get; set; }
        public object Name { get; internal set; }
        public LegsBase Legs { get; set; }

        //Legs

        public MiniFigure(string name, Head head, Torso body, LegsBase legs)
        {
            Name = name;
            Head = head;
            Body = body;
            Legs = legs;
        }

        //public void Eat()
        //{
        //    Head.Chew();
        //    Body.Digest();
        //}

        public void Greet()
        {

            Legs.Walk();
            Body.Wave();
            Head.Talk();     
        }

    }
}
