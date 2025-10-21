using System;

namespace _25_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // return - returns data back

            double x;
            double y;
            double result;
            
            Console.Write("Enter the first number: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            y = Convert.ToDouble(Console.ReadLine());
            
            result = Multiply(x, y);
            Console.WriteLine("The result is: " + result);

        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}