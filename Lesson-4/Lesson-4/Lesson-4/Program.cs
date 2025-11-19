using System;

namespace _7_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            if (string.IsNullOrEmpty(word) || word.Length == 1)
            {
                Console.WriteLine(word);
                return;
            }

            char first = word[0];
            char last = word[word.Length - 1];

            string middle = word.Substring(1, word.Length - 2);

            string result = last + middle + first;

            Console.WriteLine("New word: " + result);
        }
    }
}