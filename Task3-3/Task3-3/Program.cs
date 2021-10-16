using System;

namespace Task3_3
{
    class Program
    {
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

            int maxFrequency = 0;
            int mostCommonNumber = numbers[0];

            for (int i = 0; i < size; i++)
            {
                int numberFrequency = 0;
                for (int j = 0; j < size; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numberFrequency++;
                    }
                }
                if (numberFrequency > maxFrequency && numberFrequency != 1)
                {
                    maxFrequency = numberFrequency;
                    mostCommonNumber = numbers[i];
                }
            }

            if (maxFrequency == 0)
            {
                Console.WriteLine("There is no most common number");
            }
            else
            {
                Console.WriteLine($"The most common number: {mostCommonNumber}\nNumber of repetitions: {maxFrequency}");
            }

            Console.ReadKey();
        }
    }
}