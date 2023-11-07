using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_to_develop_a_console_app
{
    public class Calculator
    {
        public decimal Calculation(decimal number1, decimal number2, char oper)
        {
            switch (oper)
            {
                case '+':
                    decimal result_add = number1 + number2;
                    return result_add;
                case '-':
                    decimal result_min = number1 - number2;
                    return result_min;
                case '*':
                    decimal result_multiply = number1 * number2;
                    return result_multiply;
                case '/':
                    decimal result_division = number1 / number2;
                    return result_division;
                default:
                    Console.WriteLine("Invalid operator");
                    return 0;
            }
        }


    }
}

