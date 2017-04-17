using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // top part
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
            // middle part
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('*');
                Console.Write(new string('/', n * 2 - 2));
                Console.Write('*');

                if (i == (n - 1) / 2 - 1)
                {
                    Console.Write(new string('|', n));
                    
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                
                Console.Write('*');
                Console.Write(new string('/', n * 2 - 2));
                Console.WriteLine('*');



            }
            // bottom part
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));


        }
    }
}
