using System;

namespace _17_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What Symbol: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }
    }
}