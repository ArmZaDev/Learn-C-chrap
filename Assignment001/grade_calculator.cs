using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade cal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if, if else, if else if else
            //grade calculator
            int score = 0;
            string grade = "";

            Console.Write("Input your Grade: ");

            int.TryParse(Console.ReadLine(), out score);
            if (score >= 80 && score <= 100)
            {
                grade = "A";
            }
            else if (score >= 75 && score <= 79) // B+ = 75~79
            {
                grade = "B+";
            }
            else if (score >= 70 && score <= 74) // B = 70~74
            {
                grade = "B";
            }
            else if (score >= 65 && score <= 69) // C+ = 65~69
            {
                grade = "C+";
            }
            else if (score >= 60 && score <= 64) // C = 60~64  
            {
                grade = "C";
            }
            else if (score >= 55 && score <= 59) // D+ = 55~59
            {
                grade = "D+";
            }
            else if (score >= 50 && score <= 54) // D = 50~54
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            Console.WriteLine("score = {0}" + "\n" + "grade = {1}", score, grade);
            Console.ReadKey();
        }
    }
}