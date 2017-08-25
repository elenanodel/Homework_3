using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter two numbers and we'll calculate the result by action you'll choose");

            double a;
            double b;
            char c;

            Console.Write("Enter first number: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose an action:");
            Console.WriteLine("'+' - addition");
            Console.WriteLine("'-' - substraction");
            Console.WriteLine("'*' - multiplication");
            Console.WriteLine("'-' - division");
            Console.WriteLine("'%' - rest of division");
            Console.Write("Enter your choice: ");
            c = char.Parse(Console.ReadLine());

            switch (c)
            {
                case '+':
                    {
                        Console.WriteLine("You choose an addition. Reasult: " + (a + b));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine("You choose an substraction. Result: " + (a - b));
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine("You choose an multiplication. Result: " + (a * b));
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine("You choose an division. Result: " + (a / b));
                        break;
                    }
                case '%':
                    {
                        Console.WriteLine("You choose a res of division. Result: " + (a % b));
                        break;
                    }
            }

            Console.ReadLine();
        }
    }
}
