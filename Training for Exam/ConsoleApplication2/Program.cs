using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());

            double availableHours = Math.Floor(((days * 0.9) * 8) + (employees * (2 * days)));

            if (availableHours >= hoursNeeded)
            {
                Console.WriteLine($"Yes!{availableHours-hoursNeeded} hours left.");

            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursNeeded-availableHours} hours needed.");
            }
        }
    }
}