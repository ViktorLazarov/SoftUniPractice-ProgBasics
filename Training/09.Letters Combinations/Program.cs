using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char excluded = char.Parse(Console.ReadLine());
            int count = 0;
            for (char i = start; i <= end; i++)
            {
                if (i != excluded)
                {
                    for (char j = start; j <= end; j++)
                    {
                        if (j != excluded)
                        {
                            for (char k = start; k <= end; k++)
                            {
                                if (k != excluded)
                                {

                                    Console.Write($"{i}{j}{k}");
                                    Console.Write(' ');
                                    count++;
                                }
                                
                                
                            }
                        }
                        
                    }
                }
                

            }
            Console.WriteLine(count);
        }
    }
}
