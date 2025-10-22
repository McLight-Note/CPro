using System;

namespace _40_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // method overriding - new version of a method inherited from a parent class

            Dog dog = new Dog();
            Cat cat = new Cat();
            
            dog.Speak("Dog");
            cat.Speak("Cat");
        }
    }

    class Animal
    {
        public virtual void Speak(String name) // <------------- virtual added
        {
            Console.WriteLine("I'm a  " + name);
        }
    }

    class Dog : Animal
    {
        public override void Speak(String name) // <--------- override
        {
            Console.WriteLine("I'm a  " + name + ", i go *woof*");
        }
    }

    class Cat : Animal
    {
        public override void Speak(String name)
        {
            Console.WriteLine("I'm a  " + name + ", i go *meow*");
        }
    }

}