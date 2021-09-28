using System;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the coefficients of the quadratic equation.\n\nA= ");

            bool firstSuccessInput = float.TryParse(Console.ReadLine(), out float coefficientA);

            Console.Write("B= ");

            bool secondSuccessInput = float.TryParse(Console.ReadLine(), out float coefficientB);

            Console.Write("C= ");

            bool thirdSuccessInput = float.TryParse(Console.ReadLine(), out float coefficientC);

            if (firstSuccessInput && secondSuccessInput && thirdSuccessInput)
            {
                double discriminant =  Math.Pow(coefficientB, 2) - (4 * coefficientA * coefficientC);
                
                if (discriminant < 0)
                {
                    Console.WriteLine("\nThere are no roots");
                }

                else if (discriminant == 0)
                {
                    Console.WriteLine("This equation has one root: " + (coefficientB * (-1)) / (2*coefficientA));
                }

                else
                {
                    double firstRoot = (coefficientB * (-1) - Math.Sqrt(discriminant)) / (2 * coefficientA);
                    double secondRoot = (coefficientB * (-1) + Math.Sqrt(discriminant)) / (2 * coefficientA);
                    Console.WriteLine("This equation has two roots: " + firstRoot + "\t" + secondRoot);
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
