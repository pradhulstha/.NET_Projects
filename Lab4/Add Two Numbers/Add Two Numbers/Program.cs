using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1, number2 = 0, addNum, subNum;

            Console.WriteLine("Please input the two Numbers to add/subtract: ");
            Console.Write("\nNumber 1: ");
            number1 = float.Parse(Console.ReadLine());

            Console.Write("\nNumber 2: ");
            number2 = float.Parse(Console.ReadLine());

            addNum = number1 + number2;
            Console.WriteLine("\nAdding the Numbers = " + addNum);

            subNum = number1 - number2;
            if (subNum < 0)
                Console.WriteLine("\nSorry, 1st Number must be greater.");
            else {
                
                Console.WriteLine("\nSubtracting the Numbers = "+ subNum);
            }

            Console.Write("\nPress any key to exit. ");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
