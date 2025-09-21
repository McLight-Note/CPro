using System;

namespace Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temp outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It's warm outside");
            }
            else if (temp >= -50 || temp <= 50)
            {
                Console.WriteLine("Don't go outside");
            }
        }
    }
}

