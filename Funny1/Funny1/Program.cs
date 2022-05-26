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
            
            
            //Data Types
            string phrase = "Whiteblack Academy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.3;
            bool isMale = true;
           
           
            //Working With Strings
            string Aca = "Whiteblack Academy";
            Console.WriteLine("White\nblack Academy");
            Console.WriteLine(Aca);
            Console.WriteLine(Aca.Length);
            Console.WriteLine(Aca[0]);
            Console.WriteLine( Aca.Substring(Aca.IndexOf("Academy")) );
            Console.WriteLine("Uper = {0} \nLower = {1}", Aca.ToUpper(), Aca.ToLower());
            Console.ReadLine();
            
            
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
            
            
            //Getting User input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);
            Console.ReadKey();
            
            
            //Building a Calculator
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter anoter nuber: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result = {0}",num1 + num2);
            Console.ReadKey();
            
            
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
            
            
            //Arrays
            int[] luckyNumber = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[2];
            friends[0] = "jim";
            friends[1] = "kelly";

            luckyNumber[2] = 80;

            Console.WriteLine(luckyNumber[0]);
            
            
            //Methods      
            SayHi01();

            SayHi02("Mike", 29);
            SayHi02("John", 21);
            SayHi02("Tom", 15);
            Console.ReadLine();
            
            
            //Return Statement
            Console.WriteLine(cube(5));
            int cubeNumber = cube(6);
            Console.WriteLine(cubeNumber);
            Console.ReadKey();
            

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
            
            
            bool isMale = true;

            if (isMale)
            {
                Console.WriteLine("You are male"); //T
            }
            else
            {
                Console.WriteLine("You are not male");//T
            }
            Console.ReadKey();
            
            
            isMale = true;
            bool isTall = true;
            if(isMale && isTall)
            {
                Console.Write("You are a tall male"); //T & T
            }
            else
            {
                Console.WriteLine("You are either not male or not tall or both"); //T & F , F & F
            }
            Console.ReadKey();
            
            
            isMale = false;
            isTall = false;
            if (isMale || isTall)
            {
                Console.Write("You are a tall male"); 
            }
            else
            {
                Console.WriteLine("You are either not male or not tall or both");
            }
            Console.ReadKey();
            
            
            isMale = false;
            isTall = false;
            if (isMale && isTall)
            {
                Console.Write("You are a tall male"); // T & T
            }else if(isMale && !isTall)
            {
                Console.Write("You are a short male");//T & F
            }
            else if (!isMale && isTall)
            {
                Console.Write("You are not a male but you are tall"); //F & T
            }
            else
            {
                Console.WriteLine("You are not male and not tall");//F & F
            }
            Console.ReadKey();
            
            //if Statements (con't)
            Console.WriteLine(GetMax(6, 7, 200));
            Console.ReadKey();
            

            //Building a Better Calculator
            Console.Write("Enter a number: ");
            double Num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Opetor: ");
            string Op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double Num2 = Convert.ToDouble(Console.ReadLine());
            if (Op == "+")
            {
                Console.WriteLine(Num1 + Num2);
            }
            else if (Op == "-")
            {
                Console.WriteLine(Num1 - Num2);
            }
            else if (Op == "/")
            {
                Console.WriteLine(Num1 / Num2); 
            }
            else if (Op == "*")
            {
                Console.WriteLine(Num1 * Num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            Console.ReadKey();


            //Switch Statement Method GetDay
            Console.WriteLine(GetDay(2));
            Console.ReadKey();


            //While Loops
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.ReadKey();

            //Do While
            index = 6;
            do
            {
                Console.WriteLine(index); //One Time
                index++;
            }while (index <= 5);
            
            
            //Building a Guessing Game
            string secretWord = "griraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                guessCount++;
            }
            if (outOfGuesses)
            {
                Console.Write("You Lose!");
            }
            else
            {
                Console.Write("You Win!");
            }
   
            Console.ReadKey();
            
            
            //For Loops
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            //For Loops in Arrays
            int[] luckyNumber2 = { 4, 8, 15, 16, 23, 42 };
            for (int i = 0; i < luckyNumber2.Length; i++)
            {
                Console.WriteLine(luckyNumber2[i]);
            }
            
            
            //Building an Exponent Method
            Console.WriteLine(GetPow(3, 2));
            Console.ReadKey();
            
            
            //2d Arrays
            int[,] numberGrid = {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };
            Console.WriteLine(numberGrid[0,0]);
            Console.WriteLine(numberGrid[1,0]);
            Console.ReadKey();
            
            
            //Exception Handling
            try
            {
                Console.Write("Enter a number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(number1 / number2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
            
            
            // Classes & Objects >Books<
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord Of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.author);
            Console.ReadKey();
            
            
            //Constructors
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord Of the Rings", "Tolkein", 700);

            book2.title = "The hobbit";
            Console.WriteLine(book2.author);
            Console.ReadKey();
            
            
            //Object Methods
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.ReadKey();
            
            
            //Getters & Setters
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adason", "PG");

            Console.WriteLine(avengers.rating);
            Console.ReadKey();
            
            
            //Static Class Attributes
            Song holiday = new Song("Holiday", "Green day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(kashmir.getSongCount());
            //Console.WriteLine(Song.songCount);

            //Console.WriteLine(holiday.artist);
            //Console.WriteLine(kashmir.artist);

            Console.ReadKey();
            
            
            //Static Methods & Classes
            UsefulTools toolr = new UsefulTools();
            UsefulTools.SayHi("Mkie");
            //Console.WriteLine(Math.Sqrt(144));

            Console.ReadKey();
            
            
            //Inheritance
            //class Chef
            Chef chef = new Chef();
            chef.MakeChicken();

            //class ItalianChef : Chef
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakePasta();

            Console.ReadKey();

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
        
        //if Statements (con't)
        static int GetMax(int num1, int num2, int num3)
        {
            int result = 0;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if(num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }

        //Switch Statement method GetDay
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0: 
                    dayName = "Sunday";
                    break;
                case 1: 
                    dayName = "Monday";
                    break;
                case 2: 
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }
        
        //Building an Exponent Method
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for(int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }
            return result;
        }

        
    }
}
