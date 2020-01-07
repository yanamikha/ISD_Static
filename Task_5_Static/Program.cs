using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two numbers");
            Console.Write(@"     first: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write(@"     second: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Sum: {Math.Sum(a, b)}");
            Console.WriteLine($"Sub: {Math.Sub(a, b)}");
            Console.WriteLine($"Mult: {Math.Mult(a, b)}");
            Console.WriteLine($"Div: {Math.Div(a, b)}");
            Console.WriteLine($"Sqr: {Math.Sqr(a)}");
            Console.WriteLine($"Abs: {Math.Abs(a)}");
    
            Console.ReadKey();
        }
    }
    public static class Math
    {
       public static double Sum(double number_1, double number2)
        {
            return number_1 + number2;
        }
        public static double Sub(double number_1, double number2)
        {
            return number_1 - number2;
        }
        public static double Mult(double number_1, double number2)
        {
            return number_1 * number2;
        }
        public static double Div(double number_1, double number2)
        {
            return number_1 / number2;
        }
        public static double Sqr(double number_1)
        {
            return number_1 * number_1;
        }
        public static double Abs(double number_1)
        {
            if (number_1 > 0)
                return number_1;
            else return -number_1;
        }
    }

}
