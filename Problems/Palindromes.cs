using System.Text.RegularExpressions;
using Problems.UserInteraction;

namespace Problems.Problems
{
    public class Palindromes
    {
        PalindromesUserInteraction palUserInteract = new PalindromesUserInteraction();

        public void Run()
        {
            var result = IsPalindrome(palUserInteract.OriginalInput);

            palUserInteract.DisplayResult(result);
        }

        /// <summary>
        /// Ignoring spaces, punctuation, and capitalisation, 
        /// this returns true if the input is a palindrome.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static bool IsPalindrome(string input)
        {
            var normalInput = Normalise(input);

            var chars = normalInput.ToCharArray();

            return chars.SequenceEqual(Reverse(chars));
        }

        private static char[] Reverse(char[] chars)
        {
            return chars.Reverse().ToArray();
        }

        /// <summary>
        /// remove non alphanumeric characters and make lower case
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string Normalise(string input)
        {
            input = input.ToLower();
            Regex rgx = new Regex("[^a-z0-9]");
            input = rgx.Replace(input, "");

            return input.ToLower();
        }
    }
}
