using System;

namespace Prime.Services
{
    public static class PrimeService
    {
        public static double Add(double int1, double int2)
        {
            return int1 + int2;
        }
        public static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}