using System;

namespace Matrix
{
 //   класс матрица
 //   создать класс "матрица".класс должен иметь следующие переменные:
 //   двумерный массив вещественных чисел;
 //   количество строк и столбцов в матрице.
 //класс должен иметь следующие методы:


 //    сложение с другой матрицей;
 //   умножение на число;
 //              вывод на печать;
    class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Matrix(3, 5);
            var m2 = new Matrix(3, 5);
            m1.Init();
            m2.Init();
            Console.WriteLine(m1.ToString());
            Console.WriteLine(m2.ToString());
            Matrix m3 = m1 + m2;
            Console.WriteLine(m3.ToString());
        }
    }
}
