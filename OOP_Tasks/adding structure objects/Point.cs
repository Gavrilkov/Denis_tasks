﻿using System;
using System.Collections.Generic;
using System.Text;

namespace adding_structure_objects
{
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
