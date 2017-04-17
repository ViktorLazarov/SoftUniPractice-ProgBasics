using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
           
            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int i = 1; i <= days; i++)
            {
                int patientsForToday = int.Parse(Console.ReadLine());
               
                if ((i % 3 == 0) && (untreatedPatients > treatedPatients))
                {
                    doctors++;
                }
                if (patientsForToday <= doctors)
                {
                    treatedPatients += patientsForToday;

                }
                else
                {
                    treatedPatients += doctors;
                    untreatedPatients += patientsForToday - doctors;
                }
                


            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");

        }
    }
}
