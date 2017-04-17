using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string track = Console.ReadLine();
            double juniorsTax = 0;
            double seniorsTax = 0;
            switch (track)
            {
                case "trail": juniorsTax = 5.50; seniorsTax = 7; break;
                case "cross-country": juniorsTax = 8; seniorsTax = 9.50; break;
                case "downhill": juniorsTax = 12.25; seniorsTax = 13.75; break;
                case "road": juniorsTax = 20; seniorsTax = 21.50; break;
            }
            double gatheredTax = juniors * juniorsTax + seniors * seniorsTax;
            if (track == "cross-country" && juniors + seniors >= 50)
            {
                gatheredTax = gatheredTax - (gatheredTax * 0.25);
            }
            double donatedMoney = gatheredTax - (gatheredTax * 0.05);
            Console.WriteLine($"{donatedMoney:f2}");
            
        }
    }
}
