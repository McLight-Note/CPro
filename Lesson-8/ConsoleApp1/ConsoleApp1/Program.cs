using System;

class Program
{
    static void Main()
    {
        
        // 1 - Exercise
        /*
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        bool result = (a == 20 || b == 20 || (a + b == 20));
        Console.WriteLine(result);
        */
        
        // 2 - Exercise
        /*
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        string lower = text.ToLower();

        Console.WriteLine("Lowercase: " + lower);
        */
        
        // 3 - Exercise
        /*
        Enumerable.Range(1,99).Where(x=>x%2==1).ToList().ForEach(Console.WriteLine);
        */
        
        bool isPrime(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        int sum = Enumerable.Range(1, 500)
            .Where(x => isPrime(x))
            .Sum();

        Console.WriteLine(sum);
    }
}