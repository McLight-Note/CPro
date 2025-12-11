using System;
using System.Collections.Generic;

namespace _44_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // List = data structure that can be accessed by an index.
            // Dynamically can be increased or decreased.
            
            /*
            String[] food = new string[3];
            food[0] = "Apple";
            food[1] = "Bananas";
            food[2] = "Pear";
            */
            // Above array cannot be altered in size after creation!!
            
            List<String> food = new List<String>();
            food.Add("Milk");
            food.Add("Bread");
            food.Add("Cheese");
            food.Add("Milk");
            
            // food.Remove("Cheese");
            // food.Insert(0, "Cheese");
            // Console.WriteLine(food.Count);
            // Console.WriteLine(food.IndexOf("Cheese"));
            // Console.WriteLine(food.LastIndexOf("Milk"));
            // Console.WriteLine(food.Contains("Cheese"));

            // food.Sort();
            // food.Reverse();
            // food.Clear();
            String[] foodArray = food.ToArray();
            
            foreach (string food1 in foodArray)
            {
                Console.WriteLine(food1);
            }
        }
    }
}