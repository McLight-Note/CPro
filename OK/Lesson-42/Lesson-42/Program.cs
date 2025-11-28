using System;

namespace _42_Lesson
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            // polymorphism - Greek word "to have many forms"
            //                objects can be identified by many types
            //                EX. Cat can be: Organism, Animal, Mammal
            
            Car car = new Car();
            Bycicle bycicle = new Bycicle();
            Boat boat = new Boat();
            
            Vehicle[] vehicles = {car,  bycicle, boat};

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
        }
    }

    class Vehicle
    {
        public virtual void Go()
        {
            
        }
    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bycicle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Bycicle is moving");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Boat is moving");
        }
    }
    */

    class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane();
            Train train = new Train();
            Motorcycle motorcycle = new Motorcycle();
            
            Vehicle[] vehicles = {airplane, train, motorcycle};

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
            StartEngine(new Airplane());
            StartEngine(new Train());
            StartEngine(new Motorcycle());
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Stop();
            }
            StopEngine(new Airplane());
            StopEngine(new Train());
            StopEngine(new Motorcycle());
        }
        static void StartEngine(Vehicle vehicle)
        {
            vehicle.Go();
        }
        static void StopEngine(Vehicle vehicle)
        {
            vehicle.Stop();
        }
    }

    class Vehicle
    {
        public virtual void Go(){}
        public virtual void Stop(){}
    }

    class Airplane : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Airplane is moving");
        }

        public override void Stop()
        {
            Console.WriteLine("Airplane is landing");
        }
    }

    class Train : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Train is moving");
        }

        public override void Stop()
        {
            Console.WriteLine("Train is stopping at the station");
        }
    }

    class Motorcycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Motorcycle is moving");
        }

        public override void Stop()
        {
            Console.WriteLine("Motorcycle is barking");
        }
    }
}