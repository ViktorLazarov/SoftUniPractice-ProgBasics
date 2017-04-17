using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dashes = (((n * 2) + 3)) - 4;
            int stars = n;
            //top part
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{new string('*',i)}\\{new string('-',dashes)}/{new string('*', i)}");
                dashes -= 2;
            }
            //middle part
            for (int i = 0; i < n/3; i++)
            {

                Console.WriteLine($"|{new string('*',(((((n*2)+3)-stars))-4)/2)}\\{new string('*',stars)}/{new string('*', (((((n * 2) + 3) - stars)) - 4)/2)}|");
                stars -= 2;
            }
            //bottom part
            dashes = (((n * 2) + 3)) - 4; ;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{new string('-', i)}\\{new string('*', dashes)}/{new string('-', i)}");
                dashes -= 2;
            }
        }
    }
}
