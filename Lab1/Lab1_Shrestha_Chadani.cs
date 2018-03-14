using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int Hours;
            double PayRate, GrossPay;
            
           
            // Get data entered by the user.
            Console.WriteLine("Enter Hours Worked:");
            Hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Hourly PayRate:");
            PayRate = double.Parse(Console.ReadLine());


            //Calculate the gross pay.
            GrossPay = Hours * PayRate;

            //Display the gross pay in message box.
            Console.WriteLine("The Gross Pay is: " + GrossPay + (" $"));
            Console.WriteLine("\nClick any key to close");
            Console.ReadKey();

                
        }
    }
}
