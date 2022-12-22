﻿namespace Problems.UserInteraction
{
    public class PalindromesUserInteraction : IUserInteraction
    {
        public string OriginalInput;
        public PalindromesUserInteraction()
        {
            OriginalInput = GetStringInput();
        }

        public void DisplayResult(object result)
        {
            var isIsNot = (bool)result ? "" : "not ";

            Console.WriteLine($"\"{OriginalInput}\" is {isIsNot}a palindrome " +
                $"(ignoring non-alphanumeric characters and capitalisation).");
        }

        public int GetIntInput()
        {
            throw new NotImplementedException();
        }

        public string GetStringInput()
        {
            Console.WriteLine("Enter a string to check for palandromism:\r\n");
            return Console.ReadLine() ?? "";
        }
    }
}
