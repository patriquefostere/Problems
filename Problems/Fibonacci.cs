using Problems.UserInteraction;

namespace Problems.Problems
{
    public class Fibonacci
    {
        private readonly IFibonacciUserInteraction _interaction;

        public Fibonacci(IFibonacciUserInteraction interaction)
        {
            _interaction = interaction;
        }

        public void Run()
        {
            var iterations = _interaction.GetOriginalInput();

            if (iterations == 0 || iterations == 1)
            {
                _interaction.DisplayResult(0);
            }
            else
            {
                var fib = GenerateFib(iterations);

                var sum = AttemptSum(fib);

                if(sum != null) _interaction.DisplayResult(sum);

            }
        }

        private long? AttemptSum(long[] fib)
        {
            long? sum = null;
            try
            {
                sum = fib.Sum();
            }
            catch (OverflowException ex)
            {
                _interaction.HandleOverFlowException(ex);
            }

            sum = fib.Sum();

            return sum;
        }

        private static long[] GenerateFib(int iterations)
        {
            var fib = new long[iterations];

            fib[0] = 0;
            fib[1] = 1;

            for (var i = 2; i < iterations; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            return fib;
        }
    }
}
