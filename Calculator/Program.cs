using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operation;
            Console.WriteLine("Hello, Welcome to the calculator program!");
            Console.WriteLine("Please enter your first number: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Please enter a valid number!");
            }

            Console.WriteLine("Please enter your second number: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Please enter a valid number!");
            }

            Console.WriteLine("What sort of operation would you like to do: ");
            Console.WriteLine("\n a for addition\n s for subtraction\n m for multiplication\n d for division");
            operation = Console.ReadLine().ToLower();
            while (string.IsNullOrEmpty(operation) || (operation != "a" && operation != "s" && operation != "m" && operation != "d"))
            {
                Console.WriteLine("\nPlease enter a valid operation");
                Console.WriteLine("\n a for addition\n s for subtraction\n m for multiplication\n d for division");
                operation = Console.ReadLine();
            }

            switch (operation)
            {
                case "a":
                    Console.WriteLine("The addition of " + num1 + " and " + num2 + " = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine("The subtraction of " + num1 + " from " + num2 + " = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine("The multiplication of " + num1 + " and " + num2 + " = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine("The division of " + num1 + " by " + num2 + " = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("\n a for addition\n s for subtraction\n m for multiplication\n d for division");
                    break;
            }


            Console.ReadKey();
        }
    }
}
