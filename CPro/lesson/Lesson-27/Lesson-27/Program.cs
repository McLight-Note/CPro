using System;

namespace _27_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // params keyword - adding the same parameters to the method

            double result = CheckOut(2.99 , 4.75, 5.49, 15, 24);
            Console.WriteLine("The result is: " + result);

        }

        static double CheckOut(params double [] prices)
        {
            double result = 0.0;

            foreach (double price in prices)
            {
                result += price;    
            }
            return result;
        }
    }
}