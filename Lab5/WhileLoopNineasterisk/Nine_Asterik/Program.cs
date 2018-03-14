using System;
using System.IO;

namespace Nine_Asterik
{
    class Program
    {
        static void Main(string[] args)
        {
            String line; 

            //Reading from the  file;
            StreamReader sr = new StreamReader("C:\\Users\\prash\\Desktop\\IS_250_Shrestha_Chadani\\nine_asterisk.txt");

            //Read the first line of text
            line = sr.ReadLine();

            
            Console.WriteLine("Reading from the file: " + line);

            //Writing to the output file
            StreamWriter sw = new StreamWriter("C:\\Users\\prash\\Desktop\\IS_250_Shrestha_Chadani\\output.txt");
            sw.WriteLine(line);

            Console.WriteLine("Outputting to the file: " + line);

            //Close the file
            sw.Close();
            Console.WriteLine("\nPress a key to exit");
            Console.ReadKey();

        }
    }
}
