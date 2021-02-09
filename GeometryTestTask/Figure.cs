using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryTestTask
{
    public abstract class Figure
    {
        public abstract double Area { get; }
    }
    public class Round : Figure
    {
        double radius;

        public Round(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Радиус должен быть быть больше 0");
            }
            this.radius = radius;
        }

        public override double Area => Math.PI * radius * radius;

    }
    public class Triangle : Figure
    {
        double a, b, c;
        public bool isRightAngled()
        {
            var edges = new double[] { a, b, c }.OrderBy(p => p).ToArray();
            return (edges[2] * edges[2]) == (edges[0] * edges[0] + edges[1] *edges[1]);
        }
        bool isExist(double a, double b, double c)
        {
            var edges = new double[] { a, b, c }.OrderBy(p => p).ToArray();
            return edges[2] <= edges[0] + edges[1];



        }
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Все стороны должны быть больше 0");
            }
            if (isExist(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else throw new Exception("Треугольник не существует");
        }
        public override double Area
        {
            get
            {
                var p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            }
        }
    }
}
