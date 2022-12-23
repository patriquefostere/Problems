namespace Problems.UserInteraction
{
    public interface IFibonacciUserInteraction : IUserInteraction
    {
        public void HandleOverFlowException(OverflowException ex);
        public int GetOriginalInput();
    }

    public class FibonacciUserInteraction : IFibonacciUserInteraction
    {
        public int OriginalInput;
        public FibonacciUserInteraction()
        {
            OriginalInput = GetIntInput();
        }

        public int GetOriginalInput()
        {
            return OriginalInput;
        }

        public void DisplayResult(object result)
        {
            Console.WriteLine($"Sum of first {OriginalInput} Fibonacci values: {result}");
        }

        public int GetIntInput()
        {
            var startMessage = "How many fibonacci numbers do you want to add up?";
            return CommonUserInteraction.GetIntInput(startMessage, allowZero: false);

        }

        public string GetStringInput()
        {
            throw new NotImplementedException();
        }

        public void HandleOverFlowException(OverflowException ex)
        {
            Console.WriteLine("Attempting to sum values caused overflow exception:");
            Console.WriteLine(ex.ToString());
        }

    }
}
