using System;

namespace _35_Lesson_35
{
    class Program
    {
        static void Main(string[] args)
        {
            // abstract classes - incomplete implementation
            
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            
            // Vehicle vehicle = new Vehicle();     <------------

        }
    }
    abstract class  Vehicle // <-----------
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
        int maxSpeed = 500;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
};