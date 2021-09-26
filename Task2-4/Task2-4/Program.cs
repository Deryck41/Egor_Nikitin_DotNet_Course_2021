using System;

namespace Task2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers.\n\nNumber 1: ");
            bool firstSuccessInput = float.TryParse(Console.ReadLine(), out float firstNumber);
            Console.Write("Number 2: ");
            bool secondSuccessInput = float.TryParse(Console.ReadLine(), out float secondNumber);


            if (firstSuccessInput && secondSuccessInput)
            {
                if (firstNumber % secondNumber == 0)
                {
                    Console.WriteLine("\nNumber 1 is divisible by Number 2\nQuotient: " + firstNumber / secondNumber);
                }
                else
                {
                    Console.WriteLine("\nNumber 1 is not divisible by Number 2\nQuotient: " + firstNumber / secondNumber);
                    Console.WriteLine("Remainder: " + firstNumber % secondNumber);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input!");
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
