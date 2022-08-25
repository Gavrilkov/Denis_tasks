using System;

namespace Project_homework_animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doc = new Doctor();
            Animal cat = new Cat("milk", "home", "black");
            Animal dog = new Dog("bones", "yard", "Bob");
            Animal horse = new Horse("grass", "meadow", 12);
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
