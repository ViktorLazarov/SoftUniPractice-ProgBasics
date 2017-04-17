using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main()
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            
            double profit = 0.0;
            int numberOfSeats = rows * cols;
            if (projection =="Premiere")
            {
                profit = numberOfSeats * 12.0;
            }
            else if (projection == "Normal")
            {
                profit = numberOfSeats * 7.50;
            }
            else if (projection == "Discount")
            {
                profit = numberOfSeats * 5;
            }
            Console.WriteLine($"{profit:f2}");
        }
    }
}
