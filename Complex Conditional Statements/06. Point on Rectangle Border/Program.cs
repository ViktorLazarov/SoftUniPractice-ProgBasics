using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Point_on_Rectangle_Border
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (x1 < x2 && y1 < y2)
            {
                var isOnLeftSide = x == x1 && y >= y1 && y <= y2;
                var isOnRightSide = x == x2 && y >= y1 && y <= y2;
                var isOnTopside = y == y1 && x >= x1 && x <= x2;
                var isOnBottomSide = y == y2 && x >= x1 && x <= x2;
                if (isOnLeftSide || isOnRightSide || isOnBottomSide || isOnTopside)
                {
                    Console.WriteLine("Border");
                }
                else
                {
                    Console.WriteLine("Inside / Outside");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
