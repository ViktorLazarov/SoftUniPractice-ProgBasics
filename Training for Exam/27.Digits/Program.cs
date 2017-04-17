using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] number = n.ToString().ToCharArray();
            int rows = int.Parse(number[0].ToString()) + int.Parse(number[1].ToString());
            int cols = int.Parse(number[0].ToString()) + int.Parse(number[2].ToString());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (n % 5 == 0)
                    {
                        n -= int.Parse(number[0].ToString());
                    }
                    else if (n % 3 == 0)
                    {
                        n -= int.Parse(number[1].ToString());
                    }
                    else
                    {
                        n += int.Parse(number[2].ToString());
                    }
                    Console.Write("{0} ",n);
                }
                Console.WriteLine();
            }

        }
    }
}
