using System;
using System.Collections.Generic;
using System.Text;

namespace Project_homework_animal
{
   public class Horse : Animal
    {
        public int _age { get; set; }
        public override string _food { get => base._food; set => base._food = value; }

        public override string _lokation { get => base._lokation; set => base._lokation = value; }

        public Horse(string food, string lokation, int age)
        {
            _food = food;
            _lokation = lokation;
            _age = age;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("The horse is making noise");
        }

        public override void Eat()
        {
            Console.WriteLine($"The horse is eating {_food} ");
        }
    }
}
