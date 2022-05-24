using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_cal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BMI
            double weight = 0, height = 0;
            //input
            Console.Write("Input Weight (kg): ");
            double.TryParse(Console.ReadLine(), out weight);

            Console.Write("Input Height (cm): ");
            double.TryParse(Console.ReadLine(), out height);

            //Procees
            height /= 100; //แปลงเป็น (m)
            double bmi = weight / Math.Pow(height, 2);

            //output
            Console.WriteLine("BMI = {0:F2}", bmi);
            Console.ReadKey();
        }
    }
}