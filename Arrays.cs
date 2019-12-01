using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Array
    {
        private List<Point> points;
        private List<Triangle> triangles;
        private int size;
        public Array()
        {
        }
        public void CreatePoints(int n)
        {
            n = n < 3 ? 3 : n;
            points = new List<Point>();
            Random r = new Random();
            size = n;
            //Point p = new Point(0, 0);
            //points.Add(p);
            int k = 0;
            int x;
            int y;
            bool b;
            while (k < size)
            {
                x = r.Next(-2 * size, 2 * size);
                y = r.Next(-2 * size, 2 * size);
                Point p1 = new Point(x, y);
                b = true;

                for (int i = 0; i < k; i++)
                {
                    if(p1.X == points[i].X  && p1.Y == points[i].Y)//если есть уже такая точка
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    points.Add(p1);
                    k++;
                }
            }
        }
        public void CreateTriangles()
        {
            if (points != null)
            {
                triangles = new List<Triangle>();
                for (int i = 0; i < size; i++)
                {
                    for (int j = i + 1; j < size; j++)
                    {
                        for (int k = j + 1; k < size; k++)
                        {
                            if (Point.Compare(points[i], points[j], points[k]))
                            {
                                Triangle t = new Triangle(points[i], points[j], points[k]);
                                triangles.Add(t);
                            }
                        }
                    }
                }
            }
            else throw new Exception("Points are null");
        }
        public void SortTriangles()
        {
            if (triangles != null)
            {
                triangles.Sort();   
            }
            else throw new Exception("Triangles are null");
        }
        public void Display()
        {
            if (triangles != null)
            {
                Console.WriteLine();
                foreach (Triangle s in triangles)
                {
                    Console.WriteLine(s.area);
                }
            }
            else throw new Exception("Triangles are null");
        }
    }
}
