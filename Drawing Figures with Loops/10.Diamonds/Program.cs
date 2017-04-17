using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamonds
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else if (n == 2)
            {
                Console.WriteLine("**");
            }
            else if (n % 2 == 1)
            {
                int dashes = n / 2;
                int middleDashes = 1;
                Console.Write(new string('-', dashes));
                Console.Write('*');
                Console.WriteLine(new string('-', dashes));
                dashes--;

                for (int i = 0; i < (n-2) / 2; i++)
                {
                    
                    Console.Write(new string('-', dashes));
                    Console.Write('*');
                    Console.Write(new string('-', middleDashes));
                    Console.Write('*');
                    Console.WriteLine(new string('-', dashes));
                    dashes--;
                    middleDashes += 2;
                }
                
                for (int i = n / 2; i > 0; i--)
                {
                    
                    Console.Write(new string('-', dashes));
                    Console.Write('*');
                    Console.Write(new string('-', middleDashes));
                    Console.Write('*');
                    Console.WriteLine(new string('-', dashes));
                    dashes++;
                    middleDashes -= 2;

                }
                
                Console.Write(new string('-', dashes));
                Console.Write('*');
                Console.WriteLine(new string('-', dashes));

            }
            else
            {
                int dashes = (n - 2) / 2;
                
                Console.Write(new string('-', dashes));
                Console.Write("**");
                Console.WriteLine(new string('-', dashes));
                dashes--;

                for (int i = 0; i < ((n - 2) / 2); i++)
                {
                   
                    int middleDashes = (n - 2) - (2 * dashes);
                    Console.Write(new string('-', dashes));
                    Console.Write('*');
                    Console.Write(new string('-', middleDashes));
                    Console.Write('*');
                    Console.WriteLine(new string('-', dashes));
                    dashes--;

                }
                dashes++;
                for (int i = ((n - 2) / 2); i > 1 ; i--)
                {
                    dashes++;
                    int middleDashes = (n - 2) - (2 * dashes);
                    Console.Write(new string('-', dashes));
                    Console.Write('*');
                    Console.Write(new string('-', middleDashes));
                    Console.Write('*');
                    Console.WriteLine(new string('-', dashes));
                    

                }
                dashes++;
                Console.Write(new string('-', dashes));
                Console.Write("**");
                Console.WriteLine(new string('-', dashes));


            }
        }
    }
}
