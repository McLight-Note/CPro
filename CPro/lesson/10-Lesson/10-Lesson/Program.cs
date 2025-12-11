using System;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            Double b = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("The hypotenuse:" + Math.Sqrt(a * a + b * b));
        }
    }
}

