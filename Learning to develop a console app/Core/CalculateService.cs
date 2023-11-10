using System;

namespace Console_Calculator.Core
{
    internal class CalculateService
    {
        public CalculationResult PerformCalculation(decimal number1, decimal number2, char operatorChar)
        {
            decimal result = 0;

            switch (operatorChar)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        return new CalculationResult()
                        {
                            Result = 0,
                            Succeeded = false,
                            ErrorMessage = "Cannot divide by 0 \n"
                        };
                    }
                    else
                    {
                        result = number1 / number2;
                    }
                    break;
                default:
                    return new CalculationResult()
                    {
                        Result = 0,
                        Succeeded = false,
                        ErrorMessage = "Invalid operator"
                    };
            }

            return new CalculationResult()
            {
                Result = result,
                Succeeded = true
            };
        }
    }
}
