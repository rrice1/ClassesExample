using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples
{
    class Candy
    {
        //Properties
        public string Flavor { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public string Name { get; set; }
        public CandyType Type { get; set; }

        //Fields
        const int MinRatingValue = 1;
        const int MaxRatingValue = 10;

        //Consctructor has to have same name as class
        public Candy(string flavor, string name, CandyType type)
        {
            Flavor = flavor;
            Name = name;
            Type = type;
        }

        //Methods
        public void SetRating(int userRating)
        {
            if (userRating >= MinRatingValue && userRating <= MaxRatingValue)
            {
                Rating = userRating;
            }
            else
            {
                throw new Exception($"You are dumb. Ratings are {MinRatingValue}-{MaxRatingValue}. You moron.");
            }
        }
        public void SetRating(int userRating, string review)
        {
            SetRating(userRating);
            Review = review;
        }
        public override string ToString()
        {
            return $"This is {Type} {Name}, with a(n) {Flavor} flavor, rated {Rating} with a review of {Review}";
        }

    }
    enum CandyType
    {
        Chocolate,
        HardCandy,
        Caramel,
        Sour,
        Stretchy,
        Nut
    }
}
