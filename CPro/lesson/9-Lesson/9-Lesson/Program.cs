using System;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int num = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);
            
            // double num2 = random.NextDouble();
            
            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

        }
    }
}

