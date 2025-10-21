using System;

namespace _28_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // try - try some code that is considered dangerous
            // catch - catches and handles the exceptions
            // finally - always executes regardless if exception is caught or not

            double x;
            double y;
            double z;

            try
            {
                Console.Write("Enter the first number: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second number: ");
                y = Convert.ToDouble(Console.ReadLine());
                z = x / y;

                Console.WriteLine(z);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You cannot divide by zero Idiot!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }

    }
}