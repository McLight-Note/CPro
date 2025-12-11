using System;

namespace _35_Lesson_35
{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance
            
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            
            Console.WriteLine(car.wheels);
            Console.WriteLine(car.speed);
            car.go();
            
            Console.WriteLine(bicycle.wheels);
            Console.WriteLine(bicycle.speed);
            bicycle.go();
            
            Console.WriteLine(boat.wheels);
            Console.WriteLine(boat.speed);
            boat.go();

        }
    }

    class  Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("Vehicle going ...");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }
};