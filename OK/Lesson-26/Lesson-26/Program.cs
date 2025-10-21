using System;

namespace _26_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // method overloading - sharing the same name but different parameters

            double result;
            result = Multiply(2,4,5);
            Console.WriteLine("The result is: " + result);

        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }
        static double Multiply(double x, double y, double z)
        {
            return x * y * z;
        }
    }
}