using System;
using System.Reflection.Metadata.Ecma335;

namespace _24_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // methods - reusing the code
            
            String name = "Bro";
            int age = 22;
            
            for(int i = 0; i < 100; i++)
            {
            SingHappyBirthday(name, age);}
        }

        public static void SingHappyBirthday(String name, int age)
        {
            Console.WriteLine("Happy birthday");
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}