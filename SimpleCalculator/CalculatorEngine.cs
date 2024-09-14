using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            switch (argOperation.ToLower())
            {
                case "+":
                case "add":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "-":
                case "subtract":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "*":
                case "multiply":
                    result = argFirstNumber * argSecondNumber;
                    break;
                case "/":
                case "divide":
                    if (argFirstNumber == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else if (argSecondNumber == 0)
                    {

                        Console.WriteLine("Cannot divide this is equal to infinity");

                    }
                    result = argFirstNumber / argSecondNumber;
                    break;
                case "power":
                case "pow":
                case "^":
                    result = Math.Pow(argFirstNumber, argSecondNumber);
                    break;
                default:
                    throw new ArgumentException("Invalid operation");
            }

            return result;
        }
    }
}
