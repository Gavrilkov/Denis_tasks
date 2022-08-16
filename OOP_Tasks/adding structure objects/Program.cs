using System;

namespace adding_structure_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(1, 5);
            var p2 = new Point(2, 3);
            Point p3 = p1 + p2;
            Console.WriteLine(p3.ToString());
        }
    }
}
