using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Variable_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            char middleInitial;

            Console.WriteLine("Please input your First Name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("\nPlease input your Last Name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("\nPlease input the First Letter of Middle Initial(Eg: W - Wendy): ");
            middleInitial = char.Parse(Console.ReadLine());
            middleInitial = Char.ToUpper(middleInitial);

            Console.WriteLine("Your Full Name: "+ firstName + " "+ middleInitial +". "+ lastName);
            Console.ReadKey();
            Environment.Exit(0);
           
        }
    }
}
