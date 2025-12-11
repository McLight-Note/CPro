using System;

namespace _20_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0, num2 = 0, result = 0;
            bool calculate = true;
            String response;
            
            Console.WriteLine("------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");
            
            while (calculate)
            {
                Console.Write("Enter the first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
            
                Console.Write("Enter the second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            
                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option.");
                        break;
                }

                Console.WriteLine("Would you like to continue? (y/n)");
                response = Console.ReadLine();
                response = response.ToLower();
                
                while (response != "n" && response != "y")
                {
                    Console.WriteLine("Wrong Answer! Choose again ---> (y/n)");
                    response = Console.ReadLine();
                    response = response.ToLower();
                }
                
            }
            
            Console.WriteLine("Thank you for using Calculator Program");
            Console.ReadKey();
            Console.Beep();
        }
    }
}