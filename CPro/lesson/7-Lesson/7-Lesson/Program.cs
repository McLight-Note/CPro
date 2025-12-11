using System;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            int friends = 10;
            
            friends += 1;
            friends++;
            friends -= 1;
            friends--;
            friends *= 2;

            int remainder = friends % 3;
            
            Console.WriteLine(remainder);
            Console.WriteLine(friends);
        }
    }
}