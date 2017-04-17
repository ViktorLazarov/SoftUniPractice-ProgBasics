using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursOfExam = int.Parse(Console.ReadLine()) * 60;
            int minutesOfExam = int.Parse(Console.ReadLine());
            int hoursOfArrival = int.Parse(Console.ReadLine()) * 60;
            int minutesOfArrival = int.Parse(Console.ReadLine());
            int diff = (hoursOfExam + minutesOfExam) - (hoursOfArrival + minutesOfArrival);

            if (diff <= 30 && diff > 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", diff);
            }
            else if (diff > 30 && diff <= 59)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start", diff);

            }
            else if (diff > 59)
            {
                int hours = diff / 60;
                int minutes = diff % 60;
                Console.WriteLine("Early");
                Console.WriteLine($"{hours}:{minutes:00} hours before the start");
            }
            else if (diff < 0 && diff >= -59)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", Math.Abs(diff));
            }
            else if (diff <= -60)
            {
                int hours = Math.Abs(diff) / 60;
                int minutes = Math.Abs(diff) % 60;
                Console.WriteLine("Late");
                Console.WriteLine($"{hours}:{minutes:00} hours after the start");
            }
            else if (diff == 0 )
            {
                Console.WriteLine("On time");
            }



        }
    }
}
