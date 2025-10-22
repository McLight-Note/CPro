using System;
namespace _38_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] garage = new Car[3];
            
            Car car1 = new Car("Mustang");
            Car car2 = new Car("Tesla");
            Car car3 = new Car("Corvette");
            
            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;

            Car[] garage2 = { new Car("Tesla"), new Car("Corvette") , new Car("Mustang") };
            
            foreach (Car c in garage)
            {
                Console.WriteLine(c.model);
            }

            foreach (Car c in garage2)
            {
                Console.WriteLine(c.model);
            }
        }
    }

    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }
}