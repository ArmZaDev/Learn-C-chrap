using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Shape
            Console.WriteLine("     /|");
            Console.WriteLine("    / |");
            Console.WriteLine("   /  |");
            Console.WriteLine("  /   |");
            Console.WriteLine(" /____|");
            */
            /*
            //Variable
            string charecterName = "Yousuke";
            int charecterAge;
            charecterAge = 21;

            Console.WriteLine("There onec was a man name " + charecterName);
            Console.WriteLine("Ha was " + charecterAge + " years old");
            
            charecterName = "Sasuke";
            Console.WriteLine("He really like the name " + charecterName);
            Console.WriteLine("But did't like being " + charecterAge);
            Console.ReadKey();
            */
            /*
            //Data Types
            string phrase = "Whiteblack Academy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.3;
            bool isMale = true;
            */
            /*
            //Working With Strings
            string Aca = "Whiteblack Academy";
            Console.WriteLine("White\nblack Academy");
            Console.WriteLine(Aca);
            Console.WriteLine(Aca.Length);
            Console.WriteLine(Aca[0]);
            Console.WriteLine( Aca.Substring(Aca.IndexOf("Academy")) );
            Console.WriteLine("Uper = {0} \nLower = {1}", Aca.ToUpper(), Aca.ToLower());
            Console.ReadLine();
            */
            /*
            //Working With Number
            int num = -26;
            
            Console.WriteLine(5 / 2.0);
            Console.WriteLine(num);
            Console.WriteLine(Math.Abs(num));
            Console.WriteLine(Math.Pow(3 , 2));
            Console.WriteLine(Math.Sqrt(num));
            Console.WriteLine(Math.Max(6, 2));
            Console.WriteLine(Math.Min(6, 2));
            Console.WriteLine(Math.Round(2.0));
            Console.ReadLine();
            */
            /*
            //Getting User input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);
            Console.ReadKey();
            */
            /*
            //Building a Calculator
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter anoter nuber: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result = {0}",num1 + num2);
            Console.ReadKey();
            */
            /*
            //Building a Mad Lib
            string color, pluraNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a plura noun: ");
            pluraNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluraNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);
            Console.ReadLine();
            */
            /*
            //Arrays
            int[] luckyNumber = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[2];
            friends[0] = "jim";
            friends[1] = "kelly";

            luckyNumber[2] = 80;

            Console.WriteLine(luckyNumber[0]);
            */
            /*
            //Methods      
            SayHi01();

            SayHi02("Mike", 29);
            SayHi02("John", 21);
            SayHi02("Tom", 15);
            Console.ReadLine();
            */
            /*
            //Return Statement
            Console.WriteLine(cube(5));
            int cubeNumber = cube(6);
            Console.WriteLine(cubeNumber);
            Console.ReadKey();
            */

            //If Statement
            /* If I'm hungry
                    I eat breakfast

               I look at my phone
               if it's about to die
                    I charge it

               I leave my phone
               if it's cloudy
                    I bring an umbrella
               otherwise
                    I bring sunglasses
             */

        }
        //Methods
        static void SayHi01()
        {
            Console.WriteLine("Hello User");
        }

        static void SayHi02(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        //Return Statement
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        
    }
}
