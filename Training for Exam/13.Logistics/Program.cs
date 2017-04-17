using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCargos = int.Parse(Console.ReadLine());
            double totalWeight = 0;
            int pricePerTon = 0;
            double totalPrice = 0;
            double averagePrice = 0;
            int bus = 0;
            int cargoTruck = 0;
            int train = 0;
            double busUsed;
            double cargoTruckUsed;
            double trainUsed;

            for (int i = 0; i < numberOfCargos; i++)
            {
                int cargoWeight = int.Parse(Console.ReadLine());
                if (cargoWeight <= 3)
                {
                    pricePerTon = 200;
                    bus += cargoWeight;
                }
                else if (cargoWeight >= 4 && cargoWeight <= 11)
                {
                    pricePerTon = 175;
                    cargoTruck += cargoWeight;
                }
                else if (cargoWeight > 11)
                {
                    pricePerTon = 120;
                    train += cargoWeight;
                }
                totalPrice += cargoWeight * pricePerTon;
                totalWeight += cargoWeight;
            }
            averagePrice = totalPrice / totalWeight;
            busUsed = (bus / totalWeight) * 100;
            cargoTruckUsed = (cargoTruck / totalWeight) * 100;
            trainUsed = (train / totalWeight) * 100;
            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{busUsed:f2}%");
            Console.WriteLine($"{cargoTruckUsed:f2}%");
            Console.WriteLine($"{trainUsed:f2}%");



        }
    }
}
