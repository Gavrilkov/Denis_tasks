using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun g = new Gun();
            g.Reload(2);
            g.showBullets();
            g.Shot();
            g.Shot();
            g.Reload();
        //    g.Shot();
            g.showBullets();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
