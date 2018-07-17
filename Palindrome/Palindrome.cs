namespace Palindrome
{
    public class Palindrome
    {
        public bool IsWordAPalindrome(string input)
        {
            input = input.ToLower();
            int wordCount = input.Length;

            int halfOfWord = wordCount / 2;

            for (int i = 0; i <= halfOfWord; i++)
            {
                if (input[i] != input[wordCount - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
