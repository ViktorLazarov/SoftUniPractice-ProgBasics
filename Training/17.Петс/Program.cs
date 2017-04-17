using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Петс
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double tortoiseFoodPerDay = double.Parse(Console.ReadLine())/1000;
            double foodEaten = dogFoodPerDay * days + catFoodPerDay * days + tortoiseFoodPerDay * days;
            if (food>=foodEaten)
            {
                Console.WriteLine($"{Math.Floor(food-foodEaten)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodEaten-food)} more kilos of food are needed.");
                    
            }




        }
    }
}
