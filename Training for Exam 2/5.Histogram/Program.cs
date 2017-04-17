using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Histogram
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double p1Count = 0.0;
            double p2Count = 0.0;
            double p3Count = 0.0;
            double p4Count = 0.0;
            double p5Count = 0.0;

           
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1Count++;
                }
                else if (number>= 200 && number < 400)
                {
                    p2Count++;
                }
                else if (number >= 400 && number < 600)
                {
                    p3Count++;
                }
                else if (number >= 600 && number < 800)
                {
                    p4Count++;
                }
                else if (number >= 800)
                {
                    p5Count++;
                }

            }
            double p1 = (p1Count / n) * 100;
            double p2 = (p2Count / n) * 100;
            double p3 = (p3Count / n) * 100;
            double p4 = (p4Count / n) * 100;
            double p5 = (p5Count / n) * 100;
            Console.WriteLine($"{p1:f2}");
            Console.WriteLine($"{p2:f2}");
            Console.WriteLine($"{p3:f2}");
            Console.WriteLine($"{p4:f2}");
            Console.WriteLine($"{p5:f2}");


        }
    }
}
