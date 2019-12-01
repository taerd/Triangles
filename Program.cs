using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            Int32.TryParse(s, out int value);
            Console.WriteLine(value);

            Array a = new Array();
            a.CreatePoints(value);
            try
            {
                a.CreateTriangles();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }

            try 
            {
                a.Display();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }

            try
            {
                a.SortTriangles();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }

            try
            {
                a.Display();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
            Console.ReadKey();
        }
    }
}
