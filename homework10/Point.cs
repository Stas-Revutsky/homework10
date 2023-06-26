using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    public struct Point
    {
        int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({this.x}, {this.y})";
        }

        public double Distance(Point p)
        {
            return Math.Sqrt(Math.Pow(this.x - p.x, 2) + Math.Pow(this.y - p.y, 2));
        }
    }
}
