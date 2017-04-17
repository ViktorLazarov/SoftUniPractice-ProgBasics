using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num);
                    Console.Write(' ');
                    num++;
                    if (num > n)
                    {
                        Console.WriteLine();
                        return;
                    }
                    
                }
                Console.WriteLine();
            }


        }
    }
}
