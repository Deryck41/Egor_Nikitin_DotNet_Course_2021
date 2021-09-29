using System;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three numbers through the whitelines.\n\nNumber 1: ");
            bool firstSuccessInput = int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.Write("Number 2: ");
            bool secondSuccessInput = int.TryParse(Console.ReadLine(), out int secondNumber);

            Console.Write("Number 3: ");
            bool thirdSuccessInput = int.TryParse(Console.ReadLine(), out int thirdNumber);

            if(firstSuccessInput && secondSuccessInput && thirdSuccessInput)
            {
                int min = Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));
                int max = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
                int average;

                if (min == firstNumber && max == secondNumber || max == firstNumber && min == secondNumber)
                {
                    average = thirdNumber;
                }
                else if (min == firstNumber && max == thirdNumber || min == thirdNumber && max == firstNumber)
                {
                    average = secondNumber;
                }
                else
                {
                    average = thirdNumber;
                }

                Console.WriteLine($"\nIn ascending order: \t{min}\t{average}\t{max}");
                Console.WriteLine($"In descending order: \t{max}\t{average}\t{min}");
                Console.WriteLine("\nMin number: \t\t" + min);
                Console.WriteLine("Average number: \t" + average);
                Console.WriteLine("Max number: \t\t" + max);
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
