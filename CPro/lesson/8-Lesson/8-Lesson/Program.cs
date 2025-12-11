using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            
            double a = Math.Pow(x, 14);
            Console.WriteLine(a);
            
            double b = Math.Sqrt(x);
            Console.WriteLine(b);

            x = -x;
            double c = Math.Abs(x);
            Console.WriteLine(c);

            x = 3.14;
            double d = Math.Round(x);
            Console.WriteLine(d);
            
            double e = Math.Ceiling(x);
            Console.WriteLine(e);
            
            double f = Math.Floor(x);
            Console.WriteLine(f);

            double y = 5;
            double g = Math.Max(x, y);
            Console.WriteLine(g);
            
            double h = Math.Min(x, y);
            Console.WriteLine(h);
            
            
            Console.ReadKey();
        }
    }
}