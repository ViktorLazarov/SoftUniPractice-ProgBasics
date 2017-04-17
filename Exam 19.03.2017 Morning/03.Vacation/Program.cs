    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _03.Vacation
    {
        class Program
        {
            static void Main(string[] args)
            {
                double budget = double.Parse(Console.ReadLine());
                string season = Console.ReadLine();
                string location;
                string place;

                if (budget <= 1000)
                {
                    place = "Camp";
                    if (season == "Summer")
                    {
                        location = "Alaska";
                        Console.WriteLine($" {location} - {place} - {budget * 0.65:f2}");
                    }
                    else if (season == "Winter")
                    {
                        location = "Morocco";
                        Console.WriteLine($" {location} - {place} - {budget * 0.45:f2}");
                    }

                }
                else if (budget > 1000 && budget <= 3000)
                {
                    place = "Hut";
                    if (season == "Summer")
                    {
                        location = "Alaska";
                        Console.WriteLine($" {location} - {place} - {budget * 0.80:f2}");
                    }
                    else if (season == "Winter")
                    {
                        location = "Morocco";
                        Console.WriteLine($" {location} - {place} - {budget * 0.60:f2}");
                    }
                }
                else if (budget > 3000)
                {
                    place = "Hotel";
                    if (season == "Summer")
                    {
                        location = "Alaska";
                        Console.WriteLine($" {location} - {place} - {budget * 0.90:f2}");
                    }
                    else if (season == "Winter")
                    {
                        location = "Morocco";
                        Console.WriteLine($" {location} - {place} - {budget * 0.90:f2}");
                    }
                }


            }
        }
    }
