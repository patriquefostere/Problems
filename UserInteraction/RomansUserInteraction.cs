namespace Problems.UserInteraction
{
    public class RomansUserInteraction : IUserInteraction
    {
        public int OriginalInput;
        public RomansUserInteraction() 
        {
            OriginalInput = GetIntInput();
        }

        public void DisplayResult(object result)
        {
            var resultList = (List<string>) result;
            var resultString = string.Join("", resultList);
            Console.WriteLine($"The Roman numeral representation of {OriginalInput} is {resultString}");
        }

        public int GetIntInput()
        {
            var startMessage =
                "Enter a non-zero positive integer which we will convert into Roman numerals.";
            var input = CommonUserInteraction.GetIntInput(startMessage);
            OriginalInput = input;
            return input;
        }

        public string GetStringInput()
        {
            throw new NotImplementedException();
        }
    }
}
