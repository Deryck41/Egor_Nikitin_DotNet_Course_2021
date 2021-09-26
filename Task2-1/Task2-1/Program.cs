using System;

namespace Task2_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Input year: ");
            int year;
            bool successInput = int.TryParse(Console.ReadLine(), out year);

            if (successInput)
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("This year is leap");
                }
                else
                {
                    Console.WriteLine("This year is not leap");
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
