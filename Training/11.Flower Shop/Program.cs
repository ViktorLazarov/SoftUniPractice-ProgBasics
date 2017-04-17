using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine());
            int ziumbiuli = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());
            double magnoliiPrice = 3.25;
            double ziumbiuliPrice = 4;
            double roziPrice = 3.50;
            double kaktusiPrice = 8;
            double totalPrice = magnolii * magnoliiPrice + ziumbiuli * ziumbiuliPrice + rozi * roziPrice + kaktusi * kaktusiPrice;
            double profit = totalPrice - (totalPrice * 0.05);

            if (profit>= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(profit-giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice-profit)} leva.");
            }


        }
    }
}
