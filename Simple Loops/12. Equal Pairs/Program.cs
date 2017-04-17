using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] pairs = new double[n];
            double[] differences = new double[n - 1];
            double maxDiff = 0.0;
            bool isEqual = false;
            for (int i = 1; i <= n; i++)
            {
                double number1 = double.Parse(Console.ReadLine());
                double number2 = double.Parse(Console.ReadLine());
                pairs[i - 1] = number1 + number2;

            }
            for (int j = 0; j <= pairs.Length - 2; j++)
            {
                if (pairs[j] == pairs[j + 1])
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                }


            }
            for (int x = differences.Length-1; x >= 0; x--)
            {
                differences[x] = Math.Abs(pairs[x] - pairs[x + 1]);
                
            }
            if (n > 1)
            {
                maxDiff = differences.Max();
                if (isEqual)
                {
                    Console.WriteLine("Yes, value={0}", pairs[0]);
                }
                else
                {
                    Console.WriteLine("No, maxdiff={0}", maxDiff);

                }
            }
            else
            {
                Console.WriteLine("Yes, value={0}", pairs[0]);
            }


            


        }
    }
}
