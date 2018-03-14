using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string displayName= "John Doe";   //initializing name

            Console.WriteLine("\n\nIs this your Name: " + displayName + "?");
            
            Console.Write("\n\nEnter your real name: ");
            displayName= Console.ReadLine();

            Console.WriteLine("\n\nHi, "+ displayName + "! Thank you for using my program. \nPress a key to exit.");
            Console.ReadKey();
            Environment.Exit(0);
            
        }
    }
}
