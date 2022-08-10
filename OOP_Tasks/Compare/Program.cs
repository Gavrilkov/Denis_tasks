using System;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal kot = new Animal(3,2);
            Animal dog = new Animal(3,1);
            bool n = kot.Equals(dog);
            Console.WriteLine(n);
            
            Console.ReadLine();
            ////if (object.ReferenceEquals(kot, dog))
            ////    Console.WriteLine("Same objects");
            ////else
            ////    Console.WriteLine("Not the same objects");


        }
    }
}
