using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Stupid_Password_Generator
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char l1 = 'a'; l1 < 'a' + l; l1++)
                    {
                        for (char l2 = 'a'; l2 < 'a' + l; l2++)
                        {
                            for (int d = Math.Max(i,j)+1; d <=n; d++)
                            {
                                Console.Write($"{i}{j}{l1}{l2}{d} ");
                            
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            



        }
    }
}
