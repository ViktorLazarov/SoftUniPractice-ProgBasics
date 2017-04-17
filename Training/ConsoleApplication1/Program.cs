using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDays = int.Parse(Console.ReadLine());
            double dailyEarnings = double.Parse(Console.ReadLine());
            double exchangeRate = double.Parse(Console.ReadLine());

            double monthlyEarnings = workingDays * dailyEarnings;
            double yearlyEarnings = (monthlyEarnings * 12) + (monthlyEarnings * 2.50);
            double tax = yearlyEarnings * 0.25;
            double totalEarnings = yearlyEarnings - tax;
            double averageEarningsPerDay = (totalEarnings / 365) * exchangeRate;

            Console.WriteLine($"{averageEarningsPerDay:f2}");

        }
    }
}
