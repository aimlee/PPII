using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Cal
    {
        public double firstNumber = 0, secondNumber = 0, result = 0, b=0;
        public string operation = "";

        public void calculate()
        {
            switch (operation)
            {
                case "+":
                    result = firstNumber + b;
                    firstNumber = result;

                    break;
                case "-":
                    result = firstNumber - b;
                    firstNumber = result;
                    break;
                case "*":
                    result = firstNumber * b;
                    firstNumber = result;
                    break;
                case "/":
                    result = firstNumber / b;
                    firstNumber = result;
                    break;
                case "mod":
                    result = firstNumber % b;
                    firstNumber = result;
                    break;
                case "x^y":
                    result = Math.Pow(firstNumber, b);
                    firstNumber = result;
                    break;
                case "x^5":
                    result = Math.Pow(firstNumber, 5);
                    firstNumber = result;
                    break;
                case "x^(1/y)":
                    result = Math.Pow(firstNumber, 1 / b);
                    firstNumber = result;
                    break;
            }
        }
    }
}
