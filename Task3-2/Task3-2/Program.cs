using System;

namespace Task3_2
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

            int sum = 0;
            int count = 0;

            foreach (int num in numbers)
            {
                if (num > 0)
                {
                    count++;
                    sum += num;
                }
            }

            Console.WriteLine("average: " + sum / count);
            Console.ReadKey();
        }
    }
}
