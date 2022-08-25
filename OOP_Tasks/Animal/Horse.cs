using System;
using System.Collections.Generic;
using System.Text;

namespace Project_homework_animal
{
   public class Horse : Animal
    {
        public int Age { get; set; }

        public Horse(string food, string lokation, int age)
        {
            Food = food;
            Lokation = lokation;
            Age = age;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("The horse is making noise");
        }

        public override void Eat()
        {
            Console.WriteLine($"The horse is eating {Food} ");
        }
    }
}
