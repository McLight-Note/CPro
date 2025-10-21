using System;

namespace _24_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // methods - reusing the code
            
            String name = "Bro";
            int age = 22;
            
            singHappyBirthday(name, age);
            
        }

        static void singHappyBirthday(String birthdayBoy, int yearsOld)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + birthdayBoy);
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine($"You are {yearsOld} years old.");
        }
    }
}