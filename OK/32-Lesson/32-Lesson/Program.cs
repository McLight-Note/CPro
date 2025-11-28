using System;

namespace _31_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // object - instance of a class, they can have fields and characteristics
            
            Human human1 = new Human();
            human1.name = "John";
            human1.age = 25;
            
            human1.Eat();
            human1.Sleep();
            
            Human human2 = new Human();
            human2.name = "Morty";
            human2.age = 35;
            human2.Eat();
            human2.Sleep();
        }
    }

    class Human
    {
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
        
    }
};