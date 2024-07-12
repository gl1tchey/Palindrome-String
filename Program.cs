using System;
using System.Security.Cryptography.X509Certificates;

namespace Palindrome_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = {"racecar", "hello", "level", "world"};   

                        foreach (var word in words) 
            {
                if (!IsPalindrome(word)) 
                {
                    Console.WriteLine($"Word: {word} is not palindrome string");
                    continue;      
                }
                Console.WriteLine($"Word: {word} is a palindrome string");
            }
        }

         static bool IsPalindrome(string word) 
         {
            int word_length = word.Length;
            for (int i = 0; i < word_length / 2; i++)
            {
                if (word[i] != word[word_length - i - 1])
                {
                    return false;
                }
               
            } 
            return true;
         }
    }
}