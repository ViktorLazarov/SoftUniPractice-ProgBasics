using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 1)
            {
                int stars = 1;
                int dashes = n / 2;

                for (int i = 0; i < n / 2 + 1; i++)
                {
                    Console.Write(new string('-', dashes));
                    Console.Write(new string('*', stars));
                    Console.WriteLine(new string('-', dashes));
                    dashes -= 1;
                    stars += 2;
                }
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine("|");
                }

            }
            else
            {

                int stars = 2;
                int dashes = n / 2 - 1;

                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write(new string('-', dashes));
                    Console.Write(new string('*', stars));
                    Console.WriteLine(new string('-', dashes));
                    stars += 2;
                    dashes -= 1;


                }
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine("|");
                }

            }
        }
    }
}
