using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Training_Lab
{
    class Program
    {
        static void Main()
        {
            double w = double.Parse(Console.ReadLine()) * 100;
            double h = double.Parse(Console.ReadLine()) * 100;

            double rows = Math.Truncate(w / 120);
            double cols = Math.Truncate((h - 100) / 70);
            double seats = rows * cols;
            Console.WriteLine(seats -3);

        }
    }
}
