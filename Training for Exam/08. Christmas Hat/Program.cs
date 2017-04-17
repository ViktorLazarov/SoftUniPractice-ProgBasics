using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dashes = 0;
            int dots = ((4 * n + 1) - 3)/ 2;
            //top part
            Console.Write(new string('.', dots));
            Console.Write("/|\\");
            Console.WriteLine(new string('.', dots));
            Console.Write(new string('.', dots));
            Console.Write("\\|/");
            Console.WriteLine(new string('.', dots));
            //middle part
            for (int i = 0; i < n*2; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write("*");
                Console.Write(new string('-', dashes));
                Console.Write("*");
                Console.Write(new string('-', dashes));
                Console.Write("*");
                Console.WriteLine(new string('.', dots));
                dashes++;
                dots--;
                
            }
            //bottom part
            Console.WriteLine(new string('*', 4 * n + 1));
            Console.Write("*");
            for (int i = 1; i <=n*2; i++)
            {
                Console.Write(".*");
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
