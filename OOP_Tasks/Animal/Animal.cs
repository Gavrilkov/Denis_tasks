using System;
using System.Collections.Generic;
using System.Text;

namespace Project_homework_animal
{
    //    Создать класс Animal и расширяющие его классы Dog, Cat, Horse.
    //Класс Animal содержит переменные food, location и методы MakeNoise, Eat, Sleep. Метод MakeNoise, например, может выводить на консоль "Такое-то животное спит". 
    //Dog, Cat, Horse переопределяют методы MakeNoise, eat. 
    //Добавьте переменные в классы Dog, Cat, Horse, характеризующие только этих животных.
    //Создайте класс Doctor, в котором определите метод void TreatAnimal(Animal animal). Пусть этот метод распечатывает food и location пришедшего на прием животного.
    //В методе main создайте массив типа Animal, в который запишите животных всех имеющихся у вас типов.В цикле отправляйте их на прием к ветеринару.
    public abstract class Animal
    {
        public  string Food { get; set; }

        public  string Lokation { get; set; }

        public Animal(string food, string lokation)
        {
            Food = food;
            Lokation = lokation;
        }

        public abstract void MakeNoise();

        public abstract void Eat();

        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping");
        }
    }
}
