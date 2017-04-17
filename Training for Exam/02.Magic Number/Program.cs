using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Magic_Number
{
    class Program
    {  
        static void Main(string[] args)
        {
            // NOT USABLE
            int n = int.Parse(Console.ReadLine());

            for (int i = 111111; i <= 999999; i++)
            {
                char[] arr = i.ToString().ToCharArray();
                int result = int.Parse(arr[0].ToString()) * int.Parse(arr[1].ToString()) * int.Parse(arr[2].ToString()) *
                                int.Parse(arr[3].ToString()) * int.Parse(arr[4].ToString()) * int.Parse(arr[5].ToString());
                if (result == n)
                {
                    Console.Write($"{arr[0]}{arr[1]}{arr[2]}{arr[3]}{arr[4]}{arr[5]} ");
                }
            }
            //

        }
    }
}
