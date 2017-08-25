using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 1000;
            int c;

            Console.Write("Create a new price: ");
            c = int.Parse(Console.ReadLine());

            if (c >= 0)
            {
                if (c < a)
                {
                    Console.WriteLine("Your price lesser than minimum. Please, contact with trader!");
                }

                if (c > b)
                {
                    Console.WriteLine("Your price bigger than maximum. Please, contact with trader!");
                }
            }
            if (c >= a && c <= b)
            {
                Console.WriteLine("The new price was created");
            }

            Console.ReadLine();
        }
    }
}
