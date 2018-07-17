using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a word to see if it is a palindrome:");

            string input = Console.ReadLine();

            Palindrome palindrome = new Palindrome();

            Console.WriteLine(palindrome.IsWordAPalindrome(input));
            Console.ReadLine();
        }
    }
}
