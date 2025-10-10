using System;

namespace _4_Lesson;
class Program
{
    static void Main(string[] args)
    {
        /*
        for (int i = 1; i <= 64; i++)
        
        {
            decimal result = Convert.ToDecimal(Math.Pow(2, i));
            Console.WriteLine(result);
        }

        Random numberGenerator = new Random();
        // numberGenerator.Next(0,6);
        int roll = 0;
        int attempts = 0;
        Console.WriteLine("Press enter to roll the die.");
        while (roll != 6)
        {
            Console.ReadKey();
            roll = numberGenerator.Next(1, 7);
            Console.WriteLine("You rolled: " + roll);
            attempts++;
        }
        Console.WriteLine($"You rolled: {attempts}");
        */
        
        
        // * * * * General Solution to print numbers from 1 to 10 * * * *
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("");
        
        // Creative way to print them
        Enumerable.Range(1, 10).ToList().ForEach(Console.WriteLine);
        
        
        
        // * * * * Printing even numbers from 1-10 * * * *
        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }
        
        // Creative way
        Enumerable.Range(1, 20).Where(n => n % 2 == 0).ToList().ForEach(Console.WriteLine);
        
        
        
        // * * * * Sum of the numbers from 1-10  * * * * 
        int j = 0;
        for (int i = 1; i <= 10; i++)
        {
            j += i;
        }
        Console.WriteLine(j);
        
        // Creative way with formula
        int n = 10;
        int sum = n * (n + 1) / 2;
        Console.WriteLine(sum);
    }

}

