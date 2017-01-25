using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    static class Calculator
    {

        public static double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
          
        }

        public static double Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            return result;

        }

        public static double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        public static double Divide(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }

        public static double Module(double num1, double num2)
        {
            double result = num1 % num2;
            return result;
        }

        public static double Square(double num1)
        {
            double result = Math.Pow(num1, 2.0);
            return result;
        }
    }
}
