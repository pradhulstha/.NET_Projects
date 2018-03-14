using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Shrestha_Chadani_IS250
{
    class Program
    {
        static void Main(string[] args)
        {
            double raceTime1, raceTime2, raceTime3, raceTime4;
            double averageTime, totalTime;

            

            Console.Write("Enter the Four Race Time for four Athletes:\n");
            Console.Write("Race Time 1 for Athelete 1: ");
            raceTime1 = double.Parse(Console.ReadLine());

            Console.Write("Race Time 2 for Athelete 2: ");
            raceTime2 = double.Parse(Console.ReadLine());

            Console.Write("Race Time 3 for Athelete 3: ");
            raceTime3 = double.Parse(Console.ReadLine());

            Console.Write("Race Time 4 for Athelete 4: ");
            raceTime4 = double.Parse(Console.ReadLine());

            totalTime = (raceTime1 + raceTime2 + raceTime3 + raceTime4);
            averageTime = totalTime/4.0;

            Console.WriteLine("\nThe total time for 4 Athelete: " + totalTime);
            Console.WriteLine("\nThe average time for 4 Athelete: " + averageTime);

            Console.WriteLine("\nThank you for using the program. \nPress any key to Exit.");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
