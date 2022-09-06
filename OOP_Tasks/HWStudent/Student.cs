using System;
using System.Collections.Generic;
using System.Text;

namespace HWStudent
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
    class Student
    {
        public string FirstName;
        public string LastName;
        public string Group;
        public double AverageMark;
        public int Sum;
        public Student(string _firstName, string _lastName, string _group, double _averageMark)
        {
            FirstName = _firstName;
            LastName = _lastName;
            Group = _group;
            AverageMark = _averageMark;
        }

        public virtual int GetScholarship()
        {
            if (AverageMark == 5)
            {
                this.Sum = 100;
            }
            else
            {
                this.Sum = 80;
            }
            return Sum;
        }
    }
}
