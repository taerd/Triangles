using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public Point(double x,double y)
        {
            X = x;
            Y = y;
        }

        internal static bool Compare(Point point1, Point point2, Point point3)
        {
            double a = point1.GetLength(point2);
            double b = point1.GetLength(point3);
            double c = point2.GetLength(point3);
            if( a <= b+c && b<= a+c && c<= b + a)
            {
                return true;
            }
            return false;
        }
        public double GetLength(Point src)
        {
            return Math.Sqrt((src.X - this.X) * (src.X - this.X) + (src.Y - this.Y) * (src.Y - this.Y));
        }
    }
}
