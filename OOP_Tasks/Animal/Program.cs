using System;

namespace Project_homework_animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doc = new Doctor();
            Animal cat = new Cat("black");
            Animal dog = new Dog("Bob");
            Animal horse = new Horse(12);
            horse.Eat();
            horse.Sleep();
            horse.MakeNoise();
            Animal[] patients = { cat, dog, horse };
            for (int i = 0; i < patients.Length; i++)
            {
                doc.TreatAnimal(patients[i]);
            }
        }
    }
}
