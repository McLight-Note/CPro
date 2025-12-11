using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Muhammad McLight";
            
            Console.WriteLine(fullName);
            Console.WriteLine(fullName.ToUpper());
            Console.WriteLine(fullName.ToLower());
            
            String phoneNumber = "123-456-7890";
            Console.WriteLine(phoneNumber);
            Console.WriteLine(phoneNumber.Replace("-", "/"));
            Console.WriteLine(phoneNumber.Replace("-", ""));

            String userName = fullName.Insert(0, "@");
            Console.WriteLine(userName);
            
            Console.WriteLine(fullName.Length);
            
            String firstName = fullName.Substring(0, 8);
            String lastName = fullName.Substring(9, 7);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            
            String email = firstName.ToLower().Insert(firstName.Length, "@gmail.com");
            Console.WriteLine(email);
        }
    }
}

