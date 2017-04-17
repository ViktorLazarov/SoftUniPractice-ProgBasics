using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallestRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double secondRoom = smallestRoom * 1.1;
            double thirdRoom = secondRoom * 1.1;
            double bathroom = smallestRoom / 2;
            double totalArea = (smallestRoom + secondRoom + thirdRoom + kitchen + bathroom) * 1.05;
            double totalPrice = totalArea * price;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
