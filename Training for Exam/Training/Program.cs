using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int h = 1; h <= 9; h++)
                        {
                            for (int g = 1; g <= 9; g++)
                            {
                                for (int f = 1; f <= 9; f++)
                                {
                                    int result = i * j * k * h * g * f;
                                    if (result == n)
                                    {
                                        Console.Write($"{i}{j}{k}{h}{g}{f} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
