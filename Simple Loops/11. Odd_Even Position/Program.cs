using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Even_Position
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double evenSum = 0.0;
            double oddSum = 0.0;
            double evenMin = double.MaxValue;
            double oddMin = double.MaxValue;
            double evenMax = double.MinValue;
            double oddMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                }

            }
            Console.WriteLine($"OddSum={oddSum}");
            if (oddMin != double.MaxValue)
            {
                Console.WriteLine($"OddMin={oddMin}");
            }
            else
            {
                Console.WriteLine("OddMin=No");
            }
            if (oddMax != double.MinValue)
            {
                Console.WriteLine($"OddMax={oddMax}");
            }
            else
            {
                Console.WriteLine("OddMax=No");
            }
            Console.WriteLine($"EvenSum={evenSum}");
            if (evenMin != double.MaxValue)
            {
                Console.WriteLine($"EvenMin={evenMin}");
            }
            else
            {
                Console.WriteLine("EvenMin=No");
            }
            if (evenMax != double.MinValue)
            {
                Console.WriteLine($"EvenMax={evenMax}");
            }
            else
            {
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
