using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main()
        {
            var fruit = Console.ReadLine();
            var day = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            var totalSum = 0.0;

            if (day =="Monday" || day =="Tuesday" || day == "Wednesday" || day =="Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":totalSum = quantity * 2.50; break;
                    case "apple":totalSum = quantity * 1.20; break;
                    case "orange":totalSum = quantity * 0.85; break;
                    case "grapefruit": totalSum = quantity * 1.45; break;
                    case "kiwi": totalSum = quantity * 2.70; break;
                    case "pineapple": totalSum = quantity * 5.50; break;
                    case "grapes": totalSum = quantity * 3.85; break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.WriteLine($"{totalSum:f2}");
            }
            else if(day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana": totalSum = quantity * 2.70; break;
                    case "apple": totalSum = quantity * 1.25; break;
                    case "orange": totalSum = quantity * 0.90; break;
                    case "grapefruit": totalSum = quantity * 1.60; break;
                    case "kiwi": totalSum = quantity * 3.0; break;
                    case "pineapple": totalSum = quantity * 5.60; break;
                    case "grapes": totalSum = quantity * 4.20; break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.WriteLine($"{totalSum:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
