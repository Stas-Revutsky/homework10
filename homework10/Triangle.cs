using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    public class Triangle
    {
        private Point a, b, c;

        public Triangle (Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Perimeter()
        {
            return Math.Round((a.Distance(b) + b.Distance(c) + c.Distance(a)), 2);
        }

        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Round(Math.Sqrt(p *(p - a.Distance(b)) * (p - b.Distance(c)) * (p - c.Distance(a))), 2);
        }

        public void Print()
        {
            Console.WriteLine($"It's a triangle with perimeter of {Perimeter()} and area" +
                $" of {Area()} and vertexes in points {a.ToString()}, {b.ToString()}, {c.ToString()}");
        }

        public double DistanceToOrigin ()
        {
            Point origin = new Point(0, 0);
            return Math.Min(a.Distance(origin), Math.Min(b.Distance(origin), c.Distance(origin)));
        }
    }
}
