namespace Problems.UserInteraction
{
    public interface ICoinExchangeUserInteraction : IUserInteraction
    {
        public int GetOriginalInput();
    }

    public class CoinExchangeUserInteraction : ICoinExchangeUserInteraction
    {
        public int OriginalInput;
        public CoinExchangeUserInteraction()
        {
            OriginalInput = GetIntInput();
        }

        public int GetOriginalInput()
        {
            return OriginalInput;
        }

        public void DisplayResult(object result)
        {
            var resultArray = (int[]) result;

            var resultString = string.Join("p, ", resultArray);
            if (resultString.Replace(" ", "") != "") resultString += "p";

            Console.Write("The collection of coins, choosing from 1p, 2p, 5p, 10p, 20p, 50p, and 100p," +
                $"such that the fewest number of coins is used to add up to {OriginalInput} is: \r\n" +
                $"{resultString} ({resultArray.Length} coins)");
        }

        public int GetIntInput()
        {
            var startMessage = "What is your test value? " +
                    "This will return the combination of coins (of 1p, 2p, 5p, 10, 20p, 50, and 100p) " +
                    "which uses the fewest coins in adding up to the test value.";
            return CommonUserInteraction.GetIntInput(startMessage);

        }

        public string GetStringInput()
        {
            throw new NotImplementedException();
        }
    }
}
