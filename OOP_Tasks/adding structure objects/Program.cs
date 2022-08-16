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

    public struct Point
    {
        int x;
        int y;

        public Point(int X, int Y)
        {
            x = X;
            y = Y;
        }

        public static Point operator +(Point point1, Point point2)
        {
            return new Point((point1.x + point2.x), (point1.y + point2.y));
        }

        public override string ToString()
        {
            return $"a structure object with coordinates X = {x}, Y = {y}";
        }
    }
}
