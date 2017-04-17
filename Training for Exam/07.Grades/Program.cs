using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfStudents = double.Parse(Console.ReadLine());
            double sumOfGrades = 0;
            double averageGrade = 0;
            int topStudents = 0;
            int veryGoodStudents = 0;
            int goodStudents = 0;
            int failedStudents = 0;
            double top = 0;
            double veryGood = 0;
            double good = 0;
            double failed = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 3.00)
                {
                    failedStudents++;
                }
                else if (grade >= 3.00 && grade < 4.00)
                {
                    goodStudents++;
                }
                else if (grade >= 4.00 && grade < 5.00)
                {
                    veryGoodStudents++;
                }
                else if (grade >= 5.00)
                {
                    topStudents++;
                }
                sumOfGrades += grade;
            }
            top = 100 / (numberOfStudents / topStudents);
            veryGood = 100 / (numberOfStudents / veryGoodStudents);
            good = 100 / (numberOfStudents / goodStudents);
            failed = 100 / (numberOfStudents / failedStudents);
            averageGrade = sumOfGrades / numberOfStudents;
            Console.WriteLine($"Top students: {top:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {veryGood:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {good:f2}%");
            Console.WriteLine($"Fail: {failed:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");

            

        }
    }
}
