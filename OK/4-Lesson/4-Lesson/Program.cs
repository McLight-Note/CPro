using System;

namespace MyNamespace
{
    public class Exercise6
    {
        public static void Main(string[] args)
        {
            int x = 123, y = 456;
            double height = 300.5;
            bool alive = true;
            char symbol = '@';
            String name = "Muhammad"; 
            String userName = symbol + name;
            const double pi = 3.14;
            
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine(x + y);
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is " + symbol);
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("Hello " + userName + "!");
            Console.WriteLine(pi);
            
            Console.ReadKey();
            Console.Beep();
        }
    }
}