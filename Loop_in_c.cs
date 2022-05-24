using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While loop
            int count = 1;
            while (count <= 10)
            {
                Console.WriteLine("{0} X {1} = {2}", 2, count, 2 * count);
                count++;

            }
            Console.ReadKey();


            //For loop
            int number = 0;
            Console.Write("input Product: ");
            int.TryParse(Console.ReadLine(), out number);

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Product {0}", i);
            }
            Console.ReadKey();


            //Do While
            int count = 10;

            do
            {
                Console.WriteLine("Count {0}", count);
                count++;
            } while (count <= 0);
            Console.ReadKey();


            //Break, Continue
            int number = 0;
            Console.Write("Input NUmber: ");
            int.TryParse(Console.ReadLine(), out number);
            for (int count = 1; count <= 12; count++)
            {
                if (count == 3)
                {
                    continue;     
                }

                else if (count == 7)
                {
                    break;       
                }
                Console.WriteLine("{0} X {1} = {2}", number, count, 2 * count);
            }
            Console.ReadKey();


            //average
            int sum = 0, avg = 0;
            for (int count = 1; count <= 5; count++)
            {
                int num = 0;
                Console.Write("Input Number: ");
                int.TryParse(Console.ReadLine(), out num);
                sum += num;
            }
            avg = sum / 5;
            Console.WriteLine("Sum = {0}" + "\n" + "Avg = {1}", sum, avg);
            Console.ReadKey();
        }
    }
}