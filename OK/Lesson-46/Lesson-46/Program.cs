using System;
using System.Collections.Generic;

namespace _45_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // getters and setters = add security to fields by encapsulation
            // properties = combine aspects of both fields
            // get accessor = used to return property value
            // set accessor = used to assign new value
            // value keyword = defines the value being assigned be the set (parameter)
            Car car = new Car(400);
            car.Speed =11213123;
            
            Console.WriteLine(car.Speed);
            

        }
    }

    class Car
    {
        private int speed;

        public Car(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get { return speed; } //read
            set                   // write
            {
                if (value > 500)
                {
                    value = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}