using System;
using System.Linq;

namespace oop3_palindrome 
{
    class PalindromeChecker
    {
        public static bool IsPalindrome(string input)
        {
            // Видаляємо символи розділення і змінюємо регістр на нижній
            string cleanInput = input.ToLower().Replace(" ", "").Replace("-", "");

            // Перевіряємо, чи містить слово цифри
            if (cleanInput.Any(char.IsDigit))
            {
                Console.WriteLine(input + " contains numbers.");
                return false;
            }

            int left = 0;
            int right = cleanInput.Length - 1;

            // Перевірка на паліндромність
            while (left < right)
            {
                if (cleanInput[left] != cleanInput[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
