using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double taxiDayTimePrice = 0.79;
            double taxiNightTimePrice = 0.90;
            double busPrice = 0.09;
            double trainPrice = 0.06;
            double totalPrice = 0.0;

            if (n < 20)
            {
                if (dayOrNight == "day")
                {
                    totalPrice = (n * taxiDayTimePrice) + 0.70;
                }
                else if (dayOrNight == "night")
                {
                    totalPrice = (n * taxiNightTimePrice) + 0.70;
                }
            }
            else if (n >= 20 && n < 100)
            {
                totalPrice = n * busPrice;
            }
            else if (n >= 100)
            {
                totalPrice = n * trainPrice;
            }
            Console.WriteLine(totalPrice);
        }
    }
}
