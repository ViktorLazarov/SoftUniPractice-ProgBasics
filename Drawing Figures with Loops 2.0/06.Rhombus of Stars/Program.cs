using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // top part
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write('*');
                for (int col = 1; col <= row - 1; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            // bottom part

            for (int row = n-1; row >= 1; row--)
            {
                Console.Write(new string(' ', n - row));
                Console.Write('*');
                for (int col = 1; col <= row - 1; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
