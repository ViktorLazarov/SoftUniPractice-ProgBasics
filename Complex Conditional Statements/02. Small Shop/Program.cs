using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
           
            var quantity = double.Parse(Console.ReadLine());
            var totalSum = 0.0 ;
            if (product == "coffee")
            {
                if (city == "sofia")
                {
                    totalSum = quantity * 0.50;
                }
                else if (city == "varna")
                {
                    totalSum = quantity * 0.45;
                }
                else if (city == "plovdiv")
                {
                    totalSum = quantity * 0.40;
                }

            }
            else if (product == "water")
            {
                if (city == "sofia")
                {
                    totalSum = quantity * 0.80;
                }
                else if (city == "varna")
                {
                    totalSum = quantity * 0.70;
                }
                else if (city == "plovdiv")
                {
                    totalSum = quantity * 0.70;
                }
            }
            else if (product == "beer")
            {
                if (city == "sofia")
                {
                    totalSum = quantity * 1.20;
                }
                else if (city == "varna")
                {
                    totalSum = quantity * 1.10;
                }
                else if (city == "plovdiv")
                {
                    totalSum = quantity * 1.15;
                }
            }
            else if (product == "sweets")
            {
                if (city == "sofia")
                {
                    totalSum = quantity * 1.45;
                }
                else if (city == "varna")
                {
                    totalSum = quantity * 1.35;
                }
                else if (city == "plovdiv")
                {
                    totalSum = quantity * 1.30;
                }
            }
            else if (product == "peanuts")
            {
                if (city == "sofia")
                {
                    totalSum = quantity * 1.60;
                }
                else if (city == "varna")
                {
                    totalSum = quantity * 1.55;
                }
                else if (city == "plovdiv")
                {
                    totalSum = quantity * 1.50;
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
