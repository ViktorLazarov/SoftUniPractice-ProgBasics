using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Dateafter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            string month = Console.ReadLine();

            DateTime today = DateTime.ParseExact(day + "." + month + "." + "2001", "d.M.yyyy", null);

            DateTime dayAfter5Days = today.AddDays(5);

            Console.WriteLine("{0:d.MM}",dayAfter5Days);


        }
    }
}