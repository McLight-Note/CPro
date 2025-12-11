using System;

namespace _23_Lesson
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

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}