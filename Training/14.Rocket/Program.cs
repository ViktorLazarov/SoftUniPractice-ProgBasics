using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int spaces = 0;
            int dots = (((n * 3) - 2) - spaces) / 2;
            //top part
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{2}",new string('.',dots),new string(' ',spaces),new string('.',dots));
                spaces += 2;
                dots--;
            }
            dots++;
            Console.WriteLine("{0}{1}{2}",new string('.',dots),new string('*',n*2), new string('.', dots));
            //middle part
            for (int j = 0; j < n*2; j++)
            {
                Console.WriteLine("{0}|{1}|{2}", new string('.', dots), new string('\\', spaces-2), new string('.', dots));
            }
            //bottom part
            for (int k = 0; k < n/2; k++)
            {
                Console.WriteLine("{0}/{1}\\{2}", new string('.', dots), new string('*', spaces - 2), new string('.', dots));
                spaces += 2;
                dots--;
            }
        }
    }
}
