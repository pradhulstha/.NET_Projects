using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grader
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGrades;
            int numToPercent;

            Console.Write("Please Enter your Number Grade Out of 25: ");
            numGrades = int.Parse(Console.ReadLine());

            numToPercent = numGrades * 4;

            if (numToPercent >= 90 && numToPercent <= 100)
                Console.WriteLine("\nCongrats! Your letter grade is 'A'. ");

            else if (numToPercent >= 80 && numToPercent < 90)
                Console.WriteLine("\nYou can make it to A! Your letter grade is 'B'. ");

            else if (numToPercent >= 70 && numToPercent < 80)
                Console.WriteLine("\nKeep Working hard! Your letter grade is 'C'. ");

            else if (numToPercent >= 60 && numToPercent < 70)
                Console.WriteLine("\nYou can do better than this! Your letter grade is 'D'. ");

            else if (numToPercent >= 50 && numToPercent < 60)
                Console.WriteLine("\nWork Harder! Your letter grade is 'E'. ");

            else
                Console.WriteLine("\nFailed! Do your Exams well.Your grade: 'F'. ");

            Console.Write("\nPress any key to exit. ");
            Console.ReadKey();
            Environment.Exit(0);

            
        }
    }
}
