using System;
using System.Collections.Generic;
using System.Text;

namespace Project_homework_animal
{
    class Cat: Animal
    {
        public string _colour { get; set; }
        public override string _food { get => base._food; set => base._food = value; }

        public override string _lokation { get => base._lokation; set => base._lokation = value; }

        public Cat (string food, string lokation, string colour)
        {
            _food = food;
            _lokation = lokation;
            _colour = colour;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("The cat is making noise");
        }

        public override void Eat()
        {
            Console.WriteLine($"The cat is eating {_food} ");
        }
    }
}
