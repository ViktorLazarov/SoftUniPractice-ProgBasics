using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int middleDashes = 0;
            //top part
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",new string('-',3*n),new string('-',middleDashes),new string('-',(2* n)-(2+middleDashes)));
                middleDashes++;
            }
            middleDashes--;
            //middle part
            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}", new string('*', 3 * n), new string('-', middleDashes));
            }


            //bottom part
            int leftDashes = 3 * n;
            int rightDashes = (2 * n - 2) - middleDashes;
            for (int i = 1; i <=(n/2)-1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', middleDashes),new string('-',rightDashes));
                middleDashes += 2;
                leftDashes--;
                rightDashes--;
            }
            //last row
            Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('*', middleDashes), new string('-', rightDashes));

        }
    }
}
