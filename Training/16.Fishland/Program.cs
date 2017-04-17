using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriqPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudQuantity = double.Parse(Console.ReadLine());
            double safridQuantity = double.Parse(Console.ReadLine());
            double midiQuantity = double.Parse(Console.ReadLine());
            double palamudPrice = skumriqPrice * 1.6;
            double safridPrice = cacaPrice * 1.8;
            double midiPrice = 7.50;

            double totalSum = palamudQuantity * palamudPrice + safridQuantity * safridPrice + midiQuantity * midiPrice;

            Console.WriteLine($"{totalSum:f2}");



        }
    }
}
