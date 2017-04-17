using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());

            double j = (x / w) / m;
            Console.WriteLine(Math.Ceiling(j));

        }
    }
}
