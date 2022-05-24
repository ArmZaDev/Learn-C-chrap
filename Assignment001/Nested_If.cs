using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_if
{
        static void Main(string[] args)
        {
        //Nested_if
        int money = 30000;

        if (money >= 15000)
        {
            if (money >= 15000 && money <= 19999)
            {
                Console.WriteLine("Sale = 10%");
            }
            else if (money >= 20000 && money <= 29999)
            {
                Console.WriteLine("Sale = 20%");
            }
            else if (money >= 30000)
            {
                Console.WriteLine("Sale = 30%");
            }

        }
        Console.ReadLine();

    }
    }
}