using System;

namespace _22_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // String[] cars = { "BMW", "Mustang", "Corvette" };
            String[] cars = new string[3];

            cars[0] = "Tesla";
            cars[1] = "BMW";
            cars[2] = "Ford";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}

