using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupsToBeMade = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            int workingHours = workers * workingDays * 8;
            double cupsMade = workingHours / 5;

            double cupsDiff = Math.Abs(cupsToBeMade - cupsMade);
            if (cupsToBeMade > cupsMade)
            {
                Console.WriteLine($"Losses: {cupsDiff*4.2:f2}");
            }
            else
            {
                Console.WriteLine($"{cupsDiff * 4.2:f2} extra money");
            }

        }
    }
}
