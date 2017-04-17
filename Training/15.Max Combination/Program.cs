using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxCombinations = int.Parse(Console.ReadLine());
            int count = 0;


            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {

                    Console.Write($"<{i}-{j}>");
                    count++;
                    if (count == maxCombinations)
                    {
                        return;
                    }
                }
            }

        }
    }
}
