using System;

namespace Task_4
{
    enum Operators
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
        Default
    }

    class Program
    {
        static double Calculate(double firstOperand, double secondOperand, Operators operator_)
        {
            return operator_ switch
            {
                Operators.Addition => firstOperand + secondOperand,
                Operators.Subtraction => firstOperand - secondOperand,
                Operators.Multiplication => firstOperand * secondOperand,
                Operators.Division => firstOperand / secondOperand,
                _ => 0.0
            };
        }

        static void printHelp()
        {
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("!q - quit the program");
            Console.WriteLine("!clear - clear the console");
            Console.WriteLine("If you input expression like this: \"[Number] [Number]\", you will be prompted to perform math operations");
            Console.WriteLine("---------------------------------------------------------------------------\n");
        }

        static bool CheckForValid(string command)
        {
            // This method is needed in order to check the validity of the input of two numbers.
            // For example
            // 53 14

            string[] nums = command.Split(" ");

            if (nums.Length == 2)
            {
                if (double.TryParse(nums[0], out _) && double.TryParse(nums[1], out _))
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            bool menu = true;
            Console.WriteLine("Welcome to calculator. Use !help command for view commands");
            do
            {
                Console.Write("--> ");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "!help":
                        printHelp();
                        break;
                    case "!clear":
                        Console.Clear();
                        break;
                    case "!q":
                        menu = false;
                        break;
                    default:
                        if (CheckForValid(command))
                        {
                            Console.WriteLine("\n1) +\n2) -\n3) *\n4) /\n");
                            Console.Write("Enter operation: ");
                            Operators operator_ = Operators.Default;
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    operator_ = Operators.Addition;
                                    break;
                                case "2":
                                    operator_ = Operators.Subtraction;
                                    break;
                                case "3":
                                    operator_ = Operators.Multiplication;
                                    break;
                                case "4":
                                    operator_ = Operators.Division;
                                    break;
                                default:
                                    Console.WriteLine("invalid input!");
                                    break;
                            }
                            if (operator_ != Operators.Default)
                            {
                                Console.WriteLine(Calculate(double.Parse(command.Split(" ")[0]), double.Parse(command.Split(" ")[1]), operator_));

                            }

                        }
                        break;
                }
            } while (menu);
        }
    }
}
