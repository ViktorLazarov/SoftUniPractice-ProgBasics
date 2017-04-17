using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main()
        {
            var city = Console.ReadLine();
            var sales = double.Parse(Console.ReadLine());
            var commision = 0.0;
            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = sales * 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = sales * 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = sales * 0.08;
                }
                else if (sales >= 10000)
                {
                    commision = sales * 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = sales * 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = sales * 0.10;
                }
                else if (sales >= 10000)
                {
                    commision = sales * 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = sales * 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = sales * 0.12;
                }
                else if (sales >= 10000)
                {
                    commision = sales * 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine($"{commision:f2}");
        }
    }
}
