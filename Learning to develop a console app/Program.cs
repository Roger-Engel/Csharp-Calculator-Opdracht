using Console_Calculator;
using Console_Calculator.Core;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        decimal number1;
        decimal number2;
        char operatorChar;
        bool proceed = true;

        while (proceed)
        {
            number1 = inputHandling("Enter first number");
            number2 = inputHandling("Enter second number");

            do
            {
                Console.WriteLine("Choose one of the following operators: +, -, /, *");
                string operatorInput = Console.ReadLine();

                if (operatorInput.Length == 1)
                {
                    operatorChar = Convert.ToChar(operatorInput);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid operator. Please enter a valid operator");
                }
            } while (true);

            CalculateService calculator = new CalculateService();
            var calculationResult = calculator.PerformCalculation(number1, number2, operatorChar);
            if (!calculationResult.Succeeded)
            {
                Console.Write(calculationResult.ErrorMessage);
            }
            else
            {
                Console.WriteLine("Result: " + calculationResult.Result);
            }

            Console.WriteLine("To continue, type 'yes' or 'y' or 'no' or 'n' to stop: ");
            string confirmation = Console.ReadLine().ToLower();

            if (confirmation == "yes" || confirmation == "y")
            {
                proceed = true;
            }
            else if (confirmation == "no" || confirmation == "n")
            {
                proceed = false;
                Console.WriteLine("Calculator closed. Have a nice day!");
                Thread.Sleep(2000);
            } else
            {
                Console.WriteLine("Invalid input, Stopping program.");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
        }
    }

    private static decimal inputHandling(string prompt)
    {
        do
        {
            decimal inputValue;

            Console.WriteLine(prompt);
            string inputUser = Console.ReadLine();
            int decimalLength = inputUser.IndexOfAny(new char[] { '.', ',' });

            if (string.IsNullOrEmpty(inputUser))
            {
                Console.WriteLine("You need to fill in a number.");
            }
            else
            {
                if (decimal.TryParse(inputUser, out inputValue))
                {
                    if (decimalLength != -1 && inputUser.Substring(decimalLength + 1).Length > 2)
                    {
                        Console.WriteLine("You can only have 2 decimals behind your number.");
                    }

                    return inputValue;
                }
                else
                {
                    Console.WriteLine("Input needs to be a valid number.");
                }
            }
        } while (true);

    {
        }
    }
}