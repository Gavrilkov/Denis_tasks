using System;
using System.Collections.Generic;
using System.Text;

namespace Project_homework_animal
{
    class Cat: Animal
    {
        public string Colour { get; set; }

        public Cat (string food, string lokation, string colour) : base(food, lokation)
        {
            Colour = colour;
        }
        public override void MakeNoise()
        {
            Console.WriteLine("The cat is making noise");
        }

        public override void Eat()
        {
            Console.WriteLine($"The cat is eating {Food} ");
        }
    }
}
