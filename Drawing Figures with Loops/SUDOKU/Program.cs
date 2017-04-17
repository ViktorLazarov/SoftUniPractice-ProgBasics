using System;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] rank = { "Gold", "Silver", "Bronze" };
            bool isQuit = false;
            int count = 0;
            double totalSeconds = 0.0;
            double averageScore = 0.0;

            while (!isQuit)
            {
                string input = Console.ReadLine();

                if (input == "Quit")
                {
                    isQuit = true;
                }
                else
                {
                    string[] time = input.Split(':');
                    int seconds = int.Parse(time[0]) * 60 + int.Parse(time[1]);
                    totalSeconds += seconds;
                    count++;
                    
                }
            }
            averageScore = Math.Ceiling(totalSeconds / count);
            if (averageScore < 720)
            {
                Console.WriteLine($"{rank[0]} Star");
                Console.WriteLine($"Games - {count} \\ Average seconds - {averageScore}");
            }
            else if (averageScore >= 720 && averageScore<= 1440)
            {
                Console.WriteLine($"{rank[1]} Star");
                Console.WriteLine($"Games - {count} \\ Average seconds - {averageScore}");
            }
            else if (averageScore > 1440)
            {
                Console.WriteLine($"{rank[2]} Star");
                Console.WriteLine($"Games - {count} \\ Average seconds - {averageScore}");
            }
        }
    }
}
