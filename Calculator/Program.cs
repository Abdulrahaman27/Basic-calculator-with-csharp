using System;
using System.Text;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool calculatorProgram = true;
            while (calculatorProgram)
            {
                int num1;
                int num2;
                string operation;
                Console.WriteLine("Hello👋, Welcome to the calculator program!");


                Console.WriteLine("Please enter your first number: ");
                while (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("❌ : Please enter a valid number!");
                }

                Console.WriteLine("Please enter your second number: ");
                while (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("❌ : Please enter a valid number!");
                }

                Console.WriteLine("What sort of operation would you like to do: ");
                Console.WriteLine("\n a for addition\n s for subtraction\n m for multiplication\n d for division");
                operation = Console.ReadLine().ToLower();
                while (string.IsNullOrEmpty(operation) || (operation != "a" && operation != "s" && operation != "m" && operation != "d"))
                {
                    Console.WriteLine("\n❌ : Please enter a valid operation");
                    Console.WriteLine("\n a for addition\n s for subtraction\n m for multiplication\n d for division");
                    operation = Console.ReadLine();
                }

                switch (operation)
                {
                    case "a":
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case "s":
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case "m":
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                        break;
                    case "d":
                        if(num2  == 0)
                        {
                            Console.WriteLine("❌ : Can't divide by 0");
                        }
                        else { 
                            Console.WriteLine($"{num1} / {num2} = {(double)num1 / num2}");
                        }
                        break;
                    default:
                        Console.WriteLine("\n a for addition\n s for subtraction\n m for multiplication\n d for division");
                        break;
                }
            Console.WriteLine("Would you like to carry out another Calculation?(y/n)");
            string answer = Console.ReadLine().ToLower();
                if (answer != "yes" && answer != "y")
                {
                    calculatorProgram = false;
                }
            }
            Console.WriteLine("Thanks for using the calculator!💯");
            Console.ReadKey();
        }
    }
}
