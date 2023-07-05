using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iltimos, sonni kiriting:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("Bu son palindrom.");
        }
        else
        {
            Console.WriteLine("Bu son palindrom emas.");
        }
    }

    static bool IsPalindrome(string input)
    {
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
