using System;

namespace _7_Lesson
{
    class MyClass
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            double doubled = Double(num);
            double tripled = Triple(num);
            double squared = Square(num);
            double cubed = Cube(num);
            double quadripled = Quadriple(num);

            Console.WriteLine($"The double of {num} is {doubled}");
            Console.WriteLine($"The triple of {num} is {tripled}");
            Console.WriteLine($"The square of {num} is {squared}");
            Console.WriteLine($"The cube of {num} is {cubed}");
            Console.WriteLine($"The quadriple of {num} is {quadripled}");
        }
        
        static double Double(double number)
        {
            return number * 2;
        }
        
        static double Triple(double number)
        {
            return number * 3;
        }
        static double Square(double number)
        {
            return Math.Pow(number, 2);
        }
        
        static double Cube(double number)
        {
            return Math.Pow(number, 3);
        }
        
        static double Quadriple(double number)
        {
            return number * 4;
        }
    }
}