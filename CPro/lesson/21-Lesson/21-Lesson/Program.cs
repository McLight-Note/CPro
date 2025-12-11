using System;
using System.Threading;

namespace _21_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seconds are running...");
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
                Thread.Sleep(1000);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write("\a");
                Thread.Sleep(1000);
            }
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\a");
                Thread.Sleep(700);
            }
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\a");
                Thread.Sleep(500);
            }
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\a");
                Thread.Sleep(200);
            }
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\a");
                Thread.Sleep(100);
            }
            
            Console.WriteLine("Tamom!");
        }
    }
}