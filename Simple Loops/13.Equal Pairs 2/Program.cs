using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int previousSum = 0;
            int diff = 0;
            int maxDiff = 0;

            for (int i = 0; i < n * 2; i += 2)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                int Sum = number1 + number2;
                if (i > 0)
                {
                    diff = Math.Abs(Sum - previousSum);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
                previousSum = Sum;

            }

            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value = {0}", previousSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff = {0}", maxDiff);
            }

        }
    }
}