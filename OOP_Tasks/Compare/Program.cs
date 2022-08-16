using System;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal kot = new Animal(3, 2);
            Animal dog = new Animal(3, 1);
            bool f = Equals(kot, dog);
            bool n = kot.Equals(dog);
            Console.WriteLine(n);
            Console.WriteLine(f);
            bool result = kot != dog;
            Console.WriteLine($" перегруженный оператор {result}");
        }
    }
}
