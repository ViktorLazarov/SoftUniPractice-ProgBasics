using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Point_in_the_Figure
{
    class Program
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 0;
            int y1 = 0;
            int x2 = 3 * h;
            int y2 = h;
            int z1 = h;
            int c1 = h;
            int z2 = 2 * h;
            int c2 = 4 * h;

            if (x > x1 && x < x2 && y > y1 && y < y2)
            {
                Console.WriteLine("inside");
            }
            else if (x > z1 && x < z2 && y > c1 && y < c2)
            {
                Console.WriteLine("inside");
            }
            else if (x >= x1 && x <= x2 && y == y1) // bottom side of bottom rectangle
            {
                Console.WriteLine("border");
            }
            else if (y >= y1 && y <= y2 && x == x1) // left side of bottom rectangle
            {
                Console.WriteLine("border");
            }
            else if (y >= y1 && y <= y2 && x == x2) // right side of bottom rectangle
            {
                Console.WriteLine("border");
            }
            else if (x >= x1 && x <= z1 && y == y2) // left part of upper side of bottom rectangle
            {
                Console.WriteLine("border");
            }
            else if (x >= z2 && x <= x2 & y == y2) // right part of upper side of bottom rectangle
            {
                Console.WriteLine("border");
            }
            else if (y >= c1 && y <= c2 && x == z1) // left side of upper rectangle
            {
                Console.WriteLine("border");
            }
            else if (y >= y2 && y <= c2 && x == z2) // right side of upper rectangle
            {
                Console.WriteLine("border");
            }
            else if (x >= z1 && x <= z2 && y == c2) // upper part of upper rectangle
            {
                Console.WriteLine("border");
            }
            else if (x >= z1 && x <= z2 && y == y2)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }




        }
    }
}
