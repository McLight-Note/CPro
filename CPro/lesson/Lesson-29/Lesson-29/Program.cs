using System;

namespace _29_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // conditional operator - used in conditional assignment if a condition is true/false
            
            double temperature = 20;
            // String message = "";

            /*
            if (temperature >= 15)
            {
                message = "It's warm outside";
            }
            else
            {
                message = "It's cold outside";
            }
            Console.WriteLine(message);
            */

            // message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";
            
            Console.WriteLine((temperature >= 15) ? "It's warm outside!" : "It's cold outside!");
        }

    }
}