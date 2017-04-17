    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _05.Hourglass
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());

                //top row
                Console.WriteLine(new string('*', 2 * n + 1));
                //second row
                Console.WriteLine($"{new string('.', 1)}*{new string(' ', (n * 2 + 1) - 4)}*{new string('.', 1)}");
                //first half
                for (int i = 2; i < n; i++)
                {
                    Console.WriteLine($"{new string('.', i)}*{new string('@', (((n * 2 + 1) - 2) - 2 * i))}*{new string('.', i)}");
                }
                Console.WriteLine($"{new string('.', n)}*{new string('.', n)}");
                //second half
                int spaces = 0;
                for (int i = n - 1; i >= 2; i--)
                {
                
                    Console.WriteLine($"{new string('.',i)}*{new string(' ',spaces)}@{new string(' ', spaces)}*{new string('.', i)}");
                    spaces++;

                }
                // bottom part
                Console.WriteLine($".*{new string('@',(n*2+1)-4)}*.");
            Console.WriteLine(new string('*',n*2+1));

            }
        }
    }
