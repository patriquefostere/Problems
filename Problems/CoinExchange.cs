using Problems.UserInteraction;

namespace Problems.Problems
{
    public class CoinExchange
    {

        public CoinExchange(ICoinExchangeUserInteraction _coinExchangeUserInteraction) 
        {
            coinExchangeUserInteraction = _coinExchangeUserInteraction;
        }

        private readonly int[] coins = new int[] { 1, 2, 5, 10, 20, 50, 100 };
        private readonly ICoinExchangeUserInteraction coinExchangeUserInteraction;

        public void Run()
        {
            var necessaryCoins = GetNecessaryCoins(coinExchangeUserInteraction.GetOriginalInput());

            coinExchangeUserInteraction.DisplayResult(necessaryCoins);
        }

        private int[] GetNecessaryCoins(int input)
        {
            var necessaryCoins = new List<int>();

            var remainder = input;
            while (remainder > 0)
            {
                var largestCoin = coins[GetLargestCoinIndex(remainder)];
                necessaryCoins.Add(largestCoin);

                remainder -= largestCoin;
            }

            return necessaryCoins.ToArray();
        }

        /// <summary>
        /// Gets the largest coin less than or equal to value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int GetLargestCoinIndex(int value)
        {
            var index = 0;
            foreach (var coin in coins)
            {
                // could find a better algorithm, like a binary sort or something
                if(coin <= value) index = Array.IndexOf(coins, coin); 

            }

            return index;
        }
    }
}
