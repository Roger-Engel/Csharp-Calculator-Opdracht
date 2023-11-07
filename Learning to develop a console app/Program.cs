using Learning_to_develop_a_console_app;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the calculator app!");

        bool runAgain = true;
        while (runAgain)
        {
            decimal number1;
            bool validInput1 = false;

            do
            {
                Console.WriteLine("Fill in the first number (max 2 numbers after the decimal): ");
                string input1 = Console.ReadLine();

                if (decimal.TryParse(input1, out number1))
                {
                    if (decimal.Round(number1, 2) == number1)
                    {
                        validInput1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number with a maximum of 2 decimal numbers.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!validInput1);

            decimal number2;
            bool validInput2 = false;

            do
            {
                Console.WriteLine("Fill in the second number (max 2 numbers after the decimal): ");
                string input2 = Console.ReadLine();

                if (decimal.TryParse(input2, out number2))
                {
                    if (decimal.Round(number2, 2) == number2)
                    {
                        validInput2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number with a maximum of 2 decimal numbers.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!validInput2);

            char oper;
            bool validInput3 = false;
            do
            {
                Console.WriteLine("Choose an operator (+, -, *, /): ");
                string input3 = (Console.ReadLine());

                if (char.TryParse(input3, out oper))
                {
                    if (oper == '+' || oper == '-' || oper == '*' || oper == '/')
                    {
                        validInput3 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid operator");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid operator");
                }

            } while (!validInput3);

            if (oper == '/' && number2 == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            else
            {
                Calculator calculator = new Calculator();
                decimal result = calculator.Calculation(number1, number2, oper);

                Console.WriteLine($"Result: {result}");
            }
            

            Console.WriteLine("Press Enter to calculate something again, or 'N' to exit: ");
            string choice = Console.ReadLine();
            if(choice.ToLower() == "n")
            {
                runAgain = false;
            }
        }
    }
}