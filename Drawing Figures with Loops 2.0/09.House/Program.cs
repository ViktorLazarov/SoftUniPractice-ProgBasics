using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            else
            {
                stars = 1;
            }
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.Write(new string('-', (n - 1) / 2 - i));
                Console.Write(new string('*', stars + 2 * i));
                Console.WriteLine(new string('-', (n - 1) / 2 - i));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', n - 2));
                Console.WriteLine('|');
            }
        }
    }
}