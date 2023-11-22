using System;
using System.Collections.Generic;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                RunCalculator();
                Console.WriteLine("Do you want to perform another calculation? (yes or no)");

                string response = Console.ReadLine().ToLower();
                if (response != "yes")
                {
                    Console.WriteLine("Goodbye! See you next time!");
                    break;
                }
                else
                {
                    Console.WriteLine("Welcome Back!");
                    continue;
                }

            } while (true);
        }

        static void RunCalculator()
        {
            double num1, num2, result;

            Console.WriteLine("Please enter your first number");
            while (true)
            {
                string userInput1 = Console.ReadLine();

                if (!double.TryParse(userInput1, out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Please enter your second number");
                string userInput2 = Console.ReadLine();
                if (!double.TryParse(userInput2, out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("What type of operation would you like to do?");
                Console.WriteLine("a for Addition, s for Subtract, m for Multiply, d for Division");
                Console.WriteLine("________________");

                List<string> validInputs = new List<string> { "a", "s", "m", "d" };

                foreach (var operation in validInputs)
                {
                    Console.WriteLine(operation);
                }

                Console.WriteLine("________________");
                Console.WriteLine();

                string userChoice = Console.ReadLine();

                if (!validInputs.Contains(userChoice))
                {
                    Console.WriteLine("Invalid choice. Please choose a valid operation.");
                    continue;
                }

                Console.WriteLine();

                if (num2 == 0)
                {
                    Console.WriteLine("You cannot divide a number by 0. Please enter a non-zero divisor.");
                    continue;
                }

                result = PerformOperation(num1, num2, userChoice);
                Console.WriteLine($"The result is {result}");
                break;
            }
        }

        static double PerformOperation(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "a":
                    return num1 + num2;
                case "s":
                    return num1 - num2;
                case "m":
                    return num1 * num2;
                case "d":
                    return num1 / num2;
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }
    }
}
