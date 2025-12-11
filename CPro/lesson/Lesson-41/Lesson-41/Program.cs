using System;

namespace _41_Lesson_41
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            // ToString method - converts object to string format so that it is representable

            Car car = new Car("Chevy", "Convette", "Blue", 2022);
            Console.WriteLine(car.ToString());
            
        }
    }

    class Car
    {
        String model;
        String make;
        String color;
        int year;

        public Car(String model, String make, String color, int year)
        {
            this.model = model;
            this.make = make;
            this.color = color;
            this.year = year;
        }
        public override String ToString()
        {
            // return base.ToString();
            return "This is " + model+ " " + make;
        }
    }
    */
    class Exercise
    {
        static void Main(string[] args)
        {
            String[] items = {"apple", "milk", "bread"};
            double[] prices = new double [items.Length];
            double total = 0;
            for(int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("Enter a price for " + items[i]);
                double price = Convert.ToDouble(Console.ReadLine());
                prices[i] = price;
                total += price;
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("* * * * * RECIEPT * * * * *");
            Console.WriteLine("---------------------------");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{items[i],-8} .......... {prices[i].ToString("C")}");
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Total : " + total.ToString("C"));
            Console.WriteLine("---------------------------");
        }
    }
}