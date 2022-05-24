using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(Wirte/WriteLine)
            Console.Write("KesukeTakoyaki");
            Console.WriteLine("SobaNoodle");
            Console.ReadKey();

            //Set display order with braces
            Console.WriteLine("FirstName: {0} LastName: {1}", "Nobpharat", "Pongdong");               
            Console.WriteLine("{0} + {2} = {1}", 50, 80, 30);
            Console.ReadKey();

            //Variable 
            int myNum = 26;
            double myDoubleNum = 10.99D;
            char myChar = 'A';
            bool myBool = true;
            string myString = "Hello Wold";
            const int MyNum = 10;

            Console.WriteLine("int = " + myNum);
            Console.WriteLine("double = " + myDoubleNum);
            Console.WriteLine("char = " + myChar);
            Console.WriteLine("bool = " + myBool);
            Console.WriteLine("string = " + myString);
            Console.WriteLine("const = " + MyNum);
            Console.ReadKey();

            //format string
            int number = 120000;
            Console.WriteLine("Number = {0}", number);
            Console.WriteLine("Number = {0:E}", number); //Exponential
            Console.WriteLine("Number = {0:F4}", number); //Floating Point
            Console.WriteLine("Number = {0:G}", number); //เเสดงตัวเลขรูปเเบสั้นที่สุด
            Console.WriteLine("Number = {0:N}", number); //comma
            Console.WriteLine("Number = {0:P}", number); //%
            Console.WriteLine("Number = {0:X}", number); //Hex
            Console.ReadKey();

            //input values ​​on keyboard
            Console.Write("UserName: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");            
            string password = Console.ReadLine();
            Console.WriteLine("UserName is: " + username + "\n" + "Password is: " + password);
            Console.Write("Aa-Zz to ASCII Code: ");
            int Ascii = Console.Read();
            Console.WriteLine("Ascii = " + Ascii);
            Console.ReadKey();

        }
    }
}