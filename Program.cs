using System;
using System.Linq;

namespace oop3_palindrome
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter a word or phrase to check for palindromicity: ");
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Input is empty.\n");
                }
                else if (PalindromeChecker.IsPalindrome(userInput))
                {
                    Console.WriteLine(userInput + " is a palindrome.\n");
                }
                else
                {
                    Console.WriteLine(userInput + " isn't a palindrome.\n");
                }
            }
        }
    }
}
