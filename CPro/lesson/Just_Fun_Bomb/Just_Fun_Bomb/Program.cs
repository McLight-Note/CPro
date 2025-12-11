using System;
using System.Threading;

namespace _21_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seconds are running...");
            
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine($"{i}");
                Thread.Sleep(1000);
            }
            
            int h = 1000;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.Beep();
                    Thread.Sleep(h);
                }

                h /= 2;
            }

            Console.WriteLine("Boom!");
        }
    }
}