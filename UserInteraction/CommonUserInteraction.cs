namespace Problems.UserInteraction
{
    public static class CommonUserInteraction
    {
        public static int GetIntInput(
            string startMessage, string? badDataMessage = null, bool allowZero = false)
        {
            var validInput = false;

            var outputInt = 0;

            while (!validInput)
            {
                Console.WriteLine(startMessage);
                var input = Console.ReadLine();

                var success = int.TryParse(input, out outputInt);

                var condition = success && outputInt >= 0 || allowZero && success && outputInt > 0;
                if (condition) validInput = true;
                else
                {
                    badDataMessage ??= GetBadDataInputMessage(allowZero);
                    Console.WriteLine(badDataMessage);
                }

            }

            return outputInt;
        }

        private static string GetBadDataInputMessage(bool allowZero)
        {
            var nonZeroString = allowZero ? "" : " non-zero";
            return $"Invalid input - must be a positive{nonZeroString} integer.";
        }
    }
}
