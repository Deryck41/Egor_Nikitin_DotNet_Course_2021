using System;

namespace Task3_1
{
    class Program
    {
        static int NumberSum(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Input size of array: ");
            int size;

            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Invalid input!\nTry Again.");
            }

            int[] numbers = new int[size];
            Console.WriteLine("Input array: ");

            for (int i = 0; i < size; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input!\nTry Again.");
                }
            }

            int sumOfNumbers = 0;

            foreach (int number in numbers)
            {
                sumOfNumbers += NumberSum(number);
            }

            Console.WriteLine("Answer: " + sumOfNumbers);
            Console.ReadKey();
        }
    }
}