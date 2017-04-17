using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();


            }
            
        }
    }
}
