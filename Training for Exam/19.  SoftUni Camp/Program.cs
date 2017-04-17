using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());
            double car = 0;
            double microBus = 0;
            double smallBus = 0;
            double bigBus = 0;
            double train = 0;
            double totalNumberOfStudents = 0;
            for (int i = 0; i < numberOfGroups; i++)
            {
                int students = int.Parse(Console.ReadLine());
                totalNumberOfStudents += students;
                if (students <=5)
                {
                    car+=students;
                }
                else if(students>5 & students<=12)
                {
                    microBus+=students;
                }
                else if (students>12 && students<=25)
                {
                    smallBus+=students;
                }
                else if (students>25 && students<=40)
                {
                    bigBus+=students;
                }
                else if (students>40)
                {
                    train+=students;
                }
            }
            double travelByCar = (car / totalNumberOfStudents) * 100;
            double travelByMicroBus = (microBus / totalNumberOfStudents) * 100;
            double travelBySmallBus = (smallBus / totalNumberOfStudents) * 100;
            double travelByBigBus = (bigBus / totalNumberOfStudents) * 100;
            double travelByTrain = (train / totalNumberOfStudents) * 100;
            Console.WriteLine($"{travelByCar:f2}%");
            Console.WriteLine($"{travelByMicroBus:f2}%");
            Console.WriteLine($"{travelBySmallBus:f2}%");
            Console.WriteLine($"{travelByBigBus:f2}%");
            Console.WriteLine($"{travelByTrain:f2}%");
        }
    }
}
