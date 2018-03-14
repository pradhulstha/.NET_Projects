using System;
using System.IO;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable to count the loop iterations.
            int count = 1, even;
            StreamWriter sw = new StreamWriter("C:\\Users\\prash\\Desktop\\IS_250_Shrestha_Chadani\\TEXT.txt");

           
            // Display "Hello" in a message box five times.
            while (count <= 20)
            {
                // Display the message box.
                Console.WriteLine("The odd numbers are(0-20): " + count);
                //Write a line of text
                sw.WriteLine("The odd numbers are(0-20): " + count);
                // Add one to count.
                count = count + 2;
            }
            Console.WriteLine("\n**********************************\n");
            //Write a line of text
            sw.WriteLine("\n**********************************\n");


            //printing even numbers.
            for (even = 1; even <= 10; even++)
            {
                Console.WriteLine("The even numbers are(0-20): " + even * 2);
                //Write a line of text
                sw.WriteLine("The even numbers are(0-20): " + even * 2);

            }
            //Close the file
            sw.Close();
            Console.WriteLine("\nPress a key to exit");
            Console.ReadKey();

            
        }
    }
}
