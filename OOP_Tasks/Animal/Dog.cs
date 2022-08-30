using System;
using System.Collections.Generic;
using System.Text;

namespace Project_homework_animal
{
    class Dog : Animal
    {
        public string Name { get; set; }

        public Dog(string name):base("bones", "home")
        {
            Name = name;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"The dog {Name} is making noise");
        }

        public override void Eat()
        {
            Console.WriteLine($"The dog {Name} is eating {Food} ");
        }
    }
}
