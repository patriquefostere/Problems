﻿using Problems.UserInteraction;

namespace Problems.LearningDI
{
    public static class DependencyInjectionContainer
    {
        private static IFibonacciUserInteraction FibonacciUserInteraction;

        public static void SetFibonacciUserInteraction(IFibonacciUserInteraction fibonacciUserInteraction)
        {
            FibonacciUserInteraction = fibonacciUserInteraction;
        }

        public static IFibonacciUserInteraction GetFibonacciUserInteraction()
        {
            return FibonacciUserInteraction;
        }

        private static ICoinExchangeUserInteraction CoinExchangeUserInteraction;

        public static void SetCoinExchangeUserInteraction(ICoinExchangeUserInteraction coinExchangeUserInteraction)
        {
            CoinExchangeUserInteraction = coinExchangeUserInteraction;
        }

        public static ICoinExchangeUserInteraction GetCoinExchangeUserInteraction()
        {
            return CoinExchangeUserInteraction;
        }
    }
}

