using System;

namespace Assignment8ex2
{
    public class MathSolutions
    {
        public delegate double CalcProduct(double x, double y);
        static double GetProduct(double a, double b)
        {
            return a * b;
        }
        static void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            
            Func<double, double, double> calSum = delegate (double x, double y) { return x + y; };
            Console.WriteLine($" {num1} + {num2} = {calSum(num1, num2)}");
            
            CalcProduct cp = new CalcProduct(GetProduct);
            Console.WriteLine($" {num1} * {num2} = {cp(num1, num2)}");
            
            Action<double, double> calcSmaller = GetSmaller;
            calcSmaller(num1, num2);
        }
    }
}