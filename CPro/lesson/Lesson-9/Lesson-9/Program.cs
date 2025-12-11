using System;

class Program
{
    static void Main()
    {
        // even or odd
        /* 
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a%2 == 0 ? "Even" : "Odd");
        */
        
        // sum until n
        /*
        int result = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            result += i;
        }    
        Console.WriteLine(result);
        */
        
        // Reversing a String
        /*
        String string1 = Console.ReadLine();
        for (int i = string1.Length -1; i >= 0; i--)
        {
            Console.Write(string1[i]);
        }
        */
        
        // Find the max of three numbers
        /*
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int result = Math.Max(a, Math.Max(b, c);
        Console.WriteLine(result);
        */
        
        // Palindrome Checker
        /*
        String input = Console.ReadLine();
        bool isPalindrome = true;
        for (int i = 0; i < input.Length / 2; i++)
        {
            if (input[i] != input[input.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }
        Console.WriteLine(isPalindrome ? "Palindrome" : "Not Palindrome");
        */
        
        // Counting vowels
        /*
        String string1 = Console.ReadLine();
        string1 = string1.ToLower();
        int result = 0;
        for (int i = 0; i < string1.Length; i++)
        {
            if (string1[i] == 'a' ||
                string1[i] == 'u' ||
                string1[i] == 'o' ||
                string1[i] == 'i' ||
                string1[i] == 'e')
            {
                result++;
            }
        }
        Console.WriteLine(result);
        
        result = 0;
        foreach (char c in string1)
        {
            if ("aeiou".Contains(c))
                result++;
        }
        Console.WriteLine(result);
        */
        
        // Multiplication Table
        /*
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i*j}");
            }
            Console.WriteLine();
        }
        */
        
        // Array Sorting
        /*
        int[] array = {5,2,7,3,75,4,19};
        Array.Sort(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        */
        
        // Prime number detector
        /*
        int n = Convert.ToInt32(Console.ReadLine());
        for (int num = 2; num <= n; num++)
        {
            bool isPrime =  true;
            for (int i = 2; i<= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.Write(isPrime ? $"{num} ": "");
        }
        */
        
        // Fibonacci Sequence
        /*
        int n = Convert.ToInt32(Console.ReadLine());
        int a = 0;
        int b = 1;
        Console.Write(a + " " + b + " ");
        for (int i = 2; i < n; i++)
        {
            int next = a + b;
            Console.Write(next + " ");
            a = b;
            b = next;
        }
        */
        
        
    }
}