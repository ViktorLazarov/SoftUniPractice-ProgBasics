using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //top part
            Console.Write('+');
            for (int i = 0; i < n-2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
            //middle part
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write('|');
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            // bottom part
            Console.Write('+');
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
