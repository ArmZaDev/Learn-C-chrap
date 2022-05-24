using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (+ - * / %) OPerator
            int a = 15;
            int b = 10;
            int c = a + b;
            Console.WriteLine("Result = {0}", c);
            Console.WriteLine("Result = {0}", a - b);
            Console.WriteLine("Result = {0}", a * b);
            Console.WriteLine("Result = {0}", a / b);
            Console.WriteLine("Result = {0}", a % b);
            Console.WriteLine("Result = {0} {1} {2} {3} {4}", c, a - b, a * b, a / b, a % b);
            Console.ReadKey();

            //Funtion math
            double number = -15.59;
            Console.WriteLine("Abs = {0}", Math.Abs(number));
            Console.WriteLine("Ceiling = {0}", Math.Ceiling(number));
            Console.WriteLine("Floor = {0}", Math.Floor(number));
            Console.WriteLine("Round = {0}", Math.Round(number));
            Console.WriteLine("Power = {0}", Math.Pow(number, 2));
            Console.WriteLine("Square Root = {0}", Math.Sqrt(25));
            Console.WriteLine("PI = {0:F4}", Math.PI);
            Console.ReadKey();

            //Operator comparison of type boolean
            int num1 = 60, num2 = 100;

            Console.WriteLine(num1 == num2); 
            Console.WriteLine(num1 != num2); 
            Console.WriteLine(num1 > num2); 
            Console.WriteLine(num1 < num2); 
            Console.WriteLine(num1 >= num2); 
            Console.WriteLine(num1 <= num2); 
            Console.ReadKey();

            //Operator ++ 
            int a = 20, b = 10;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("Prefix = {0}", ++a); //Prefix 
            Console.WriteLine("Last a = {0}", a + "\n");

            a = 20;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("Posfix = {0}", a++); //Posfix 
            Console.WriteLine("Last a = {0}", a);


            //Operator --
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("Prefix = {0}", --b); //Prefix 
            Console.WriteLine("Last b = {0}", b + "\n");

            b = 10;
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("Posfix = {0}", b--); //Posfix 
            Console.WriteLine("Last b = {0}", b);
            Console.ReadKey();

            //Compound Assignment 
            int x = 10, y = 15;
            x += y;             //x = x + y;
            Console.WriteLine(x);

            x = 10;
            y = 15;
            Console.WriteLine(x -= y); //x = x - y;

            x = 10;
            y = 15;
            Console.WriteLine(x *= y); //x = x * y;

            x = 10;
            y = 15;
            Console.WriteLine(x /= y); //x = x / y;
            x = 10;
            y = 15;
            Console.WriteLine(x %= y); //x = x % y;
            Console.ReadKey();

            /*
            //order of importance Operator
            1. ()
            2. ++, --
            3. * , / , % 
            4. + , -
            5. < , <= , => , > 
            6. == , != 
            7. && (AND)
            8. || (OR)"    "
            9. = , += , -= , *= , /= , %= Compound Assignment 
            */
        }
    }
}
