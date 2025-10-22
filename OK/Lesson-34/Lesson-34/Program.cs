using System;

namespace _31_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // static = modifier to declare the static number. Everything that is static is belongs to the class. Car.___

            Car car1 = new Car("Mustang");
            Car car2 = new Car("BMW");
            Car car3 = new Car("Audi");

            Console.WriteLine(Car.numberOfCars);
            Car.Race();
        }
    }

    class Car
    {
        String model;
        public static int numberOfCars;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void Race()
        {
            Console.WriteLine("The Race has begun!");
        }
    }
};