using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Triangle : IComparable<Triangle>//наследуется от интерфейса конкретного типа
    {
        public double perimetr;
        public double area;
        public Point Point1 { get; private set; }
        public Point Point2 { get; private set; }
        public Point Point3 { get; private set; }
        public Triangle(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            double a = point1.GetLength(point2);
            double b = point1.GetLength(point3);
            double c = point2.GetLength(point3);
            perimetr = a + b + c;
            area = Math.Sqrt((perimetr / 2) * ((perimetr / 2) - a) * ((perimetr / 2) - b) * ((perimetr / 2) - a));
        }
        public int CompareTo(Triangle other)//перегрузка list.sort()
        {

            if (area > other.area)
            {
                return 1;
            }
            else
            {
                if (area < other.area)
                {
                    return -1;
                }
                else
                {
                    if (perimetr == other.perimetr)
                    {
                        return 0;
                    }
                    else return perimetr < other.perimetr ? 1 : -1;
                }
            }
        }
    }
}
