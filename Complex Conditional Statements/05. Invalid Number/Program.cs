﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Invalid_Number
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var isNumberValid = number >= 100 && number <= 200 || number == 0;

            if (!isNumberValid)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
