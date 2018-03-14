using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        public static String FirstName, LastName, DateofBirth, City, State;
        public static double ExamScore;

        static void Main(string[] args)
        {
           

            Console.WriteLine("Hi, Please fill in the following Info. ");
            Console.Write("\nStudent's First Name: ");
            FirstName = Console.ReadLine();

            Console.Write("\nStudent's Last Name: ");
            LastName = Console.ReadLine();

            Console.Write("\nStudent's Date of Birth(dd/mm/yy): ");
            DateofBirth = Console.ReadLine();

            Console.Write("\nStudent's City: ");
            City = Console.ReadLine();

            Console.Write("\nStudent's State: ");
            State = Console.ReadLine();

            Console.Write("\nStudent's Exam Score(100): ");
            ExamScore = double.Parse(Console.ReadLine());

            //Displaying User Info
            DisplayUser();

            

            GradeCalculator(LastName, ExamScore);

            Console.Write("\n\nPress any key to Exit. ");
            Console.ReadKey();
            Environment.Exit(0);

        }

        static void DisplayUser()
        {
            Console.WriteLine("\n\nStudent Information: ");
            Console.WriteLine("Student Name: " + FirstName + LastName);
            Console.WriteLine("Student City: " + City);
            Console.WriteLine("Student State: "+ State);
            Console.WriteLine(CalculateAge());
            Console.WriteLine("Student Exam Score(100): " + ExamScore + "/100\n\n");
        }

        static int CalculateAge()
        {
            int Age;
            DateTime dob = Convert.ToDateTime(DateofBirth);
            Age = DateTime.Now.Year - dob.Year;

            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                Age = Age - 1;

            Console.Write("Student Age(Calculate Age Function): ");

            return Age;

        }
        static void GradeCalculator(String lastName, double ExamScore)
        {
            Console.WriteLine("\nExam Score of " + lastName + " is: " + ExamScore + "/100. ");
        }
    }
}
