using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;
            switch (month)
            {
                case "May":
                case "October": studioPrice = 50; apartmentPrice = 65; break;
                case "June":
                case "September": studioPrice = 75.2; apartmentPrice = 68.70; break;
                case "July":
                case "August": studioPrice = 76; apartmentPrice = 77; break;

            }
            
            if (nights > 14)
            {
                apartmentPrice = apartmentPrice * 0.90;
            }
            if (nights > 7 && nights <= 14 && (month == "May" || month == "October"))
            {
                studioPrice = studioPrice * 0.95;

            }
            else if (nights > 14 && (month == "May" || month == "October"))
            {
                studioPrice = studioPrice * 0.70;
            }
            else if (nights > 14 && (month == "June" || month == "September"))
            {
                studioPrice = studioPrice * 0.80;
            }
            double studioTotal = nights * studioPrice;
            double apartmentTotal = nights * apartmentPrice;
            Console.WriteLine($"Apartment: {apartmentTotal:f2} lv.");
            Console.WriteLine($"Studio: {studioTotal:f2} lv.");
        }
    }
}
