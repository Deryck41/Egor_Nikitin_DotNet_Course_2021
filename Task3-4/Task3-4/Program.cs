using System;

namespace Task3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input size of array: ");
            int size;

            while (!int.TryParse(Console.ReadLine(), out size) || size < 1)
            {
                Console.WriteLine("Invalid input!\nTry again.");
                Console.Write("Input size of array: ");
            }

            int[] numbers = new int[size];

            for (int i = 0; i < size - 1; i++)
            {
                Console.Write("input the value of the array element at position " + i + ": ");

                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input!\nTry Again.");
                    Console.Write("input the value of the array element at position " + i + ": ");
                }
            }

            Console.Write("array: |");

            for (int i = 0; i < size - 1; i++)
            {
                Console.Write(numbers[i] + "|");
            }

            Console.WriteLine();
            Console.Write("Input position to insert: ");
            int position;

            while (!int.TryParse(Console.ReadLine(), out position) || position < 0 || position > size - 1)
            {
                Console.WriteLine("Invalid input!\nTry again.");
                Console.Write("Input position to insert: ");
            }

            for (int i = size - 1; i > position; i--)
            {
                numbers[i] = numbers[i - 1];
            }

            Console.Write("Input value to insert: ");
            int insertValue;

            while (!int.TryParse(Console.ReadLine(), out insertValue))
            {
                Console.WriteLine("Invalid input!\nTry again.");
                Console.Write("Input value to insert: ");
            }

            numbers[position] = insertValue;
            Console.Write("array: |");

            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + "|");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}