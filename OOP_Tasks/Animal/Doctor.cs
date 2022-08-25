using System;
using System.Collections.Generic;
using System.Text;

namespace Project_homework_animal
{
   public class Doctor
    {
       public  void TreatAnimal(Animal animal)
        {
            Console.WriteLine($" {animal} came to the reception with food {animal._food} and location {animal._lokation}");
        }
    }
}
