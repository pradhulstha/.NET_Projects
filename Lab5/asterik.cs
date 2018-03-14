using System;
using System.IO;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable
            int count, two;
            //Program
            for (int num = 1; num <= 6; num++)
            {
                for (two = 1; two <= 6; two++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");
            }
            
                Console.WriteLine("Press any key to exit.");
                Console.ReadLine();
            



        }
    }
}
