using System;

namespace Task3_5
{
    class Program
    {
        static void PrintArray(int[] array)
        {
            Console.Write("array: |");

            foreach (int element in array)
            {
                Console.Write(element+"|");
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int size = random.Next(2, 20);
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(-100, 100);
            }

            Console.WriteLine("Before sorting:");
            PrintArray(numbers);

            int buffer;

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        buffer = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = buffer;
                    }
                }
            }

            Console.WriteLine("\nAfter sorting:");
            PrintArray(numbers);
            Console.ReadKey();
        }
    }
}