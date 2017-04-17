using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main()
        {
            //char[] input = Console.ReadLine().ToCharArray();
            //int result = 0;
            //for (int i = 0; i < input.Length-1; i++)
            //{
            //    result += int.Parse(input[i].ToString());
            //}
            //Console.WriteLine(result);

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            do
            {
                sum += n % 10;
                n /= 10;

            } while (n > 0);
            Console.WriteLine(sum);
        }
    }
}
