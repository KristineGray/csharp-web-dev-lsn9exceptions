using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            try
            {
                return Math.Round((x / y), 2);
            }
            catch (ArithmeticException)
            {
                Console.WriteLine($"ERROR! Cannot divide by 0.");
                return 0;
            }
        }

        
        static int CheckFileExtension(string fileName)
        {
            // Returns int representing how many points earned for properly submitting a file in C#
            // Returns 1 if file ends in .cs
            // Returns 0 if doesn't end in .cs
            // Throws an exception if file submitted is null or an empty string


            try 
            {
                
                string correctFile = ".cs";
                string fileNameEnding = fileName.Substring((fileName.Length - 3), 3);
                if (fileNameEnding == correctFile)
                    return 1;
                else
                    return 0;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("ERROR! Submitted string's index is out of range.");
                return 0;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("ERROR! Submitted string is out of range");
                return 0;
            }
            
        }
        

        static void Main(string[] args)
        {

            // Test out your Divide() function here!
            Console.WriteLine("===== PART ONE =====");
            Console.WriteLine("Enter the number of points earned:");
            double numX = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the total number of points possible:");
            double numY = double.Parse(Console.ReadLine());
            double grade;
                        
            grade = Divide(numX, numY);
            Console.WriteLine($"The student earned {grade} point(s).");
            Console.WriteLine();
            

            Console.WriteLine("===== PART TWO =====");
            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> student in students)
            {
                Console.WriteLine();
                int points = CheckFileExtension(student.Value);
                Console.WriteLine($"{student.Key} earned {points} point(s) for the submission of file: {student.Value}");
            }
            Console.WriteLine("\nPress any key to exit program");
            Console.ReadKey();
        }
    }
}
