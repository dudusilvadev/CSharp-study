﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppStudy
{
    internal class Class2
    {
        public readonly struct Coords
        {
            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; init; }
            public double Y { get; init; }

            public override string ToString() => $"({X}, {Y})";
        }

        public static void Main()
        {
            var p1 = new Coords(0, 0);
            Console.WriteLine(p1);  // output: (0, 0)

            var p2 = p1 with { X = 3 };
            Console.WriteLine(p2);  // output: (3, 0)

            var p3 = p1 with { X = 1, Y = 4 };
            Console.WriteLine(p3);  // output: (1, 4)
        }
    }
}
