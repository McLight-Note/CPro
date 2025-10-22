using System;

namespace _35_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructors = technique to create multiple constructors with the same class
            
            Pizza pizza1 = new Pizza("stuffed crusty", "Red");
            Pizza pizza2 = new Pizza("stuffed crusty", "Red", "mozarella");
            Pizza pizza3 = new Pizza("stuffed crusty", "Red", "mozarella", "pepperoni");
            
        }
    }

    class Pizza
    {
        String sauce;
        String cheese;
        String bread;
        String topping;

        public Pizza(String bread, String sauce)
        {
            this.sauce = sauce;
            this.bread = bread;
        }
        public Pizza(String bread, String sauce, String cheese)
        {
            this.sauce = sauce;
            this.cheese = cheese;
            this.bread = bread;
        }
        
        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.sauce = sauce;
            this.cheese = cheese;
            this.bread = bread;
            this.topping = topping;
        }
        
    }
};