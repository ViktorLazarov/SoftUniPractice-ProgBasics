using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lectures = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double moneyPerLecture = budget / lectures;
            
            double jelevSalary = 0;
            double royalSalary = 0;
            double roliSalary = 0;
            double trofonSalary = 0;
            double sinoSalary = 0;
            double othersSalary = 0;
          
            for (int i = 0; i < lectures; i++)
            {
                string trainer = Console.ReadLine();
                switch (trainer)
                {
                    case "Jelev":jelevSalary += moneyPerLecture; break;
                    case "RoYaL":royalSalary += moneyPerLecture; break;
                    case "Roli":roliSalary += moneyPerLecture; break;
                    case "Trofon":trofonSalary += moneyPerLecture; break;
                    case "Sino":sinoSalary += moneyPerLecture; break;
                    default:othersSalary += moneyPerLecture;
                        break;
                }
            }
            Console.WriteLine($"Jelev salary: {jelevSalary:f2} lv");
            Console.WriteLine($"RoYaL salary: {royalSalary:f2} lv");
            Console.WriteLine($"Roli salary: {roliSalary:f2} lv");
            Console.WriteLine($"Trofon salary: {trofonSalary:f2} lv");
            Console.WriteLine($"Sino salary: {sinoSalary:f2} lv");
            Console.WriteLine($"Others salary: {othersSalary:f2} lv");
        }
    }
}
