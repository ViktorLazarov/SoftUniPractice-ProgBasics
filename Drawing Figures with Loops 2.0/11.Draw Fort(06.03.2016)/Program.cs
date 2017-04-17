using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Draw_Fort_06._03._2016_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //top part
            Console.Write('/');
            Console.Write(new string('^', n / 2));
            Console.Write('\\');
            Console.Write(new string('_', (((n * 2) - 4) - (2 * (n / 2)))));
            Console.Write('/');
            Console.Write(new string('^', n / 2));
            Console.WriteLine('\\');
            //middle part
            for (int i = 1; i <= n - 3; i++)
            {
                Console.Write('|');
                Console.Write(new string(' ', (n * 2) - 2));
                Console.WriteLine('|');
            }
            //row before last row
            Console.Write('|');
            Console.Write(new string(' ', (n / 2) + 1));
            Console.Write(new string('_', ((n * 2) - 4) - (2 * (n / 2))));
            Console.Write(new string(' ', (n / 2) + 1));
            Console.WriteLine('|');


            //bottom part
            Console.Write('\\');
            Console.Write(new string('_', n / 2));
            Console.Write('/');
            Console.Write(new string(' ', (((n * 2) - 4) - (2 * (n / 2)))));
            Console.Write('\\');
            Console.Write(new string('_', n / 2));
            Console.WriteLine('/');

        }
    }
}
