using System;

namespace _31_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // constructor - same as class method, used in assigning the arguments when creating the objects 
            
            Human human1 = new Human("John", 24);
            human1.Eat();
            human1.Sleep();
            
            Human human2 = new Human("Morty", 35);
            human2.Eat();
            human2.Sleep();

            Car car1 = new Car("Fast", "Audi", 2025, "black");
            Car car2 = new Car("Corvette", "Chevy", 2025, "red");
            car1.Drive();
            car2.Drive();
            
        }
    }

    class Human
    {
        public String name;
        public int age;

        public Human(String name, int age)
        {
            this.name = name;
            this.age = age;
        }
        
        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
        
    }

    class Car
    {
        public String model;
        public String make;
        public int year;
        public String color;

        public Car(string model, string make, int year, string color)
        {
            this.model = model;
            this.make = make;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine($"You drive {this.model}.");
        }
    }
};