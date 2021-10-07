using System;

namespace Task2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lengths of the sides of the triangle.\n\nSide 1: ");
            bool firstSuccessInput = float.TryParse(Console.ReadLine(), out float firstSide);

            Console.Write("Side 2: ");
            bool secondSuccessInput = float.TryParse(Console.ReadLine(), out float secondSide);

            Console.Write("Side 3: ");
            bool thirdSuccessInput = float.TryParse(Console.ReadLine(), out float thirdSide);

            if (firstSuccessInput && secondSuccessInput && thirdSuccessInput)
            {
                if (firstSide + secondSide >= thirdSide && firstSide + thirdSide >= secondSide && secondSide + thirdSide >= firstSide)
                {
                    Console.WriteLine("\nThis triangle exists");

                    if (firstSide == secondSide && secondSide == thirdSide)
                    {
                        Console.WriteLine("This triangle is equilateral");
                    }
                    else if(firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)
                    {
                        Console.WriteLine("This triangle is isosceles");
                    }
                }
                else
                {
                    Console.WriteLine("\nThis triangle does not exist");
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
