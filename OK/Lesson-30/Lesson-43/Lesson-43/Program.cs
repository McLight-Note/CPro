using System;

namespace _43_Lesson
{
    class Program
        {
            static void Main(string[] args)
            {
                // interface = defines a contract that all classes inheriting from should follow
                //             An interface declares "what class should have" and "how it should do it" 
                // Benefit   = security + multiple inheritors + plug-and-play
                
                Rabbit rabbit = new Rabbit();
                rabbit.Flee();
                
                Hawk hawk = new Hawk();
                hawk.Hunt();
                
                Fish fish = new Fish();
                fish.Flee();
                fish.Hunt();
                
            }
        }

    interface IPrey
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }
    
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("Rabbit runs away");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("Hawk is searching for food");
        }
    }

    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("Fish swims away");
        }

        public void Hunt()
        {
            Console.WriteLine("Fish is searching for smaller fish");
        }
    }
}

