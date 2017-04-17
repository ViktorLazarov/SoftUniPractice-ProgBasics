using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main()
        {
            string yearType = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsAtHome = double.Parse(Console.ReadLine());
            
            double weekendsInSofia = 48 - weekendsAtHome;
            double gamesInSofia = weekendsInSofia * 3.0 / 4;
            double gamesAtHome = weekendsAtHome;
            gamesInSofia += (holidays * 2.0 / 3);
            double totalGames = gamesInSofia + gamesAtHome;

            if (yearType == "leap")
            {
                totalGames += totalGames * 0.15;
                Console.WriteLine(Math.Floor(totalGames));
            }
            else if (yearType == "normal")
            {
                Console.WriteLine(Math.Floor(totalGames));
            }




        }
    }
}
