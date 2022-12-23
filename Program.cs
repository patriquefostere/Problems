// See https://aka.ms/new-console-template for more information

using Problems.LearningDI;
using Problems.Problems;
using Problems.UserInteraction;

public class Program
{
    public static void Main()
    {
        var endProgram = false;

        while (!endProgram)
        {
            endProgram = RunProgramOnce();
        }
    }

    private static bool RunProgramOnce()
    {
        var programString = ProgramUserInteraction.ChooseProblem();
        CallProblems(programString);

        return ProgramUserInteraction.CheckForProgramEnd();
    }

    private static void CallProblems(string programString)
    {
        switch (programString)
        {
            case "1":
                Console.WriteLine("\r\nPalindromes selected");
                Palindromes palindromes = new Palindromes();
                palindromes.Run();

                break;
            case "2":
                Console.WriteLine("\r\nRomans selected");
                Romans romans = new Romans();
                romans.Run();
                break;

            case "3":
                Console.WriteLine("\r\nFibonacci selected");

                DependencyInjectionContainer.SetFibonacciUserInteraction(new FibonacciUserInteraction());
                var fibonacci = new Fibonacci(DependencyInjectionContainer.GetFibonacciUserInteraction());

                fibonacci.Run();
                break;

            case "4":
                Console.WriteLine("\r\nCoin Exchange selected");
                CoinExchange coinExchange = new CoinExchange();
                coinExchange.Run();

                break;

        }
    }

}
