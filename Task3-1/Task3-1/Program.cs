using System;

namespace Task3_1
{
    class Program
    {
        static int NumSum(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static int Main(string[] args)
        {
            Console.Write("Input size of array: ");
            if (!int.TryParse(Console.ReadLine(), out int size))
            {
                Console.WriteLine("Invalid input!");
                return 0;
            }

            int[] numArray = new int[size];
            Console.WriteLine("Input array: ");
            for (int i = 0; i < size; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out numArray[i]))
                {
                    Console.WriteLine("Invalid input!");
                    return 0;
                }
            }

            int sumOfNumbers = 0;
            foreach (int num in numArray)
            {
                sumOfNumbers += NumSum(Math.Abs(num));
            }
            Console.WriteLine("Answer: " + sumOfNumbers);

            Console.ReadKey();
            return 0;
        }
    }
}
