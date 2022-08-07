using System;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal kot = new Animal(3);
            Animal dog = new Animal(3);

            string A = "hey";
            string B = "hey";

            if (object.ReferenceEquals(kot, dog))
                Console.WriteLine("Same objects");
            else
                Console.WriteLine("Not the same objects");

            Console.ReadLine();


            if (object.ReferenceEquals(A, B))
                Console.WriteLine("Same objects");
            else
                Console.WriteLine("Not the same objects");
        }
    }


    public class Animal
    {
        public Animal(int a)
        {
            int age = a;
        }
    }
}
