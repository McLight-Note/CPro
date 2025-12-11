using System;

namespace _39_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mustang", "red");
            Car car2 = Copy(car1);
            
            
            
            ChangeColor(car1, "silver");
            Console.WriteLine(car1.model + " is " + car1.color);
            Console.WriteLine(car2.model + " is " + car2.color);
        }

        public static void ChangeColor(Car car, String color)
        {
            car.color = color;
        }

        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }

    class Car
    {
        public String model;
        public String color;

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }
}