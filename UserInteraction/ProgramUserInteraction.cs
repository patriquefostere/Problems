namespace Problems.UserInteraction
{
    //not inheriting IUserInteraction because this behaves a bit differently. 
    public static class ProgramUserInteraction
    {
        public static bool CheckForProgramEnd()
        {
            var result = false;
            var validInput = false;

            while (!validInput)
            {
                Console.WriteLine("\r\nEnd program? y/n");
                var input = Console.ReadLine();

                if (input == "y" || input == "n")
                {
                    validInput = true;
                    result = input == "y";
                }
                else Console.WriteLine("Please enter 'y' or 'n'.");
            }

            return result;

        }

        public static string ChooseProblem()
        {
            var validInput = false;
            var result = "";

            while (!validInput)
            {
                Console.WriteLine("\r\nEnter 1-4 to choose test:\r\n" +
                "1. Palindromes\r\n" +
                "2. Romans\r\n" +
                "3. Fibonacci\r\n" +
                "4. Coin Exchange");

                var validInputs = new string[] { "1", "2", "3", "4" };

                var input = Console.ReadLine();

                if (input != null) input = input.Replace(" ", "");

                if (input == null || input == "") continue;

                if (validInputs.Contains(input))
                {
                    result = input;
                    validInput = true;
                }
                else
                    Console.WriteLine($"Invalid input \"{input}\". Try again.");

            }

            return result;
        }
    }
}
