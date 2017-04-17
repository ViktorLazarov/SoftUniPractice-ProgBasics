using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Paintingg
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double windowArea = 1.5 * 1.5;
            double frontDoorArea = 1.2 * 2;

            double sideWallsArea = ((x * y) * 2) - (2 * windowArea);
            double frontAndBackWallsArea = ((x * x) * 2) - frontDoorArea;
            double roofArea = ((x * y) * 2) + (((x * h) / 2) * 2);

            double greenPaint = (sideWallsArea + frontAndBackWallsArea) / 3.4;
            double redPaint = roofArea / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");



        }
    }
}
