using System;
using System.Collections.Generic;
using System.Text;

namespace Project_homework_animal
{
    class Dog : Animal
    {
        public string _name { get; set; }
        public override string _food { get => base._food; set => base._food = value; }

        public override string _lokation { get => base._lokation; set => base._lokation = value; }

        public Dog (string food, string lokation, string name)
        {
            _food = food;
            _lokation = lokation;
            _name = name;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"The dog {_name} is making noise");
        }

        public override void Eat()
        {
            Console.WriteLine($"The dog {_name} is eating {_food} ");
        }
    }
}
