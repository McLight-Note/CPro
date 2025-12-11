using System;

namespace _7_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // method overriding - a new version of a method that is inherited from a
            //                     parent class 
            Dog dog = new Dog();
            Cat cat = new Cat();
            
            dog.Speak();
            cat.Speak();
        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal Speaking");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog Speaking");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat Speaking");
        }
    }
}