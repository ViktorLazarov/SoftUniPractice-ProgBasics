using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int seniors = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();
            double transportFeeSeniors = 0;
            double transportFeeStudents = 0;
            switch (transport)
            {
                case "train": transportFeeSeniors = 24.99; transportFeeStudents = 14.99; break;
                case "bus": transportFeeSeniors = 32.50; transportFeeStudents = 28.50; break;
                case "boat": transportFeeSeniors = 42.99; transportFeeStudents = 39.99; break;
                case "airplane": transportFeeSeniors = 70.00; transportFeeStudents = 50.00; break;
            }
            if (seniors + students >= 50 && transport == "train")
            {
                transportFeeSeniors /= 2;
                transportFeeStudents /= 2;
            }
            double transportExpence = (seniors * transportFeeSeniors + students * transportFeeStudents) * 2;
            double sleepExpence = nights * 82.99;
            double comission = (transportExpence + sleepExpence) * 0.10;
            double totalExpence = transportExpence + sleepExpence + comission;
            Console.WriteLine($"{totalExpence:f2}");
        }
    }
}
