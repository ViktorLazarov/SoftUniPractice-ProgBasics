using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = start; i >= end; i--)
            {
                for (int j = start; j >= end; j--)
                {
                    count++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNumber})");
                        return;
                    }

                }
            }

            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");

        }
    }
}
