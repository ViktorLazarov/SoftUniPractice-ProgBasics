using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string(' ', n + 1));
            Console.Write("|");
            Console.WriteLine(new string(' ', n + 1));
            int stars = 1;
            int spaces = n - 1;
            for (int j = 0; j < n; j++)
            {
                Console.Write(new string(' ',spaces));
                Console.Write(new string('*', stars));
                Console.Write(" | ");
                Console.WriteLine(new string('*', stars));
                stars += 1;
                spaces -= 1;

            }


        }
    }
}
