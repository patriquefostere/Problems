using Problems.UserInteraction;

namespace Problems.Problems
{
    public class Fibonacci
    {
        FibonacciUserInteraction fibUserInteract = new FibonacciUserInteraction();



        private void AttemptSum(long[] fib)
        {
            try
            {
                var sum = fib.Sum();
                fibUserInteract.DisplayResult(sum);
            }
            catch (OverflowException ex)
            {
                fibUserInteract.HandleOverFlowException(ex);
            }
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

        public void Run()
        {
            var iterations = fibUserInteract.OriginalInput;

            if (iterations == 0 || iterations == 1)
            {
                fibUserInteract.DisplayResult(0);
            }
            else
            {
                var fib = GenerateFib(iterations);

                AttemptSum(fib);
            }
        }
    }
}
