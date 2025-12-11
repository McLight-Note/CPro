using System;

namespace _35_Lesson_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter first number");
        int z = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter first number");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine((x + y) * z);
        Console.WriteLine(x * (y + z));
    }
}


/*
string word = "raxmat";
string newword = word[word.Length - 1].ToString();

for (int i = 1; i < word.Length - 1; i++)
{
    newword += word[i];
}

newword += word[0];

Console.WriteLine(newword);
*/