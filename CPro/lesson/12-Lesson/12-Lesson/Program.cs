using System;

namespace Lesson12
{
    class MyClass
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 100)
            {
                Console.WriteLine("You are too old to sign up!");
            }
            else if (age >=18)
            {
                Console.WriteLine("You are now signed up!");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't born yet");
            }
            else
            {
                Console.WriteLine("You must be 18+ to sign up!");
            }
            */
            
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("You didnt enter your name");
            }
            else
            {
                Console.WriteLine("Your name is " + name);
            }
            
        }
    }
}