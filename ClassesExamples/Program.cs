using ClassesExamples.Legos;
using ClassesExamples.Legos.Heads;
using ClassesExamples.Legos.Torsos;
using System;

namespace ClassesExamples
{
    class Program
    {

        private static void Main(string[] args)
        {
            var taffy = new Candy("Orange", "Orange Saltwater Taffy", CandyType.Stretchy);
            taffy.SetRating(10);
            taffy.SetRating(5, "Just kinda liked it.");

            Console.WriteLine(taffy);

            var myDogHead = new Dog();
            var martinHead = new Bald();
            var astronaut = new Astronaut();

            var fitTorso = new FitTorso(2, Sex.Male,Legos.Colors.Freckles);
            fitTorso.Crunch(12);


            var miniFigure = new MiniFigure(martinHead,fitTorso);

            miniFigure.Greet();

            Console.ReadLine();
        }
    }
}
