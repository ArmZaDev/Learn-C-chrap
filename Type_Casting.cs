using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type Casting
            //Data type Convert
            string MyString = "120";
            int MyInt = 100;


            byte myByte = Convert.ToByte(MyString); //SBtye - 
            short myShort = Convert.ToInt16(MyString);
            int myInt = Convert.ToInt32(MyString);
            long myLong = Convert.ToInt64(MyString);
            float myFloat = Convert.ToSingle(MyString); 
            double myDouble = Convert.ToDouble(MyString);
            string result = Convert.ToString(myDouble);

            Console.WriteLine("Byte = {0}", myByte + MyInt);
            Console.WriteLine("Short = {0}", myShort + MyInt);
            Console.WriteLine("Int = {0}", myInt + MyInt);
            Console.WriteLine("long = {0}", myLong + MyInt);
            Console.WriteLine("Float = {0}", myFloat + MyInt);
            Console.WriteLine("Double = {0}", myDouble + MyInt);
            Console.WriteLine("Double to String = {0}", result);
            Console.ReadKey();


            //Parse
            string myString = "200";

            byte myByte = byte.Parse(myString);
            short myShort = short.Parse(myString);
            int myInt = int.Parse(myString);
            long myLong = long.Parse(myString);
            float myFloat = float.Parse(myString);
            double myDouble = double.Parse(myString);

            Console.WriteLine("Byte = {0}", myByte);
            Console.WriteLine("Short = {0}", myShort);
            Console.WriteLine("Int = {0}", myInt);
            Console.WriteLine("Long = {0}", myLong);
            Console.WriteLine("Float = {0}", myFloat);
            Console.WriteLine("Double = {0}", myDouble);
            Console.ReadLine();

            //Try Parse
            string myString = "200.00";
            int myInt;
            long myLong;
            bool success = int.TryParse(myString, out myInt);
            bool success2 = long.TryParse(myString, out myLong);
            float myFloat = float.Parse(myString);
            double myDouble = double.Parse(myString);

            Console.WriteLine("Long = {0}", myLong);
            Console.WriteLine("Float = {0}", myFloat);
            Console.WriteLine("Double = {0}", myDouble);
            Console.ReadLine();

            //Narrowing Casting manual
            double x = 105.21;
            int y = (int)x;
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
