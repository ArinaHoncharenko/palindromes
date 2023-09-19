using System;
using System.Linq;

namespace oop3_palindrome 
{
    class PalindromeChecker
    {
        public static bool IsPalindrome(string input)
        {
            // ��������� ������� ��������� � ������� ������ �� �����
            string cleanInput = input.Replace(" ", "").ToLower();

            // ����������, �� ������ ����� �����
            if (cleanInput.Any(char.IsDigit))
            {
                Console.WriteLine(input + " contains numbers.");
                return false;
            }

            int left = 0;
            int right = cleanInput.Length - 1;

            // �������� �� ������������
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