using System;

namespace HWStudent
{
    class Program
    {
        //    Создайте пример наследования, реализуйте класс Student и класс Aspirant, аспирант отличается от студента наличием некой научной работы.
        //Класс Student содержит переменные: String FirstName, LastName, Group. 
        //        А также, double AverageMark, содержащую среднюю оценку.
        //Создать переменную типа Student, которая ссылается на объект типа Aspirant.
        //Создать метод GetScholarship() для класса Student, который возвращает сумму стипендии.
        //            Если средняя оценка студента равна 5, то сумма 100 р, иначе 80 р.Переопределить этот метод в классе Aspirant. 
        //            Если средняя оценка аспиранта равна 5, то сумма 200 р, иначе 180.
        //Создать массив типа Student, содержащий объекты класса Student и Aspirant. 
        //            Вызвать метод GetScholarship() для каждого элемента массива.
     
        static void Main(string[] args)
        {
            Student Roma = new Aspirant("Roma", "Ivanov", "A", 5.0);
            Student Vova = new Aspirant("Vova", "Sdorov", "B", 4.9);
            Student ALex = new Student("Alex", "Petrov", "C", 5.0);
            Student Mike = new Student("Mike", "Dak", "C", 4.0);
            Student[] Univers = { Roma, Vova, ALex, Mike };

            for (int i = 0; i < Univers.Length; i++)
            {
                Univers[i].GetScholarship();
                Console.WriteLine($" Student {Univers[i].FirstName} {Univers[i].LastName} from grope {Univers[i].Group} with averageMark {Univers[i].AverageMark} received a scholarship in the amount of {Univers[i].Sum}");
            }
        }
    }
}
